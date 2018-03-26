using System;
using System.Collections.Generic;
using Placement_Application.Components;
using Placement_Application.Commons;

namespace Placement_Application
{
    public class Entity_Staff
    {
        public virtual long staffId { get; set; }
        public virtual string staffName { get; set; }
        public virtual string password { get; set; }
        public virtual string email { get; set; }
        public virtual string phone { get; set; }
        public virtual MyConfiguration myConfigObj { get; set; }
        public virtual DateTime createdOn { get; set; }
        public virtual DateTime lastModifiedOn { get; set; }
        public virtual bool isAccountActive { get; set; }

        public Entity_Staff()
        {
            this.createdOn = DateTime.Now;
            this.lastModifiedOn = this.createdOn;
            this.isAccountActive = true;
            this.myConfigObj = new MyConfiguration();
        }

        public override bool Equals(Object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false; 

            if (this == obj)
                return true;
           
          
            Entity_Staff staffObj = obj as Entity_Staff;
            return staffName == staffObj.staffName 
                && email == staffObj.email
                && phone == staffObj.phone;
        }

        public override int GetHashCode()
        {
            int prime = 31;
            int result = 1;
            result = prime * result + staffId.GetHashCode();
            return result;
        }

    }
}
