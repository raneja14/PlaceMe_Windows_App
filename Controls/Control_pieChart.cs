using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Placement_Application.DTO;
using Placement_Application.Commons;

namespace Placement_Application
{
    public partial class Control_pieChart : UserControl
    {
        private StatsDto dtoObj;

        public Control_pieChart(StatsDto dtoObj)
        {
            this.dtoObj = dtoObj;
            InitializeComponent();
        }

        private void Control_pieChart_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            box_slideOut.Visible = false;
            populate_pieChart();
            populate_doghnut();
        }

        private void populate_pieChart()
        {
            pieChart.Series["Overall_Series"].Points.AddXY(dtoObj.legend1, dtoObj.value1);
            pieChart.Series["Overall_Series"].Points.AddXY(dtoObj.legend2, dtoObj.value2);

            pieChart.Series["Overall_Series"].IsVisibleInLegend = true;
            pieChart.ChartAreas[0].InnerPlotPosition.Height = 70;
            pieChart.ChartAreas[0].InnerPlotPosition.Width = 70;
        }

        private void populate_doghnut()
        {
            IDictionary<string, int> resultMap = dtoObj.dataMap[0];

            if (resultMap != null)
            {
                foreach (KeyValuePair<string, int> entry in resultMap)
                {
                    doghnut.Series["Distribution_Series"].Points.AddXY(entry.Key, entry.Value);
                }
                doghnut.Series["Distribution_Series"].IsVisibleInLegend = true;
                doghnut.ChartAreas[0].InnerPlotPosition.Height = 85;
                doghnut.ChartAreas[0].InnerPlotPosition.Width = 85;

                doghnut.Series["Distribution_Series"]["PieLabelStyle"] = "Outside";
            }
            else
            {
                doghnut.Hide();
                label1.Visible = true;
                label1.Text = Labels.NO_PLACEMENTS;
                box_slideIn.Hide();
            }
        }

        private void timer_slide_Tick(object sender, EventArgs e)
        {
            if (panel_left.Size.Width < 30)
            {
                timer_slideIn.Enabled = false;
                box_slideOut.Visible = true;
            }
            else
            {
                panel_left.Width -= 15;
                panel_right.Width += 15;
            }
        }
       
        private void timer_slideOut_Tick(object sender, EventArgs e)
        {
            if (panel_right.Size.Width < 471)
            {
                timer_slideOut.Enabled = false;
                box_slideOut.Hide();
            }
            else
            {
                panel_right.Width -= 15;
                panel_left.Width += 15;
            }
        }

        private void box_slideIn_Click(object sender, EventArgs e)
        {
            timer_slideIn.Enabled=true;
        }

        private void box_slideOut_Click(object sender, EventArgs e)
        {
            timer_slideOut.Enabled = true;
        }

     
    }
}
