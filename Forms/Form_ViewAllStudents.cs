using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Placement_Application.Commons;
using Placement_Application.Service;
using Placement_Application.DTO;

namespace Placement_Application
{
    public partial class Form_ViewAllStudents : Form
    {
        private Form_Home homeform;
        private StudentPlacedManager placedDetailsManager;
        private ToolTip tooltip;
        private bool isListPlacedLoaded;
        private bool isListNonPlacedLoaded;
        private List<StudentPlacedDto> placedList;
        private List<StudentPlacedDto> nonPlacedList;
        private DIalog_ProgressBar myProgressDialog;
     
        public Form_ViewAllStudents(Form_Home homeform)
        {
            this.homeform = homeform;
            InitializeComponent();
        }

        private void Form_ViewAllStudents_Load(object sender, EventArgs e)
        {
            Placement_Application.Components.Resolution res = new Placement_Application.Components.Resolution();
            res.ResizeForm(this, Common.form_height, Common.form_width);

            this.label_top_batch.Text = Utility.getConfigLabel();
            timer1.Start();
            timer1.Interval = 1000;
            tooltip = new ToolTip();

            isListPlacedLoaded = false;
            isListNonPlacedLoaded = false;

            prepareListPlaced();
            prepareListNonPlaced();
            placedDetailsManager = new StudentPlacedManagerImpl();

            startBackgroundThread(true);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label_time.Text = DateTime.Now.ToString(Constant.TIME_FORMAT);
            label_date.Text = DateTime.Now.ToString(Constant.DATE_FORMAT);
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

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            textBox_search.Text = string.Empty;
            tabView.SelectedIndex = 0;
        }

        private void tabView_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_search.Text = ".";
            textBox_search.Text = string.Empty;
            textBox_search.Focus();
        }

        private void getPlacedList()
        {
            if (!isListPlacedLoaded)
            {
                placedList = placedDetailsManager.getPlacedStudents();
            }
        }

        private void getNonPlacedList()
        {
            if (!isListNonPlacedLoaded)
            {
                nonPlacedList = placedDetailsManager.getNonPlacedStudents();
            }
        }

        private void prepareListPlaced()
        {
            listView_placed.GridLines = true;
            listView_placed.View = View.Details;

            listView_placed.Columns.Add(EnumData.StudentsListHeadings.COLLEGE_ID.ToString(), 90);
            listView_placed.Columns.Add(EnumData.StudentsListHeadings.NAME.ToString(), 130);
            listView_placed.Columns.Add(EnumData.StudentsListHeadings.GENDER.ToString(), 70);
            listView_placed.Columns.Add(EnumData.StudentsListHeadings.BRANCH.ToString(), 100);
            listView_placed.Columns.Add(EnumData.StudentsListHeadings.DEGREE.ToString(), 80);
            listView_placed.Columns.Add(EnumData.StudentsListHeadings.CONTACT.ToString(), 90);
            listView_placed.Columns.Add(EnumData.StudentsListHeadings.PLACED_IN.ToString(), 140);
            listView_placed.Columns.Add(EnumData.StudentsListHeadings.TYPE.ToString(), 140);
            listView_placed.Columns.Add(EnumData.StudentsListHeadings.DOR.ToString(), 100);

            Utility.allocateEqualColumnWidth(listView_placed);
        }

        private void prepareListNonPlaced()
        {
            listView_nonPlaced.GridLines = true;
            listView_nonPlaced.View = View.Details;

            listView_nonPlaced.Columns.Add(EnumData.StudentsListHeadings.COLLEGE_ID.ToString(), 100);
            listView_nonPlaced.Columns.Add(EnumData.StudentsListHeadings.NAME.ToString(), 170);
            listView_nonPlaced.Columns.Add(EnumData.StudentsListHeadings.GENDER.ToString(), 100);
            listView_nonPlaced.Columns.Add(EnumData.StudentsListHeadings.BRANCH.ToString(), 130);
            listView_nonPlaced.Columns.Add(EnumData.StudentsListHeadings.DEGREE.ToString(), 100);
            listView_nonPlaced.Columns.Add(EnumData.StudentsListHeadings.CONTACT.ToString(), 120);

            Utility.allocateEqualColumnWidth(listView_nonPlaced);
        }

        private void populateListPlaced(List<StudentPlacedDto> detailList)
        {
            var detailSet = new HashSet<StudentPlacedDto>();
            isListPlacedLoaded = true;

            if (detailList != null && detailList.Count > 0)
            {
                listView_placed.SuspendLayout();
                listView_placed.Items.Clear();
                ListViewItem lv = null;
                var placedsSudentIds = new AutoCompleteStringCollection();
                foreach (StudentPlacedDto dtoObj in detailList)
                {
                    lv = new ListViewItem(dtoObj.collegeId);
                    lv.SubItems.Add(dtoObj.name);
                    lv.SubItems.Add(dtoObj.gender);
                    lv.SubItems.Add(dtoObj.branch);
                    lv.SubItems.Add(dtoObj.degree);
                    lv.SubItems.Add(dtoObj.contact);
                    lv.SubItems.Add(dtoObj.company);
                    lv.SubItems.Add(Utility.getEnumValueByIndex(Constant.ENUM_COMPANY_TYPE, dtoObj.companyType));
                    lv.SubItems.Add(Utility.convertDateToString(dtoObj.dor));

                    lv.Tag = dtoObj;
                    listView_placed.Items.Add(lv);
                    detailSet.Add(dtoObj);
                    placedsSudentIds.Add(dtoObj.collegeId);
                }
                listView_placed.ResumeLayout();
                textBox_search.AutoCompleteCustomSource = placedsSudentIds;
                Utility.showToolTip(tooltip, label_tool1, detailSet.Count + Labels.STUDENTS,Constant.TOOLTIP_TYPE_INFO,Constant.TOOLTIP_FOUND);
            }
            else
            {
                listView_placed.Items.Clear();
                Utility.showToolTip(tooltip, label_tool1, 0 + Labels.STUDENTS, Constant.TOOLTIP_TYPE_INFO, Constant.TOOLTIP_FOUND);
            }
        }

