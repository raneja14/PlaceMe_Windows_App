using System;
using System.Collections.Generic;

namespace Placement_Application
{
    public class Entity_StudentScore
    {
        public virtual long studentId { get; set; }
        public virtual string collegeId { get; set; }
        public virtual double X { get; set; }
        public virtual double XII { get; set; }
        public virtual double diploma { get; set; }
        public virtual double cgpa { get; set; }
        public virtual int arrears { get; set; }

        public Entity_StudentScore()
        {
            this.studentId = 9999999999;
        }
    }
}
