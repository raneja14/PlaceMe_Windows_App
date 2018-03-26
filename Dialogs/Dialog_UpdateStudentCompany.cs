using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Placement_Application.Service;
using Placement_Application.Commons;

namespace Placement_Application
{
    public partial class Dialog_UpdateStudentCompany : Form
    {
        private static Dialog_UpdateStudentCompany dialogUpdatePlacementDetails;
        private static DialogResult result = DialogResult.Cancel;
        private CompanyManager compManager;
        private Dictionary<string, Entity_CompanyDetails> compMap;
        private AutoCompleteStringCollection compNames;
        private Entity_Student studentObj;
        private DIalog_ProgressBar myProgressDialog;
        private bool isCompanyPresent;
        private bool isBulkUpdate;
        private string filePath;

        public Dialog_UpdateStudentCompany()
        {
            InitializeComponent();
        }

        public static DialogResult Show(Entity_Student studentObj)
        {
            initialiseDialog();
            dialogUpdatePlacementDetails.label_studentId.Text = studentObj.collegeId;
            dialogUpdatePlacementDetails.studentObj = studentObj;
            dialogUpdatePlacementDetails.isBulkUpdate = false;
            dialogUpdatePlacementDetails.dateTime_dor.MaxDate = DateTime.Now;
            dialogUpdatePlacementDetails.ShowDialog();
            return result;
        }

        public static DialogResult Show(string filePath)
        {
            initialiseDialog();
            dialogUpdatePlacementDetails.label_studentId.Hide();
            dialogUpdatePlacementDetails.isBulkUpdate = true;
            dialogUpdatePlacementDetails.filePath = filePath;
            dialogUpdatePlacementDetails.dateTime_dor.MaxDate = DateTime.Now.Date;
            dialogUpdatePlacementDetails.ShowDialog();
            return result;
        }

        private static void initialiseDialog()
        {
            dialogUpdatePlacementDetails = new Dialog_UpdateStudentCompany();
            Placement_Application.Components.Resolution res = new Placement_Application.Components.Resolution();
            res.ResizeForm(dialogUpdatePlacementDetails, Common.dialog_height, Common.dialog_width);
          
            dialogUpdatePlacementDetails.Opacity = Common.dialogOpacity;
            dialogUpdatePlacementDetails.dropdown_company.Focus();
            dialogUpdatePlacementDetails.isCompanyPresent = false;
            dialogUpdatePlacementDetails.getPossibleCompanies();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            result = DialogResult.Cancel;
            this.Dispose();
        }

        private void but_update_Click(object sender, EventArgs e)
        {
            if (!Utility.isNetworkAvailable())
            {
                Dialog_MyMessageBox.Show(Validations.VALIDATION_NO_NETWORK, 1, UiColors.MESSAGE_ERROR);
            }
            else
            {
                if (dialogUpdatePlacementDetails.isCompanyPresent)
                    saveDetials();
                else
                {
                    Utility.showToolTip(new ToolTip(), dialogUpdatePlacementDetails.dropdown_company,
                        Validations.VALIDATION_NO_COMPANY_FOUND, Constant.TOOLTIP_TYPE_WARNING, Constant.TOOLTIP_FOUND);
                }
            }
        }

        private void getPossibleCompanies()
        {
            compNames = new AutoCompleteStringCollection();
            compManager = new CompanyManagerImpl();
            List<Entity_CompanyDetails> compDetailList = compManager.getCompanyNamesWithDetailId(true);
            if (compDetailList != null && compDetailList.Count > 0)
            {
                compMap = new Dictionary<string, Entity_CompanyDetails>();
                foreach (Entity_CompanyDetails compDetailObj in compDetailList)
                {
                    compNames.Add(compDetailObj.companyObj.companyName);
                    dropdown_company.Items.Add(compDetailObj.companyObj.companyName);
                    compMap.Add(compDetailObj.companyObj.companyName, compDetailObj);
                }
                dialogUpdatePlacementDetails.isCompanyPresent = true;
                dialogUpdatePlacementDetails.dropdown_company.AutoCompleteCustomSource = compNames;
                dialogUpdatePlacementDetails.dropdown_company.SelectedIndex = 0;
            }
            else
            {
                dialogUpdatePlacementDetails.isCompanyPresent = false;
            }
        }

        private bool isValidated(string compName)
        {
            if (string.IsNullOrWhiteSpace(compName))
            {
                Utility.showToolTip(new ToolTip(), dialogUpdatePlacementDetails.dropdown_company,
                   Validations.VALIDATION_EMPTY_FIELD, Constant.TOOLTIP_TYPE_WARNING, null);
                return false;
            }
            else if (!compNames.Contains(compName))
            {
                Utility.showToolTip(new ToolTip(), dialogUpdatePlacementDetails.dropdown_company,
                   Validations.VALIDATION_VALUE_NOT_EXIST, Constant.TOOLTIP_TYPE_WARNING, null);
                return false;
            }
            return true;
        }

