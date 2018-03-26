using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Placement_Application.Commons;
using Placement_Application.Service;
using Placement_Application.Components;

namespace Placement_Application.Dialogs
{
    public partial class Dialog_Configure : Form
    {
        private static Dialog_Configure dialogConfigure;
        private static DialogResult result = DialogResult.Cancel;
        private DIalog_ProgressBar myProgressDialog;
        private IDictionary<string, IList<string>> batchdegreeMap;

        public Dialog_Configure()
        {
            InitializeComponent();
        }

        public static DialogResult Show()
        {
            dialogConfigure = new Dialog_Configure();
            Placement_Application.Components.Resolution res = new Placement_Application.Components.Resolution();
            res.ResizeForm(dialogConfigure, Common.dialog_height, Common.dialog_width);
           
            dialogConfigure.Opacity = Common.dialogOpacity;
            dialogConfigure.dropdown_batch.Focus();
            dialogConfigure.startBackgroundThread(false);
            dialogConfigure.ShowDialog();

            return result;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            result = DialogResult.Cancel;
            this.Dispose();
        }

        private void but_update_Click(object sender, EventArgs e)
        {
            updateConfiguration();
        }

        private IDictionary<string, IList<string>> getBatchdegreeMap()
        {
            StudentManager studentManager = new StudentManagerImpl();
            return studentManager.getDegreeWithBatch();
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
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            e.Result = getBatchdegreeMap();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Result == null)
            {
                dropdown_batch.Enabled = false;
                dropDown_degree.Enabled = false;
            }
            else
            {
                batchdegreeMap = (IDictionary<string, IList<string>>)e.Result;
                dropdown_batch.DataSource = batchdegreeMap.Keys.ToArray();
                if (Common.loggedUser.myConfigObj.currentBatch.Equals(Constant.NOT_APPLICABLE))
                    dropdown_batch.SelectedIndex = 0;
                else
                {
                    dropdown_batch.SelectedItem = Common.loggedUser.myConfigObj.currentBatch;
                    dropDown_degree.SelectedItem = Common.loggedUser.myConfigObj.currentDegree;
                }
            }
           //  myProgressDialog.Dispose();
        }

        private void dropdown_batch_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedBatch = dropdown_batch.SelectedItem.ToString();
            dropDown_degree.DataSource = batchdegreeMap[selectedBatch];
        }

        private void updateConfiguration()
        {
            if (!Utility.isNetworkAvailable())
            {
                Dialog_MyMessageBox.Show(Validations.VALIDATION_NO_NETWORK, 1, UiColors.MESSAGE_ERROR);
            }
            else
            {
                string batch = dropdown_batch.SelectedItem.ToString();
                string degree = dropDown_degree.SelectedItem.ToString();
                MyConfiguration configObjCopy = Common.loggedUser.myConfigObj;

                if (isValidated(batch, degree))
                {
                    Common.loggedUser.myConfigObj.currentBatch = batch;
                    Common.loggedUser.myConfigObj.currentDegree = degree;
                    if (new StaffManagerImpl().updateStaffDetails(Common.loggedUser))
                        result = DialogResult.Yes;
                    else
                    {
                        Common.loggedUser.myConfigObj = configObjCopy;
                        result = DialogResult.Retry;
                    }
                    this.Dispose();
                }
            }
        }

        private bool isValidated(string batch, string degree)
        {
            if (Common.loggedUser.myConfigObj.currentBatch.Equals(batch) &&
                Common.loggedUser.myConfigObj.currentDegree.Equals(degree))
            {
                Utility.showToolTip(new ToolTip(), dropdown_batch, Validations.VALIDATION_NO_CHANGE_DETECTED,
                  Constant.TOOLTIP_TYPE_WARNING, null);
                dropdown_batch.Focus();
                return false;
            }
             return true;
        }
    }
}
