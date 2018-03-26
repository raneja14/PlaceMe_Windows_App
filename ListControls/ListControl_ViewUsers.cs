using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Placement_Application.Commons;
using Placement_Application.Service;
using Placement_Application.Dialogs;
using Placement_Application.Components;

namespace Placement_Application.Controls
{
    public partial class ListControl_ViewUsers : UserControl
    {
        private ToolTip tooltip;
        private Form_Home homeForm;
        private StaffManager staffManager;
        private List<Entity_Staff> usersList;
        private List<Entity_Staff> unusedUsersList;
        private DIalog_ProgressBar myProgressDialog;

        public ListControl_ViewUsers(Form_Home homeForm)
        {
            this.homeForm = homeForm;
            tooltip = new ToolTip();
            staffManager = new StaffManagerImpl();
            InitializeComponent();
        }

        private void ListControl_ViewUsers_Load(object sender, EventArgs e)
        {
            usersList = staffManager.loadAllUsers();
            if (usersList != null && usersList.Count > 0)
            {
                prepareList();
                populateList(usersList);
            }
            else
                Dialog_MyMessageBox.Show(Constant.MESSAGE_NO_DATA, 1, UiColors.MESSAGE_ERROR);
        }

        private void pic_activate_Click(object sender, EventArgs e)
        {
            if (!Utility.isNetworkAvailable())
            {
                Dialog_MyMessageBox.Show(Validations.VALIDATION_NO_NETWORK, 1, UiColors.MESSAGE_ERROR);
            }
            else
            {
                if (!isUserlistEmpty())
                {
                    DialogResult result = Dialog_MyMessageBox.Show(Constant.CONFIRM_USER_ACTIVE, 2);

                    if (result == DialogResult.Yes)
                    {
                        showProgressBar();
                        if (staffManager.changeUserStatus(listView1, true))
                        {
                            myProgressDialog.Close();
                            homeForm.but_manageUsers_sidePanel.PerformClick();
                            Dialog_MyMessageBox.Show(Constant.SUCCESS_ACTIVATION, 1, UiColors.MESSAGE_SUCCESS);
                        }
                        else
                        {
                            myProgressDialog.Close();
                            Dialog_MyMessageBox.Show(Constant.FAILED_ACTIVATION, 1, UiColors.MESSAGE_ERROR);
                        }
                    }
                }
            }
        }

        private void pic_deactivate_Click(object sender, EventArgs e)
        {
            if (!Utility.isNetworkAvailable())
            {
                Dialog_MyMessageBox.Show(Validations.VALIDATION_NO_NETWORK, 1, UiColors.MESSAGE_ERROR);
            }
            else
            {
                if (!isUserlistEmpty())
                {
                    DialogResult result = Dialog_MyMessageBox.Show(Constant.CONFIRM_USER_DEACTIVE, 2);
                    if (result == DialogResult.Yes)
                    {
                        showProgressBar();
                        if (staffManager.changeUserStatus(listView1, false))
                        {
                            myProgressDialog.Close();
                            homeForm.but_manageUsers_sidePanel.PerformClick();
                            Dialog_MyMessageBox.Show(Constant.SUCCESS_DEACTIVATION, 1, UiColors.MESSAGE_SUCCESS);
                        }
                        else
                        {
                            myProgressDialog.Close();
                            Dialog_MyMessageBox.Show(Constant.FAILED_DEACTIVATION, 1, UiColors.MESSAGE_ERROR);
                        }
                    }
                }
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
                if (!isUserlistEmpty())
                {
                    DialogResult result = Dialog_MyMessageBox.Show(Constant.CONFIRM_USER_DELETE, 2);
                    if (result == DialogResult.Yes)
                    {
                        showProgressBar();
                        if (staffManager.deleteUsers(listView1))
                        {
                            myProgressDialog.Close();
                            homeForm.but_manageUsers_sidePanel.PerformClick();
                            Dialog_MyMessageBox.Show(Constant.SUCCESS_DELETE_USERS, 1, UiColors.MESSAGE_SUCCESS);
                        }
                        else
                        {
                            myProgressDialog.Close();
                            Dialog_MyMessageBox.Show(Constant.FAILED_DELETE_USERS, 1, UiColors.MESSAGE_ERROR);
                        }
                    }
                }
            }
        }

