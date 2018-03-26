using Placement_Application.Commons;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Placement_Application.Service;

namespace Placement_Application
{
    public partial class Form_UpdatePlacementStatus : Form
    {
        private Form_Home homeform;
        private ListControl_PlacementStatus listupdateView;
        private StudentManager studentManager;
        private List<Entity_Student> studentList;
        private List<Entity_Student> studentListCopy;
        private DIalog_ProgressBar myProgressDialog;
        public bool placementStatusUpdated = false;

        public Form_UpdatePlacementStatus(Form_Home homeform)
        {
            this.homeform = homeform;
            studentManager = new StudentManagerImpl();
            InitializeComponent();
        }

        private void UpdatePlacementStatusForm_Load(object sender, EventArgs e)
        {
            Placement_Application.Components.Resolution res = new Placement_Application.Components.Resolution();
            res.ResizeForm(this, Common.form_height, Common.form_width);
            this.label_top_batch.Text = Utility.getConfigLabel();
            timer1.Start();
            timer1.Interval = 1000;

            startBackgroundThread(true);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            textBox_search.Text = string.Empty;
            panel_search.Visible = true;
            startBackgroundThread(true);
            textBox_search.Focus();
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

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            panel_search.Hide();
            panel_main.Controls.Clear();
            Control_DropFile dropFile = new Control_DropFile(this);
            dropFile.Dock = DockStyle.Fill;
            panel_main.Controls.Add(dropFile);
        }

        private void panel_top_MouseMove(object sender, MouseEventArgs e)
        {
            Utility.dragForm(e, Handle);
        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            Utility.dragForm(e, Handle);
        }

        private void viewAllStudents()
        {
            if (studentList == null || placementStatusUpdated)
            {
                studentList = studentManager.loadAllStudentsWithDetails();
                studentListCopy = studentList;
                placementStatusUpdated = false;
            }
      //      listupdateView = new ListControl_PlacementStatus(this, studentListCopy);
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            searchDetails();
        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_search.Text))
            {
                startBackgroundThread(false);// viewAllStudents();
            }
        }

        private void textBox_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData.ToString().Equals("Return"))
            {
                searchDetails();
            }
        }

        private void searchDetails()
        {
            if (!Utility.isNetworkAvailable())
            {
                Dialog_MyMessageBox.Show(Validations.VALIDATION_NO_NETWORK, 1, UiColors.MESSAGE_ERROR);
            }
            else
            {
                string searchKey = textBox_search.Text;
                if (!string.IsNullOrWhiteSpace(searchKey))
                {
                    studentList = studentManager.loadStudentDetailsBySearchKey(searchKey);
                    listupdateView = new ListControl_PlacementStatus(this, studentList);

                    panel_main.Controls.Clear();
                    panel_main.Controls.Add(listupdateView);
                }
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                viewAllStudents();
                e.Result = true;
            }
            catch (Exception ex)
            {
                Utility.logFile(ex.Message, ex.InnerException, Constant.LOGTYPE_ERROR);
                e.Result = false;
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Opacity = 1;
            myProgressDialog.Dispose();
            if ((bool)e.Result)
            {
                listupdateView = new ListControl_PlacementStatus(this, studentListCopy);
                panel_main.Controls.Clear();
                panel_main.Controls.Add(listupdateView);
            }
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
                    Utility.exportToExcel(listupdateView.listView1,homeform);
                return true;
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
            else if (keyData == (Keys.Control | Keys.I))
            {
                pictureBox8_Click(this.pictureBox_excel, null);
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

    }
}