        private void saveDetials()
        {
            string selectedCompanyName = (dialogUpdatePlacementDetails.dropdown_company.SelectedItem == null) ?
                string.Empty : dialogUpdatePlacementDetails.dropdown_company.SelectedItem.ToString();

            if (isValidated(selectedCompanyName))
            {
                long selectedCompanyDetailId = compMap[selectedCompanyName].compDetailsId;
                if (dialogUpdatePlacementDetails.isBulkUpdate)
                {
                    result = DialogResult.No;
                    var argsMap = new Dictionary<string, Object>();
                    argsMap.Add("compId", selectedCompanyDetailId);
                    argsMap.Add("DOR", dialogUpdatePlacementDetails.dateTime_dor.Value);
                    argsMap.Add("filePath", dialogUpdatePlacementDetails.filePath);

                    startBackgroundThread(true, argsMap, null);
                }
                else
                {
                    long studentId = studentObj.studentId;
                    var placedObj = new Entity_PlacementDetails
                        (studentId, selectedCompanyDetailId, dialogUpdatePlacementDetails.dateTime_dor.Value);
                    startBackgroundThread(true, null, placedObj);
                }
            }
        }

        private void Dialog_UpdateStudentCompany_Load(object sender, EventArgs e)
        {
            //  usc.dateTime_dor.MaxDate = DateTime.Now;
        }

        private void dropdown_company_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCompanyName = (dialogUpdatePlacementDetails.dropdown_company.SelectedItem == null) ?
                string.Empty : dialogUpdatePlacementDetails.dropdown_company.SelectedItem.ToString();

            DateTime date = compMap[selectedCompanyName].DOR;
            dateTime_dor.Value = date.Date;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            StudentPlacedManager manager = new StudentPlacedManagerImpl();

            if (Utility.areObjectsOfSameType(e.Argument, new Entity_PlacementDetails()))
            {
                var placedObj = e.Argument as Entity_PlacementDetails;
                e.Result = manager.savePlacementDetails(placedObj);
            }
            else
            {
                var argsMap = e.Argument as IDictionary<string, Object>;
                string filepath = (String)argsMap["filePath"];
                long selectedCompanyDetailId = (long)argsMap["compId"];
                DateTime dor = (DateTime)argsMap["DOR"];

                e.Result = manager.uploadPlacementData(Utility.readExcel(filePath,Constant.DB_GET_COLLEGE_ID), selectedCompanyDetailId, dor);
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Opacity = 1;
            dialogUpdatePlacementDetails.pictureBox1.Enabled = true;
            myProgressDialog.Dispose();

            if (Utility.areObjectsOfSameType(e.Result, true))
                result = (bool)e.Result ? DialogResult.Yes : DialogResult.No;
            else
            {
                if (e.Result != null)
                {
                    switch ((int)e.Result)
                    {
                        case 0:
                            Dialog_MyMessageBox.Show(Validations.VALIDATION_UPLOAD_FAILED, 1, UiColors.MESSAGE_ERROR);
                            break;
                        case 1:
                            Dialog_MyMessageBox.Show(Constant.UPLOAD_SUCCESS, 1, UiColors.MESSAGE_SUCCESS);
                            result = DialogResult.Yes;
                            break;
                        case 2:
                            Dialog_MyMessageBox.Show(Constant.DATA_EXISTS, 1, UiColors.MESSAGE_ERROR);
                            break;
                        case 3:
                            Dialog_MyMessageBox.Show(Constant.FILE_EMPTY, 1, UiColors.MESSAGE_ERROR);
                            break;
                        case 4:
                            Dialog_MyMessageBox.Show(Validations.VALIDATION_NO_NETWORK, 1, UiColors.MESSAGE_ERROR);
                            break;
                    }
                }
                else
                    Dialog_MyMessageBox.Show(Validations.VALIDATION_UPLOAD_FAILED, 1, UiColors.MESSAGE_ERROR);
                           
            }
            this.Dispose();
        }

        private void startBackgroundThread(bool dialogRequired, IDictionary<string, Object> argsMap, Entity_PlacementDetails placedObj)
        {
            if (!backgroundWorker1.IsBusy)
            {
                if (dialogRequired)
                {
                    myProgressDialog = new DIalog_ProgressBar();
                    this.Opacity = 0.8;
                    myProgressDialog.Show();
                }
                if (placedObj == null)
                    backgroundWorker1.RunWorkerAsync(argsMap);
                else
                    backgroundWorker1.RunWorkerAsync(placedObj);

                dialogUpdatePlacementDetails.pictureBox1.Enabled = false;
            }
        }

    }
}
