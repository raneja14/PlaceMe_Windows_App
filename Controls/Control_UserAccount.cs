using System;
using System.Windows.Forms;
using Placement_Application.Commons;

namespace Placement_Application
{
    public partial class Control_UserAccount : UserControl 
    {
        private Entity_Staff loggedUser;
        
        public Control_UserAccount()
        { 
            this.loggedUser = Common.loggedUser;
            InitializeComponent();
        }

        private void Control_UserAccount_Load(object sender, EventArgs e)
        {
            setPage();
        }

        private void setPage()
        {
            label_userId.Text = loggedUser.staffId.ToString();
            label_userName.Text = loggedUser.staffName;
            label_userEmail.Text = loggedUser.email;
            label_userContact.Text = loggedUser.phone;
            label_lastModified.Text = Utility.convertTimeToString(loggedUser.lastModifiedOn)
                + "  " + Utility.convertDateToString(loggedUser.lastModifiedOn);
            label_userCreatedDate.Text = Utility.convertTimeToString(loggedUser.createdOn)
                + "  " + Utility.convertDateToString(loggedUser.createdOn);
        }
    }
}
