using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Placement_Application.Commons;
using Placement_Application.Controls;
using Placement_Application.Service;
using Placement_Application.Components;

namespace Placement_Application
{
    public partial class Form_Home : Form
    {
        private Form_Welcome mainForm;
        private Entity_Staff loggedUser;
        private NotificationManager notificationManager;
        private DIalog_ProgressBar myProgressDialog;
        public int notificationCount = 0;
      
        public Form_Home(Form_Welcome mainform)
        {   
            this.mainForm = mainform;
            this.loggedUser = Common.loggedUser;
            InitializeComponent();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {

            Resolution resolution = new Resolution();
            resolution.ResizeForm(this, Common.form_height, Common.form_width);
            ////pictureBox_notification.Visible = false;
            //label_notification_count.Visible = false;

            timer1.Start();
            timer1.Interval = 1000;

            if (Common.loggedUser.staffId == Common.adminId)
                but_manageUsers_sidePanel.Visible = true;

            if (Common.loggedUser.myConfigObj.currentBatch.Equals(Constant.NOT_APPLICABLE))
            {
                Common.isAppConfigured = false;
            }
            else
            {
                Common.isAppConfigured = true;
                label_top_batch.Visible = true;
                this.label_top_batch.Text = Utility.getConfigLabel();
                openHomeControl();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult result = Dialog_MyMessageBox.Show(Constant.MESSAGE_EXIT, 2);

            if (result == DialogResult.Yes)
                Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            panel_main.Controls.Clear();
            Control_Home homeControl = new Control_Home(this);
            homeControl.Dock = DockStyle.Fill;
            panel_main.Controls.Add(homeControl);
        }

        private void but_home_side_panel_Click(object sender, EventArgs e)
        {
            if (Common.isAppConfigured)
            {
                openHomeControl();
            }
            else
            {
                displayConfigureHint();
            }
        }

        private void but_logout_side_panel_Click(object sender, EventArgs e)
        {
            DialogResult result = Dialog_MyMessageBox.Show(Constant.MESSAGE_LOGOUT, 2);

            if (result == DialogResult.Yes)
            {
                this.Close();
                loggedUser = null;
                mainForm.Show();
            }
        }

        private void but_user_side_panel_Click(object sender, EventArgs e)
        {
            panel_main.Controls.Clear();
            Control_UserAccount useraccountControl = new Control_UserAccount();
            useraccountControl.Dock = DockStyle.Fill;
            panel_main.Controls.Add(useraccountControl);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label_time.Text = DateTime.Now.ToString(Constant.TIME_FORMAT);
            label_date.Text = DateTime.Now.ToString(Constant.DATE_FORMAT);
        }

        private void but_settings_side_panel_Click(object sender, EventArgs e)
        {
            panel_main.Controls.Clear();
            Control_Settings1 settingsControl = new Control_Settings1(this);
            settingsControl.Dock = DockStyle.Fill;
            panel_main.Controls.Add(settingsControl);
        }

        private void panel_top_MouseMove(object sender, MouseEventArgs e)
        {
            Utility.dragForm(e, Handle);
        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            Utility.dragForm(e, Handle);
        }

        private void pictureBox_notification_Click(object sender, EventArgs e)
        {
            if (Common.isAppConfigured)
                startBackgroundThread(true);
            else
            {
                displayConfigureHint();
            }
        }

        public void setNotificationLabelFromDb()
        {
            notificationManager = new NotificationManagerImpl();
            notificationCount = notificationManager.getNotificationCount();
            label_notification_count.Text = notificationCount.ToString();
        }

        public void decrementNotification()
        {
            if (notificationCount > 0)
            {
                notificationCount--;
                label_notification_count.Text = notificationCount.ToString();
            }
        }

        private FlowLayoutPanel getFlowPanel()
        {
            FlowLayoutPanel flowPanel = new FlowLayoutPanel();
            flowPanel.BackColor = Utility.getColorFromHex(UiColors.LOGO_PANEL_COLOR);
         //   flowPanel.Width = Common.main_panel_width;
            flowPanel.Height = Common.main_panel_height;
            flowPanel.FlowDirection = FlowDirection.LeftToRight;
            flowPanel.AutoScroll = true;
            flowPanel.Dock = DockStyle.Fill;
            return flowPanel;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            List<Entity_Notification> notificationList = notificationManager.loadAllNotifications();

            if (notificationList != null)
            {
                List<Entity_UserNotification> userNotificationList =
                    notificationManager.loadAllUserNotification(Common.loggedUser.staffId);

                if (userNotificationList != null)
                {
                    IDictionary<long, Entity_Notification> notifyMap = new Dictionary<long, Entity_Notification>();
                    foreach (Entity_Notification notifyObj in notificationList)
                    {
                        notifyMap.Add(notifyObj.notificationId, notifyObj);
                    }
                 
                    foreach (Entity_UserNotification userNotifyObj in userNotificationList)
                    {
                        notifyMap[userNotifyObj.notificationId].IsRead = true;
                        notifyMap[userNotifyObj.notificationId].ViewedDate = userNotifyObj.viewDate;
                    }
                }
           }
            e.Result = notificationList;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            var notificationList = (List<Entity_Notification>)e.Result;
            if (notificationList != null)
            {
                FlowLayoutPanel flowPanel = getFlowPanel();
                panel_main.Controls.Clear();
                
                for (int i = 0; i < notificationList.Count; i++)
                {
                    Notification_template _template = new Notification_template(i, notificationList[i], this);
                    _template.Dock = DockStyle.Top;
                    flowPanel.Controls.Add(_template);
                }
                panel_main.Controls.Add(flowPanel);
                flowPanel.Focus();
             
                myProgressDialog.Dispose();
            }
            else
            {
                myProgressDialog.Dispose();
                Dialog_MyMessageBox.Show(Constant.MESSAGE_NO_DATA, 1, UiColors.MESSAGE_ERROR);
            }
            this.Opacity = 1;
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

        private void displayConfigureHint()
        {
            Dialog_MyMessageBox.Show(Constant.MISSING_CONFIGURATION, 1, UiColors.MESSAGE_ERROR);
            Utility.showToolTip(new ToolTip(), but_settings_side_panel, Constant.HINT_CONGIFURE_HERE,
                   Constant.TOOLTIP_TYPE_INFO, Constant.HINT);
        }

        private void openHomeControl()
        {
            panel_main.Controls.Clear();
            Control_Home homeControl = new Control_Home(this);
            homeControl.Dock = DockStyle.Fill;
            panel_main.Controls.Add(homeControl);
            
            //if (notificationManager == null)
            //    setNotificationLabelFromDb();
         }

        private void but_manageUsers_sidePanel_Click(object sender, EventArgs e)
        {
            if (!Utility.isNetworkAvailable())
            {
                Dialog_MyMessageBox.Show(Validations.VALIDATION_NO_NETWORK, 1, UiColors.MESSAGE_ERROR);
            }
            else
            {
                panel_main.Controls.Clear();
                ListControl_ViewUsers viewUsers = new ListControl_ViewUsers(this);
                viewUsers.Dock = DockStyle.Fill;
                panel_main.Controls.Add(viewUsers);
            }
        }

        private void notifyIcon_MouseDown(object sender, MouseEventArgs e)
        {
            this.notifyIcon.Visible = true;
        }
        
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.L))
            {
                but_logout_side_panel.PerformClick();
            }
            else if (keyData == (Keys.Control | Keys.H))
            {
                but_home_side_panel.PerformClick();
            }
            else if(keyData==(Keys.Control | Keys.P))
            {
                pictureBox1_Click(this.pictureBox_power, null);
            }
            else if (keyData == (Keys.Control | Keys.M))
            {
                pictureBox2_Click(this.pictureBox_minimise, null);
            }
            else if (keyData == (Keys.Control | Keys.N))
            {
                pictureBox_notification_Click(this.pictureBox_notification, null);
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

      
    }
}