        private void pic_addUser_Click(object sender, EventArgs e)
        {
            var newUser = new Entity_Staff();
            DialogResult result = Dialog_UpdateUser.Show(newUser);
            if (result == DialogResult.Yes)
            {
                homeForm.but_manageUsers_sidePanel.PerformClick();
                Dialog_MyMessageBox.Show(Constant.USER_ADDED_SUCCESS +
                    "\nUserID: " + newUser.staffId + " ;; Password: " + Utility.generateTempUserPassword(newUser), 1, UiColors.MESSAGE_SUCCESS);

                //if (!backgroundWorker1.IsBusy)
                //    backgroundWorker1.RunWorkerAsync(newUser);
            }
            else if (result == DialogResult.Retry)
                Dialog_MyMessageBox.Show(Constant.USER_ADDED_FAILED, 1, UiColors.MESSAGE_ERROR);
        }

        private void pic_editUser_Click(object sender, EventArgs e)
        {
            panel_userControls.Visible = false;
            panel_activationControls.Visible = true;
            listView1.CheckBoxes = true;
        }

        private void pic_deleteUser_Click(object sender, EventArgs e)
        {
            if (!Utility.isNetworkAvailable())
            {
                Dialog_MyMessageBox.Show(Validations.VALIDATION_NO_NETWORK, 1, UiColors.MESSAGE_ERROR);
            }
            else
            {
                if (unusedUsersList == null)
                {
                    unusedUsersList = staffManager.getUnusedUsersList();
                }
                displayUnUsedUser(unusedUsersList);
            }
        }

        private void pic_back_Click(object sender, EventArgs e)
        {
            panel_userControls.Visible = true;
            panel_activationControls.Visible = false;
            listView1.CheckBoxes = false;
        }

        private void pic_backDel_Click(object sender, EventArgs e)
        {
            panel_userControls.Visible = true;
            panel_deleteUser.Visible = false;
            listView1.CheckBoxes = false;
            populateList(usersList);
        }

        private void pic_deactivate_MouseHover(object sender, EventArgs e)
        {
            Utility.showToolTip(tooltip, pic_deactivate, "Deactivate User", Constant.TOOLTIP_TYPE_GENERAL, string.Empty);
        }

        private void pic_activate_MouseHover(object sender, EventArgs e)
        {
            Utility.showToolTip(tooltip, pic_activate, "Activate User", Constant.TOOLTIP_TYPE_GENERAL, string.Empty);
        }

        private void pic_editUser_MouseHover(object sender, EventArgs e)
        {
            Utility.showToolTip(tooltip, pic_editUser, "Edit User", Constant.TOOLTIP_TYPE_GENERAL, string.Empty);
        }

        private void pic_addUser_MouseHover(object sender, EventArgs e)
        {
            Utility.showToolTip(tooltip, pic_addUser, "Add New User", Constant.TOOLTIP_TYPE_GENERAL, string.Empty);
        }

        private void pic_back_MouseHover(object sender, EventArgs e)
        {
            Utility.showToolTip(tooltip, pic_back, "Back", Constant.TOOLTIP_TYPE_GENERAL, string.Empty);
        }

        private void pic_delete_MouseHover(object sender, EventArgs e)
        {
            Utility.showToolTip(tooltip, pic_delete, "Delete", Constant.TOOLTIP_TYPE_GENERAL, string.Empty);
        }

        private void pic_backDel_MouseHover(object sender, EventArgs e)
        {
            Utility.showToolTip(tooltip, pic_backDel, "Back", Constant.TOOLTIP_TYPE_GENERAL, string.Empty);
        }

        private void pic_deleteUser_MouseHover(object sender, EventArgs e)
        {
            Utility.showToolTip(tooltip, pic_deleteUser, "Delete Users", Constant.TOOLTIP_TYPE_GENERAL, string.Empty);
        }

        private void prepareList()
        {
            listView1.View = View.Details;

            listView1.Columns.Add(EnumData.UsersListHeadings.Sr_No.ToString(), 50);
            listView1.Columns.Add(EnumData.UsersListHeadings.STAFF_ID.ToString(), 70);
            listView1.Columns.Add(EnumData.UsersListHeadings.NAME.ToString(), 110);
            listView1.Columns.Add(EnumData.UsersListHeadings.EMAIL.ToString(), 160);
            listView1.Columns.Add(EnumData.UsersListHeadings.CONTACT.ToString(), 85);
            listView1.Columns.Add(EnumData.UsersListHeadings.CREATED_ON.ToString(), 90);
            listView1.Columns.Add(EnumData.UsersListHeadings.LAST_MODIFIED_ON.ToString(), 125);
            listView1.Columns.Add(EnumData.UsersListHeadings.STATUS.ToString(), 100);

            Utility.allocateEqualColumnWidth(listView1);
        }

