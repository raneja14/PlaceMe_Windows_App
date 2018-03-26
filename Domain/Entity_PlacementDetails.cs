using System;
using System.Collections.Generic;

namespace Placement_Application
{
    public class Entity_PlacementDetails
    {
        public virtual long detailsId { get; set; }
        public virtual long studentId { get; set; }
        public virtual long companyDetailsId { get; set; }
        public virtual DateTime DOR { get; set; }

        public virtual Entity_Student stuObj { get; set; }
        public virtual Entity_CompanyDetails compDetailsObj { get; set; }

        public Entity_PlacementDetails(){ }

        public Entity_PlacementDetails(long studentId,long compId,DateTime Dor)
        {
            this.studentId=studentId;
            this.companyDetailsId=compId;
            this.DOR = Dor;
        }
       
    }
}
