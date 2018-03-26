using System.Collections.Generic;
using Placement_Application.Commons;

namespace Placement_Application.DTO
{
    public class StatsDto
    {
        public StatsDto()
        {
            this.legend1 = Labels.BAR_COMPANY_CONFIRMED;
            this.legend2 = Labels.BAR_STUDENT_PLACED;
            this.initialiseStatsDto();
        }
        
        public StatsDto(string identifier)
        {
            if (identifier == Constant.IDENTIFIER_STUDENT)
            {
                this.legend1 = Labels.PLACED;
                this.legend2 = Labels.NON_PLACED;
            }
            else
            {
                this.legend1 = EnumData.companyStatus.CONFIRMED.ToString();
                this.legend2 = EnumData.companyStatus.UPCOMING.ToString();
            }
            this.initialiseStatsDto();
        }

        private void initialiseStatsDto()
        {
            this.value1 = 0;
            this.value2 = 0;
            this.dataMap = new List<IDictionary<string, int>>();
        }
    
        public string legend1 { get; set; }
        public string legend2 { get; set; }
        public int value1 { get; set; }
        public int value2 { get; set; }
        public IList<IDictionary<string, int>> dataMap { get; set; }

    }
}
