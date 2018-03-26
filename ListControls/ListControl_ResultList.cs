using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Placement_Application.Commons;

namespace Placement_Application
{
    public partial class ListControl_ResultList : UserControl
    {
        private Form_Notification form_Notification;
        private IDictionary<string, IList<Entity_Student>> eligibleStudentsMap;
        private bool isFirstLoad;
        private List<Entity_Student> myList;

        public ListControl_ResultList(Form_Notification form_Notification, IDictionary<string, IList<Entity_Student>> filteredStudentMap)
        {
            InitializeComponent();
            this.form_Notification = form_Notification;
            this.eligibleStudentsMap = filteredStudentMap;
        }

        private void ListControl_ResultList_Load(object sender, EventArgs e)
        {
            isFirstLoad = true;
            prepareListView();

            if (eligibleStudentsMap != null)
                loadPaneTopInfo();
            else
            {
                dropdown_branch.Enabled = false;
                but_next.Enabled = false;
                Dialog_MyMessageBox.Show(Constant.MESSAGE_NO_DATA, 1, UiColors.MESSAGE_ERROR);
            }
        }

        private void populateResultList(List<Entity_Student> studentList)
        {
            listView1.SuspendLayout();
            listView1.Items.Clear();
           
            foreach (Entity_Student stuObj in studentList)
            {
                ListViewItem lv = new ListViewItem(stuObj.collegeId);
                lv.SubItems.Add(stuObj.studentName);
                lv.SubItems.Add(stuObj.gender);
                lv.SubItems.Add(stuObj.myConfigObj.currentDegree);
                lv.SubItems.Add(stuObj.myConfigObj.currentBatch); 
                lv.SubItems.Add(stuObj.branch);
                lv.SubItems.Add(stuObj.scoreObj.cgpa.ToString());
                lv.SubItems.Add(stuObj.scoreObj.X.ToString());
                lv.SubItems.Add(stuObj.scoreObj.XII.ToString());
                lv.SubItems.Add(stuObj.scoreObj.diploma.ToString());
                lv.SubItems.Add(stuObj.scoreObj.arrears.ToString());

                listView1.Items.Add(lv);
            }
            listView1.ResumeLayout();
            label_eligibleCount.Text = listView1.Items.Count + Labels.ELIGIBLE_STUDENTS_FOUND;
        }

        private void loadPaneTopInfo()
        {
            dropdown_branch.Items.Add(EnumData.CriteriaListHeadings.ALL.ToString());
            dropdown_branch.Items.AddRange(eligibleStudentsMap.Keys.ToArray());
            dropdown_branch.SelectedIndex = 0;
        }

        private void but_next_Click(object sender, EventArgs e)
        {
            DialogResult result = Dialog_MyMessageBox.Show(Constant.NOTIFICATION_CONFIRM_CONTINUE_LIST, 2);

            if (result == DialogResult.Yes)
            {
                form_Notification.step++;
                form_Notification.but_details.Enabled = true;
                form_Notification.but_details.PerformClick();
            }
        }

        private void dropdown_branch_SelectedIndexChanged(object sender, EventArgs e)
        {
            string branchKey = dropdown_branch.SelectedItem.ToString();
            populateResultList(getStudentList(branchKey));
        }

        private void prepareListView()
        {
            listView1.View = View.Details;

            listView1.Columns.Add(EnumData.StudentsListHeadings.COLLEGE_ID.ToString(), 100);
            listView1.Columns.Add(EnumData.StudentsListHeadings.NAME.ToString(), 150);
            listView1.Columns.Add(EnumData.StudentsListHeadings.GENDER.ToString(), 60);
            listView1.Columns.Add(EnumData.StudentsListHeadings.DEGREE.ToString(), 70);
            listView1.Columns.Add(EnumData.StudentsListHeadings.BATCH.ToString(), 70);
            listView1.Columns.Add(EnumData.StudentsListHeadings.BRANCH.ToString(), 135);
            listView1.Columns.Add(EnumData.StudentsListHeadings.CGPA.ToString(), 70);
            listView1.Columns.Add(EnumData.StudentsListHeadings.X.ToString() + " %", 65);
            listView1.Columns.Add(EnumData.StudentsListHeadings.XII.ToString() + " %", 65);
            listView1.Columns.Add(EnumData.StudentsListHeadings.DIPLOMA.ToString() + " %", 65);
            listView1.Columns.Add(EnumData.StudentsListHeadings.ARREARS.ToString(), 80);

            Utility.allocateEqualColumnWidth(listView1);
        }

        private List<Entity_Student> getStudentList(string branchKey)
        {
            if (dropdown_branch.SelectedIndex == 0)
            {
                if (isFirstLoad)
                {
                    IDictionary<string, int> studentMap = new Dictionary<string, int>();
                    myList = new List<Entity_Student>();
                    int studentCount = 0;
        
                    foreach (KeyValuePair<string, IList<Entity_Student>> entry in eligibleStudentsMap)
                    {
                        myList.AddRange(entry.Value);
                        studentMap.Add(entry.Key, entry.Value.Count);
                        studentCount += entry.Value.Count;
                    }
                    form_Notification.notification.EligibleStudentMapObj = studentMap;
                    form_Notification.notification.CriteriaObj.eligibleCount = studentCount;
                    form_Notification.notification.StudentList = myList;
                    isFirstLoad = false;
                }
                return myList;
            }
            else
            {
                return eligibleStudentsMap[branchKey].Cast<Entity_Student>().ToList();
            }
        }
    }
}
