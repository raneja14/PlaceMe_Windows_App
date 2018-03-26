using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Criterion;
using System.Collections;
using Placement_Application.DAO;
using Placement_Application.Components;
using Placement_Application.Commons;

namespace Placement_Application.Service
{
    public class NotificationManagerImpl : NotificationManager
    {
        private Persistence persistence;

        public NotificationManagerImpl()
        {
            this.persistence = new PersistenceImpl();
        }

        public Dictionary<string, List<string>> loadAllBranches()
        {
            Utility.logFile(Constant.METHOD_ENTER + Utility.getCurrentMethodName(1) + "(NotificationManagerImpl)",null, Constant.LOGTYPE_INFO);
            Dictionary<string, List<string>> branchMap = null;
            var branchList = getBranchesByDegree(Common.loggedUser.myConfigObj.currentDegree);
            if (branchList != null)
            {
                branchMap = new Dictionary<string, List<string>>();
                branchMap.Add(Common.loggedUser.myConfigObj.currentDegree, branchList);
            }
            return branchMap;
            
            //List<string> degreeList = loadAllDegrees(true);
            //if (degreeList != null)
            //{
            //    List<string> branchList = null;
            //    Dictionary<string, List<string>> branchMap = new Dictionary<string, List<string>>();

            //    foreach (string degree in degreeList)
            //    {
            //        branchList = getBranchesByDegree(degree);
            //        if (branchList != null)
            //        {
            //            branchMap.Add(degree, branchList);
            //        }
            //    }
            //    return branchMap;
            //}
            //return null;

          //  List<string> branchList = null;
        
        }

        public List<string> loadAllDegrees(bool isBatchRestricted)
        {
            Utility.logFile(Constant.METHOD_ENTER + Utility.getCurrentMethodName(1) + "(NotificationManagerImpl)",null, Constant.LOGTYPE_INFO);
            DetachedCriteria criteria = DetachedCriteria.For<Entity_Student>();
            criteria.SetProjection(Projections.Distinct(Projections.Property("myConfigObj.currentDegree")));

            if (isBatchRestricted)
            {
                criteria.Add(Restrictions.Eq("myConfigObj.currentBatch", Common.loggedUser.myConfigObj.currentBatch));
                criteria.Add(Restrictions.Eq("myConfigObj.currentDegree", Common.loggedUser.myConfigObj.currentDegree));
            }
            IList list = persistence.findByCriteria(criteria);

            if (list != null && list.Count > 0)
                return list.Cast<string>().ToList<string>();
            else
                return null;
        }

        public List<string> getBranchesByDegree(string degree)
        {
            Utility.logFile(Constant.METHOD_ENTER + Utility.getCurrentMethodName(1) + "(NotificationManagerImpl)",null, Constant.LOGTYPE_INFO);
            DetachedCriteria criteria = DetachedCriteria.For<Entity_Student>();
            criteria.Add(Restrictions.Eq(Projections.Property("myConfigObj.currentDegree"), degree));
            criteria.SetProjection(Projections.Distinct(Projections.Property("branch")));

            IList list = persistence.findByCriteria(criteria);

            if (list != null && list.Count > 0)
                return list.Cast<string>().ToList<string>();
            else
                return null;
        }

        public IDictionary<string, IList<Entity_Student>> filteredStudentList(MyCriteria notifyCriteria)
        {
            Utility.logFile(Constant.METHOD_ENTER + Utility.getCurrentMethodName(1) + "(NotificationManagerImpl)",null, Constant.LOGTYPE_INFO);
            DetachedCriteria mainCriteria = DetachedCriteria.For<Entity_Student>("student");
            mainCriteria.CreateAlias("scoreObj", "score");
            Conjunction conjunction = Restrictions.Conjunction();
            conjunction.Add(Restrictions.Eq("student.myConfigObj.currentBatch", notifyCriteria.batch));
            conjunction.Add(Restrictions.Eq("student.myConfigObj.currentDegree", notifyCriteria.degree));
            conjunction.Add(Restrictions.Ge("score.X", notifyCriteria.X));
            conjunction.Add(Restrictions.Ge("score.cgpa", notifyCriteria.cgpa));
            conjunction.Add(Restrictions.Le("score.arrears", notifyCriteria.arrears));
            conjunction.Add(Restrictions.In("student.branch", notifyCriteria.branch));

            if (notifyCriteria.isDiplomaAllowed)
            {
                Disjunction disjunction = Restrictions.Disjunction();
                disjunction.Add(Restrictions.Ge("score.XII", notifyCriteria.XII));
                disjunction.Add(Restrictions.Ge("score. ", notifyCriteria.XII));

                conjunction.Add(disjunction);
            }
            else
                conjunction.Add(Restrictions.Ge("score.XII", notifyCriteria.XII));
        
            mainCriteria.Add(conjunction);

            if (!notifyCriteria.isPlaced)
            {
                DetachedCriteria subCriteria = DetachedCriteria.For<Entity_PlacementDetails>("placedObj");
                subCriteria.Add(Restrictions.EqProperty("placedObj.studentId", "student.studentId"));
                subCriteria.SetProjection(Projections.Distinct(Projections.Property("placedObj.studentId")));
                mainCriteria.Add(Subqueries.NotExists(subCriteria));
            }

            IList list = persistence.findByCriteria(mainCriteria);

            if (list != null && list.Count > 0)
            {
                IDictionary<string, IList<Entity_Student>> eligibleStudentMap = prepareStudentList(list.Cast<Entity_Student>().ToList());
                return eligibleStudentMap;
            }
            else
                return null;
        }

