using System;
using System.Windows.Forms;
using Placement_Application.Commons;
using Placement_Application.Dialogs;

namespace Placement_Application
{
    public partial class Control_Settings1 : UserControl
    {
        private Form_Home homeForm;

        public Control_Settings1(Form_Home homeForm)
        {
            this.homeForm = homeForm;
            InitializeComponent();
        }

        private void Control_Settings1_Load(object sender, EventArgs e)
        {
            if (Common.loggedUser.staffId != Common.adminId)
                label_DBconf.Visible = false;
        }

        private void but_configure_Click(object sender, EventArgs e)
        {
            DialogResult result = Dialog_Configure.Show();
            if (result == DialogResult.Yes)
            {
                Dialog_MyMessageBox.Show(Constant.UPDATE_SUCCESS, 1, UiColors.MESSAGE_SUCCESS);
                Common.isAppConfigured = true;
                homeForm.label_top_batch.Text = Utility.getConfigLabel();
                homeForm.label_top_batch.Visible = true;
             //   homeForm.setNotificationLabelFromDb();
            }
            else if (result == DialogResult.Retry)
                Dialog_MyMessageBox.Show(Constant.EXCEPTION, 1, UiColors.MESSAGE_ERROR);
            
        }

        private void but_password_Click(object sender, EventArgs e)
        {
            DialogResult result = Dialog_UpdatePassword.Show();
            displayResponseFromDialogResult(result);
        }   
            
        private void but_userDetails_Click(object sender, EventArgs e)
        {
            DialogResult result = Dialog_UpdateUser.Show(Common.loggedUser,false);
            displayResponseFromDialogResult(result);
        }

        private void displayResponseFromDialogResult(DialogResult result)
        {
            if (result == DialogResult.Yes)
                Dialog_MyMessageBox.Show(Constant.UPDATE_SUCCESS, 1, UiColors.MESSAGE_SUCCESS);
            else if (result == DialogResult.Retry)
                Dialog_MyMessageBox.Show(Constant.EXCEPTION, 1, UiColors.MESSAGE_ERROR);
        }

        private void label_DBconf_Click(object sender, EventArgs e)
        {
        //    DialogResult result = Dialog_ManageDB.Show();
            Dialog_ManageDB.Show();

        }
    }
}
