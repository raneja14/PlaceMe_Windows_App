using System;
using System.Collections.Generic;

namespace Placement_Application.Components
{
    [Serializable]
    public class MyCriteria
    {
        public string batch { get; set; }
        public string degree { get; set; }
        public double cgpa { get; set; }
        public int arrears { get; set; }
        public double X { get; set; }
        public double XII { get; set; }
        public bool isPlaced { get; set; }
        public bool isDiplomaAllowed { get; set; }
        public List<String> branch { get; set; }
        public int eligibleCount { get; set; }
    }
}
