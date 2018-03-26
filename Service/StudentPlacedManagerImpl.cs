using System;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Criterion;
using Placement_Application.DAO;
using Placement_Application.DTO;
using System.Collections;
using NHibernate.Transform;
using Placement_Application.Commons;

namespace Placement_Application.Service
{
    class StudentPlacedManagerImpl : StudentPlacedManager
    {
        private Persistence persistence;

        public StudentPlacedManagerImpl()
        {
            this.persistence = new PersistenceImpl();
        }

        public int getHiredStudentsCount(long compDetailsId)
        {
            Utility.logFile(Constant.METHOD_ENTER + Utility.getCurrentMethodName(1) + "(StudentPlacedManagerImpl)", null, Constant.LOGTYPE_INFO);
            DetachedCriteria criteria = DetachedCriteria.For<Entity_PlacementDetails>();
            criteria.CreateAlias("compDetailsObj", "compDetails");

            criteria.Add(Restrictions.Eq("compDetails.myConfigObj.currentBatch", Common.loggedUser.myConfigObj.currentBatch));
            criteria.Add(Restrictions.Eq("compDetails.myConfigObj.currentDegree", Common.loggedUser.myConfigObj.currentDegree));
            criteria.Add(Restrictions.Eq("companyDetailsId", compDetailsId));
            criteria.SetProjection(Projections.Count("companyDetailsId"));

            IList list = persistence.findByCriteria(criteria);
            if (list != null && list.Count > 0)
            {
                return Convert.ToInt32(list[0]);
            }
            else
                return 0;
        }

        public List<StudentPlacedDto> getPlacedStudents()
        {
            Utility.logFile(Constant.METHOD_ENTER + Utility.getCurrentMethodName(1) + "(StudentPlacedManagerImpl)",null, Constant.LOGTYPE_INFO);
            DetachedCriteria criteria = DetachedCriteria.For<Entity_PlacementDetails>();
            criteria.CreateAlias("stuObj", "student");
            criteria.CreateAlias("compDetailsObj", "compDetails");
            criteria.CreateAlias("compDetails.companyObj", "company");

            ProjectionList projectionsList = Projections.ProjectionList();
            projectionsList.Add(Projections.Property("detailsId"), "detailsId");
            projectionsList.Add(Projections.Property("student.collegeId"), "collegeId");
            projectionsList.Add(Projections.Property("student.studentName"), "name");
            projectionsList.Add(Projections.Property("student.gender"), "gender");
            projectionsList.Add(Projections.Property("student.branch"), "branch");
            projectionsList.Add(Projections.Property("student.myConfigObj.currentDegree"), "degree");
            projectionsList.Add(Projections.Property("student.phone"), "contact");
            projectionsList.Add(Projections.Property("company.companyName"), "company");
            projectionsList.Add(Projections.Property("compDetails.type"), "companyType"); 
            projectionsList.Add(Projections.Property("DOR"), "dor");

            criteria.SetProjection(projectionsList);
            criteria.Add(Restrictions.Eq("compDetails.myConfigObj.currentBatch", Common.loggedUser.myConfigObj.currentBatch));
            criteria.Add(Restrictions.Eq("compDetails.myConfigObj.currentDegree", Common.loggedUser.myConfigObj.currentDegree));
            criteria.Add(Restrictions.Eq("student.myConfigObj.currentBatch", Common.loggedUser.myConfigObj.currentBatch));
            criteria.Add(Restrictions.Eq("student.myConfigObj.currentDegree", Common.loggedUser.myConfigObj.currentDegree));
           
            criteria.AddOrder(Order.Asc("DOR"));
            criteria.SetResultTransformer(new AliasToBeanResultTransformer(typeof(StudentPlacedDto)));
            IList list = persistence.findByCriteria(criteria);

            if (list != null && list.Count > 0)
                return list.Cast<StudentPlacedDto>().ToList();
            else
                return null;
        }