        private void populateList(List<Entity_Staff> userList)
        {
            listView1.SuspendLayout();
            listView1.Items.Clear();
            int totalUsers = 0;
            int activeUsers = 0;
            int deactiveUsers = 0;

            foreach (Entity_Staff staffObj in userList)
            {
                totalUsers++;
                ListViewItem lv = new ListViewItem(totalUsers.ToString());
                lv.SubItems.Add(staffObj.staffId.ToString());
                lv.SubItems.Add(staffObj.staffName);
                lv.SubItems.Add(staffObj.email);
                lv.SubItems.Add(staffObj.phone);
                lv.SubItems.Add(Utility.convertDateToString(staffObj.createdOn));
                lv.SubItems.Add(Utility.convertDateToString(staffObj.lastModifiedOn));

                lv.UseItemStyleForSubItems = false;

                if (staffObj.isAccountActive)
                {
                    lv.SubItems.Add(Constant.USER_ACTIVE);
                    lv.SubItems[7].ForeColor = Utility.getColorFromHex(UiColors.MESSAGE_SUCCESS);
                    activeUsers++;
                }
                else
                {
                    lv.SubItems.Add(Constant.USER_DEACTIVE);
                    lv.SubItems[7].ForeColor = Utility.getColorFromHex(UiColors.MESSAGE_ERROR);
                    deactiveUsers++;
                }
                lv.Tag = staffObj;
                listView1.Items.Add(lv);
            }
            listView1.ResumeLayout();
            label_totalUsersCount.Text = totalUsers.ToString();
            label_activeUsersCount.Text = activeUsers.ToString();
            label_deactiveUsersCount.Text = deactiveUsers.ToString();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (!listView1.CheckBoxes)
            {
                Entity_Staff stafObj = listView1.SelectedItems[0].Tag as Entity_Staff;
                DialogResult result = Dialog_UpdateUser.Show(stafObj, true);
                if (result == DialogResult.Yes)
                {
                    homeForm.but_manageUsers_sidePanel.PerformClick();
                    Dialog_MyMessageBox.Show(Constant.UPDATE_SUCCESS, 1, UiColors.MESSAGE_SUCCESS);
                }
                else if (result == DialogResult.Retry)
                    Dialog_MyMessageBox.Show(Constant.EXCEPTION, 1, UiColors.MESSAGE_ERROR);
            }
        }

        private bool isUserlistEmpty()
        {
            if (listView1.CheckedItems.Count == 0)
            {
                Dialog_MyMessageBox.Show(Validations.NO_BOX_CHECKED, 1, UiColors.MESSAGE_ERROR);
                return true;
            }
            return false;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (Utility.isNetworkAvailable())
            {
                var staffObj = e.Argument as Entity_Staff;
                MyMail mailObj = new MyMail();
                mailObj.email = Common.loggedUser.email + "," + staffObj.email;
                mailObj.subject = Labels.NEW_USER_MAIL_SUBJECT;
                mailObj.body = frameMailBody(staffObj);

                if ((bool)Utility.sendMail(mailObj, false))
                    e.Result = 1;
            }
            else
                e.Result = 0;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Result != null)
            {
                switch ((int)e.Result)
                {
                    case 0:
                        Dialog_MyMessageBox.Show(Constant.MAIL_UNSENT_NETWORK_ISSUES, 1, UiColors.MESSAGE_ERROR);
                        break;
                    case 1:
                        Dialog_MyMessageBox.Show(Constant.NEW_USER_MAIL_SUCCESS, 1, UiColors.MESSAGE_SUCCESS);
                        break;
                }
            }
        }

        private string frameMailBody(Entity_Staff staffObj)
        {
            string mailBody = Labels.NEW_USER_MAIL_BODY;
            mailBody = Utility.replaceKeyword(mailBody, Constant.RECOVERY_STAFF_NAME, Common.loggedUser.staffName + "/" + staffObj.staffName);
            mailBody = Utility.replaceKeyword(mailBody, Constant.RECOVERY_STAFF_ID, staffObj.staffId.ToString());
            mailBody = Utility.replaceKeyword(mailBody, Constant.RECOVERY_STAFF_PWD, Utility.generateTempUserPassword(staffObj));

            return mailBody;
        }

        private void displayUnUsedUser(List<Entity_Staff> unusedUsersList)
        {
            if (unusedUsersList != null && unusedUsersList.Count > 0)
            {
                panel_userControls.Visible = false;
                panel_deleteUser.Visible = true;
                listView1.CheckBoxes = true;
                populateList(unusedUsersList);
            }
            else
                Dialog_MyMessageBox.Show(Constant.MESSAGE_NO_DATA, 1, UiColors.MESSAGE_ERROR);
        }

        private void showProgressBar()
        {
            myProgressDialog = new DIalog_ProgressBar();
            myProgressDialog.Show();
        }

    }
}
