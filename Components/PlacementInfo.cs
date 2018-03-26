using System;

namespace Placement_Application.Components
{
    [Serializable]
    public class PlacementInfo
    {
        public string companyName { get; set; }
        public string venue { get; set; }
        public DateTime DOR { get; set; }
        public string time { get; set; }
        public string message { get; set; }
    }
}