        private void populateListNonPlaced(List<StudentPlacedDto> detailList)
        {
            isListNonPlacedLoaded = true;
            if (detailList != null && detailList.Count > 0)
            {
                listView_nonPlaced.SuspendLayout();
                listView_nonPlaced.Items.Clear();
                ListViewItem lv = null;
                AutoCompleteStringCollection nonPlacedsSudentIds = new AutoCompleteStringCollection();
                foreach (StudentPlacedDto dtoObj in detailList)
                {
                    lv = new ListViewItem(dtoObj.collegeId);
                    lv.SubItems.Add(dtoObj.name);
                    lv.SubItems.Add(dtoObj.gender);
                    lv.SubItems.Add(dtoObj.branch);
                    lv.SubItems.Add(dtoObj.degree);
                    lv.SubItems.Add(dtoObj.contact);

                    lv.Tag = dtoObj;
                    listView_nonPlaced.Items.Add(lv);
                    nonPlacedsSudentIds.Add(dtoObj.collegeId);
                }
                listView_nonPlaced.ResumeLayout();
                textBox_search.AutoCompleteCustomSource = nonPlacedsSudentIds;
                Utility.showToolTip(tooltip, label_tool2, detailList.Count + Labels.STUDENTS, Constant.TOOLTIP_TYPE_INFO, Constant.TOOLTIP_FOUND);
            }
            else
            {
                listView_nonPlaced.Items.Clear();
                Utility.showToolTip(tooltip, label_tool2, 0 + Labels.STUDENTS, Constant.TOOLTIP_TYPE_INFO, Constant.TOOLTIP_FOUND);
            }
        }
        
        private void panel_top_MouseMove(object sender, MouseEventArgs e)
        {
            Utility.dragForm(e, Handle);
        }

        private void searchDetails()
        {
            if (!Utility.isNetworkAvailable())
            {
                Dialog_MyMessageBox.Show(Validations.VALIDATION_NO_NETWORK, 1, UiColors.MESSAGE_ERROR);
            }
            else
            {
                string searchKey = textBox_search.Text.Trim();
                if (searchKey.Length > 0)
                {
                    List<StudentPlacedDto> detailList;
                    switch (tabView.SelectedIndex)
                    {
                        case 0:
                            detailList = placedDetailsManager.getPlacedStudentsBySearchKey(searchKey);
                            populateListPlaced(detailList);
                            break;
                        case 1:
                            detailList = placedDetailsManager.getNonPlacedStudentsBySearchKey(searchKey);
                            populateListNonPlaced(detailList);
                            break;
                    }
                }
            }
        }
        
        private void button_search_Click(object sender, EventArgs e)
        {
            searchDetails();
        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_search.Text))
            {
                switch (tabView.SelectedIndex)
                {
                    case 0:
                        populateListPlaced(placedList);
                        break;
                    case 1:
                        populateListNonPlaced(nonPlacedList);
                        break;
                }
            }
        }

        private void textBox_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData.ToString().Equals("Return"))
            {
                searchDetails();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                getPlacedList();
                getNonPlacedList();
                e.Result = true;
            }
            catch (Exception ex)
            {
                Utility.logFile("formViewAll bakground thread: " + ex, ex.InnerException, Constant.LOGTYPE_ERROR);
                e.Result = false;
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Opacity = 1;
            myProgressDialog.Dispose(); ;

            if ((bool)e.Result)
                populateListPlaced(placedList);
            else
                Dialog_MyMessageBox.Show(Constant.REQUEST_UNPROCESSED, 1, UiColors.MESSAGE_ERROR);
            pictureBox_home.Enabled = true;
        }

        private void startBackgroundThread(bool dialogRequired)
        {
            if (!backgroundWorker1.IsBusy)
            {
                if (dialogRequired)
                {
                    myProgressDialog = new DIalog_ProgressBar();
                    this.Opacity = 0.8;
                    pictureBox_home.Enabled = false;
                    myProgressDialog.Show();
                }
                backgroundWorker1.RunWorkerAsync();
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.E))
            {
                DialogResult result = Dialog_MyMessageBox.Show(Constant.MESSAGE_EXCEL_EXPORT, 2);
                if (result == DialogResult.Yes)
                {
                    switch (tabView.SelectedIndex)
                    {
                        case 0:
                            Utility.exportToExcel(listView_placed,homeform);
                            break;
                        case 1:
                            Utility.exportToExcel(listView_nonPlaced,homeform);
                            break;
                    }
                    return true;
                }
            }
            else if (keyData == (Keys.Control | Keys.P))
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
            else if (keyData == (Keys.Control | Keys.R))
            {
                pictureBox5_Click(this.pictureBox_refresh, null);
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
