using System.Collections;
using System.Collections.Generic;

namespace Placement_Application.Service
{
    interface StatisticsManager
    {
        int getPlacedStudentCount();

        int getNonPlacedStudentCount();

        IList getCompanyStatCount();

        IDictionary<string, int> getStudentBranchData();

        IDictionary<string, int> getStudentCompanyData();

        IDictionary<string, int> getMonthlyCompanyMap();

        IDictionary<string, int> getMonthlyStudentMap();

        IDictionary<string, int> getYearlyCompanyMap();

        IDictionary<string, int> getYearlyStudentMap();







    }
}
