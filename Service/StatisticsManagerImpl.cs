using NHibernate.Criterion;
using System;
using System.Collections;
using System.Collections.Generic;
using Placement_Application.DAO;
using Placement_Application.Commons;
using NHibernate.Type;
using NHibernate;

namespace Placement_Application.Service
{
    class StatisticsManagerImpl:StatisticsManager
    {
        private Persistence persistence;

        public StatisticsManagerImpl()
        {
            this.persistence = new PersistenceImpl();
        }

        public int getPlacedStudentCount()
        {
            Utility.logFile(Constant.METHOD_ENTER + Utility.getCurrentMethodName(1) + "(StatisticsManagerImpl)",null, Constant.LOGTYPE_INFO);
            DetachedCriteria criteria = DetachedCriteria.For<Entity_PlacementDetails>();
            criteria.CreateAlias("stuObj","student");
            criteria.SetProjection(Projections.Count(Projections.Distinct(Projections.Property("studentId"))));

            criteria.Add(Restrictions.Eq("student.myConfigObj.currentBatch", Common.loggedUser.myConfigObj.currentBatch));
            criteria.Add(Restrictions.Eq("student.myConfigObj.currentDegree", Common.loggedUser.myConfigObj.currentDegree));
            IList list = persistence.findByCriteria(criteria);

            if (list != null && list.Count > 0)
                return Convert.ToInt32(list[0]);
            else
                return 0;
        }

        public int getNonPlacedStudentCount()
        {
            Utility.logFile(Constant.METHOD_ENTER + Utility.getCurrentMethodName(1) + "(StatisticsManagerImpl)",null, Constant.LOGTYPE_INFO);
            DetachedCriteria subCriteria = DetachedCriteria.For<Entity_PlacementDetails>("placedObj");
            subCriteria.Add(Restrictions.EqProperty("placedObj.studentId", "student.studentId"));
            subCriteria.SetProjection(Projections.Distinct(Projections.Property("placedObj.studentId")));

            DetachedCriteria mainCriteria = DetachedCriteria.For<Entity_Student>("student");
            mainCriteria.SetProjection(Projections.Count(Projections.Distinct(Projections.Property("student.studentId"))));
            mainCriteria.Add(Subqueries.NotExists(subCriteria));
            mainCriteria.Add(Restrictions.Eq("student.myConfigObj.currentBatch", Common.loggedUser.myConfigObj.currentBatch));
            mainCriteria.Add(Restrictions.Eq("student.myConfigObj.currentDegree", Common.loggedUser.myConfigObj.currentDegree));
          
            IList list = persistence.findByCriteria(mainCriteria);

            if (list != null && list.Count > 0)
                return Convert.ToInt32(list[0]);
            else
                return 0;
       
        }

        public IList getCompanyStatCount()
        {
            Utility.logFile(Constant.METHOD_ENTER + Utility.getCurrentMethodName(1) + "(StatisticsManagerImpl)", null,Constant.LOGTYPE_INFO);
            DetachedCriteria criteria = DetachedCriteria.For<Entity_CompanyDetails>();
            criteria.Add(Restrictions.Eq("myConfigObj.currentBatch", Common.loggedUser.myConfigObj.currentBatch));
            criteria.Add(Restrictions.Eq("myConfigObj.currentDegree", Common.loggedUser.myConfigObj.currentDegree));
   
            ProjectionList projectionList = Projections.ProjectionList();
            projectionList.Add(Projections.Count((Projections.Property("status"))));
            projectionList.Add(Projections.GroupProperty(Projections.Property("status")));

            criteria.SetProjection(projectionList);
            criteria.AddOrder(Order.Desc(Projections.Property("status")));

            IList list = persistence.findByCriteria(criteria);

            if (list != null && list.Count > 0)
                return list;
            else
                return null;
        }

