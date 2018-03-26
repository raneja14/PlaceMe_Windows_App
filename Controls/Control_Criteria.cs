using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Placement_Application.Commons;
using Placement_Application.Components;

namespace Placement_Application
{
    public partial class Control_Criteria : UserControl
    {
        private Form_Notification form_Notification;
        private bool isSelectAllChecked = false;
        private int status;
        private int diplomaAllowed;
        private bool isPlaced = false;
        private bool isDiplomaAllowed = false;
        private Dictionary<string, List<string>> branchMap;

        public Control_Criteria(Form_Notification form_Notification)
        {
             this.form_Notification = form_Notification;
             InitializeComponent();
        }

        private void Control_Criteria_Load(object sender, EventArgs e)
        {
            initaliseForm();
            resetToDefault();
        }

        private void but_reset_Click(object sender, EventArgs e)
        {
            resetToDefault();
        }

        private void resetToDefault()
        {
           // dropdown_degree.SelectedIndex = 0;
            numeric_arrears.Value = 0;
            numeric_cgpa.Value = 6;
            numeric_percent.Value = 50;
            numeric_x.Value = 50;
            numeric_xii.Value = 50;
            status = 0;
            diplomaAllowed = 0;
         //   but_status.PerformClick();

            if (listView1.CheckedIndices.Count > 0)
                selectNone();
        }

        private void but_next_Click(object sender, EventArgs e)
        {
            if (isFormValidated())
            {
                DialogResult result = Dialog_MyMessageBox.Show(Constant.NOTIFICATION_CONFIRM_CONTINUE_CRITERIA, 2);

                if (result == DialogResult.Yes)
                {
                    MyCriteria notifyCriteria = new MyCriteria();
                    notifyCriteria.batch = Common.loggedUser.myConfigObj.currentBatch;
                    notifyCriteria.degree = dropdown_degree.SelectedItem.ToString();
                    notifyCriteria.arrears =Convert.ToInt32(numeric_arrears.Value);
                    notifyCriteria.X = Convert.ToDouble(numeric_x.Value);
                    notifyCriteria.XII = Convert.ToDouble(numeric_xii.Value);
                    notifyCriteria.isPlaced = isPlaced;
                    notifyCriteria.isDiplomaAllowed = isDiplomaAllowed;
                    notifyCriteria.branch = getSelectedBranchList();

                    if (radio_cgpa.Checked)
                        notifyCriteria.cgpa = Convert.ToDouble(numeric_cgpa.Value);
                    else
                        notifyCriteria.cgpa = Convert.ToDouble(label_equiCgpa.Text);
                    
                    form_Notification.notification.CriteriaObj = notifyCriteria;
                    form_Notification.step++;
                    form_Notification.but_resultList.Enabled = true;
                    form_Notification.but_resultList.PerformClick();
                }
            }
        }

        private void populateList(String degree)
        {
            listView1.SuspendLayout();
            listView1.Items.Clear();
            listView1.View = View.Details;
            listView1.Columns.Add(EnumData.CriteriaListHeadings.ALL.ToString(), 50);
            listView1.Columns.Add(EnumData.CriteriaListHeadings.BRANCH.ToString(), 355);

            if (branchMap.ContainsKey(degree))
            {
                List<string> branchList = branchMap[degree];
                foreach (string branch in branchList)
                {
                    ListViewItem lv1 = new ListViewItem(string.Empty);
                    lv1.SubItems.Add(branch);
                    listView1.Items.Add(lv1);
                    lv1 = null;
                }
            }
            listView1.ResumeLayout();
       }

        private void dropdown_degree_SelectedIndexChanged(object sender, EventArgs e)
        {
            populateList(dropdown_degree.SelectedItem.ToString());
            isSelectAllChecked = false;
        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == 0 && isSelectAllChecked==false)
            {  
                selectAll();
            }
            else if (e.Column == 0 && isSelectAllChecked == true)
            {
                selectNone();
            }
        }

        private void selectAll()
        {
            foreach (ListViewItem item in listView1.Items)
            {
                item.Checked = true;
            }
            isSelectAllChecked = true;
        }

