using Placement_Application.Commons;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Placement_Application.Dialogs
{
    public partial class Dialog_ManageDB : Form
    {
        private static Dialog_ManageDB dialogDB;
        private static int dbOperation;
        private static string filePath, fileName;
        private static DIalog_ProgressBar myProgressDialog;
        private static DialogResult result = DialogResult.Cancel;

        public Dialog_ManageDB()
        {
            InitializeComponent();
        }

        public static DialogResult Show()
        {
            dialogDB = new Dialog_ManageDB();
            Placement_Application.Components.Resolution res = new Placement_Application.Components.Resolution();
            res.ResizeForm(dialogDB, Common.dialog_height, Common.dialog_width);
      
            dialogDB.Opacity = Common.dialogOpacity;
            fileName = string.Empty;
            dbOperation = Constant.DB_INSERT_STUDENT_DATA;
            dialogDB.ShowDialog();

            return result;
        }

        private void picture_close_Click(object sender, EventArgs e)
        {
            result = DialogResult.Cancel;
            this.Dispose();
        }

        private void radioInsertData_CheckedChanged(object sender, EventArgs e)
        {
            if (radioInsertData.Checked)
            {
                radioInsertData.ForeColor = Utility.getColorFromHex(UiColors.NOTIFCATION_TEMPLATE_HOVER_LABEL_COLOR_GOLD);
                radioUploadData.ForeColor = SystemColors.ControlLight;
                dbOperation = Constant.DB_INSERT_STUDENT_DATA;
            }
            else
            {
                radioUploadData.ForeColor = Utility.getColorFromHex(UiColors.NOTIFCATION_TEMPLATE_HOVER_LABEL_COLOR_GOLD);
                radioInsertData.ForeColor = SystemColors.ControlLight;
                dbOperation = Constant.DB_UPDATE_STUDENT_DATA;
            }
            but_uploadData.Visible = false;
            filePath = string.Empty;
            fileName = string.Empty;
            label_excelName.Visible = false;
        }

        private void but_importExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog myfile = new OpenFileDialog();
            myfile.Filter = "Excel Files (*.xlsx)|*.xlsx|(*.xls)|*.xls";
            if (myfile.ShowDialog() == DialogResult.OK)
            {
                filePath = myfile.FileName;
                fileName = myfile.SafeFileName;
                label_excelName.Text = fileName;
                label_excelName.Visible = true;
                but_uploadData.Visible = true;
            }
        }

        private void but_uploadData_Click(object sender, EventArgs e)
        {
            if (!Utility.isNetworkAvailable())
            {
                Dialog_MyMessageBox.Show(Validations.VALIDATION_NO_NETWORK, 1, UiColors.MESSAGE_ERROR);
            }
            else
            {
                dialogDB.Opacity = 0.4F;
                var result = Dialog_MyMessageBox.Show(Constant.DB_CONFIRM_OPERATION, 2);
                if (result == DialogResult.Yes)
                {
                    if (!backgroundWorker1.IsBusy)
                    {
                        myProgressDialog = new DIalog_ProgressBar();
                        myProgressDialog.Show();
                        backgroundWorker1.RunWorkerAsync();
                    }
                }
                else
                    dialogDB.Opacity = Common.dialogOpacity;
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            DbConfigManager manager = new DbConfigManagerImpl();
            switch (dbOperation)
            {
                case Constant.DB_INSERT_STUDENT_DATA:
                    e.Result = manager.insertStudentData(Utility.readExcel(filePath, dbOperation));
                    break;
                case Constant.DB_UPDATE_STUDENT_DATA:
                    e.Result = manager.updateStudentData(Utility.readExcel(filePath, dbOperation));
                    break;
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            myProgressDialog.Dispose();
            dialogDB.Opacity = Common.dialogOpacity;

            if (e.Result != null)
            {
                switch ((int)e.Result)
                {
                    case 0:
                        Dialog_MyMessageBox.Show(Constant.UPLOAD_FAILED, 1, UiColors.MESSAGE_ERROR);
                        break;
                    case 1:
                        Dialog_MyMessageBox.Show(Constant.UPLOAD_SUCCESS, 1, UiColors.MESSAGE_SUCCESS);
                        result = DialogResult.Cancel;
                        this.Dispose();
                        break;
                    case 2:
                        Dialog_MyMessageBox.Show(Constant.FILE_EMPTY, 1, UiColors.MESSAGE_ERROR);
                        break;
                    case 3:
                        Dialog_MyMessageBox.Show(Constant.DATA_EXISTS, 1, UiColors.MESSAGE_ERROR);
                        break;
                }
            }
        }
    }
}
