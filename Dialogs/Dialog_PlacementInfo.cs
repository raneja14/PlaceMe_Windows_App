using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Placement_Application.Components;
using Placement_Application.Commons;

namespace Placement_Application.Dialogs
{
    public partial class Dialog_PlacementInfo : Form
    {
        private static Dialog_PlacementInfo dialogPlacementInfo;
        private static DialogResult result = DialogResult.Cancel;
        private static ToolTip tooltip;
        private static string venue;
        private static StringBuilder branchBulider;
        private static StringBuilder eligibleBulder;

        public Dialog_PlacementInfo()
        {
            InitializeComponent();
        }

        public static DialogResult Show(Entity_Notification notifyObject)
        {
            dialogPlacementInfo = new Dialog_PlacementInfo();
            //Placement_Application.Components.Resolution res = new Placement_Application.Components.Resolution();
            //res.ResizeForm(dialogPlacementInfo, 522, 359);
    
            dialogPlacementInfo.Opacity = Common.dialogOpacity;
            venue = notifyObject.PlacementObj.venue;
            dialogPlacementInfo.populateCriteriaBox(notifyObject.CriteriaObj);
            dialogPlacementInfo.populatePlacementInfoBox(notifyObject.PlacementObj);
            dialogPlacementInfo.setBuilders(notifyObject);
          
            dialogPlacementInfo.ShowDialog();
            return result;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void populateCriteriaBox(MyCriteria placementCriteria)
        {
            label_degree.Text = placementCriteria.degree;
            label_cgpa.Text = placementCriteria.cgpa.ToString();
            label_branch.Text = placementCriteria.branch.Count.ToString();
            label_arrears.Text = placementCriteria.arrears.ToString();
            label_x.Text = placementCriteria.X.ToString() + "%";
            label_xii.Text = placementCriteria.XII.ToString() + "%";
            label_status.Text = (placementCriteria.isPlaced) ? Labels.PLACED_ALLOWED : Labels.NON_PLACED;
            label_eligible.Text = placementCriteria.eligibleCount.ToString() + Labels.STUDENTS;
        }

        private void populatePlacementInfoBox(PlacementInfo placementInfoObj)
        {
            label_date.Text = Utility.convertDateToString(placementInfoObj.DOR);
            label_venue.Text = Utility.getTrimText(venue);
            label_time.Text = placementInfoObj.time;
        }

        private void setBuilders(Entity_Notification notifyObject)
        {
            branchBulider= new StringBuilder();
            foreach (string item in notifyObject.CriteriaObj.branch)
                branchBulider.AppendLine(item);

            eligibleBulder = new StringBuilder();
            foreach (KeyValuePair<string, int> entry in notifyObject.EligibleStudentMapObj)
            {
                eligibleBulder.Append(entry.Key)
                    .Append("  =>  ")
                    .AppendLine(entry.Value.ToString());
            }
        }

        private void label_venue_MouseHover(object sender, EventArgs e)
        {
            if (tooltip == null)
                tooltip = new ToolTip();

            Utility.showToolTip(tooltip, label_venue, venue,
                Constant.TOOLTIP_TYPE_GENERAL, Labels.VENUE);
        }

        private void label_eligible_MouseHover(object sender, EventArgs e)
        {
            if (tooltip == null)
                tooltip = new ToolTip();

            Utility.showToolTip(tooltip, label_eligible, eligibleBulder.ToString(),
                Constant.TOOLTIP_TYPE_GENERAL, Labels.ELIGIBLE);
        }

        private void label_branch_MouseHover(object sender, EventArgs e)
        {
            if (tooltip == null)
                tooltip = new ToolTip();

            Utility.showToolTip(tooltip, label_branch, branchBulider.ToString(),
                Constant.TOOLTIP_TYPE_GENERAL, Labels.BRANCH);
        }
    }
}
