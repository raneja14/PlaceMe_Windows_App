using System;
using System.Collections.Generic;
using Placement_Application.Components;

namespace Placement_Application
{
    public class Entity_CompanyDetails
    {
        public virtual long compDetailsId { get; set; }
        public virtual int status { get; set; }
        public virtual DateTime DOR { get; set; }
        public virtual int type { get; set; }
        public virtual string host { get; set; }
        public virtual long staffId { get; set; }
        public virtual Entity_Company companyObj { get; set; }
        public virtual MyConfiguration myConfigObj { get; set; }

        public override bool Equals(Object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            if (this == obj)
                return true;

            Entity_CompanyDetails compDetailsObj = obj as Entity_CompanyDetails;

            if (compDetailsObj.compDetailsId == 0)
            {
                return (this.myConfigObj.currentBatch.Equals(compDetailsObj.myConfigObj.currentBatch)
                    && this.myConfigObj.currentDegree.Equals(compDetailsObj.myConfigObj.currentDegree));
            }
         
            return this.compDetailsId.Equals(compDetailsObj.compDetailsId);
        }

        public override int GetHashCode()
        {
            int prime = 31;
            int result = 1;
            result = prime * result + companyObj.companyId.GetHashCode();
            return result;
        }
    }
}
