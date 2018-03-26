using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Placement_Application.Commons;
using Placement_Application.Service;

namespace Placement_Application
{
    public partial class Form_RegisterCompanies : Form
    {
        private Form_Home homeform;
        private CompanyManager compManager;
        private DIalog_ProgressBar myProgressDialog;

        public Form_RegisterCompanies(Form_Home homeform)
        {
            this.homeform = homeform;
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult result = Dialog_MyMessageBox.Show(Constant.MESSAGE_EXIT, 2);

            if (result == DialogResult.Yes)
                Application.Exit();
        }
      
        private void RegisterCompaniesForm_Load(object sender, EventArgs e)
        {
            Placement_Application.Components.Resolution res = new Placement_Application.Components.Resolution();
            res.ResizeForm(this, Common.form_height, Common.form_width);
            this.label_top_batch.Text = Utility.getConfigLabel();
            timer1.Start();
            timer1.Interval = 1000;
        
            dropdown_companyType.DataSource=Utility.setDropdownDataFromEnum(Constant.ENUM_COMPANY_TYPE);
            dropown_status.DataSource = Utility.setDropdownDataFromEnum(Constant.ENUM_COMPANY_STATUS);

            dropdown_companyType.SelectedIndex = 0;
            dropown_status.SelectedIndex = 0;

            dateTime_dor.MinDate = DateTime.Now.AddDays(1);
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
            refreshPage();
        }

        private void but_registerCompany_Click(object sender, EventArgs e)
        {
            if (isValidated())
            {
                DialogResult result = Dialog_MyMessageBox.Show(Constant.CONFIRM_SAVE, 2);
                if (result == DialogResult.Yes)
                {
                    startBackgoundThread();
                }
            }
        }

        private void dropdown_companyType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dropdown_companyType.SelectedIndex == 0)
                textBox_collegeName.Text = Common.homeCollege;
            else
                textBox_collegeName.Text = string.Empty;
        }

        private void refreshPage()
        {
            textBox_companyName.Text = string.Empty;
            dropown_status.SelectedIndex = 0;
            dropdown_companyType.SelectedIndex = 0;
            dateTime_dor.Value = DateTime.Now.AddDays(1);

            textBox_companyName.Focus();
        }

        private void panel_top_MouseMove(object sender, MouseEventArgs e)
        {
            Utility.dragForm(e, Handle);
        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            Utility.dragForm(e, Handle);
        }

        private bool isValidated()
        {
            if(textBox_companyName.Text.Trim().Length<1 || textBox_collegeName.Text.Trim().Length<1)
            {
                Dialog_MyMessageBox.Show(Validations.VALIDATION_EMPTY_FIELD, 1, UiColors.MESSAGE_ERROR);
                return false;
            }
            DateTime currentDate = DateTime.Now.Date;
            DateTime selectedDate = dateTime_dor.Value.Date;

            if ( Utility.compareDates(selectedDate, currentDate) < 0)
            {
                Dialog_MyMessageBox.Show(Validations.VALIDATION_MIN_DATE, 1, UiColors.MESSAGE_ERROR);
                return false;
            }
            
            if (!Utility.isNetworkAvailable())
            {
                Dialog_MyMessageBox.Show(Validations.VALIDATION_NO_NETWORK, 1, UiColors.MESSAGE_ERROR);
                return false;
            }
          
            return true;
        }

        private void startBackgoundThread()
        {
            if (!backgroundWorker1.IsBusy)
            {
                myProgressDialog = new DIalog_ProgressBar();
                this.Opacity = 0.8;
                myProgressDialog.Show();

                var dropdownMap = new Dictionary<string, int>();
                dropdownMap.Add(EnumData.viewCompanyListHeadings.STATUS.ToString(), dropown_status.SelectedIndex);
                dropdownMap.Add(EnumData.viewCompanyListHeadings.TYPE.ToString(), dropdown_companyType.SelectedIndex);

                backgroundWorker1.RunWorkerAsync(dropdownMap);
            }
            else
            {
                Dialog_MyMessageBox.Show(Constant.REQUEST_UNDER_PROCESS, 1, UiColors.MESSAGE_ERROR);
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            compManager = new CompanyManagerImpl();
            var company = compManager.getCompanyByName(textBox_companyName.Text.Trim());

            if (company == null)
            {
                company = new Entity_Company();
                company.companyName = textBox_companyName.Text.Trim();
            }

            var dropdownMap = e.Argument as Dictionary<string, int>;

            var compDetails = new Entity_CompanyDetails();
            compDetails.type = dropdownMap[EnumData.viewCompanyListHeadings.TYPE.ToString()];
            compDetails.host = textBox_collegeName.Text.Trim();
            compDetails.DOR = dateTime_dor.Value;
            compDetails.status = dropdownMap[EnumData.viewCompanyListHeadings.STATUS.ToString()];
            compDetails.myConfigObj = Utility.getConfigObj();
            compDetails.staffId = Common.loggedUser.staffId;

            if (company.addCompDetailsObj(compDetails))
                e.Result = 0;
            else
            {
                if (compManager.saveNewCompany(company))
                    e.Result = 1;
                else
                    e.Result = 2;
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            myProgressDialog.Dispose();
            this.Opacity = 1;
            switch ((int)e.Result)
            {
                case 0:
                    Dialog_MyMessageBox.Show(Constant.DUPLICATE_COMPANY, 1, UiColors.MESSAGE_ERROR);
                    break;
                case 1:
                    Dialog_MyMessageBox.Show(Constant.SAVE_SUCCESS, 1, UiColors.MESSAGE_SUCCESS);
                    refreshPage();
                    break;
                case 2:
                    Dialog_MyMessageBox.Show(Constant.REQUEST_UNPROCESSED, 1, UiColors.MESSAGE_ERROR);
                    refreshPage();
                    break;
            }
        }
     
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.P))
            {
                pictureBox1_Click(this.picture_power, null);
            }
            else if (keyData == (Keys.Control | Keys.M))
            {
                pictureBox2_Click(this.picture_minimise, null);
            }
            else if (keyData == (Keys.Control | Keys.H))
            {
                pictureBox4_Click(this.picture_home, null);
            }
            else if (keyData == (Keys.Control | Keys.R))
            {
                pictureBox5_Click(this.picture_refresh, null);
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

    }
}
