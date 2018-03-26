using System;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Criterion;
using System.Collections;
using Placement_Application.DAO;
using Placement_Application.Commons;

namespace Placement_Application.Service
{
    class StudentManagerImpl : StudentManager
    {
        private Persistence persistence;

        public StudentManagerImpl()
        {
            this.persistence = new PersistenceImpl();
        }

        public List<Entity_Student> loadAllStudentsWithDetails()
        {
            Utility.logFile(Constant.METHOD_ENTER + Utility.getCurrentMethodName(1) + "(StudentManagerImpl)", null,Constant.LOGTYPE_INFO);
            DetachedCriteria criteria = DetachedCriteria.For<Entity_Student>();
            criteria.CreateAlias("placedDetailsObj", "list", NHibernate.SqlCommand.JoinType.LeftOuterJoin);
            criteria.Add(Restrictions.Eq("myConfigObj.currentBatch", Common.loggedUser.myConfigObj.currentBatch));
            criteria.Add(Restrictions.Eq("myConfigObj.currentDegree", Common.loggedUser.myConfigObj.currentDegree));
            criteria.AddOrder(Order.Asc("collegeId"));
            IList resultList = persistence.findByCriteria(criteria);

            if (resultList != null && resultList.Count > 0)
                return resultList.Cast<Entity_Student>().Distinct().ToList();
            else
                return null;
        }

        public List<Entity_Student> loadStudentDetailsBySearchKey(string searchKey)
        {
            Utility.logFile(Constant.METHOD_ENTER + Utility.getCurrentMethodName(1) + "(StudentManagerImpl)",null, Constant.LOGTYPE_INFO);
            DetachedCriteria criteria = DetachedCriteria.For<Entity_Student>();
            criteria.CreateAlias("placedDetailsObj", "list", NHibernate.SqlCommand.JoinType.LeftOuterJoin);
            criteria.Add(Restrictions.Eq("myConfigObj.currentBatch", Common.loggedUser.myConfigObj.currentBatch));
            criteria.Add(Restrictions.Eq("myConfigObj.currentDegree", Common.loggedUser.myConfigObj.currentDegree));
  
            Disjunction disjunction = Restrictions.Disjunction();
            disjunction.Add(Restrictions.InsensitiveLike("collegeId", searchKey, MatchMode.Exact));
            
            criteria.Add(disjunction);
            criteria.AddOrder(Order.Asc("collegeId"));
            
            IList resultList = persistence.findByCriteria(criteria);

            if (resultList != null && resultList.Count > 0)
                return resultList.Cast<Entity_Student>().Distinct().ToList();
            else
                return null;
        }

        public IDictionary<string, IList<string>> getDegreeWithBatch()
        {
            Utility.logFile(Constant.METHOD_ENTER + Utility.getCurrentMethodName(1) + "(StudentManagerImpl)",null, Constant.LOGTYPE_INFO);
            DetachedCriteria subCriteria = DetachedCriteria.For<Entity_Student>();
            subCriteria.SetProjection(Projections.Distinct(Projections.Property("myConfigObj.currentBatch")));

            DetachedCriteria mainCriteria = DetachedCriteria.For<Entity_Student>();
            ProjectionList projectionList = Projections.ProjectionList();
            projectionList.Add(Projections.Distinct(Projections.Property("myConfigObj.currentDegree")));
            projectionList.Add(Projections.Property("myConfigObj.currentBatch"));
            mainCriteria.SetProjection(projectionList);
            mainCriteria.Add(Subqueries.Exists(subCriteria));

            IList resultList = persistence.findByCriteria(mainCriteria);

            if (resultList != null && resultList.Count > 0)
            {
                IList<string> degreeList;
                IDictionary<string, IList<string>> batchDegreeMap=new Dictionary<string,IList<string>>();
                foreach (Object[] arr in resultList)
                {
                    string key = arr[1].ToString();
                    string value = arr[0].ToString();
                    if (batchDegreeMap.ContainsKey(key))
                    {
                        batchDegreeMap[key].Add(value);
                    }
                    else
                    {
                        degreeList=new List<string>();
                        degreeList.Add(value);
                        batchDegreeMap.Add(key,degreeList);
                    }
                }
                return batchDegreeMap;
            }
            return null;
        }

        public List<Entity_Student> loadAllStudents()
        {
            Utility.logFile(Constant.METHOD_ENTER + Utility.getCurrentMethodName(1) + "(StudentManagerImpl)", null,Constant.LOGTYPE_INFO);
            DetachedCriteria criteria = DetachedCriteria.For<Entity_Student>();
            criteria.Add(Restrictions.Eq("myConfigObj.currentBatch", Common.loggedUser.myConfigObj.currentBatch));
            criteria.Add(Restrictions.Eq("myConfigObj.currentDegree", Common.loggedUser.myConfigObj.currentDegree));
            criteria.AddOrder(Order.Asc("collegeId"));
            IList resultList = persistence.findByCriteria(criteria);

            if (resultList != null && resultList.Count > 0)
                return resultList.Cast<Entity_Student>().Distinct().ToList();
            else
                return null;
        }
    }
}
