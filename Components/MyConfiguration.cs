namespace Placement_Application.Components
{
    public class MyConfiguration
    {
        public virtual string currentBatch { get; set; }
        public virtual string currentDegree { get; set; }

        public MyConfiguration()
        {
            this.currentBatch = Constant.NOT_APPLICABLE;
            this.currentDegree = Constant.NOT_APPLICABLE;
        }
    }
}
