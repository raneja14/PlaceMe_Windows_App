using Placement_Application.Commons;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Placement_Application.DTO;
using Placement_Application.Service;

namespace Placement_Application
{
    public partial class Form_Statistics : Form
    {
        private Form_Home homeform;
        private StatisticsManager statsManager;
        private StatsDto piechartStudentDto;
        private StatsDto piechartCompanyDto;
        private StatsDto barMonthDto;
        private StatsDto barYearDto;
        private DIalog_ProgressBar myProgressDialog;
       
        public Form_Statistics(Form_Home homeform)
        {
            this.homeform = homeform;
            InitializeComponent();
        }

        private void Form_Statistics_Load(object sender, EventArgs e)
        {
            Placement_Application.Components.Resolution res = new Placement_Application.Components.Resolution();
            res.ResizeForm(this, Common.form_height, Common.form_width);
            this.label_top_batch.Text = Utility.getConfigLabel();
        
            timer1.Start();
            timer1.Interval = 1000;

            startBackgroundThread(true);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult result = Dialog_MyMessageBox.Show(Constant.MESSAGE_EXIT, 2);

            if (result == DialogResult.Yes)
                Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            homeform.Show();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label_time.Text = DateTime.Now.ToString(Constant.TIME_FORMAT);
            label_date.Text = DateTime.Now.ToString(Constant.DATE_FORMAT);
        }

        private void panel_top_MouseMove(object sender, MouseEventArgs e)
        {
            Utility.dragForm(e, Handle);
        }

        private void but_student_stats_Click(object sender, EventArgs e)
        {
            loadPiechart(piechartStudentDto);
        }

        private void but_comp_stats_Click(object sender, EventArgs e)
        { 
            loadPiechart(piechartCompanyDto);
        }

        private void but_monthly_stats_Click(object sender, EventArgs e)
        {
              loadBarGraph(barMonthDto);
        }

        private void but_yearly_stats_Click(object sender, EventArgs e)
        {
             loadBarGraph(barYearDto);
        }

        private void loadPiechart(StatsDto dtoObj)
        {
            panel_main.Controls.Clear();
            Control_pieChart pieChart = new Control_pieChart(dtoObj);
            pieChart.Dock = DockStyle.Fill;
            panel_main.Controls.Add(pieChart);
        }

        private void loadBarGraph(StatsDto dtoObj)
        {
            panel_main.Controls.Clear();
            Control_barGraph barGraph = new Control_barGraph(dtoObj);
            barGraph.Dock = DockStyle.Fill;
            panel_main.Controls.Add(barGraph);
        }

        private void loadAllDto()
        {
            if (piechartStudentDto == null)
            {
                piechartStudentDto = new StatsDto(Constant.IDENTIFIER_STUDENT);

                piechartStudentDto.value1 = statsManager.getPlacedStudentCount();
                piechartStudentDto.value2 = statsManager.getNonPlacedStudentCount();

                var dataMapList = new List<IDictionary<string, int>>();
                piechartStudentDto.dataMap.Add(statsManager.getStudentBranchData());
            }

            if (piechartCompanyDto == null)
            {
                piechartCompanyDto = new StatsDto(Constant.IDENTIFIER_COMPANY);

                var compStatList = statsManager.getCompanyStatCount();
                if (compStatList != null)
                {
                    foreach (Object[] objArr in compStatList)
                    {
                        if (EnumData.companyStatus.CONFIRMED.ToString() ==
                            Utility.getEnumValueByIndex(Constant.ENUM_COMPANY_STATUS, Convert.ToInt16(objArr[1])))
                        {
                            piechartCompanyDto.value1 = Convert.ToInt32(objArr[0]);
                        }
                        else
                        {
                            piechartCompanyDto.value2 = Convert.ToInt32(objArr[0]);
                        }
                    }
                }
                piechartCompanyDto.dataMap.Add(statsManager.getStudentCompanyData());
            }

            if (barMonthDto == null)
            {
                barMonthDto = new StatsDto();
                barMonthDto.dataMap.Add(statsManager.getMonthlyCompanyMap());
                barMonthDto.dataMap.Add(statsManager.getMonthlyStudentMap());
            }

            if (barYearDto == null)
            {
                barYearDto = new StatsDto();
                barYearDto.dataMap.Add(statsManager.getYearlyCompanyMap());
                barYearDto.dataMap.Add(statsManager.getYearlyStudentMap());
            }

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                loadAllDto();
                e.Result = true;
            }
            catch (Exception ex)
            {
                Utility.logFile(ex.Message, ex.InnerException, Constant.LOGTYPE_ERROR);
                e.Result = false;
                throw;
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Opacity = 1;
            myProgressDialog.Dispose();
            if ((bool)e.Result)
                loadPiechart(piechartStudentDto);
            else
                Dialog_MyMessageBox.Show(Constant.REQUEST_UNPROCESSED, 1, UiColors.MESSAGE_ERROR);
        }

        private void startBackgroundThread(bool dialogRequired)
        {
            if (!backgroundWorker1.IsBusy)
            {
                if (dialogRequired)
                {
                    myProgressDialog = new DIalog_ProgressBar();
                    this.Opacity = 0.8;
                    myProgressDialog.Show();
                }
                statsManager = new StatisticsManagerImpl();
                backgroundWorker1.RunWorkerAsync();
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.P))
            {
                pictureBox1_Click(this.pictureBox_power, null);
            }
            else if (keyData == (Keys.Control | Keys.M))
            {
                pictureBox2_Click(this.pictureBox_minimise, null);
            }
            else if (keyData == (Keys.Control | Keys.H))
            {
                pictureBox4_Click(this.pictureBox_home, null);
            }
           
            return base.ProcessCmdKey(ref msg, keyData);
        }

    }
}
