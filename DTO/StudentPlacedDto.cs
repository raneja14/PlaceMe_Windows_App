using System;

namespace Placement_Application.DTO
{
   public  class StudentPlacedDto
    {
       public virtual long detailsId { get; set; }
       public virtual string collegeId { get; set; }
       public virtual string name { get; set; }
       public virtual string gender { get; set; }
       public virtual string branch { get; set; }
       public virtual string degree { get; set; }
       public virtual string contact { get; set; }
       public virtual string company { get; set; }
       public virtual int companyType { get; set; }
       public virtual DateTime dor { get; set; }

       // override object.Equals
       public override bool Equals(object obj)
       {
           if (obj == null || GetType() != obj.GetType())
               return false;

           if (this == obj)
               return true;
            
           StudentPlacedDto dtoObj = obj as StudentPlacedDto;
           return name == dtoObj.name;
       }

       // override object.GetHashCode
       public override int GetHashCode()
       {
           int prime = 31;
           int result = 1;
           result = prime * result + name.GetHashCode();
           return result;
       }

    }
}
