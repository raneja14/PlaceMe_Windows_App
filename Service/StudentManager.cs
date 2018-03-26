using System.Collections.Generic;

namespace Placement_Application.Service
{
    interface StudentManager
    {
        List<Entity_Student> loadAllStudentsWithDetails();

        List<Entity_Student> loadStudentDetailsBySearchKey(string searchKey);

        IDictionary<string, IList<string>> getDegreeWithBatch();

        List<Entity_Student> loadAllStudents();



    }
}
