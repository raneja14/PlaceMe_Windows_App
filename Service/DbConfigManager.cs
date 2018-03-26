using System;
using System.Collections.Generic;
using Excel = Microsoft.Office.Interop.Excel;

namespace Placement_Application
{
    interface DbConfigManager
    {
        int insertStudentData(IList<Object> coll);

        int updateStudentData(IList<Object> coll);

        IList<Object> getListFromExcel(Excel.Range xlRange, int operation);


    }
}