        public List<StudentPlacedDto> getNonPlacedStudents()
        {
            Utility.logFile(Constant.METHOD_ENTER + Utility.getCurrentMethodName(1) + "(StudentPlacedManagerImpl)",null, Constant.LOGTYPE_INFO);
            DetachedCriteria mainCriteria = DetachedCriteria.For<Entity_Student>("student");
            mainCriteria.Add(Restrictions.Eq("student.myConfigObj.currentBatch", Common.loggedUser.myConfigObj.currentBatch));
            mainCriteria.Add(Restrictions.Eq("student.myConfigObj.currentDegree", Common.loggedUser.myConfigObj.currentDegree));
  
            DetachedCriteria subCriteria = DetachedCriteria.For<Entity_PlacementDetails>("placedObj");
            subCriteria.Add(Restrictions.EqProperty("placedObj.studentId", "student.studentId"));
            subCriteria.SetProjection(Projections.Distinct(Projections.Property("placedObj.studentId")));
            mainCriteria.Add(Subqueries.NotExists(subCriteria));

            ProjectionList projectionsList = Projections.ProjectionList();
            projectionsList.Add(Projections.Property("student.collegeId"), "collegeId");
            projectionsList.Add(Projections.Property("student.studentName"), "name");
            projectionsList.Add(Projections.Property("student.gender"), "gender");
            projectionsList.Add(Projections.Property("student.branch"), "branch");
            projectionsList.Add(Projections.Property("student.myConfigObj.currentDegree"), "degree");
            projectionsList.Add(Projections.Property("student.phone"), "contact");

            mainCriteria.SetProjection(projectionsList);
            mainCriteria.AddOrder(Order.Asc("student.collegeId"));

            mainCriteria.SetResultTransformer(new AliasToBeanResultTransformer(typeof(StudentPlacedDto)));

            IList list = persistence.findByCriteria(mainCriteria);
            if (list != null && list.Count > 0)
                return list.Cast<StudentPlacedDto>().ToList();
            else
                return null;
        }
    
        public List<StudentPlacedDto> getPlacedStudentsBySearchKey(string searchKey)
        {
            Utility.logFile(Constant.METHOD_ENTER + Utility.getCurrentMethodName(1) + "(StudentPlacedManagerImpl)", null,Constant.LOGTYPE_INFO);
            DetachedCriteria criteria = DetachedCriteria.For<Entity_PlacementDetails>();
            criteria.CreateAlias("stuObj", "student");
            criteria.CreateAlias("compDetailsObj", "compDetails");
            criteria.CreateAlias("compDetails.companyObj", "company");

            Disjunction disjunction = Restrictions.Disjunction();
            disjunction.Add(Restrictions.InsensitiveLike("student.collegeId", searchKey, MatchMode.Exact));
         
            criteria.Add(disjunction);

            ProjectionList projectionsList = Projections.ProjectionList();
            projectionsList.Add(Projections.Property("student.collegeId"), "collegeId");
            projectionsList.Add(Projections.Property("student.studentName"), "name");
            projectionsList.Add(Projections.Property("student.gender"), "gender");
            projectionsList.Add(Projections.Property("student.branch"), "branch");
            projectionsList.Add(Projections.Property("student.myConfigObj.currentDegree"), "degree");
            projectionsList.Add(Projections.Property("student.phone"), "contact");
            projectionsList.Add(Projections.Property("company.companyName"), "company");
            projectionsList.Add(Projections.Property("DOR"), "dor");

            criteria.SetProjection(projectionsList);
            criteria.Add(Restrictions.Eq("compDetails.myConfigObj.currentBatch", Common.loggedUser.myConfigObj.currentBatch));
            criteria.Add(Restrictions.Eq("compDetails.myConfigObj.currentDegree", Common.loggedUser.myConfigObj.currentDegree));
            criteria.Add(Restrictions.Eq("student.myConfigObj.currentBatch", Common.loggedUser.myConfigObj.currentBatch));
            criteria.Add(Restrictions.Eq("student.myConfigObj.currentDegree", Common.loggedUser.myConfigObj.currentDegree));
           
            criteria.AddOrder(Order.Asc("DOR"));
            criteria.SetResultTransformer(new AliasToBeanResultTransformer(typeof(StudentPlacedDto)));
            IList list = persistence.findByCriteria(criteria);

            if (list != null && list.Count > 0)
                return list.Cast<StudentPlacedDto>().ToList();
            else
                return null;
        }

