using System;
using System.ComponentModel;
using System.Windows.Forms;
using Placement_Application.Service;
using Placement_Application.Commons;
using Placement_Application.Dialogs;
using System.IO;
using System.Reflection;
using System.Diagnostics;
using Placement_Application.DAO;
using Placement_Application.Components;
using System.Collections.Generic;


namespace Placement_Application
{
    public partial class Control_Login : UserControl
    {
        private Form_Welcome mainForm;
        private DIalog_ProgressBar myProgressDialog;
        private ToolTip tooltip;
      
        public Control_Login(Form_Welcome mainform)
        {
            this.mainForm = mainform;
            InitializeComponent();
        }

        private void LoginControl_Load(object sender, EventArgs e)
        {
            resetPage();
            displayExpiryMessage();
            tooltip = new ToolTip();
            //textBox_userID.Text = Common.adminId.ToString();
            //textBox_password.Text = "pwd01";
        }

        private void textBox_userID_Enter(object sender, EventArgs e)
        {
            if (string.Equals(textBox_userID.Text.Trim(), Labels.PLACEHOLDER_USERID))
            {
                textBox_userID.Text = string.Empty;
                textBox_userID.ForeColor = Utility.getColorFromHex(UiColors.FORECOLOR_ACTIVE); ;
            }
        }

