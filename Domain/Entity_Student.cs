using System;
using System.Collections.Generic;
using Placement_Application.Components;

namespace Placement_Application
{
    public class Entity_Student
    {
        public virtual long studentId { get; set; }
        public virtual string collegeId { get; set; }
        public virtual string studentName { get; set; }
        public virtual string gender { get; set; }
        public virtual string branch { get; set; }
        public virtual string email { get; set; }
        public virtual string phone { get; set; }
        public virtual Entity_StudentScore scoreObj { get; set; }
        public virtual ICollection<Entity_PlacementDetails> placedDetailsObj { get; set; }
        public virtual MyConfiguration myConfigObj { get; set; }

        public override bool Equals(Object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            if (this == obj)
                return true;

            Entity_Student studentObj = obj as Entity_Student;
            return studentId == studentObj.studentId;
        }


        public override int GetHashCode()
        {
            int prime = 31;
            int result = 1;
            result = prime * result + studentId.GetHashCode();
            return result;
        }

    }
}
