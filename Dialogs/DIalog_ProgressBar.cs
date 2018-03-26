using System;
using System.Windows.Forms;

namespace Placement_Application
{
    public partial class DIalog_ProgressBar : Form
    {
        public int ProgressValue
        {
            set { progressBar1.Value = value; }
        }

        public DIalog_ProgressBar()
        {
            InitializeComponent();
        }

        private void DIalog_ProgressBar_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
        }
    }
}
