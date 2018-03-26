using System;
using System.Windows.Forms;
using System.Collections.Generic;
using Placement_Application.Commons;
using Placement_Application.Service;

namespace Placement_Application.Dialogs
{
    public partial class Dialog_UpdateUser : Form
    {
        private static Dialog_UpdateUser dialogUser;
        private static DialogResult result = DialogResult.Cancel;
        private DIalog_ProgressBar myProgressDialog;
        private static Entity_Staff currentUser;
        private static bool isAdminRequest;
        private static bool isNewUser;
        private ToolTip tooltip;

        public Dialog_UpdateUser()
        {
            InitializeComponent();
        }

        public static DialogResult Show(Entity_Staff user, bool forOtherUser)
        {
            dialogUser = new Dialog_UpdateUser();
            Placement_Application.Components.Resolution res = new Placement_Application.Components.Resolution();
            res.ResizeForm(dialogUser, Common.dialog_height, Common.dialog_width);
                       
            dialogUser.Opacity = Common.dialogOpacity;
            currentUser = user;
            isNewUser = false;
            isAdminRequest = forOtherUser;

            dialogUser.textBox_userName.Text = currentUser.staffName;
            dialogUser.textBox_email.Text = currentUser.email;
            dialogUser.textBox_contact.Text = currentUser.phone;

            dialogUser.textBox_userName.Focus();
            dialogUser.ShowDialog();

            return result;
        }

        public static DialogResult Show(Entity_Staff user)
        {
            dialogUser = new Dialog_UpdateUser();
            Placement_Application.Components.Resolution res = new Placement_Application.Components.Resolution();
            res.ResizeForm(dialogUser, 580, 1050);
            dialogUser.StartPosition = FormStartPosition.CenterParent;
        
            dialogUser.Opacity = Common.dialogOpacity;
            isNewUser = true;
            currentUser = user;

            dialogUser.label_studentId.Text = Labels.ADD_USER;
            dialogUser.but_update.Text = Labels.ADD;

            dialogUser.textBox_userName.Focus();
            dialogUser.ShowDialog();

            return result;
        }

        private void picture_close_Click(object sender, EventArgs e)
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
                if (isNewUser)
                    addNewUser();
                else
                    updateUserInfo();
            }
        }

        private void updateUserInfo()
        {
            if (isValidated())
            {
                Entity_Staff editedObj = new Entity_Staff();

                editedObj.phone = dialogUser.textBox_contact.Text.Trim();
                editedObj.staffName = dialogUser.textBox_userName.Text.Trim();
                editedObj.email = dialogUser.textBox_email.Text.Trim();

                if (currentUser.Equals(editedObj))
                {
                    Utility.showToolTip(new ToolTip(), but_update, Validations.VALIDATION_NO_CHANGE_DETECTED,
                        Constant.TOOLTIP_TYPE_WARNING, null);
                }
                else
                {
                    editedObj.staffId = currentUser.staffId;
                    editedObj.password = currentUser.password;
                    editedObj.myConfigObj = currentUser.myConfigObj;
                    editedObj.createdOn = currentUser.createdOn;
                    editedObj.isAccountActive = currentUser.isAccountActive;
                    editedObj.lastModifiedOn = DateTime.Now;

                    startBackgroundThread(true, false, editedObj);
                }
            }
        }

        private void addNewUser()
        {
            if (isValidated())
            {
                currentUser.staffName = dialogUser.textBox_userName.Text.Trim();
                currentUser.email = dialogUser.textBox_email.Text.Trim();
                currentUser.phone = dialogUser.textBox_contact.Text.Trim();

                startBackgroundThread(true, true, currentUser);
            }
        }

        private bool isValidated()
        {
            if (tooltip == null)
                tooltip = new ToolTip();

            if (string.IsNullOrEmpty(textBox_userName.Text))
            {
                Utility.showToolTip(tooltip, textBox_userName, Validations.VALIDATION_EMPTY_FIELD,
                 Constant.TOOLTIP_TYPE_WARNING, null);
                textBox_userName.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(textBox_email.Text))
            {
                Utility.showToolTip(tooltip, textBox_email, Validations.VALIDATION_EMPTY_FIELD,
                 Constant.TOOLTIP_TYPE_WARNING, null);
                textBox_email.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(textBox_contact.Text))
            {
                Utility.showToolTip(tooltip, textBox_contact, Validations.VALIDATION_EMPTY_FIELD,
                 Constant.TOOLTIP_TYPE_WARNING, null);
                textBox_contact.Focus();
                return false;
            }
            else if (textBox_userName.Text.Trim().Length < Validations.userName_MinLength)
            {
                Utility.showToolTip(tooltip, textBox_userName, Validations.VALIDATION_NAME_MIN_LENGTH,
                   Constant.TOOLTIP_TYPE_WARNING, null);
                textBox_userName.Focus();
                return false;
            }
            else if (!Utility.isValidEmail(textBox_email.Text))
            {
                Utility.showToolTip(tooltip, textBox_email, Validations.VALIDATION_INVALID_EMAIL_FORMAT,
                    Constant.TOOLTIP_TYPE_WARNING, string.Empty);
                textBox_email.Focus();
                return false;
            }
            else if (textBox_contact.Text.Trim().Length != Validations.phone_MinLength)
            {
                Utility.showToolTip(tooltip, textBox_contact, Validations.VALIDATION_PHONE_MIN_LENGTH,
                  Constant.TOOLTIP_TYPE_WARNING, null);
                textBox_contact.Focus();
                return false;
            }
            return true;
        }

        private void textBox_contact_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.allowNumericOnly(e);
        }

        private void startBackgroundThread(bool dialogRequired, bool addNewUser, Entity_Staff userObj)
        {
            if (!backgroundWorker1.IsBusy)
            {
                if (dialogRequired)
                {
                    myProgressDialog = new DIalog_ProgressBar();
                    this.Opacity = 0.8;
                    myProgressDialog.Show();
                }

                var objectMap = new Dictionary<string, Object>();
                objectMap.Add("staffObj", userObj);
                objectMap.Add("operation", addNewUser);

                backgroundWorker1.RunWorkerAsync(objectMap);
            }
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            var objectMap = e.Argument as Dictionary<string, Object>;
            var operationNewUser = (bool)objectMap["operation"];
            var userObj = objectMap["staffObj"] as Entity_Staff;
            StaffManager staffManager = new StaffManagerImpl();

            if (operationNewUser)
            {
                e.Result = staffManager.addNewUser(userObj);
            }
            else
            {
                e.Result = false;
                if (staffManager.updateStaffDetails(userObj))
                {
                    if (!isAdminRequest)
                        Common.loggedUser = userObj;
                    e.Result = true;
                }
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            this.Opacity = 1;
            myProgressDialog.Dispose();

            if ((bool)e.Result)
                result = DialogResult.Yes;
            else
                result = DialogResult.Retry;

            this.Dispose();
        }

    }
}
