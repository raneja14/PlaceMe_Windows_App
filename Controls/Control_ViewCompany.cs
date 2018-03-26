using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Placement_Application.Commons;
using Placement_Application.Service;

namespace Placement_Application
{
    public partial class Control_ViewCompany : UserControl
    {
        private ListControl_CompanyView compListControl;
        private Form_ViewCompanies viewCompany;
        private Entity_CompanyDetails compDetailObj;
        private DIalog_ProgressBar myProgressDialog;

        public Control_ViewCompany(ListControl_CompanyView compListControl, Entity_CompanyDetails compDetailsObj, Form_ViewCompanies viewCompany)
        {
            this.compListControl = compListControl;
            this.viewCompany = viewCompany;
            this.compDetailObj = compDetailsObj;
            InitializeComponent();
        }

        private void ViewCompanyControl_Load(object sender, EventArgs e)
        {
            disableControls();
            fill_values();
        }

        private void fill_values()
        {
            StudentPlacedManager placedManager = new StudentPlacedManagerImpl();
            string hiredCount = (DateTime.Now.Date > compDetailObj.DOR.Date) ?
                placedManager.getHiredStudentsCount(compDetailObj.compDetailsId).ToString() : Constant.NOT_APPLICABLE;

            label_placedStudents.Text = hiredCount;
            label_company.Text = compDetailObj.companyObj.companyName;
            textBox_companyName.Text = compDetailObj.companyObj.companyName;
            textBox_collegeName.Text = compDetailObj.host;
            dateTime_dor.Value = compDetailObj.DOR;
            dropdown_companyType.SelectedIndex = compDetailObj.type;
            dropown_status.SelectedIndex = compDetailObj.status;
    
        }

        private void disableControls()
        {
            textBox_collegeName.ReadOnly = true;
            textBox_companyName.ReadOnly = true;
            dropown_status.Enabled = false;
            dropdown_companyType.Enabled = false;
            dateTime_dor.Enabled = false;

            but_updateCompany.Visible = false;
            but_editCompany.Visible = true;

        }

        private void enableControls()
        {
            textBox_collegeName.ReadOnly = false;
            textBox_companyName.ReadOnly = false;
            dropown_status.Enabled = true;
            dropdown_companyType.Enabled = true;
            dateTime_dor.Enabled = true;

            but_updateCompany.Visible = true;
            but_editCompany.Visible = false;
        }

        private void but_editCompany_Click(object sender, EventArgs e)
        {
            if (label_placedStudents.Text != Constant.NOT_APPLICABLE)
                Dialog_MyMessageBox.Show(Validations.VALIDATION_COMPANY_VISITED, 1, UiColors.MESSAGE_ERROR);
            else
                enableControls();
        }

        private void but_updateCompany_Click(object sender, EventArgs e)
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

        private bool isValidated()
        {
            if (string.IsNullOrWhiteSpace(textBox_companyName.Text))
            {
                Utility.showToolTip(new ToolTip(), textBox_companyName, Validations.VALIDATION_EMPTY_FIELD, Constant.TOOLTIP_TYPE_WARNING, null);
                return false;
            }
            if (string.IsNullOrWhiteSpace(textBox_collegeName.Text))
            {
                Utility.showToolTip(new ToolTip(), textBox_collegeName, Validations.VALIDATION_EMPTY_FIELD, Constant.TOOLTIP_TYPE_WARNING, null);
                return false;
            }

            DateTime currentDate = DateTime.Now.Date;
            DateTime selectedDate = dateTime_dor.Value.Date;

            if (Utility.compareDates(selectedDate.Date, currentDate.Date) < 0)
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
                viewCompany.Opacity = 0.8;
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
            var dropdownMap = e.Argument as Dictionary<string, int>;

            compDetailObj.companyObj.companyName = textBox_companyName.Text.Trim();
            compDetailObj.host = textBox_collegeName.Text.Trim();
            compDetailObj.type = dropdownMap[EnumData.viewCompanyListHeadings.TYPE.ToString()];
            compDetailObj.status = dropdownMap[EnumData.viewCompanyListHeadings.STATUS.ToString()];
            compDetailObj.DOR = dateTime_dor.Value;

            CompanyManager compManager = new CompanyManagerImpl();
            e.Result = compManager.updateCompany(compDetailObj);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            myProgressDialog.Dispose();
            viewCompany.Opacity = 1;

            if ((bool)e.Result)
            {
                Dialog_MyMessageBox.Show(Constant.UPDATE_SUCCESS_DETAILS, 1, UiColors.MESSAGE_SUCCESS);
                label_company.Text = compDetailObj.companyObj.companyName;
            }
            else
                Dialog_MyMessageBox.Show(Constant.REQUEST_UNPROCESSED, 1, UiColors.MESSAGE_ERROR);

            disableControls();
        }
       
    }
}