        public IDictionary<string, int> getStudentBranchData()
        {
            Utility.logFile(Constant.METHOD_ENTER + Utility.getCurrentMethodName(1) + "(StatisticsManagerImpl)",null, Constant.LOGTYPE_INFO);
            DetachedCriteria subCriteria = DetachedCriteria.For<Entity_PlacementDetails>("placedObj");
            subCriteria.Add(Restrictions.EqProperty("placedObj.studentId", "student.studentId"));
            subCriteria.SetProjection(Projections.Distinct(Projections.Property("placedObj.studentId")));

            DetachedCriteria mainCriteria = DetachedCriteria.For<Entity_Student>("student");
            ProjectionList projectionList = Projections.ProjectionList();
            projectionList.Add(Projections.GroupProperty(Projections.Property("student.branch")));
            projectionList.Add(Projections.Count(Projections.Property("student.branch")));
           
            mainCriteria.SetProjection(projectionList);
            mainCriteria.Add(Subqueries.Exists(subCriteria));
            mainCriteria.Add(Restrictions.Eq("student.myConfigObj.currentBatch", Common.loggedUser.myConfigObj.currentBatch));
            mainCriteria.Add(Restrictions.Eq("student.myConfigObj.currentDegree", Common.loggedUser.myConfigObj.currentDegree));
            mainCriteria.AddOrder(Order.Asc("student.branch"));
           
            IList list = persistence.findByCriteria(mainCriteria);

            if (list != null && list.Count > 0)
            {
                IDictionary<string, int> resultMap = new Dictionary<string, int>();

                foreach (Object[] item in list)
                {
                    resultMap.Add(item[0].ToString(), Convert.ToInt32(item[1]));
                }
                return resultMap;
            }
            else
                return null;
        }

        public IDictionary<string, int> getStudentCompanyData()
        {
            Utility.logFile(Constant.METHOD_ENTER + Utility.getCurrentMethodName(1) + "(StatisticsManagerImpl)", null,Constant.LOGTYPE_INFO);
            DetachedCriteria criteria = DetachedCriteria.For<Entity_PlacementDetails>();
            criteria.CreateAlias("compDetailsObj", "compDetail");
            criteria.CreateAlias("compDetail.companyObj", "company");

            ProjectionList projectionList = Projections.ProjectionList();
            projectionList.Add(Projections.GroupProperty(Projections.Property("company.companyName")));
            projectionList.Add(Projections.Count(Projections.Property("compDetail.compDetailsId")));

            criteria.Add(Restrictions.Eq("compDetail.myConfigObj.currentBatch", Common.loggedUser.myConfigObj.currentBatch));
            criteria.Add(Restrictions.Eq("compDetail.myConfigObj.currentDegree", Common.loggedUser.myConfigObj.currentDegree));
            criteria.SetProjection(projectionList);
            criteria.AddOrder(Order.Asc("company.companyName"));

            IList list = persistence.findByCriteria(criteria);

            if (list != null && list.Count > 0)
            {
                IDictionary<string, int> resultMap = new Dictionary<string, int>();

                foreach (Object[] item in list)
                {
                    resultMap.Add(item[0].ToString(), Convert.ToInt32(item[1]));
                }
                return resultMap;
            }
            else
                return null;
        }

        public IDictionary<string, int> getMonthlyCompanyMap()
        {
            Utility.logFile(Constant.METHOD_ENTER + Utility.getCurrentMethodName(1) + "(StatisticsManagerImpl)",null, Constant.LOGTYPE_INFO);
            DetachedCriteria criteria = DetachedCriteria.For<Entity_CompanyDetails>();
            criteria.Add(Restrictions.Eq("myConfigObj.currentBatch", Common.loggedUser.myConfigObj.currentBatch));
            criteria.Add(Restrictions.Eq("myConfigObj.currentDegree", Common.loggedUser.myConfigObj.currentDegree));
            criteria.Add(Restrictions.Eq("status", Utility.getEnumIndexByValue(Constant.ENUM_COMPANY_STATUS,
                       EnumData.companyStatus.CONFIRMED.ToString())));
            //criteria.Add(Restrictions.Le("DOR", DateTime.Now));

            ProjectionList projectionList = Projections.ProjectionList();
            projectionList.Add(Projections.SqlGroupProjection(
                "MONTH(DOR) as Month,COUNT(COMP_DETAILS_ID) AS CompCount",
                "Month",
                new String[] { "Month", "CompCount" },
                new IType[] { NHibernateUtil.Int32, NHibernateUtil.Int32 }
                ));

            criteria.SetProjection(projectionList);

            IList list = persistence.findByCriteria(criteria);

            if (list != null && list.Count > 0)
            {
                IDictionary<string, int> resultMap = new Dictionary<string, int>();
               
                foreach (var enumValue in Enum.GetValues(typeof(EnumData.StatsUiMonth)))
                {
                    resultMap.Add(enumValue.ToString(), 0);
                }
                
                foreach (Object[] item in list)
                {
                    resultMap[Utility.getEnumValueByIndex(Constant.ENUM_STATS_MONTH,
                        Convert.ToInt32(item[0]))]= Convert.ToInt32(item[1]);
                }
                return resultMap;
            }
            else
                return null;
        }

