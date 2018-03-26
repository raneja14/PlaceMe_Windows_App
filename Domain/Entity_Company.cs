using System.Collections.Generic;

namespace Placement_Application
{
    public class Entity_Company
    {
        public virtual long companyId { get; set; }
        public virtual string companyName { get; set; }
        public virtual ICollection<Entity_CompanyDetails> compDetailsObjList { get; set; }

        public virtual bool addCompDetailsObj(Entity_CompanyDetails compDetailsObj)
        {
            compDetailsObj.companyObj = this;
            if (compDetailsObjList == null)
                compDetailsObjList = new List<Entity_CompanyDetails>();

            int size = this.compDetailsObjList.Count;
            compDetailsObjList.Add(compDetailsObj);

            return (size==compDetailsObjList.Count);
        }

        // override object.Equals
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        // override object.GetHashCode
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
