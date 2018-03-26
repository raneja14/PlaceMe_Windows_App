using System;
using System.Windows.Forms;
using Placement_Application.Service;
using Placement_Application.Commons;

namespace Placement_Application
{
    public partial class Control_Home : UserControl
    {
        private Form_Home homeform;

        public Control_Home(Form_Home homeform)
        {
            this.homeform = homeform;
            InitializeComponent();
        }

        private void but_registerCompanies_Click(object sender, EventArgs e)
        {
            homeform.Hide();
            Form_RegisterCompanies regcomp = new Form_RegisterCompanies(homeform);
            regcomp.Show();
           
        }

        private void but_viewCompanies_Click(object sender, EventArgs e)
        {
            if (!Utility.isNetworkAvailable())
            {
                Dialog_MyMessageBox.Show(Validations.VALIDATION_NO_NETWORK, 1, UiColors.MESSAGE_ERROR);
            }
            else
            {
                homeform.Opacity = 0.9F;
                Form_ViewCompanies viewcomp = new Form_ViewCompanies(homeform);
                viewcomp.Show();
                homeform.Hide();
                homeform.Opacity = 1F;
            }
            //if (getCompanyCount() > 0)
            //{
            //    homeform.Hide();
            //    Form_ViewCompanies viewcomp = new Form_ViewCompanies(homeform);
            //    viewcomp.Show();
            //}
            //else
            //{
            //    Dialog_MyMessageBox.Show(Validations.VALIDATION_NO_COMPANY_FOUND, 1, UiColors.MESSAGE_ERROR);
            //}
        }

        private void but_updateStudents_Click(object sender, EventArgs e)
        {
            if (!Utility.isNetworkAvailable())
            {
                Dialog_MyMessageBox.Show(Validations.VALIDATION_NO_NETWORK, 1, UiColors.MESSAGE_ERROR);
            }
            else
            {
                homeform.Opacity = 0.9F; 
                homeform.Hide();
                Form_UpdatePlacementStatus updatecomp = new Form_UpdatePlacementStatus(homeform);
                updatecomp.Show();
                homeform.Opacity = 1F; 
            }   //if (getCompanyCount() > 0)
            //{
            //    homeform.Hide();
            //    Form_UpdatePlacementStatus updatecomp = new Form_UpdatePlacementStatus(homeform);
            //    updatecomp.Show();
            //}
            //else
            //{
            //    Dialog_MyMessageBox.Show(Validations.VALIDATION_NO_COMPANY_FOUND, 1, UiColors.MESSAGE_ERROR);
            //}
         
        }

        private void but_viewStudent_Click(object sender, EventArgs e)
        {

            if (!Utility.isNetworkAvailable())
            {
                Dialog_MyMessageBox.Show(Validations.VALIDATION_NO_NETWORK, 1, UiColors.MESSAGE_ERROR);
            }
            else
            {
                homeform.Opacity = 0.9F;
                homeform.Hide();
                Form_ViewAllStudents viewStudents = new Form_ViewAllStudents(homeform);
                viewStudents.Show();
                homeform.Opacity = 1F;
            }
        }

        private void but_statistics_Click(object sender, EventArgs e)
        {

            if (!Utility.isNetworkAvailable())
            {
                Dialog_MyMessageBox.Show(Validations.VALIDATION_NO_NETWORK, 1, UiColors.MESSAGE_ERROR);
            }
            else
            {
                homeform.Opacity = 0.9F;
                homeform.Hide();
                Form_Statistics stats = new Form_Statistics(homeform);
                stats.Show();
                homeform.Opacity = 1F;
            }
        }

        private void but_notify_Click(object sender, EventArgs e)
        {
            if (!Utility.isNetworkAvailable())
            {
                Dialog_MyMessageBox.Show(Validations.VALIDATION_NO_NETWORK, 1, UiColors.MESSAGE_ERROR);
            }
            else
            {
                homeform.Opacity = 0.9F;
                Form_Notification notify = new Form_Notification(homeform);
                notify.Show();
                homeform.Hide();
                homeform.Opacity = 1F;
            }  //if (getCompanyCount() > 0)
            //{
            //    homeform.Hide();
            //    Form_Notification notify = new Form_Notification(homeform);
            //    notify.Show();
            //}
            //else
            //{
            //    Dialog_MyMessageBox.Show(Constant.NO_COMPANY_TO_NOTIFY, 1, UiColors.MESSAGE_ERROR);
            //}
        }

        private int getCompanyCount()
        {
            CompanyManager compManager = new CompanyManagerImpl();
            return compManager.getCompanyCount();
        }

        private void Control_Home_Load(object sender, EventArgs e)
        {
            //    Placement_Application.Components.Resolution res = new Placement_Application.Components.Resolution();
            //    res.ResizeControl(this);
        }
   }
}
