using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Placement_Application.Commons;

namespace Placement_Application
{
    public partial class ListControl_PlacementStatus : UserControl
    {
        private Form_UpdatePlacementStatus updateStatus;
        private List<Entity_Student> studentList;

        public ListControl_PlacementStatus(Form_UpdatePlacementStatus updateStatus, List<Entity_Student> studentList)
        {
            this.updateStatus = updateStatus;
            this.studentList = studentList;
            InitializeComponent();
        }

        private void ListPlacementStatusControl_Load(object sender, EventArgs e)
        {
            prepareList();
            populateList();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (!Utility.isNetworkAvailable())
            {
                Dialog_MyMessageBox.Show(Validations.VALIDATION_NO_NETWORK, 1, UiColors.MESSAGE_ERROR);
            }
            else
            {
                Entity_Student studentObj = listView1.SelectedItems[0].Tag as Entity_Student;
                updateStatus.panel_search.Hide();
                DialogResult result = Dialog_UpdateStudentCompany.Show(studentObj);

                if (result == DialogResult.Yes)
                {
                    Dialog_MyMessageBox.Show(Constant.UPDATE_SUCCESS, 1, UiColors.MESSAGE_SUCCESS);
                    updateStatus.placementStatusUpdated = true;
                }
                else if (result == DialogResult.No)
                {
                    Dialog_MyMessageBox.Show(Constant.DATA_EXISTS, 1, UiColors.MESSAGE_ERROR);
                }
                updateStatus.panel_search.Show();
            }
        }
        private void prepareList()
        {
            listView1.GridLines = true;
            listView1.View = View.Details;

            listView1.Columns.Add(EnumData.StudentsListHeadings.Sr_No.ToString(), 60);
            listView1.Columns.Add(EnumData.StudentsListHeadings.COLLEGE_ID.ToString(), 100);
            listView1.Columns.Add(EnumData.StudentsListHeadings.NAME.ToString(), 180);
            listView1.Columns.Add(EnumData.StudentsListHeadings.GENDER.ToString(), 100);
            listView1.Columns.Add(EnumData.StudentsListHeadings.BRANCH.ToString(), 140);
            listView1.Columns.Add(EnumData.StudentsListHeadings.DEGREE.ToString(), 90);
            listView1.Columns.Add(EnumData.StudentsListHeadings.PLACED_COUNT.ToString(), 100);
          
            Utility.allocateEqualColumnWidth(listView1);
        }

        private void populateList()
        {
            if (studentList != null && studentList.Count > 0)
            {
                listView1.SuspendLayout();
                int count = 0;
                ListViewItem lv;
                listView1.Items.Clear();
                AutoCompleteStringCollection studentIds = new AutoCompleteStringCollection();
                foreach (Entity_Student studentObj in studentList)
                {
                    lv = new ListViewItem((++count).ToString());
                    lv.SubItems.Add(studentObj.collegeId);
                    lv.SubItems.Add(studentObj.studentName);
                    lv.SubItems.Add(studentObj.gender);
                    lv.SubItems.Add(studentObj.branch);
                    lv.SubItems.Add(studentObj.myConfigObj.currentDegree);
                    lv.SubItems.Add(studentObj.placedDetailsObj.Count.ToString());
             
                    lv.Tag = studentObj;

                    listView1.Items.Add(lv);
                    studentIds.Add((studentObj.collegeId));
                }
                listView1.ResumeLayout();
                updateStatus.textBox_search.AutoCompleteCustomSource = studentIds;
            }
            else
            {
                Dialog_MyMessageBox.Show(Constant.MESSAGE_NO_DATA, 1,UiColors.MESSAGE_ERROR);
            }
        }
     
    }
}
