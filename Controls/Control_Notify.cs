using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Threading;
using Placement_Application.Components;
using Placement_Application.Commons;

namespace Placement_Application
{
    public partial class Control_Notify : UserControl
    {
        private Form_Notification form_Notification;
        private int seconds_left = 60;
        private ToolTip tooltip;
        private long OTP;
        private string notifyMsg;
        private DIalog_ProgressBar myProgressDialog;

        public Control_Notify(Form_Notification form_Notification)
        {
            InitializeComponent(); 
            this.form_Notification = form_Notification;
        }

        private void Control_Verify_Load(object sender, EventArgs e)
        {
            prepareDataForDB();
        }

        private void but_otp_Click(object sender, EventArgs e)
        {
            generateOTP();
            but_otp.Enabled = false;
            label_sec_msg.Visible = true;
            label_secLeft.Visible = true;
            timer_second.Start();
            text_otp.Text = string.Empty;
            but_verify.Enabled = true;
            but_otp.Text = Labels.BUT_TEXT_RESEND;
            text_otp.Focus();
        }

        private void timer_second_Tick(object sender, EventArgs e)
        {
            seconds_left -= 1;
            label_secLeft.Text = seconds_left.ToString();

            if (seconds_left < 1)
            {
                timer_second.Stop();
                seconds_left = 60;
                label_secLeft.Text = seconds_left.ToString();
                label_secLeft.Hide();
                label_sec_msg.Hide();
                but_otp.Enabled = true;
            }
        }

        private void but_verify_Click(object sender, EventArgs e)
        {
            if (string.Equals(OTP.ToString(), text_otp.Text))
            {
                Dialog_MyMessageBox.Show(Constant.NOTIFICATION_OTP_VERIFIED, 1, UiColors.MESSAGE_SUCCESS);
                groupBox_verify.Enabled = false;
                timer_second.Stop();
                label_secLeft.Hide();
                label_sec_msg.Hide();
                groupBox_notify.Visible = true;
            }
            else
            {
                Dialog_MyMessageBox.Show(Constant.NOTIFICATION_OTP_DECLINED, 1, UiColors.MESSAGE_ERROR);
                text_otp.Text = string.Empty;
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
                DialogResult result = Dialog_MyMessageBox.Show(Constant.NOTIFICATION_CONFIRM_CONTINUE_NOTIFY, 2);
                if (result == DialogResult.Yes)
                {
                    startBackgroundThread();
                }
            }
        }

        private void generateOTP()
        {
            OTP = Utility.generateRandomNumber(1000, 9999);
            Dialog_MyMessageBox.Show(OTP.ToString(), 1);
        }

        private void prepareDataForDB()
        {
            MyCriteria placementCriteria=form_Notification.notification.CriteriaObj;
            PlacementInfo placementInfoObj=form_Notification.notification.PlacementObj;
         
            populateCriteriaBox(placementCriteria);
            populatePlacementInfoBox(placementInfoObj);

            form_Notification.notification.criteria = Utility.convertObjectToByteArray(placementCriteria);
            notifyMsg = placementInfoObj.message;
            placementInfoObj.message = null;
            form_Notification.notification.placementInfo = Utility.convertObjectToByteArray(placementInfoObj);
            form_Notification.notification.eligibleStudentMap = Utility.convertObjectToByteArray
                                                        (form_Notification.notification.EligibleStudentMapObj);
        }

        private void populateCriteriaBox(MyCriteria placementCriteria)
        {
            label_batch.Text = placementCriteria.batch.ToString();
            label_degree.Text = placementCriteria.degree;
            label_cgpa.Text = placementCriteria.cgpa.ToString();
            label_branch.Text = placementCriteria.branch.Count.ToString();
            label_arrears.Text = placementCriteria.arrears.ToString();
            label_x.Text = placementCriteria.X.ToString() + "%";
            label_xii.Text = placementCriteria.XII.ToString() + "%";
            label_status.Text = (placementCriteria.isPlaced) ? Labels.PLACED_ALLOWED : Labels.NON_PLACED;
        }

        private void populatePlacementInfoBox(PlacementInfo placementInfoObj)
        {
            label_company.UseMnemonic = false;
            label_company.Text = Utility.getTrimText(placementInfoObj.companyName);
            label_date.Text = Utility.convertDateToString(placementInfoObj.DOR);
            label_venue.Text = Utility.getTrimText(placementInfoObj.venue);
            label_time.Text = placementInfoObj.time;
            label_msg.Text = Utility.getTrimText(placementInfoObj.message);
            label_eligible.Text = form_Notification.notification.CriteriaObj.eligibleCount.ToString() + Labels.STUDENTS;
         }

        private void label_company_MouseHover(object sender, EventArgs e)
        {
            if (tooltip == null)
                tooltip = new ToolTip();

            Utility.showToolTip(tooltip, label_company, form_Notification.notification.PlacementObj.companyName,
                Constant.TOOLTIP_TYPE_GENERAL, Labels.COMPANY);
        }

        private void label_venue_MouseHover(object sender, EventArgs e)
        {
            if (tooltip == null)
                tooltip = new ToolTip();

            Utility.showToolTip(tooltip, label_venue, form_Notification.notification.PlacementObj.venue,
                Constant.TOOLTIP_TYPE_GENERAL, Labels.VENUE);
        }

        private void label_msg_MouseHover(object sender, EventArgs e)
        {
            if (tooltip == null)
                tooltip = new ToolTip();

            Utility.showToolTip(tooltip, label_msg, notifyMsg,
                Constant.TOOLTIP_TYPE_GENERAL, Labels.MESSAGE);
        }

        private void text_otp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData.ToString().Equals("Return"))
            {
                but_verify.PerformClick();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Entity_Notification notificationObj = form_Notification.notification;
            notificationObj.notificationDate = DateTime.Now;
            notificationObj.staffId = Common.loggedUser.staffId;
            notificationObj.myConfigObj = Utility.getConfigObj();

            if(form_Notification.notifyManager.notifyStudents(notificationObj.StudentList,notifyMsg))
                e.Result = form_Notification.notifyManager.saveNotifications(notificationObj);
       }    
        
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            form_Notification.Opacity = 1;
            myProgressDialog.Dispose();
            if ((bool)e.Result)
                Dialog_MyMessageBox.Show(Constant.NOTIFICATION_NOTIFY_SUCCESS, 1, UiColors.MESSAGE_SUCCESS);
            else
                Dialog_MyMessageBox.Show(Constant.REQUEST_UNPROCESSED, 1, UiColors.MESSAGE_ERROR);

            but_notify.Enabled = false;
        }

        private void startBackgroundThread()
        {
            if (!backgroundWorker1.IsBusy)
            {
                myProgressDialog = new DIalog_ProgressBar();
                form_Notification.Opacity = 0.8;
                myProgressDialog.Show();
                backgroundWorker1.RunWorkerAsync();
            }
        }
       
    }
}
