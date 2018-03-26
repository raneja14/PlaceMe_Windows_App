using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Placement_Application.Service;
using Placement_Application.Commons;

namespace Placement_Application
{
    public partial class Form_ViewCompanies : Form
    {
        private Form_Home homeform;
        private CompanyManager compManager;
        private List<Entity_CompanyDetails> compDetailList;
        private ListControl_CompanyView listCompView;
        private DIalog_ProgressBar myProgressDialog;
        public bool fistLoad;
        public bool performDelete;
        public IDictionary<string, Entity_CompanyDetails> compMap;

        public Form_ViewCompanies(Form_Home homeform)
        {
            this.homeform = homeform;
            InitializeComponent();
        }

        private void ViewCompaniesForm_Load(object sender, EventArgs e)
        {
            Placement_Application.Components.Resolution res = new Placement_Application.Components.Resolution();
            res.ResizeForm(this, Common.form_height, Common.form_width);
            this.label_top_batch.Text = Utility.getConfigLabel();

            timer1.Start();
            timer1.Interval = 1000;
            compMap = new Dictionary<string, Entity_CompanyDetails>();
            startBackgroundThread(true, 0);
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

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            textBox_search.Text = string.Empty;
            panel_search.Visible = true;
            fistLoad = true;
            startBackgroundThread(true, 0);
            showTopIcons();
            textBox_search.Focus();
        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            Utility.dragForm(e, Handle);
        }

        private void panel_top_MouseMove(object sender, MouseEventArgs e)
        {
            Utility.dragForm(e, Handle);
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            viewSearchedCompany();
        }

        private void viewAllCompanies()
        {
            if (compDetailList == null)
            {
                compDetailList = compManager.loadAllCompanies();
                fistLoad = true;
            }
        }

        private void viewSearchedCompany()
        {
            string searchKey = textBox_search.Text;
            if (!string.IsNullOrWhiteSpace(searchKey))
            {
                List<Entity_CompanyDetails> tempList = null;
                if (compMap.ContainsKey(searchKey))
                    tempList = new List<Entity_CompanyDetails> { compMap[searchKey] };

                listCompView = new ListControl_CompanyView(this, tempList);
                //          compManager.getCompanyBySearchKey(searchKey));
                panel_main.Controls.Clear();
                panel_main.Controls.Add(listCompView);

            }
        }

