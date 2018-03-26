using Placement_Application.Commons;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Placement_Application.Service;

namespace Placement_Application
{
    public partial class Form_Notification : Form
    {
        private Form_Home homeform;
        private DIalog_ProgressBar myProgressDialog;
        public int step = 0;
        public Entity_Notification notification;
        private ListControl_ResultList control_branch;
        public NotificationManager notifyManager;

        public Form_Notification(Form_Home homeform)
        {
            InitializeComponent();
            this.homeform = homeform;
        }

        private void Form_Notification_Load(object sender, EventArgs e)
        {
            Placement_Application.Components.Resolution res = new Placement_Application.Components.Resolution();
            res.ResizeForm(this, Common.form_height, Common.form_width);
            timer1.Start();
            timer1.Interval = 1000;
            this.label_top_batch.Text = Utility.getConfigLabel();
            notification = new Entity_Notification();
            notifyManager = new NotificationManagerImpl();
            resetButtonControls();
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            label_time.Text = DateTime.Now.ToString(Constant.TIME_FORMAT);
            label_date.Text = DateTime.Now.ToString(Constant.DATE_FORMAT);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            homeform.Show();
            //homeform.setNotificationLabelFromDb();
            this.Close();
        }

        private void panel_top_MouseMove(object sender, MouseEventArgs e)
        {
            Utility.dragForm(e, Handle);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            resetButtonControls();
        }

        private void changeToActive(Button button)
        {
            button.Enabled = true;
            button.FlatAppearance.MouseDownBackColor = Utility.getColorFromHex(UiColors.NOTIFICATION_ACTIVE_BUTTON_BACK_COLOR_BLUE_HIGHLIGHT);
            button.FlatAppearance.MouseOverBackColor = Utility.getColorFromHex(UiColors.NOTIFICATION_ACTIVE_BUTTON_MOUSEOVER_BACK_COLOR);
            button.BackColor = Utility.getColorFromHex(UiColors.NOTIFICATION_ACTIVE_BUTTON_BACK_COLOR_BLUE_HIGHLIGHT);
            button.Tag = Constant.BUTTON_ACTIVE;
        }

        private void changeToVisited(Button button)
        {
            button.FlatAppearance.MouseDownBackColor = Utility.getColorFromHex(UiColors.NOTIFICATION_VISITED_BUTTON_BACK_COLOR);
            button.FlatAppearance.MouseOverBackColor = Utility.getColorFromHex(UiColors.NOTIFICATION_VISITED_BUTTON_MOUSEOVER_BACK_COLOR);
            button.BackColor = Utility.getColorFromHex(UiColors.NOTIFICATION_VISITED_BUTTON_BACK_COLOR);
            button.Tag = Constant.BUTTON_VISITED;
        }

        private void changeToDefault(Button button)
        {
            if (button.Name == "but_criteria")
            {
                changeToActive(but_criteria);
                openControlCriteria();
            }
            else
            {
                button.Enabled = false;
                button.FlatAppearance.MouseDownBackColor = Utility.getColorFromHex(UiColors.NOTIFICATION_DISABLED_BUTTON_BACK_COLOR);
                button.FlatAppearance.MouseOverBackColor = Utility.getColorFromHex(UiColors.NOTIFICATION_DISABLED_BUTTON_MOUSEOVER_BACK_COLOR);
                button.BackColor = Utility.getColorFromHex(UiColors.NOTIFICATION_DISABLED_BUTTON_BACK_COLOR);
                button.Tag = Constant.BUTTON_DISABLED;
            }
        }

        public void resetButtonControls()
        {
            foreach (Button button in panel_left.Controls)
                changeToDefault(button);

            step = 0;
        }

        private void but_criteria_Click(object sender, EventArgs e)
        {
            if (step < 1 && but_criteria.Tag.ToString() != Constant.BUTTON_ACTIVE)
                openControlCriteria();
        }

