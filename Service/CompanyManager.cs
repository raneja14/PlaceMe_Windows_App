using System.Windows.Forms;
using System.Collections.Generic;

namespace Placement_Application.Service
{
    public interface CompanyManager
    {
        bool saveNewCompany(Entity_Company compObj);

        Entity_Company getCompanyById(long compId);

        List<Entity_CompanyDetails> loadAllCompanies();

        bool updateCompany(Entity_CompanyDetails compDetailObj);

        List<Entity_CompanyDetails> getCompanyBySearchKey(string searchKey);

        List<Entity_CompanyDetails> getCompanyNamesWithDetailId(bool isRestriction);

        int getCompanyCount();

        Entity_Company getCompanyByName(string compName);

        string getCompaniesForNotification(List<Entity_CompanyDetails> compColl);

        bool deleteCompanies(ListView listview1);
    }
}
