using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Placement_Application.DAO;
using NHibernate.Criterion;
using System.Collections;
using Placement_Application.Commons;
using System.Windows.Forms;

namespace Placement_Application.Service
{
    public class CompanyManagerImpl : CompanyManager
    {
        private Persistence persistence;

        public CompanyManagerImpl()
        {
            this.persistence = new PersistenceImpl();
        }

        public bool saveNewCompany(Entity_Company compObj)
        {
            Utility.logFile(Constant.METHOD_ENTER + Utility.getCurrentMethodName(1) + "(CompanyManagerImpl)", null,Constant.LOGTYPE_INFO);
            return persistence.saveOrUpdate(compObj);
        }

        public Entity_Company getCompanyById(long compId)
        {
            Utility.logFile(Constant.METHOD_ENTER + Utility.getCurrentMethodName(1) + "(CompanyManagerImpl)", null,Constant.LOGTYPE_INFO);
            DetachedCriteria criteria = DetachedCriteria.For<Entity_Company>();
            criteria.Add(Restrictions.Eq("companyId", compId));
            criteria.SetFetchMode("compDetailsObjList", NHibernate.FetchMode.Eager);//left outer join
     
            IList list = persistence.findByCriteria(criteria);

            if (list.Count > 0)
                return (Entity_Company)list[0];
            else
                return null;
        }

        public List<Entity_CompanyDetails> loadAllCompanies()
        {
            Utility.logFile(Constant.METHOD_ENTER + Utility.getCurrentMethodName(1) + "(CompanyManagerImpl)", null,Constant.LOGTYPE_INFO);
            DetachedCriteria criteria = DetachedCriteria.For<Entity_CompanyDetails>();
            criteria.CreateAlias("companyObj", "company");
      
            criteria.Add(Restrictions.Eq("myConfigObj.currentBatch", Common.loggedUser.myConfigObj.currentBatch));
            criteria.Add(Restrictions.Eq("myConfigObj.currentDegree", Common.loggedUser.myConfigObj.currentDegree));
            criteria.AddOrder(Order.Asc("DOR"));
            
            IList list = persistence.findByCriteria(criteria);
           
            if (list != null && list.Count > 0)
                return list.Cast<Entity_CompanyDetails>().ToList();
            else
                return null;
        }

        public bool updateCompany(Entity_CompanyDetails compDetailObj)
        {
            Utility.logFile(Constant.METHOD_ENTER + Utility.getCurrentMethodName(1) + "(CompanyManagerImpl)", null,Constant.LOGTYPE_INFO);
            if( persistence.update(compDetailObj.companyObj))
                return persistence.update(compDetailObj);
            return false;
        }

        public List<Entity_CompanyDetails> getCompanyBySearchKey(string searchKey)
        {
            Utility.logFile(Constant.METHOD_ENTER + Utility.getCurrentMethodName(1) + "(CompanyManagerImpl)", null,Constant.LOGTYPE_INFO);
            DetachedCriteria criteria = DetachedCriteria.For<Entity_CompanyDetails>();
            criteria.CreateAlias("companyObj", "company");

            criteria.Add(Restrictions.InsensitiveLike("company.companyName", searchKey, MatchMode.Exact));
            criteria.Add(Restrictions.Eq("myConfigObj.currentBatch", Common.loggedUser.myConfigObj.currentBatch));
            criteria.Add(Restrictions.Eq("myConfigObj.currentDegree", Common.loggedUser.myConfigObj.currentDegree));

            IList list = persistence.findByCriteria(criteria);

            if (list != null && list.Count > 0)
                return list.Cast<Entity_CompanyDetails>().ToList();
            else
                return null;
        }