        private void textBox_userID_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_userID.Text))
            {
                textBox_userID.Text = Labels.PLACEHOLDER_USERID;
                textBox_userID.ForeColor = Utility.getColorFromHex(UiColors.FORECOLOR_INACTIVE);
            }
        }

        private void textBox_password_Enter(object sender, EventArgs e)
        {
            if (string.Equals(textBox_password.Text.Trim(), Labels.PLACEHOLDER_PASSWORD))
            {
                textBox_password.Text = string.Empty;
                textBox_password.PasswordChar = Labels.PLACEHOLDER_PASSWORD_MASKED_CHAR;
                textBox_password.ForeColor = Utility.getColorFromHex(UiColors.FORECOLOR_ACTIVE);
            }
        }

        private void textBox_password_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_password.Text))
            {
                textBox_password.Text = Labels.PLACEHOLDER_PASSWORD;
                textBox_password.PasswordChar = Labels.NULL_CHARACTER;
                textBox_password.ForeColor = Utility.getColorFromHex(UiColors.FORECOLOR_INACTIVE);
            }
        }

        private void but_login_Click(object sender, EventArgs e)
        {
            if (isValidated())
            {
                startBackgoundThread();
            }
        }

        private void but_forgot_Click(object sender, EventArgs e)
        {
           Dialog_ForgotPassword.Show();
        }

        private void resetPage()
        {
            //textBox_userID.Text = string.Empty;
            //textBox_password.Text = string.Empty;
            textBox_userID.Text = Labels.PLACEHOLDER_USERID;
            textBox_password.Text = Labels.PLACEHOLDER_PASSWORD;
            textBox_password.ForeColor = Utility.getColorFromHex(UiColors.FORECOLOR_INACTIVE);
            textBox_userID.ForeColor = Utility.getColorFromHex(UiColors.FORECOLOR_INACTIVE);
            textBox_password.PasswordChar = Labels.NULL_CHARACTER;

            textBox_userID.Focus();
        }

        private bool isValidated()
        {
            if (textBox_userID.Text.Trim() == Labels.PLACEHOLDER_USERID || string.IsNullOrEmpty(textBox_userID.Text))
            {
                Utility.showToolTip(tooltip, textBox_userID, Validations.VALIDATION_EMPTY_FIELD, Constant.TOOLTIP_TYPE_WARNING, null);
                textBox_userID.Focus();
                return false;
            }
            else if (textBox_password.Text.Trim() == Labels.PLACEHOLDER_PASSWORD || string.IsNullOrEmpty(textBox_password.Text))
            {
                Utility.showToolTip(tooltip, textBox_password, Validations.VALIDATION_EMPTY_FIELD, Constant.TOOLTIP_TYPE_WARNING, null);
                textBox_password.Focus();
                return false;
            }
            else if (!Utility.isNetworkAvailable())
            {
                Dialog_MyMessageBox.Show(Validations.VALIDATION_NO_NETWORK, 1, UiColors.MESSAGE_ERROR);
                return false;
            }
            return true;
        }

        private void textBox_userID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData.ToString().Equals("Return"))
            {
                textBox_password.Focus();
            }
        }

        private void textBox_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData.ToString().Equals("Return"))
            {
                but_login.PerformClick();
            }
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            textBox_userID.Focus();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            textBox_password.Focus();
        }

        private void startBackgoundThread()
        {
            if (!backgroundWorker1.IsBusy)
            {
                myProgressDialog = new DIalog_ProgressBar();
                mainForm.Opacity = 0.8;
                myProgressDialog.Show();

                backgroundWorker1.RunWorkerAsync();
            }
            else
            {
                Dialog_MyMessageBox.Show(Constant.REQUEST_UNDER_PROCESS, 1, UiColors.MESSAGE_ERROR);
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            StaffManager manager = new StaffManagerImpl();
            Common.loggedUser = manager.getStaffById(Convert.ToInt32(textBox_userID.Text.Trim()),
                   Utility.getMD5Value(textBox_password.Text.Trim()));

            e.Result = Common.loggedUser;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            myProgressDialog.Dispose();
            mainForm.Opacity = 1;

            var user = e.Result as Entity_Staff;
            if (user == null)
            {
                Dialog_MyMessageBox.Show(Constant.INVALID_CREDENTIALS, 1, UiColors.MESSAGE_ERROR);
            }
            else if (!user.isAccountActive)
            {
                Dialog_MyMessageBox.Show(Constant.ACCOUNT_LOCKED, 1, UiColors.MESSAGE_ERROR);
            }
            else
            {
                mainForm.Hide();
                Form_Home homeForm = new Form_Home(mainForm);
                homeForm.Show();
            }
            resetPage();
        }

        private void insertStudentData()
        {
            Persistence p = new PersistenceImpl();

            var conf = new MyConfiguration();
            conf.currentBatch = "2012-16";
            conf.currentDegree = "B.TECH";

            string[] branch= new string[5]{"Software","COMPUTER SCIENCE","MECHANICAL","ECE","CIVIL"};
            string[] gender = new string[2] {"MALE","FEMALE" };
            int studentId = 1704;
            long scoreID = 247;
            var mylist = new List<Object>();
            var scoreList = new List<Object>();

            for (int i = 200; i < 2201; i++)
            {
                var student = new Entity_Student();
                student.branch = branch[i % branch.Length];
                student.collegeId = studentId.ToString();
                student.email = "xyz@abc.com";
                student.gender = gender[i % gender.Length];
                student.myConfigObj = conf;
                student.phone = "111111111";
                student.studentName = "Student" + i;

                mylist.Add(student);
                studentId++;

                var score = new Entity_StudentScore();
                score.arrears = 0;
                score.cgpa = 7.6;
                score.X = 85;
                score.XII = 78;
                score.studentId = scoreID;
                scoreList.Add(score);

                scoreID++;
              
            }

            if (p.bulkInsert(mylist))
                p.bulkInsert(scoreList);
        }

        private void insertCompanyData()
        {
            Persistence pers = new PersistenceImpl();

            var myconf = new MyConfiguration();
            myconf.currentBatch = "2012-16";
            myconf.currentDegree = "B.TECH";

            var compList=new List<Object>();

            for (int i = 108; i < 109; i++)
            {
                var compObj = new Entity_Company();
                compObj.companyId = i;
                compObj.companyName = "COMPANY"+i;

                var compDetail = new Entity_CompanyDetails();
                compDetail.DOR = DateTime.Now.AddDays(20+i);
                compDetail.host = "ACET";
                compDetail.myConfigObj = myconf;
                compDetail.staffId = 1;
                compDetail.status = 1;
                compDetail.type = 0;
                compDetail.companyObj = compObj;
             
                compList.Add(compDetail);
            }

            pers.bulkInsert(compList);
        }

        private void displayExpiryMessage()
        {
            int productExpiryDaysLeft = Utility.getDaysDifference(Utility.convertStringToDateTime(Common.productExpiryDate), DateTime.Now);
            if (productExpiryDaysLeft <= Common.warningDays)
            {
                if (productExpiryDaysLeft > 0)
                {
                    string message = Labels.PRODUCT_EXPIRY_WARNING_MESSAGE;
                    message = message.Replace(Constant.MSG_PRODUCT_EXPIRY, productExpiryDaysLeft.ToString());
                    label_expiry_msg.Text = message;
                }
                else
                {
                    label_expiry_msg.Text = Labels.PRODUCT_EXPIRED_MESSAGE;
                    but_login.Enabled = false;
                    but_forgot.Enabled = false;
                    textBox_userID.ReadOnly = true;
                    textBox_password.ReadOnly = true;
                }
                label_expiry_msg.Visible = true;
            }
        }
    }
}
