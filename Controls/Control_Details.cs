using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Placement_Application.Components;
using Placement_Application.Commons;

namespace Placement_Application
{
    public partial class Control_Details : UserControl
    {
        private Form_Notification form_Notification;
        private ToolTip tooltip;
        private PlacementInfo placementInfo;
        private Dictionary<string, Entity_CompanyDetails> compMap;

        public Control_Details(Form_Notification form_Notification, List<Entity_CompanyDetails> compList)
        {
            InitializeComponent();
            this.form_Notification = form_Notification;
            getPossibleCompanies(compList);
        }

        private void Control_Details_Load(object sender, EventArgs e)
        {
            dropdown_am_pm.SelectedIndex = 0;
            dropdown_company.SelectedIndex = 0;
        }
       
        private void but_msg_Click(object sender, EventArgs e)
        {
            groupBox_msg.Visible = true;
            generateMsg();
        }

        private void textBox_venue_Leave(object sender, EventArgs e)
        {
            if (textBox_venue.Text == string.Empty)
            {
                but_msg.Enabled = false;
                groupBox_msg.Hide();
            }
            else
                but_msg.Enabled = true;
        }

        private void generateMsg()
        {
            if (placementInfo == null)
                placementInfo = new PlacementInfo();

            placementInfo.companyName = dropdown_company.SelectedItem.ToString();
            placementInfo.DOR = dateTime_date.Value;
            placementInfo.time = (numeric_hr.Value < 10 ? "0" + numeric_hr.Value.ToString() : numeric_hr.Value.ToString()) + ":" + (numeric_min.Value < 10 ? "0" + numeric_min.Value.ToString() : numeric_min.Value.ToString()) + " " + dropdown_am_pm.SelectedItem.ToString();
            placementInfo.venue = textBox_venue.Text;

            string msg = Labels.NOTIFY_MESSAGE;
            msg = Utility.replaceKeyword(msg, Constant.MSG_ITEM_COMPANY_NAME, placementInfo.companyName);
            msg = Utility.replaceKeyword(msg, Constant.MSG_ITEM_VENUE, placementInfo.venue);
            msg = Utility.replaceKeyword(msg, Constant.MSG_ITEM_DATE, Utility.convertDateToString(placementInfo.DOR));
            msg = Utility.replaceKeyword(msg, Constant.MSG_ITEM_TIME, placementInfo.time);
            msg = Utility.replaceKeyword(msg, Constant.MSG_ITEM_HOME_COLLEGE, Common.homeCollege);

            placementInfo.message = msg;
            text_msg_content.Text = placementInfo.message;
        }

        private void but_msg_MouseHover(object sender, EventArgs e)
        {
            if (tooltip == null)
                tooltip = new ToolTip();

              tooltip.Show(Constant.TOOLTIP_GENERATE_MESSAGE, but_msg, 800);
        }

        private void but_next_Click(object sender, EventArgs e)
        {
            DialogResult result = Dialog_MyMessageBox.Show(Constant.NOTIFICATION_CONFIRM_CONTINUE_MESSAGE, 2);

            if (result == DialogResult.Yes)
            {
                placementInfo.message = text_msg_content.Text;
                form_Notification.notification.PlacementObj = placementInfo;
                form_Notification.step++; 
                form_Notification.but_notify.Enabled = true;
                form_Notification.but_notify.PerformClick();
            }
        }

        private void dropdown_company_Leave(object sender, EventArgs e)
        {
            if (dropdown_company.SelectedItem==null)
            {
                Utility.showToolTip(new ToolTip(), dropdown_company, Validations.VALIDATION_VALUE_NOT_EXIST, Constant.TOOLTIP_TYPE_WARNING, null);
                dropdown_company.Focus();
            }
        }

        private void getPossibleCompanies(List<Entity_CompanyDetails> compList)
        {
            AutoCompleteStringCollection compNames = new AutoCompleteStringCollection();
            compMap = new Dictionary<string, Entity_CompanyDetails>();
            if (compList != null && compList.Count > 0)
            {
                foreach (Entity_CompanyDetails compDetailObj in compList)
                {
                    dropdown_company.Items.Add(compDetailObj.companyObj.companyName);
                    compMap.Add(compDetailObj.companyObj.companyName, compDetailObj);
                    compNames.Add(compDetailObj.companyObj.companyName);
                }
                dropdown_company.AutoCompleteCustomSource = compNames;
            }
        }

        private void dropdown_company_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCompanyName = (dropdown_company.SelectedItem == null) ?
               string.Empty : dropdown_company.SelectedItem.ToString();

            DateTime date = compMap[selectedCompanyName].DOR;
            dateTime_date.Value = date;
        }

    }
}
