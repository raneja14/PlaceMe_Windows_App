namespace Placement_Application
{
    public class Entity_TempData
    {
        public Entity_TempData() { }
        public Entity_TempData(string collgId)
        {
            this.collegeId = collgId;
            this.studentId = 0;
        }

        public virtual long studentId { get; set; }
        public virtual string collegeId { get; set; }
    }
}
