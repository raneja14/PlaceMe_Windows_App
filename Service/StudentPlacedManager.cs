using System;
using System.Collections.Generic;
using Placement_Application.DTO;

namespace Placement_Application.Service
{
    interface StudentPlacedManager
    {
        int getHiredStudentsCount(long compId);

        bool savePlacementDetails(Entity_PlacementDetails placedDetailsObj);

        List<StudentPlacedDto> getPlacedStudents();

        List<StudentPlacedDto> getNonPlacedStudents();

        List<StudentPlacedDto> getPlacedStudentsBySearchKey(string searchKey);

        List<StudentPlacedDto> getNonPlacedStudentsBySearchKey(string searchKey);

        int uploadPlacementData(IList<Object> coll, long compId, DateTime DOR);
    }
}