        public List<Entity_CompanyDetails> getCompanyNamesWithDetailId(bool isRestriction)
        {
            Utility.logFile(Constant.METHOD_ENTER + Utility.getCurrentMethodName(1) + "(CompanyManagerImpl)", null,Constant.LOGTYPE_INFO);
            DetachedCriteria criteria = DetachedCriteria.For<Entity_CompanyDetails>();
            criteria.CreateAlias("companyObj", "company");

            criteria.Add(Restrictions.Eq("myConfigObj.currentBatch", Common.loggedUser.myConfigObj.currentBatch));
            criteria.Add(Restrictions.Eq("myConfigObj.currentDegree", Common.loggedUser.myConfigObj.currentDegree));

            if (isRestriction)
            {
                criteria.Add(Restrictions.Eq("status", Utility.getEnumIndexByValue(Constant.ENUM_COMPANY_STATUS,
                     EnumData.companyStatus.CONFIRMED.ToString())));
                criteria.Add(Restrictions.Le("DOR",DateTime.Now.Date.AddDays(1)));
            }
            IList list = persistence.findByCriteria(criteria);

            if (list != null && list.Count > 0)
                return list.Cast<Entity_CompanyDetails>().ToList();
            else
                return null;
        }

        public int getCompanyCount()
        {
            Utility.logFile(Constant.METHOD_ENTER + Utility.getCurrentMethodName(1) + "(CompanyManagerImpl)", null,Constant.LOGTYPE_INFO);
            DetachedCriteria criteria = DetachedCriteria.For<Entity_CompanyDetails>();
            criteria.SetProjection(Projections.Count(Projections.Distinct(Projections.Property("compDetailsId"))));
            criteria.Add(Restrictions.Eq("myConfigObj.currentBatch", Common.loggedUser.myConfigObj.currentBatch));
            criteria.Add(Restrictions.Eq("myConfigObj.currentDegree", Common.loggedUser.myConfigObj.currentDegree));

            IList list = persistence.findByCriteria(criteria);

            if (list != null && list.Count > 0)
                return Convert.ToInt32(list[0]);
            else
                return 0;
        }

        public Entity_Company getCompanyByName(string compName)
        {
            Utility.logFile(Constant.METHOD_ENTER + Utility.getCurrentMethodName(1) + "(CompanyManagerImpl)", null,Constant.LOGTYPE_INFO);
            DetachedCriteria criteria = DetachedCriteria.For<Entity_Company>();
            criteria.SetFetchMode("compDetailsObjList", NHibernate.FetchMode.Eager);//left outer join
            criteria.Add(Restrictions.InsensitiveLike("companyName", compName, MatchMode.Exact));

            IList list = persistence.findByCriteria(criteria);

            if (list != null && list.Count > 0)
                return (Entity_Company)list[0];
            else
                return null;
        }

        public string getCompaniesForNotification(List<Entity_CompanyDetails> compColl)
        {
            Utility.logFile(Constant.METHOD_ENTER + Utility.getCurrentMethodName(1) + "(CompanyManagerImpl)", null,Constant.LOGTYPE_INFO);
            string message = string.Empty;
            StringBuilder tempBuilder = new StringBuilder();
            foreach (Entity_CompanyDetails obj in compColl)
            {
                if (Utility.compareDates(obj.DOR.Date, DateTime.Now.Date) > 0)
                {
                    message = frameMessage(obj, tempBuilder);
                }
            }
            return message;
        }

        private string frameMessage(Entity_CompanyDetails compObj,StringBuilder builder)
        {
            Utility.logFile(Constant.METHOD_ENTER + Utility.getCurrentMethodName(1) + "(CompanyManagerImpl)",null, Constant.LOGTYPE_INFO);
            builder.Append(compObj.companyObj.companyName)
                .Append("=>")
                .Append(Utility.convertDateToString(compObj.DOR))
                .Append("\n");

            return builder.ToString();
        }

        public bool deleteCompanies(ListView listview1)
        {
            Utility.logFile(Constant.METHOD_ENTER + Utility.getCurrentMethodName(1) + "(CompanyManagerImpl)",null, Constant.LOGTYPE_INFO);
            var checkedCompanyList = listview1.CheckedItems.Cast<ListViewItem>()
              .Select(item => item.Tag).ToList();

            return persistence.bulkDelete(checkedCompanyList);
        }

    }
}