        private IDictionary<string, IList<Entity_Student>> prepareStudentList(List<Entity_Student> resultList)
        {
            Utility.logFile(Constant.METHOD_ENTER + Utility.getCurrentMethodName(1) + "(NotificationManagerImpl)",null, Constant.LOGTYPE_INFO);
            IList<Entity_Student> studentList;
            var eligibleStudentMap = new Dictionary<string, IList<Entity_Student>>();

            foreach (Entity_Student stuObj in resultList)
            {
                if (stuObj != null)
                {
                    string branchKey = stuObj.branch;

                    if (eligibleStudentMap.ContainsKey(branchKey))
                    {
                        eligibleStudentMap[branchKey].Add(stuObj);
                    }
                    else
                    {
                        studentList = new List<Entity_Student>();
                        studentList.Add(stuObj);
                        eligibleStudentMap.Add(branchKey, studentList);
                    }
                }
            }
            return eligibleStudentMap;
        }

        public bool saveNotifications(Entity_Notification notificationObj)
        {
            Utility.logFile(Constant.METHOD_ENTER + Utility.getCurrentMethodName(1) + "(NotificationManagerImpl)", null,Constant.LOGTYPE_INFO);
            return persistence.save(notificationObj);
        }

        public List<Entity_Notification> loadAllNotifications()
        {
            Utility.logFile(Constant.METHOD_ENTER + Utility.getCurrentMethodName(1) + "(NotificationManagerImpl)",null, Constant.LOGTYPE_INFO);
            DetachedCriteria mainCriteria = DetachedCriteria.For<Entity_Notification>();
            mainCriteria.CreateAlias("staffObj", "staff");
            mainCriteria.Add(Restrictions.Eq("myConfigObj.currentBatch", Common.loggedUser.myConfigObj.currentBatch));
            mainCriteria.Add(Restrictions.Eq("myConfigObj.currentDegree", Common.loggedUser.myConfigObj.currentDegree));

            mainCriteria.AddOrder(Order.Desc("notificationId"));

            IList list = persistence.findByCriteria(mainCriteria);

            if (list != null && list.Count > 0)
            {
                return list.Cast<Entity_Notification>().ToList();
            }
            else
                return null;
        }

        public int getNotificationCount()
        {
            Utility.logFile(Constant.METHOD_ENTER + Utility.getCurrentMethodName(1) + "(NotificationManagerImpl)",null, Constant.LOGTYPE_INFO);
            DetachedCriteria mainCriteria = DetachedCriteria.For<Entity_Notification>("notification");
            mainCriteria.Add(Restrictions.Eq("notification.myConfigObj.currentBatch", Common.loggedUser.myConfigObj.currentBatch));
            mainCriteria.Add(Restrictions.Eq("notification.myConfigObj.currentDegree", Common.loggedUser.myConfigObj.currentDegree));
            mainCriteria.SetProjection(Projections.Count("notification.notificationId"));

            DetachedCriteria subCriteria = DetachedCriteria.For<Entity_UserNotification>("userNotification");
            subCriteria.Add(Restrictions.EqProperty("userNotification.notificationId", "notification.notificationId"));
            subCriteria.Add(Restrictions.Eq("userNotification.staffId", Common.loggedUser.staffId));
            subCriteria.SetProjection(Projections.Distinct(Projections.Property("userNotification.notificationId")));

            mainCriteria.Add(Subqueries.NotExists(subCriteria));

            IList list = persistence.findByCriteria(mainCriteria);

            if (list != null && list.Count > 0)
                return Convert.ToInt32(list[0]);
            else
                return 0;
        }

        public void saveUserNotification(Entity_UserNotification userNotifyObj)
        {
            Utility.logFile(Constant.METHOD_ENTER + Utility.getCurrentMethodName(1) + "(NotificationManagerImpl)",null, Constant.LOGTYPE_INFO);
            persistence.save(userNotifyObj);
        }

        public List<Entity_UserNotification> loadAllUserNotification(long staffId)
        {
            Utility.logFile(Constant.METHOD_ENTER + Utility.getCurrentMethodName(1) + "(NotificationManagerImpl)",null, Constant.LOGTYPE_INFO);
            DetachedCriteria mainCriteria = DetachedCriteria.For<Entity_UserNotification>();
            mainCriteria.Add(Restrictions.Eq("myConfigObj.currentBatch", Common.loggedUser.myConfigObj.currentBatch));
            mainCriteria.Add(Restrictions.Eq("myConfigObj.currentDegree", Common.loggedUser.myConfigObj.currentDegree));
            mainCriteria.Add(Restrictions.Eq("staffId", staffId));
            mainCriteria.AddOrder(Order.Desc("notificationId"));

            IList list = persistence.findByCriteria(mainCriteria);

            if (list != null && list.Count > 0)
            {
                return list.Cast<Entity_UserNotification>().ToList();
            }
            else
                return null;
        }

        public bool notifyStudents(List<Entity_Student> studentList, string msg)
        {
            Utility.logFile(Constant.METHOD_ENTER + Utility.getCurrentMethodName(1) + "(NotificationManagerImpl)",null, Constant.LOGTYPE_INFO);
            StringBuilder smsBuilder = new StringBuilder();
            StringBuilder emailBuilder = new StringBuilder();

            foreach (Entity_Student stuObj in studentList)
            {
                if (stuObj.phone != null)
                {
                    smsBuilder.Append(stuObj.phone)
                      .Append(",");
                }
                if (stuObj.email != null)
                {
                    emailBuilder.Append(stuObj.email)
                        .Append(",");
                }
            }
            smsBuilder = smsBuilder.Remove(smsBuilder.Length - 1, 1);
            emailBuilder = emailBuilder.Remove(emailBuilder.Length - 1, 1);

            Console.WriteLine(msg);
            Console.WriteLine(smsBuilder);
            Console.WriteLine(emailBuilder);

            return true;
        }
    }
}