        public List<StudentPlacedDto> getNonPlacedStudentsBySearchKey(string searchKey)
        {
            Utility.logFile(Constant.METHOD_ENTER + Utility.getCurrentMethodName(1) + "(StudentPlacedManagerImpl)", null,Constant.LOGTYPE_INFO);
            DetachedCriteria mainCriteria = DetachedCriteria.For<Entity_Student>("student");
             mainCriteria.Add(Restrictions.Eq("student.myConfigObj.currentBatch", Common.loggedUser.myConfigObj.currentBatch));
            mainCriteria.Add(Restrictions.Eq("student.myConfigObj.currentDegree", Common.loggedUser.myConfigObj.currentDegree));
    
            DetachedCriteria subCriteria = DetachedCriteria.For<Entity_PlacementDetails>("placedObj");
            subCriteria.Add(Restrictions.EqProperty("placedObj.studentId", "student.studentId"));
            subCriteria.SetProjection(Projections.Distinct(Projections.Property("placedObj.studentId")));
            mainCriteria.Add(Subqueries.NotExists(subCriteria));

            Disjunction disjunction = Restrictions.Disjunction();
            disjunction.Add(Restrictions.InsensitiveLike("student.collegeId", searchKey, MatchMode.Exact));
          
            mainCriteria.Add(disjunction);

            ProjectionList projectionsList = Projections.ProjectionList();
            projectionsList.Add(Projections.Property("student.collegeId"), "collegeId");
            projectionsList.Add(Projections.Property("student.studentName"), "name");
            projectionsList.Add(Projections.Property("student.gender"), "gender");
            projectionsList.Add(Projections.Property("student.branch"), "branch");
            projectionsList.Add(Projections.Property("student.myConfigObj.currentDegree"), "degree");
            projectionsList.Add(Projections.Property("student.phone"), "contact");

            mainCriteria.SetProjection(projectionsList);
            mainCriteria.AddOrder(Order.Asc("student.collegeId"));

            mainCriteria.SetResultTransformer(new AliasToBeanResultTransformer(typeof(StudentPlacedDto)));

            IList list = persistence.findByCriteria(mainCriteria);
            if (list != null && list.Count > 0)
                return list.Cast<StudentPlacedDto>().ToList();
            else
                return null;
        }

        public bool savePlacementDetails(Entity_PlacementDetails placedDetailsObj)
        {
            Utility.logFile(Constant.METHOD_ENTER + Utility.getCurrentMethodName(1) + "(StudentPlacedManagerImpl)",null, Constant.LOGTYPE_INFO);
            return persistence.save(placedDetailsObj);
        }

        public int uploadPlacementData(IList<Object> coll,long compId,DateTime DOR)
        {
            Utility.logFile(Constant.METHOD_ENTER + Utility.getCurrentMethodName(1) + "(StudentPlacedManagerImpl)",null, Constant.LOGTYPE_INFO);
            if (coll == null)
                return 0;
            
            if (coll.Count == 0)
                return 3;

            if (!Utility.isNetworkAvailable())
                return 4;

            if (!persistence.truncateTable<Entity_TempData>())
                return 0;
            
            if (!Utility.isNetworkAvailable())
                return 4;
            
            if (!persistence.bulkInsert(coll))
                return 0;

            if (!Utility.isNetworkAvailable())
                return 4;

            if (!persistence.nativeQuery(Common.mySqlUpdateQuery1_tempdata))
                return 0;

            if (!Utility.isNetworkAvailable())
                return 4; 
            List<long> studentIdsList = loadTempData();
            if (studentIdsList != null)
            {
                var studentPlacedList = new List<Object>();
                foreach (long id in studentIdsList)
                {
                    studentPlacedList.Add(new Entity_PlacementDetails(id, compId, DOR));
                }
                if (!Utility.isNetworkAvailable())
                    return 4;

                if (!persistence.bulkInsert(studentPlacedList))
                    return 2;
            }
            return 1;
        }

        private List<long> loadTempData()
        {
            Utility.logFile(Constant.METHOD_ENTER + Utility.getCurrentMethodName(1) + "(StudentPlacedManagerImpl)", null,Constant.LOGTYPE_INFO);
            DetachedCriteria criteria = DetachedCriteria.For<Entity_TempData>();
            ProjectionList projectionsList = Projections.ProjectionList();
            projectionsList.Add(Projections.Property("studentId"));
            criteria.SetProjection(projectionsList);

            IList list = persistence.findByCriteria(criteria);

            if (list != null && list.Count > 0)
                return list.Cast<long>().ToList<long>();
            else
                return null;
        }

    }
}
