using Placement_Application.DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Placement_Application
{
    public partial class Control_barGraph : UserControl
    {
        private StatsDto dtoObj;

        public Control_barGraph(StatsDto dtoObj)
        {
            this.dtoObj = dtoObj;
            InitializeComponent();
        }

        private void Control_barGraph_Load(object sender, EventArgs e)
        {
            populateBarGraph_Companies();
            populateBarGraph_Students();
        }

        private void populateBarGraph_Companies()
        {
            IDictionary<string, int> compMap = dtoObj.dataMap[0];

            if (compMap != null)
            {
                barGraph_overall.Series["Companies Visited"].Points.Clear();
                barGraph_overall.Series["Companies Visited"].LegendText = dtoObj.legend1;

                foreach (KeyValuePair<string, int> entry in compMap)
                {
                    barGraph_overall.Series["Companies Visited"].Points.AddXY(entry.Key, entry.Value);
                }
            }
            barGraph_overall.Series["Companies Visited"].IsVisibleInLegend = true;

        }

        private void populateBarGraph_Students()
        {
            IDictionary<string, int> studentMap = dtoObj.dataMap[1];

            if (studentMap != null)
            {
                barGraph_overall.Series["Students Placed"].Points.Clear();
                barGraph_overall.Series["Students Placed"].LegendText = dtoObj.legend2;

                foreach (KeyValuePair<string, int> entry in studentMap)
                {
                    barGraph_overall.Series["Students Placed"].Points.AddXY(entry.Key, entry.Value);
                }
            }
            barGraph_overall.Series["Students Placed"].IsVisibleInLegend = true;
        }
    }
}
