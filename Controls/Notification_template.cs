using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Placement_Application.Commons;
using Placement_Application.Components;
using Placement_Application.Properties;
using Placement_Application.Dialogs;
using Placement_Application.Service;

namespace Placement_Application.Controls
{
    public partial class Notification_template : UserControl
    {
        private Entity_Notification notifyObj;
        private NotificationManager notificationManager;
        private Form_Home homeForm;

        public Notification_template(int count,Entity_Notification notifyObj,Form_Home homeForm)
        {
            this.homeForm = homeForm;
            this.notifyObj = notifyObj;
            setNotificationObj();
        
            InitializeComponent();
            
            setTemplate();
            setNotifyIconForRow(count);
        }

        private void setNotifyIconForRow(int count)
        {
            int index = count % EnumData.notificatioTemplateImages.Length ;
            object img = Resources.ResourceManager.GetObject(EnumData.notificatioTemplateImages[index]);
            notifyIcon.Image = (Image)img;
        }

        private void Notification_template_Click(object sender, EventArgs e)
        {
            Dialog_PlacementInfo.Show(notifyObj);
            setAttributesOnClick();
        }

        private void Notification_template_MouseLeave(object sender, EventArgs e)
        {
            setBackColor();
            label_company.ForeColor = Utility.getColorFromHex(UiColors.APPLICATION_DEFAULT_TOP_PANE);
            label2.ForeColor = Utility.getColorFromHex(UiColors.APPLICATION_DEFAULT_TOP_PANE);
            label3.ForeColor = Utility.getColorFromHex(UiColors.APPLICATION_DEFAULT_TOP_PANE);
            label4.ForeColor = Utility.getColorFromHex(UiColors.APPLICATION_DEFAULT_TOP_PANE);
            label_viewDate.ForeColor = Utility.getColorFromHex(UiColors.APPLICATION_DEFAULT_TOP_PANE);
        }

        private void label_staff_MouseMove(object sender, MouseEventArgs e)
        {
            this.BackColor = Utility.getColorFromHex(UiColors.APPLICATION_DEFAULT_TOP_PANE);
            label_company.ForeColor = Utility.getColorFromHex(UiColors.NOTIFCATION_TEMPLATE_HOVER_LABEL_COLOR_GOLD);
            label2.ForeColor = Color.Snow;
            label3.ForeColor = Color.Snow;
            label4.ForeColor = Color.Snow;
            label_viewDate.ForeColor = Color.Snow;
        }

        private void setTemplate()
        {
            //this.Width = Common.notification_template_width;
            this.Height = Common.notification_template_height;
            this.Width = homeForm.panel_main.Width - 6;
            
            setBackColor();
        }

        private void setNotificationObj()
        {
            notifyObj.CriteriaObj = (MyCriteria) Utility.ConvertByteArrayToObject(notifyObj.criteria);
            notifyObj.PlacementObj = (PlacementInfo)Utility.ConvertByteArrayToObject(notifyObj.placementInfo);
            notifyObj.EligibleStudentMapObj = (IDictionary<string, int>)Utility.ConvertByteArrayToObject(notifyObj.eligibleStudentMap);
        }

        private void setBackColor()
        {
            if (this.notifyObj.IsRead)
            {
                this.BackColor = Utility.getColorFromHex(UiColors.NOTIFCATION_TEMPLATE_BACK_COLOR_READ);
                this.label_viewDate.Visible = true;
                this.label_viewDateVal.Visible = true;
                this.label_viewedTime.Visible = true;
                this.label_viewDateVal.Text = Utility.convertDateToString(this.notifyObj.ViewedDate);
                this.label_viewedTime.Text = Utility.convertTimeToString(this.notifyObj.ViewedDate);
            }
            else
            {
                this.BackColor = Utility.getColorFromHex(UiColors.NOTIFCATION_TEMPLATE_BACK_COLOR_UNREAD);
            }
        }

        private void setAttributesOnClick()
        {
            if (!this.notifyObj.IsRead)
            {
                this.notifyObj.IsRead = true;
                homeForm.decrementNotification();
                this.notifyObj.ViewedDate = DateTime.Now;
                setBackColor();
                markNotificationAsRead();
            }
       }

        private void markNotificationAsRead()
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void Notification_template_Load_1(object sender, EventArgs e)
        {
            this.label_company.Text = notifyObj.PlacementObj.companyName;
            this.label_date.Text = Utility.convertDateToString(notifyObj.notificationDate);
            this.label_staff.Text = notifyObj.staffObj.staffName;
            this.label_studentCount.Text = notifyObj.CriteriaObj.eligibleCount + Labels.STUDENTS;
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            var userNotifyObj = new Entity_UserNotification();
            userNotifyObj.myConfigObj = Utility.getConfigObj();
            userNotifyObj.viewDate = DateTime.Now;
            userNotifyObj.staffId = Common.loggedUser.staffId;
            userNotifyObj.notificationId = this.notifyObj.notificationId;

            if (notificationManager == null)
                notificationManager = new NotificationManagerImpl();

            notificationManager.saveUserNotification(userNotifyObj);
        }
    }
}
