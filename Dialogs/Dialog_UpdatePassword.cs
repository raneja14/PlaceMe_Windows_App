using System;
using System.Windows.Forms;
using Placement_Application.Commons;
using Placement_Application.Service;

namespace Placement_Application.Dialogs
{
    public partial class Dialog_UpdatePassword : Form
    {
        private static Dialog_UpdatePassword dialogPwd;
        private static DialogResult result = DialogResult.Cancel;
        private DIalog_ProgressBar myProgressDialog; 
        private ToolTip tooltip;
        private DateTime lastModifiedDate;

        public Dialog_UpdatePassword()
        {
            InitializeComponent();
        }

        public static DialogResult Show()
        {
            dialogPwd = new Dialog_UpdatePassword();
            Placement_Application.Components.Resolution res = new Placement_Application.Components.Resolution();
            res.ResizeForm(dialogPwd, Common.dialog_height, Common.dialog_width);
       
            dialogPwd.Opacity = Common.dialogOpacity;
            dialogPwd.textBox_oldPassword.Focus();
            dialogPwd.ShowDialog();

            return result;
        }

        private void picture_close_Click(object sender, EventArgs e)
        {
            result = DialogResult.Cancel;
            this.Dispose();
        }

        private void but_update_Click(object sender, EventArgs e)
        {
            updatePassWord();
         }

        private void updatePassWord()
        {
            if (!Utility.isNetworkAvailable())
            {
                Dialog_MyMessageBox.Show(Validations.VALIDATION_NO_NETWORK, 1, UiColors.MESSAGE_ERROR);
            }
            else
            {
                string oldPassword = textBox_oldPassword.Text;
                string newPassword = textBox_newPassword.Text;
                string confirmPassword = textBox_confirmPassword.Text;
                lastModifiedDate = Common.loggedUser.lastModifiedOn;

                if (isValidated(oldPassword, newPassword, confirmPassword))
                {
                    Common.loggedUser.password = Utility.getMD5Value(newPassword);
                    Common.loggedUser.lastModifiedOn = DateTime.Now;
                    startBackgroundThread(true);
                }
            }
        }

        private bool isValidated(string oldPassword, string newPassword, string confirmPassword)
        {
            if (tooltip == null)
                tooltip = new ToolTip();

            if (string.IsNullOrEmpty(oldPassword))
            {
                Utility.showToolTip(tooltip, textBox_oldPassword, Validations.VALIDATION_EMPTY_FIELD,
                 Constant.TOOLTIP_TYPE_WARNING, null);
                textBox_oldPassword.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(newPassword))
            {
                Utility.showToolTip(tooltip, textBox_newPassword, Validations.VALIDATION_EMPTY_FIELD,
                 Constant.TOOLTIP_TYPE_WARNING, null);
                textBox_newPassword.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(confirmPassword))
            {
                Utility.showToolTip(tooltip, textBox_confirmPassword, Validations.VALIDATION_EMPTY_FIELD,
                 Constant.TOOLTIP_TYPE_WARNING, null);
                textBox_confirmPassword.Focus();
                return false;
            }
            else if (oldPassword == newPassword)
            {
                Utility.showToolTip(tooltip, textBox_newPassword, Validations.VALIDATION_DUPLICATE_PASSWORD,
                 Constant.TOOLTIP_TYPE_WARNING, null);
                textBox_newPassword.Focus();
                return false;
            }
            else if (newPassword.Length < Validations.password_MinLength)
            {
                Utility.showToolTip(tooltip, textBox_newPassword, Validations.VALIDATION_PASSWORD_MIN_LENGTH,
                              Constant.TOOLTIP_TYPE_WARNING, null);
                textBox_newPassword.Focus();
                return false;
            }
            else if (newPassword != confirmPassword)
            {
                Utility.showToolTip(tooltip, textBox_confirmPassword, Validations.VALIDATION_UNMATCHED_PASSWORDS,
                 Constant.TOOLTIP_TYPE_WARNING, null);
                textBox_confirmPassword.Focus();
                return false;
            }
            else if (Utility.getMD5Value(oldPassword) != Common.loggedUser.password)
            {
                Utility.showToolTip(tooltip, textBox_oldPassword, Validations.VALIDAITON_INVALID_PASSWORD,
                Constant.TOOLTIP_TYPE_WARNING, null);
                textBox_oldPassword.Focus();
                return false;
            }
          
           
            return true;
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

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            StaffManager staffmanager = new StaffManagerImpl();
            e.Result = staffmanager.updateStaffDetails(Common.loggedUser);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            this.Opacity = 1;
            myProgressDialog.Dispose();

            if ((bool)e.Result)
            {
                result = DialogResult.Yes;
            }
            else
            {
                Common.loggedUser.password = Utility.getMD5Value(textBox_oldPassword.Text.Trim());
                Common.loggedUser.lastModifiedOn = lastModifiedDate;
                result = DialogResult.Retry;
            }
            this.Dispose();
        }
    }
}