        private void openControlCriteria()
        {
            panel_main.Controls.Clear();

            Control_Criteria control_criteria = new Control_Criteria(this);
            control_criteria.Dock = DockStyle.Fill;
            panel_main.Controls.Add(control_criteria);
        }

        private void but_resultList_Click(object sender, EventArgs e)
        {
            if (step < 2 && but_resultList.Tag.ToString().Equals(Constant.BUTTON_DISABLED))
            {
                changeToActive(but_resultList);
                changeToVisited(but_criteria);
               
                panel_main.Controls.Clear();
                startBackgroundThread(true);
            }
        }

        private void but_details_Click(object sender, EventArgs e)
        {
            if (step < 3 && but_details.Tag.ToString().Equals(Constant.BUTTON_DISABLED))
            {
                changeToActive(but_details);
                changeToVisited(but_resultList);

                panel_main.Controls.Clear();
                startBackgroundThread(true);
            }
        }

        private void but_notify_Click(object sender, EventArgs e)
        {
            if (step < 4 && but_notify.Tag.ToString().Equals(Constant.BUTTON_DISABLED))
            {
                changeToActive(but_notify);
                changeToVisited(but_details);

                panel_main.Controls.Clear();

                Control_Notify control_notify = new Control_Notify(this);
                control_notify.Dock = DockStyle.Fill;
                panel_main.Controls.Add(control_notify);

            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            switch (step)
            {
                case 1:
                    e.Result = notifyManager.filteredStudentList(notification.CriteriaObj);
                    break;
                case 2:
                    CompanyManager compManager = new CompanyManagerImpl();
                    e.Result = compManager.getCompanyNamesWithDetailId(false);
                    break;
                default:
                    break;
            }
       }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Opacity = 1;
            pictureBox_home.Enabled = true;
            myProgressDialog.Dispose();
            switch (step)
            {
                case 1:
                    control_branch = new ListControl_ResultList
                        (this, (IDictionary<string, IList<Entity_Student>>)e.Result);
                    control_branch.Dock = DockStyle.Fill;
                    panel_main.Controls.Add(control_branch);
                    break;
                case 2:
                    if (e.Result == null)
                    {
                        Dialog_MyMessageBox.Show(Constant.NO_COMPANY_TO_NOTIFY, 1, UiColors.MESSAGE_ERROR);
                    }
                    else
                    {
                        var control_details = new Control_Details
                                        (this, (List<Entity_CompanyDetails>)e.Result);
                        control_details.Dock = DockStyle.Fill;
                        panel_main.Controls.Add(control_details);
                    } break;
                default:
                    break;
            }
        }

        private void startBackgroundThread(bool dialogRequired)
        {
            if (!backgroundWorker1.IsBusy)
            {
                if (dialogRequired)
                {
                    myProgressDialog = new DIalog_ProgressBar();
                    this.Opacity = 0.8;
                    pictureBox_home.Enabled = false;
                    myProgressDialog.Show();
                }
                backgroundWorker1.RunWorkerAsync();
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (step == 1 && keyData == (Keys.Control | Keys.E))
            {
                DialogResult result = Dialog_MyMessageBox.Show(Constant.MESSAGE_EXCEL_EXPORT, 2);
                if (result == DialogResult.Yes)
                {
                    Utility.exportToExcel(control_branch.listView1,homeform);
                    return true;
                }
            }
            else if (keyData == (Keys.Control | Keys.P))
            {
                pictureBox1_Click(this.pictureBox_power, null);
            }
            else if (keyData == (Keys.Control | Keys.M))
            {
                pictureBox2_Click(this.pictureBox_minimise, null);
            }
            else if (keyData == (Keys.Control | Keys.H))
            {
                pictureBox4_Click(this.pictureBox_home, null);
            }
            else if (keyData == (Keys.Control | Keys.R))
            {
                pictureBox5_Click(this.pictureBox_refresh, null);
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