        private void textBox_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData.ToString().Equals("Return"))
            {
                viewSearchedCompany();
            }
        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_search.Text))
                startBackgroundThread(false, 0);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                viewAllCompanies();
                e.Result = true;
            }
            catch (Exception ex)
            {
                Utility.logFile("Form_viewCOmpanies(viewAllCompanies) => " + ex.Message, ex.InnerException, Constant.LOGTYPE_ERROR);
                e.Result = false;
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Opacity = 1;
            myProgressDialog.Dispose();
            if ((bool)e.Result)
            {
                listCompView = new ListControl_CompanyView(this, compDetailList);
                panel_main.Controls.Add(listCompView);
                fistLoad = false;
            }
            else
                Dialog_MyMessageBox.Show(Constant.REQUEST_UNPROCESSED, 1, UiColors.MESSAGE_ERROR);
        }

        private void startBackgroundThread(bool dialogRequired, int mode)
        {
            if (compManager == null)
                compManager = new CompanyManagerImpl();

            switch (mode)
            {
                case 0:
                    if (!backgroundWorker1.IsBusy)
                    {
                        if (dialogRequired)
                        {
                            myProgressDialog = new DIalog_ProgressBar();
                            this.Opacity = 0.8;
                            myProgressDialog.Show();
                        }
                        panel_main.Controls.Clear();
                        backgroundWorker1.RunWorkerAsync();
                    }
                    break;
                case 1:
                    if (!backgroundWorker2.IsBusy)
                    {
                        Dialog_MyMessageBox.Show(Constant.NOTIFICATION_NOTIFY_SUCCESS, 1);
                        backgroundWorker2.RunWorkerAsync();
                    }
                    else
                    {
                        Dialog_MyMessageBox.Show(Constant.REQUEST_UNDER_PROCESS, 1, UiColors.MESSAGE_ERROR);
                    }
                    break;
            }
        }

        private void pictureBox_notifyCompany_Click(object sender, EventArgs e)
        {
            DialogResult result = Dialog_MyMessageBox.Show(Constant.NOTIFICATION_CONFIRM_CONTINUE_NOTIFY, 2);
            if (result == DialogResult.Yes)
            {
                startBackgroundThread(false, 1);
            }

        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            if (compDetailList != null && compDetailList.Count > 0)
            {
                string message = compManager.getCompaniesForNotification(compDetailList);
                if (message == string.Empty)
                    e.Result = 0;
                else
                {
                    StudentManager stuManager = new StudentManagerImpl();
                    var studentList = stuManager.loadAllStudents();
                    if (studentList != null || studentList.Count > 0)
                    {
                        NotificationManager notifyManager = new NotificationManagerImpl();
                        if (notifyManager.notifyStudents(studentList, message))
                            e.Result = 1;
                        else
                            e.Result = 3;
                    }
                    else
                        e.Result = 2;
                }
            }
            else
                e.Result = 0;
        }

        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            switch (Convert.ToInt16(e.Result))
            {
                case 0:
                    Dialog_MyMessageBox.Show(Constant.NO_COMPANY_TO_NOTIFY, 1, UiColors.MESSAGE_ERROR);
                    break;
                case 1:
                    Dialog_MyMessageBox.Show(Constant.NOTIFICATION_NOTIFIED_SUCCESS, 1, UiColors.MESSAGE_SUCCESS);
                    break;
                case 2:
                    Dialog_MyMessageBox.Show(Constant.NO_STUDENT_TO_NOTIFY, 1, UiColors.MESSAGE_ERROR);
                    break;
                case 3:
                    Dialog_MyMessageBox.Show(Constant.NOTIFY_GLITCH, 1, UiColors.MESSAGE_ERROR);
                    break;
            }
        }

        private void pic_delete_Click(object sender, EventArgs e)
        {
            if (!Utility.isNetworkAvailable())
            {
                Dialog_MyMessageBox.Show(Validations.VALIDATION_NO_NETWORK, 1, UiColors.MESSAGE_ERROR);
            }
            else
            {
                if (performDelete)
                {
                    if (listCompView.listView1.CheckedItems.Count == 0)
                        Dialog_MyMessageBox.Show(Validations.NO_BOX_CHECKED, 1, UiColors.MESSAGE_ERROR);
                    else
                    {
                        DialogResult result = Dialog_MyMessageBox.Show(Constant.CONFIRM_COMPANY_DELETE, 2);
                        if (result == DialogResult.Yes)
                        {
                            deleteCompanies();
                        }
                    }
                }
                else
                {
                    if (compDetailList != null && compDetailList.Count > 0)
                    {
                        hideTopIcons();
                        displayUpcomingCompanies();
                        listCompView.listView1.CheckBoxes = true;
                    }
                    else
                        Dialog_MyMessageBox.Show(Constant.MESSAGE_NO_DATA, 1, UiColors.MESSAGE_ERROR);
                }
            }
        }

        private void hideTopIcons()
        {
            pic_delete.Image = Properties.Resources.DeleteCross;
            pictureBox_home.Visible = false;
            pictureBox_minimise.Visible = false;
            pictureBox_power.Visible = false;
            pictureBox_notifyCompany.Visible = false;
            performDelete = true;
            panel_search.Hide();
        }

        private void showTopIcons()
        {
            pic_delete.Image = Properties.Resources.deleteBin;
            pictureBox_home.Visible = true;
            pictureBox_minimise.Visible = true;
            pictureBox_power.Visible = true;
           // pictureBox_notifyCompany.Visible = true;
            performDelete = false;
            panel_search.Visible = true;
        }

        private void displayUpcomingCompanies()
        {
            var upcomingCompanies = new List<Entity_CompanyDetails>();
            foreach (var compObj in compDetailList)
            {
                if (compObj.DOR >= DateTime.Now.Date &&
                   (Common.loggedUser.staffId == compObj.staffId || Common.loggedUser.staffId == Common.adminId))
                    upcomingCompanies.Add(compObj);
            }
            listCompView = new ListControl_CompanyView(this, upcomingCompanies);
            panel_main.Controls.Clear();
            panel_main.Controls.Add(listCompView);
        }

        private void deleteCompanies()
        {
            if (compManager.deleteCompanies(listCompView.listView1))
            {
                foreach (var checkedItem in listCompView.listView1.CheckedItems)
                {
                    compDetailList.Remove(((ListViewItem)checkedItem).Tag as Entity_CompanyDetails);
                    listCompView.listView1.Items.Remove(checkedItem as ListViewItem);
                }
            }
            else
                Dialog_MyMessageBox.Show(Constant.FAILED_DELETE_COMPANIES,1,UiColors.MESSAGE_ERROR);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.E))
            {
                DialogResult result = Dialog_MyMessageBox.Show(Constant.MESSAGE_EXCEL_EXPORT, 2);
                if (result == DialogResult.Yes)
                    Utility.exportToExcel(listCompView.listView1,homeform);
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
            else if (keyData == (Keys.Control | Keys.D))
            {
                pic_delete_Click(this.pic_delete, null);
            }
            //else if (keyData == (Keys.Control | Keys.F))
            //{
            //    pictureBox_notifyCompany_Click(this.pictureBox_notifyCompany, null);
            //}
            return base.ProcessCmdKey(ref msg, keyData);
        }

    }
}
