using System;
using System.ComponentModel;
using System.Windows.Forms;
using Placement_Application.Commons;
using Placement_Application.Service;
using Placement_Application.Components;

namespace Placement_Application.Dialogs
{
    public partial class Dialog_ForgotPassword : Form
    {
        private static Dialog_ForgotPassword dialogForgotPassword;
        private static DialogResult result = DialogResult.Cancel;
        private DIalog_ProgressBar myProgressDialog;
        private StaffManager staffManager;
        private Entity_Staff staffObj;
        private string email;
        private string phone;

        public Dialog_ForgotPassword()
        {
            InitializeComponent();
        }

        public static DialogResult Show()
        {
            initialiseDialog();
            return result;
        }

        private static void initialiseDialog()
        {
            dialogForgotPassword = new Dialog_ForgotPassword();
            Placement_Application.Components.Resolution res = new Placement_Application.Components.Resolution();
            res.ResizeForm(dialogForgotPassword, Common.dialog_height, Common.dialog_width);
           
            dialogForgotPassword.Opacity = Common.dialogOpacity;
            dialogForgotPassword.ShowDialog();
       }

        private void but_verify_Click(object sender, EventArgs e)
        {
            email = text_email.Text.Trim();
            phone = text_contact.Text.Trim();

            if (isValidated())
            {
                startBackgoundThread();
            }
        }

        private void picture_close_Click(object sender, EventArgs e)
        {
            result = DialogResult.Cancel;
            this.Dispose();
        }

        private void text_contact_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.allowNumericOnly(e);
        }

        private bool isValidated()
        {
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phone))
            {
                Dialog_MyMessageBox.Show(Validations.VALIDATION_EMPTY_FIELD, 1, UiColors.MESSAGE_ERROR);
                return false;
            }
            else if (!Utility.isValidEmail(email))
            {
                Utility.showToolTip(new ToolTip(), text_email, Validations.VALIDATION_INVALID_EMAIL_FORMAT,
                    Constant.TOOLTIP_TYPE_WARNING, string.Empty);
                return false;
            }
            else if (phone.Length != Validations.phone_MinLength)
            {
                Utility.showToolTip(new ToolTip(), text_contact, Validations.VALIDATION_PHONE_MIN_LENGTH,
                    Constant.TOOLTIP_TYPE_WARNING, string.Empty);
                return false;
            }
            else if (!Utility.isNetworkAvailable())
            {
                Dialog_MyMessageBox.Show(Validations.VALIDATION_NO_NETWORK, 1, UiColors.MESSAGE_ERROR);
                return false;
            }

            return true;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            staffManager = new StaffManagerImpl();
            staffObj = staffManager.getStaffByEmail(email, phone);
            if (staffObj == null)
                e.Result = 0;
            else
            {
                staffObj.password = Utility.getMD5Value(Utility.generateTempUserPassword(staffObj));
                if (staffManager.updateStaffDetails(staffObj))
                {
                    e.Result = 1;
                    //MyMail mailObj = new MyMail();
                    //mailObj.email = email;
                    //mailObj.subject = Labels.RECOVERY_MAIL_SUBJECT;
                    //mailObj.body = frameMailBody(staffObj);

                    //if ((bool)Utility.sendMail(mailObj, false))
                    //    e.Result = 1;
                    //else
                    //    e.Result = 2;
                }
                else
                    e.Result = 3;
            }

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            myProgressDialog.Dispose();
            this.Opacity = 1;

            if (e.Result != null)
            {
                switch ((int)e.Result)
                {
                    case 0:
                        Dialog_MyMessageBox.Show(Constant.INVALID_CREDENTIALS, 1, UiColors.MESSAGE_ERROR);
                        break;
                    case 1:
                        string msg = Labels.PASSWORD_RECOVERY_MSG;
                        msg = Utility.replaceKeyword(msg,Constant.RECOVERY_STAFF_ID,staffObj.staffId.ToString());
                        msg = Utility.replaceKeyword(msg, Constant.RECOVERY_STAFF_PWD, Utility.generateTempUserPassword(staffObj));
                        Dialog_MyMessageBox.Show(msg,1,UiColors.MESSAGE_SUCCESS);
                    //  Dialog_MyMessageBox.Show(Constant.RECOVERY_MAIL_SUCCESS, 1, UiColors.MESSAGE_SUCCESS);
                        result = DialogResult.Yes;
                        this.Dispose();
                        break;
                    case 2:
                        Dialog_MyMessageBox.Show(Constant.MAIL_UNSENT, 1, UiColors.MESSAGE_ERROR);
                        break;
                    case 3:
                        Dialog_MyMessageBox.Show(Constant.PASSWORD_RESET_FAILED, 1, UiColors.MESSAGE_ERROR);
                        break;
                }
            }
        }

        private string frameMailBody(Entity_Staff staffObj)
        {
            string mailBody = Labels.RECOVERY_MAIL_BODY;
            mailBody = Utility.replaceKeyword(mailBody, Constant.RECOVERY_STAFF_NAME, staffObj.staffName);
            mailBody = Utility.replaceKeyword(mailBody, Constant.RECOVERY_STAFF_ID, staffObj.staffId.ToString());
            mailBody = Utility.replaceKeyword(mailBody, Constant.RECOVERY_STAFF_PWD, Utility.generateTempUserPassword(staffObj));

            return mailBody;
        }

        private void startBackgoundThread()
        {
            if (!backgroundWorker1.IsBusy)
            {
                myProgressDialog = new DIalog_ProgressBar();
                this.Opacity = 0.8;
                myProgressDialog.Show();

                backgroundWorker1.RunWorkerAsync();
            }
            else
            {
                Dialog_MyMessageBox.Show(Constant.REQUEST_UNDER_PROCESS, 1, UiColors.MESSAGE_ERROR);
            }
        }
    }
}
