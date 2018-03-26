using System;
using System.Collections.Generic;
using Placement_Application.DAO;
using Placement_Application.Commons;
using Placement_Application.Components;
using Excel = Microsoft.Office.Interop.Excel;

namespace Placement_Application
{
    public class DbConfigManagerImpl : DbConfigManager
    {
        public int insertStudentData(IList<object> coll)
        {
            if (coll != null && coll.Count > 0)
            {
                var studentList = coll[0] as List<object>;
                var scoreList = coll[1] as List<object>;

                if (studentList.Count > 0)
                {
                    Persistence persistence = new PersistenceImpl();
                    if (persistence.bulkInsert(studentList))
                    {
                        if (persistence.bulkInsert(scoreList))
                        {
                            if (persistence.nativeQuery(Common.mySqlUpdateQuery1_studentscore))
                                return 1;
                        }
                    }
                    else
                        return 3;
                }
                else
                    return 2;
            }
            return 0;
        }

        public int updateStudentData(IList<object> coll)
        {
            if (coll != null )
            {
                if (coll.Count > 0)
                {   
                    Persistence persistence = new PersistenceImpl();
                    if (persistence.truncateTable<Entity_UpdateScore>())
                    {
                        if (persistence.bulkInsert(coll))
                        {
                            if (persistence.nativeQuery(Common.mySqlUpdateQuery1_updatescore))
                                return 1;
                        }
                        return 0;
                    }
                    return 0;
                }
                return 2;
            }
            return 0;
        }

        public IList<object> getListFromExcel(Excel.Range xlRange,int operation)
        {
            switch (operation)
            {
                case Constant.DB_GET_COLLEGE_ID:
                    return getCollegeId(xlRange);

                case Constant.DB_INSERT_STUDENT_DATA:
                    return getStudentData(xlRange);

                case Constant.DB_UPDATE_STUDENT_DATA:
                    return getScoreData(xlRange);
            }
            return null;
        }

        private IList<object> getCollegeId(Excel.Range xlRange)
        {
            if (xlRange != null)
            {
                if (xlRange.Columns.Count == Constant.DB_GET_COLLEGE_ID)
                {
                    var collegeIds = new List<Object>();
                    int rowCount = xlRange.Rows.Count;
                    int colCount = xlRange.Columns.Count;

                    for (int currRow = 3; currRow <= rowCount; currRow++)
                    {
                        for (int currCol = 1; currCol <= colCount; currCol++)
                        {
                            if (xlRange.Cells[currRow, currCol] != null &&
                                xlRange.Cells[currRow, currCol].Value2 != null &&
                                xlRange.Cells[currRow, currCol].Value2.ToString() != string.Empty)
                            {
                                string currValue = xlRange.Cells[currRow, currCol].Value2.ToString();
                                collegeIds.Add(new Entity_TempData(currValue));
                            }
                        }
                    }
                    return collegeIds;
                }
                return null;
            }
            return null;
        }

        private IList<object> getStudentData(Excel.Range xlRange)
        {
            if (xlRange != null)
            {
                if (xlRange.Columns.Count == Constant.DB_INSERT_STUDENT_DATA)
                {
                    int rowCount = xlRange.Rows.Count;
                    int colCount = xlRange.Columns.Count;

                    var studentList = new List<Object>();
                    var scoreList = new List<Object>();
                    var clusteredList = new List<Object>();

                    Entity_Student studentObj;
                    Entity_StudentScore scoreObj;
                    MyConfiguration myconfObj;

                    for (int currRow = 3; currRow <= rowCount; currRow++)
                    {
                        studentObj = new Entity_Student();
                        scoreObj = new Entity_StudentScore();
                        myconfObj = new MyConfiguration();

                        for (int currCol = 1; currCol <= colCount; currCol++)
                        {
                            if (xlRange.Cells[currRow, currCol] != null &&
                                xlRange.Cells[currRow, currCol].Value2 != null &&
                                xlRange.Cells[currRow, currCol].Value2.ToString() != string.Empty)
                            {
                                string currValue = xlRange.Cells[currRow, currCol].Value2.ToString();

                                switch (currCol)
                                {
                                    case 1:
                                        studentObj.collegeId = currValue;
                                        scoreObj.collegeId = studentObj.collegeId;
                                        break;
                                    case 2:
                                        studentObj.studentName = currValue;
                                        break;
                                    case 3:
                                        studentObj.gender = currValue;
                                        break;
                                    case 4:
                                        studentObj.branch = currValue;
                                        break;
                                    case 5:
                                        myconfObj.currentDegree = currValue;
                                        break;
                                    case 6:
                                        myconfObj.currentBatch = currValue;
                                        break;
                                    case 7:
                                        studentObj.phone = currValue;
                                        break;
                                    case 8:
                                        studentObj.email = currValue;
                                        break;
                                    case 9:
                                        scoreObj.X = Convert.ToDouble(currValue);
                                        break;
                                    case 10:
                                        scoreObj.XII = Convert.ToDouble(currValue);
                                        break;
                                    case 11:
                                        scoreObj.cgpa = Convert.ToDouble(currValue);
                                        break;
                                    case 12:
                                        scoreObj.diploma = Convert.ToDouble(currValue);
                                        break;
                                    case 13:
                                        scoreObj.arrears = Convert.ToInt16(currValue);
                                        break;
                                }
                            }
                        }
                        studentObj.myConfigObj = myconfObj;
                        studentList.Add(studentObj);
                        scoreList.Add(scoreObj);
                        studentObj = null;
                        scoreObj = null;
                        myconfObj = null;
                    }

                    clusteredList.Add(studentList);
                    clusteredList.Add(scoreList);
                    return clusteredList;
                }
                return null;
            }
            return null;
        }

        private IList<object> getScoreData(Excel.Range xlRange)
        {
            if (xlRange != null)
            {
                if (xlRange.Columns.Count == Constant.DB_UPDATE_STUDENT_DATA)
                {
                    int rowCount = xlRange.Rows.Count;
                    int colCount = xlRange.Columns.Count;

                    var updatedScoreList = new List<Object>();
                    Entity_UpdateScore updatedScoreObj;

                    for (int currRow = 3; currRow <= rowCount; currRow++)
                    {
                        updatedScoreObj = new Entity_UpdateScore();

                        for (int currCol = 1; currCol <= colCount; currCol++)
                        {
                            if (xlRange.Cells[currRow, currCol] != null &&
                                xlRange.Cells[currRow, currCol].Value2 != null &&
                                xlRange.Cells[currRow, currCol].Value2.ToString() != string.Empty)
                            {
                                string currValue = xlRange.Cells[currRow, currCol].Value2.ToString();

                                switch (currCol)
                                {
                                    case 1:
                                        updatedScoreObj.collegeId = currValue;
                                        break;
                                    case 2:
                                        updatedScoreObj.cgpa = Convert.ToDouble(currValue);
                                        break;
                                    case 3:
                                        updatedScoreObj.arrears = Convert.ToInt16(currValue);
                                        break;
                                }
                            }
                        }
                        updatedScoreList.Add(updatedScoreObj);
                        updatedScoreObj = null;
                    }
                    return updatedScoreList;
                }
                return null;
            }
            return null;
        }
    }
}