        private void selectNone()
        {
            foreach (ListViewItem item in listView1.Items)
            {
                item.Checked = false;
            }
            isSelectAllChecked = false;
        }

        private void listView1_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            label_checkCount.Text = listView1.CheckedIndices.Count + Labels.SELECTED;

            if (listView1.Items.Count > listView1.CheckedIndices.Count)
            {
                isSelectAllChecked = false;
                listView1.Columns[0].Text = EnumData.CriteriaListHeadings.ALL.ToString();
            }
            else
            {
                isSelectAllChecked = true;
                listView1.Columns[0].Text = EnumData.CriteriaListHeadings.NONE.ToString();
            }
        }

        private void but_status_Click(object sender, EventArgs e)
        {
            status++;
            if (status % 2 == 0)
            {
                isPlaced = false;
                but_status.BackColor = UiColors.NON_PLACED_COLOR;
                but_status.Text = Labels.NON_PLACED;
            }
            else
            {
                isPlaced = true;
                but_status.BackColor = UiColors.PLACED_COLOR;
                but_status.Text = Labels.PLACED_ALLOWED;
            }
        }

        private void initaliseForm()
        {
            branchMap = form_Notification.notifyManager.loadAllBranches();
            if (branchMap != null)
            {
                dropdown_degree.DataSource = branchMap.Keys.ToArray();
            }
        }

        private bool isFormValidated()
        {
            if (listView1.CheckedIndices.Count == 0)
            {
                Utility.showToolTip(new ToolTip(), listView1, Validations.VALIDATION_ZERO_BRANCH_SELECTED, Constant.TOOLTIP_TYPE_WARNING, null);
                return false;
            }
            else if (!Utility.isNetworkAvailable())
            {
                Dialog_MyMessageBox.Show(Validations.VALIDATION_NO_NETWORK, 1, UiColors.MESSAGE_ERROR);
                return false;
            }
            
            return true;
        }

        private List<string> getSelectedBranchList()
        {
            List<string> selectedList = new List<string>();
            foreach (ListViewItem selectedItem in listView1.CheckedItems)
            {
                selectedList.Add(selectedItem.SubItems[1].Text);
            }
            return selectedList;
        }

        private string cgpaToPercent(double cgpa)
        {
            var percent = Math.Round(cgpa * 9.5, 1);
            return percent.ToString();
        }

        private string percentToCgpa(double percent)
        {
            var cgpa = Math.Round(percent / 9.5, 1);
            return cgpa.ToString();
        }

        private void numeric_cgpa_ValueChanged(object sender, EventArgs e)
        {
            label_equiPercent.Text = cgpaToPercent(Convert.ToDouble(numeric_cgpa.Value)) + " %";
        }

        private void numeric_percent_ValueChanged(object sender, EventArgs e)
        {
            label_equiCgpa.Text = percentToCgpa(Convert.ToDouble(numeric_percent.Value));
        }

        private void radio_cgpa_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_cgpa.Checked)
            {
                label_cgpa.Visible = true;
                label_equiPercent.Visible = true;
                numeric_cgpa.Visible = true;

                label_percent.Visible = false;
                label_equiCgpa.Visible = false;
                numeric_percent.Visible = false;
            }
            else
            {
                label_cgpa.Visible = false;
                label_equiPercent.Visible = false;
                numeric_cgpa.Visible = false;

                label_percent.Visible = true;
                label_equiCgpa.Visible = true;
                numeric_percent.Visible = true;
            }
        }

        private void but_diplomaAllowed_Click(object sender, EventArgs e)
        {
            diplomaAllowed++;
            if (diplomaAllowed % 2 == 0)
            {
                isDiplomaAllowed = false;
                but_diplomaAllowed.BackColor = UiColors.NON_PLACED_COLOR;
                but_diplomaAllowed.Text = Labels.DIPLOMA_NOT_ALLOWED;
            }
            else
            {
                isDiplomaAllowed = true;
                but_diplomaAllowed.BackColor = UiColors.PLACED_COLOR;
                but_diplomaAllowed.Text = Labels.DIPLOMA_ALLOWED;
            }
        }

       
    }
}
