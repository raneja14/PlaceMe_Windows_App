using System;
using System.Windows.Forms;
using System.IO;
using Placement_Application.Commons;

namespace Placement_Application
{
    public partial class Control_DropFile : UserControl
    {
        private Form_UpdatePlacementStatus updateStatus;
        private string filePath;
        private string fileName;
        private string[] droppedfiles;

        public Control_DropFile()
        {
            InitializeComponent();
        }

        public Control_DropFile(Form_UpdatePlacementStatus updateStatus)
        {
            this.updateStatus = updateStatus;
            InitializeComponent();
        }

        private void but_browseFile_Click(object sender, EventArgs e)
        {
            //Text files (*.txt)|*.txt|All files (*.*)|*.*"
            OpenFileDialog myfile = new OpenFileDialog();
            myfile.Filter = "Excel Files (*.xlsx)|*.xlsx|(*.xls)|*.xls";
            if (myfile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                filePath = myfile.FileName;
                fileName = myfile.SafeFileName;
                label_fileLocation.Text = filePath;
                label_panel_filename.Text = fileName;
                panel_excel.Visible = true;
            }
        }

        private void subpanel_center_DragDrop(object sender, DragEventArgs e)
        {
            droppedfiles = (string[])e.Data.GetData(DataFormats.FileDrop);

            filePath = droppedfiles.GetValue(0).ToString();
            fileName = Path.GetFileName(filePath);

            label_fileLocation.Text = filePath;
            label_panel_filename.Text = fileName;
            panel_excel.Visible = true;

        }

        private void subpanel_center_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                string[] testfile = (string[])e.Data.GetData(DataFormats.FileDrop);
                string ext = testfile.GetValue(0).ToString();
            
                if(validateExtenstion(ext))
                    e.Effect = DragDropEffects.All;
            }
            else
                e.Effect = DragDropEffects.None;
        }

        private void DropFileControl_Load(object sender, EventArgs e)
        {
            panel_excel.Hide();
        }

        private Boolean validateExtenstion(string extension)
        {
            if (System.IO.Path.GetExtension(extension).ToUpperInvariant() == ".XLSX" || 
                System.IO.Path.GetExtension(extension).ToUpperInvariant() == ".XLS")
                return true;
            else
                return false;
        }

        private void but_upload_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                Dialog_MyMessageBox.Show(Validations.VALIDATION_NO_FILE_SELECTED, 1, UiColors.MESSAGE_ERROR);
            }
            else
            {
                if (!Utility.isNetworkAvailable())
                {
                    Dialog_MyMessageBox.Show(Validations.VALIDATION_NO_NETWORK, 1, UiColors.MESSAGE_ERROR);
                }
                else
                {
                    try
                    {
                        DialogResult result = Dialog_UpdateStudentCompany.Show(filePath);
                        if (result == DialogResult.Yes)
                            updateStatus.placementStatusUpdated = true;
                        but_cancel.PerformClick();
                    }
                    catch (Exception ex)
                    {
                        Utility.logFile(ex.Message, ex.InnerException, Constant.LOGTYPE_ERROR);
                        Dialog_MyMessageBox.Show(Constant.EXCEPTION, 1, UiColors.MESSAGE_ERROR);
                    }
                }
            }
        }

        private void but_cancel_Click(object sender, EventArgs e)
        {
            panel_excel.Hide();
            fileName = string.Empty;
            filePath = string.Empty;
            label_fileLocation.Text = "??";
        }
      
    }
}
