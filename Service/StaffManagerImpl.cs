using System;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Criterion;
using System.Collections;
using Placement_Application.DAO;
using System.Windows.Forms;
using Placement_Application.Commons;

namespace Placement_Application.Service
{
    public class StaffManagerImpl : StaffManager
    {
        private Persistence persistence;

        public StaffManagerImpl()
        {
            this.persistence = new PersistenceImpl();
        }

        public Entity_Staff getStaffById(long staffId, string password)
        {
            Utility.logFile(Constant.METHOD_ENTER + Utility.getCurrentMethodName(1) + "(StaffManagerImpl)", null,Constant.LOGTYPE_INFO);
            DetachedCriteria criteria = DetachedCriteria.For<Entity_Staff>();
            criteria.Add(Restrictions.Eq("staffId", staffId));
            criteria.Add(Restrictions.Eq("password", password));

            IList list = new List<Entity_Staff>();
            list = persistence.findByCriteria(criteria);

            if (list != null && list.Count > 0)
                return (Entity_Staff)list[0];
            else
                return null;
        }

        public bool updateStaffDetails(Entity_Staff staffObj)
        {
            Utility.logFile(Constant.METHOD_ENTER + Utility.getCurrentMethodName(1) + "(StaffManagerImpl)", null,Constant.LOGTYPE_INFO);
            return persistence.update(staffObj);
        }

        public Entity_Staff getStaffByEmail(string email, string phone)
        {
            Utility.logFile(Constant.METHOD_ENTER + Utility.getCurrentMethodName(1) + "(StaffManagerImpl)", null,Constant.LOGTYPE_INFO);
            DetachedCriteria criteria = DetachedCriteria.For<Entity_Staff>();
            criteria.Add(Restrictions.Eq("email", email));
            criteria.Add(Restrictions.Eq("phone", phone));

            IList list = new List<Entity_Staff>();
            list = persistence.findByCriteria(criteria);

            if (list != null && list.Count > 0)
                return (Entity_Staff)list[0];
            else
                return null;
        }

        public List<Entity_Staff> loadAllUsers()
        {
            Utility.logFile(Constant.METHOD_ENTER + Utility.getCurrentMethodName(1) + "(StaffManagerImpl)", null,Constant.LOGTYPE_INFO);
            DetachedCriteria criteria = DetachedCriteria.For<Entity_Staff>();
            criteria.Add(Restrictions.Gt("staffId",Convert.ToInt64(Common.adminId)));

            IList list = persistence.findByCriteria(criteria);

            if (list != null && list.Count > 0)
                return list.Cast<Entity_Staff>().ToList();
            else
                return null;
        }

        public bool changeUserStatus(ListView listView1, bool status)
        {
            Utility.logFile(Constant.METHOD_ENTER + Utility.getCurrentMethodName(1) + "(StaffManagerImpl)", null,Constant.LOGTYPE_INFO);
            var checkedUsersList = new List<Object>();
            foreach (ListViewItem item in listView1.CheckedItems)
            {
                var staffObj = item.Tag as Entity_Staff;
                staffObj.isAccountActive = status;
                checkedUsersList.Add(staffObj);
                staffObj = null;
            }
            return persistence.bulkUpdate(checkedUsersList);
        }

        public bool addNewUser(Entity_Staff newUser)
        {
            Utility.logFile(Constant.METHOD_ENTER + Utility.getCurrentMethodName(1) + "(StaffManagerImpl)",null, Constant.LOGTYPE_INFO);
            newUser.password = Utility.getMD5Value(Utility.generateTempUserPassword(newUser));
            return persistence.save(newUser);
        }

        public List<Entity_Staff> getUnusedUsersList()
        {
            Utility.logFile(Constant.METHOD_ENTER + Utility.getCurrentMethodName(1) + "(StaffManagerImpl)", null,Constant.LOGTYPE_INFO);
            DetachedCriteria mainCriteria = DetachedCriteria.For<Entity_Staff>("staff");
          
            DetachedCriteria subCriteria1 = DetachedCriteria.For<Entity_Notification>("notificationObj");
            subCriteria1.Add(Restrictions.EqProperty("notificationObj.staffId", "staff.staffId"));
            subCriteria1.SetProjection(Projections.Distinct(Projections.Property("notificationObj.staffId")));

            DetachedCriteria subCriteria2 = DetachedCriteria.For<Entity_UserNotification>("userNotificationObj");
            subCriteria2.Add(Restrictions.EqProperty("userNotificationObj.staffId", "staff.staffId"));
            subCriteria2.SetProjection(Projections.Distinct(Projections.Property("userNotificationObj.staffId")));
         
            mainCriteria.Add(Subqueries.NotExists(subCriteria1));
            mainCriteria.Add(Subqueries.NotExists(subCriteria2));
            mainCriteria.Add(Restrictions.Gt("staffId", Convert.ToInt64(Common.adminId)));
  
            IList list = persistence.findByCriteria(mainCriteria);

            if (list != null && list.Count > 0)
                return list.Cast<Entity_Staff>().ToList();
            else
                return null;
        }

        public bool deleteUsers(ListView listview1)
        {
            Utility.logFile(Constant.METHOD_ENTER + Utility.getCurrentMethodName(1) + "(StaffManagerImpl)", null,Constant.LOGTYPE_INFO);
            var checkedUsersList = listview1.CheckedItems.Cast<ListViewItem>()
                .Select(item => item.Tag).ToList();
           
            return persistence.bulkDelete(checkedUsersList);
        }
    }
}