        public IDictionary<string, int> getMonthlyStudentMap()
        {
            Utility.logFile(Constant.METHOD_ENTER + Utility.getCurrentMethodName(1) + "(StatisticsManagerImpl)",null, Constant.LOGTYPE_INFO);
            DetachedCriteria criteria = DetachedCriteria.For<Entity_PlacementDetails>();
            criteria.CreateAlias("stuObj","student");
            criteria.Add(Restrictions.Eq("student.myConfigObj.currentBatch", Common.loggedUser.myConfigObj.currentBatch));
            criteria.Add(Restrictions.Eq("student.myConfigObj.currentDegree", Common.loggedUser.myConfigObj.currentDegree));
  
            ProjectionList projectionList = Projections.ProjectionList();
            projectionList.Add(Projections.SqlGroupProjection(
                "MONTH(DOR) as Month,COUNT(DETAILS_ID) AS StudentCount",
                "Month",
                new String[] { "Month", "StudentCount" },
                new IType[] { NHibernateUtil.Int32, NHibernateUtil.Int32 }
                ));

            criteria.SetProjection(projectionList);

            IList list = persistence.findByCriteria(criteria);

            if (list != null && list.Count > 0)
            {
                IDictionary<string, int> resultMap = new Dictionary<string, int>();
              
                foreach (var enumValue in Enum.GetValues(typeof(EnumData.StatsUiMonth)))
                {
                    resultMap.Add(enumValue.ToString(), 0);
                }
              
                foreach (Object[] item in list)
                {
                    resultMap[Utility.getEnumValueByIndex(Constant.ENUM_STATS_MONTH,
                        Convert.ToInt32(item[0]))]= Convert.ToInt32(item[1]);
                }
                return resultMap;
            }
            else
                return null;
        }

        public IDictionary<string, int> getYearlyCompanyMap()
        {
            Utility.logFile(Constant.METHOD_ENTER + Utility.getCurrentMethodName(1) + "(StatisticsManagerImpl)", null,Constant.LOGTYPE_INFO);
            DetachedCriteria criteria = DetachedCriteria.For<Entity_CompanyDetails>();
            criteria.Add(Restrictions.Eq("status", Utility.getEnumIndexByValue(Constant.ENUM_COMPANY_STATUS,
                       EnumData.companyStatus.CONFIRMED.ToString())));
            criteria.Add(Restrictions.Eq("myConfigObj.currentDegree", Common.loggedUser.myConfigObj.currentDegree));
     
            ProjectionList projectionList = Projections.ProjectionList();
            projectionList.Add(Projections.GroupProperty(Projections.Property("myConfigObj.currentBatch")));
            projectionList.Add(Projections.Count(Projections.Property("compDetailsId")));
         
            criteria.SetProjection(projectionList);

            IList list = persistence.findByCriteria(criteria);

            if (list != null && list.Count > 0)
            {
                IDictionary<string, int> resultMap = new Dictionary<string, int>();

                foreach (Object[] item in list)
                {
                    resultMap.Add(item[0].ToString(), Convert.ToInt32(item[1]));
                }
                return resultMap; 
            }
            else
                return null;
        }

        public IDictionary<string, int> getYearlyStudentMap()
        {
            Utility.logFile(Constant.METHOD_ENTER + Utility.getCurrentMethodName(1) + "(StatisticsManagerImpl)", null,Constant.LOGTYPE_INFO);
            DetachedCriteria criteria = DetachedCriteria.For<Entity_PlacementDetails>();
            criteria.CreateAlias("stuObj", "student");

            ProjectionList projectionList = Projections.ProjectionList();
            projectionList.Add(Projections.GroupProperty(Projections.Property("student.myConfigObj.currentBatch")));
            projectionList.Add(Projections.Count(Projections.Property("detailsId")));

            criteria.SetProjection(projectionList);
            criteria.Add(Restrictions.Eq("student.myConfigObj.currentDegree", Common.loggedUser.myConfigObj.currentDegree));
       
            IList list = persistence.findByCriteria(criteria);

            if (list != null && list.Count > 0)
            {
                IDictionary<string, int> resultMap = new Dictionary<string, int>();

                foreach (Object[] item in list)
                {
                    resultMap.Add(item[0].ToString(), Convert.ToInt32(item[1]));
                }
                return resultMap;
            }
            else
                return null;
        }
    }
}
