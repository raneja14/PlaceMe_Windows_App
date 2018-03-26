using System;
using System.Windows.Forms;
using Placement_Application.Commons;

namespace Placement_Application
{
    public partial class Form_Welcome : Form
    {
        public Form_Welcome()
        {  
            InitializeComponent();
       //    this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {
            Placement_Application.Components.Resolution res = new Placement_Application.Components.Resolution();
            res.ResizeForm(this, Common.form_height, Common.form_width);
            timer1.Start();
            timer1.Interval = 1000;
            Control_Welcome welcomeControl = new Control_Welcome();
            welcomeControl.Dock = DockStyle.Fill;
            panel_main.Controls.Add(welcomeControl);
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult result= Dialog_MyMessageBox.Show(Constant.MESSAGE_EXIT,2);

            if(result==DialogResult.Yes)
                 Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void but_login_side_panel_Click(object sender, EventArgs e)
        {
            panel_main.Controls.Clear(); 
            Control_Login loginControl = new Control_Login(this);
            loginControl.Dock = DockStyle.Fill;
            panel_main.Controls.Add(loginControl);
        }

        private void but_welcome_side_panel_Click(object sender, EventArgs e)
        {
            panel_main.Controls.Clear();
            Control_Welcome welcomeControl = new Control_Welcome();
            welcomeControl.Dock = DockStyle.Fill;
            panel_main.Controls.Add(welcomeControl);
        }

        private void but_about_side_panel_Click(object sender, EventArgs e)
        {
            panel_main.Controls.Clear();
            Control_Shortcuts shortcutControl = new Control_Shortcuts();
            shortcutControl.Dock = DockStyle.Fill;
            panel_main.Controls.Add(shortcutControl);
        }
      
        private void but_contactUs_side_panel_Click(object sender, EventArgs e)
        {
            panel_main.Controls.Clear();
            Control_ContactUs contactusControl = new Control_ContactUs();
            contactusControl.Dock = DockStyle.Fill;
            panel_main.Controls.Add(contactusControl);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label_time.Text = DateTime.Now.ToString(Constant.TIME_FORMAT);
            label_date.Text = DateTime.Now.ToString(Constant.DATE_FORMAT);
        }

        private void panel_top_MouseMove(object sender, MouseEventArgs e)
        {
            Utility.dragForm(e, Handle);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {           
            if (keyData == (Keys.Control | Keys.P))
            {
                pictureBox1_Click(this.pictureBox_power, null);
            }
            else if (keyData == (Keys.Control | Keys.M))
            {
                pictureBox2_Click(this.pictureBox_minimise, null);
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
   
    }
}
