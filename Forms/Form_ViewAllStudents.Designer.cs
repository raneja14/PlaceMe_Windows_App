namespace Placement_Application
{
    partial class Form_ViewAllStudents
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ViewAllStudents));
            this.panel_left = new System.Windows.Forms.Panel();
            this.panel_search = new System.Windows.Forms.Panel();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.button_search = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.panel_logo = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel_top = new System.Windows.Forms.Panel();
            this.label_top_batch = new System.Windows.Forms.Label();
            this.label_tool3 = new System.Windows.Forms.Label();
            this.label_tool2 = new System.Windows.Forms.Label();
            this.label_tool1 = new System.Windows.Forms.Label();
            this.pictureBox_refresh = new System.Windows.Forms.PictureBox();
            this.label_date = new System.Windows.Forms.Label();
            this.label_time = new System.Windows.Forms.Label();
            this.pictureBox_home = new System.Windows.Forms.PictureBox();
            this.pictureBox_minimise = new System.Windows.Forms.PictureBox();
            this.pictureBox_power = new System.Windows.Forms.PictureBox();
            this.panel_main = new System.Windows.Forms.Panel();
            this.tabView = new System.Windows.Forms.TabControl();
            this.tabPage_placed = new System.Windows.Forms.TabPage();
            this.listView_placed = new System.Windows.Forms.ListView();
            this.tabPage_nonPlaced = new System.Windows.Forms.TabPage();
            this.listView_nonPlaced = new System.Windows.Forms.ListView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel_left.SuspendLayout();
            this.panel_search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.button_search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_refresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_minimise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_power)).BeginInit();
            this.panel_main.SuspendLayout();
            this.tabView.SuspendLayout();
            this.tabPage_placed.SuspendLayout();
            this.tabPage_nonPlaced.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_left
            // 
            this.panel_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.panel_left.Controls.Add(this.panel_search);
            this.panel_left.Controls.Add(this.pictureBox6);
            this.panel_left.Controls.Add(this.panel_logo);
            resources.ApplyResources(this.panel_left, "panel_left");
            this.panel_left.Name = "panel_left";
            // 
            // panel_search
            // 
            this.panel_search.BackColor = System.Drawing.SystemColors.Control;
            this.panel_search.Controls.Add(this.textBox_search);
            this.panel_search.Controls.Add(this.button_search);
            resources.ApplyResources(this.panel_search, "panel_search");
            this.panel_search.Name = "panel_search";
            // 
            // textBox_search
            // 
            this.textBox_search.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBox_search.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox_search.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_search.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            resources.ApplyResources(this.textBox_search, "textBox_search");
            this.textBox_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.TextChanged += new System.EventHandler(this.textBox_search_TextChanged);
            this.textBox_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_search_KeyDown);
            // 
            // button_search
            // 
            this.button_search.BackColor = System.Drawing.SystemColors.Control;
            this.button_search.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.button_search, "button_search");
            this.button_search.Name = "button_search";
            this.button_search.TabStop = false;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Image = global::Placement_Application.Properties.Resources.spyglass__4_;
            resources.ApplyResources(this.pictureBox6, "pictureBox6");
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "";
            // 
            // panel_logo
            // 
            this.panel_logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(119)))), ((int)(((byte)(120)))));
            this.panel_logo.Controls.Add(this.pictureBox3);
            resources.ApplyResources(this.panel_logo, "panel_logo");
            this.panel_logo.Name = "panel_logo";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.SizeAll;
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Image = global::Placement_Application.Properties.Resources.lion;
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            this.pictureBox3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_top_MouseMove);
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.panel_top.Controls.Add(this.label_top_batch);
            this.panel_top.Controls.Add(this.label_tool3);
            this.panel_top.Controls.Add(this.label_tool2);
            this.panel_top.Controls.Add(this.label_tool1);
            this.panel_top.Controls.Add(this.pictureBox_refresh);
            this.panel_top.Controls.Add(this.label_date);
            this.panel_top.Controls.Add(this.label_time);
            this.panel_top.Controls.Add(this.pictureBox_home);
            this.panel_top.Controls.Add(this.pictureBox_minimise);
            this.panel_top.Controls.Add(this.pictureBox_power);
            this.panel_top.Cursor = System.Windows.Forms.Cursors.SizeAll;
            resources.ApplyResources(this.panel_top, "panel_top");
            this.panel_top.Name = "panel_top";
            this.panel_top.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_top_MouseMove);
            // 
            // label_top_batch
            // 
            resources.ApplyResources(this.label_top_batch, "label_top_batch");
            this.label_top_batch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_top_batch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(2)))));
            this.label_top_batch.Name = "label_top_batch";
            // 
            // label_tool3
            // 
            resources.ApplyResources(this.label_tool3, "label_tool3");
            this.label_tool3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.label_tool3.Name = "label_tool3";
            // 
            // label_tool2
            // 
            resources.ApplyResources(this.label_tool2, "label_tool2");
            this.label_tool2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.label_tool2.Name = "label_tool2";
            // 
            // label_tool1
            // 
            resources.ApplyResources(this.label_tool1, "label_tool1");
            this.label_tool1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.label_tool1.Name = "label_tool1";
            // 
            // pictureBox_refresh
            // 
            this.pictureBox_refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.pictureBox_refresh, "pictureBox_refresh");
            this.pictureBox_refresh.Image = global::Placement_Application.Properties.Resources.update_arrow__1_;
            this.pictureBox_refresh.Name = "pictureBox_refresh";
            this.pictureBox_refresh.TabStop = false;
            this.pictureBox_refresh.Tag = "";
            this.pictureBox_refresh.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // label_date
            // 
            resources.ApplyResources(this.label_date, "label_date");
            this.label_date.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_date.ForeColor = System.Drawing.Color.White;
            this.label_date.Name = "label_date";
            // 
            // label_time
            // 
            resources.ApplyResources(this.label_time, "label_time");
            this.label_time.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_time.ForeColor = System.Drawing.Color.White;
            this.label_time.Name = "label_time";
            // 
            // pictureBox_home
            // 
            this.pictureBox_home.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.pictureBox_home, "pictureBox_home");
            this.pictureBox_home.Image = global::Placement_Application.Properties.Resources.house_outline1;
            this.pictureBox_home.Name = "pictureBox_home";
            this.pictureBox_home.TabStop = false;
            this.pictureBox_home.Tag = "";
            this.pictureBox_home.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox_minimise
            // 
            this.pictureBox_minimise.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.pictureBox_minimise, "pictureBox_minimise");
            this.pictureBox_minimise.Image = global::Placement_Application.Properties.Resources.computer_screen;
            this.pictureBox_minimise.Name = "pictureBox_minimise";
            this.pictureBox_minimise.TabStop = false;
            this.pictureBox_minimise.Tag = "";
            this.pictureBox_minimise.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox_power
            // 
            this.pictureBox_power.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.pictureBox_power, "pictureBox_power");
            this.pictureBox_power.Image = global::Placement_Application.Properties.Resources.power_button_off;
            this.pictureBox_power.Name = "pictureBox_power";
            this.pictureBox_power.TabStop = false;
            this.pictureBox_power.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.SystemColors.Control;
            this.panel_main.Controls.Add(this.tabView);
            resources.ApplyResources(this.panel_main, "panel_main");
            this.panel_main.Name = "panel_main";
            // 
            // tabView
            // 
            resources.ApplyResources(this.tabView, "tabView");
            this.tabView.Controls.Add(this.tabPage_placed);
            this.tabView.Controls.Add(this.tabPage_nonPlaced);
            this.tabView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabView.Multiline = true;
            this.tabView.Name = "tabView";
            this.tabView.SelectedIndex = 0;
            this.tabView.SelectedIndexChanged += new System.EventHandler(this.tabView_SelectedIndexChanged);
            // 
            // tabPage_placed
            // 
            this.tabPage_placed.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_placed.Controls.Add(this.listView_placed);
            resources.ApplyResources(this.tabPage_placed, "tabPage_placed");
            this.tabPage_placed.Name = "tabPage_placed";
            // 
            // listView_placed
            // 
            this.listView_placed.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.listView_placed, "listView_placed");
            this.listView_placed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.listView_placed.FullRowSelect = true;
            this.listView_placed.Name = "listView_placed";
            this.listView_placed.UseCompatibleStateImageBehavior = false;
            // 
            // tabPage_nonPlaced
            // 
            this.tabPage_nonPlaced.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_nonPlaced.Controls.Add(this.listView_nonPlaced);
            resources.ApplyResources(this.tabPage_nonPlaced, "tabPage_nonPlaced");
            this.tabPage_nonPlaced.Name = "tabPage_nonPlaced";
            // 
            // listView_nonPlaced
            // 
            this.listView_nonPlaced.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.listView_nonPlaced, "listView_nonPlaced");
            this.listView_nonPlaced.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.listView_nonPlaced.FullRowSelect = true;
            this.listView_nonPlaced.Name = "listView_nonPlaced";
            this.listView_nonPlaced.UseCompatibleStateImageBehavior = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // Form_ViewAllStudents
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_top);
            this.Controls.Add(this.panel_left);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Form_ViewAllStudents";
            this.Load += new System.EventHandler(this.Form_ViewAllStudents_Load);
            this.panel_left.ResumeLayout(false);
            this.panel_search.ResumeLayout(false);
            this.panel_search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.button_search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel_logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_refresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_minimise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_power)).EndInit();
            this.panel_main.ResumeLayout(false);
            this.tabView.ResumeLayout(false);
            this.tabPage_placed.ResumeLayout(false);
            this.tabPage_nonPlaced.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_left;
        public System.Windows.Forms.Panel panel_search;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.PictureBox button_search;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Panel panel_logo;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.PictureBox pictureBox_refresh;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.PictureBox pictureBox_home;
        private System.Windows.Forms.PictureBox pictureBox_minimise;
        private System.Windows.Forms.PictureBox pictureBox_power;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label_tool3;
        private System.Windows.Forms.Label label_tool2;
        private System.Windows.Forms.Label label_tool1;
        private System.Windows.Forms.TabControl tabView;
        private System.Windows.Forms.TabPage tabPage_placed;
        private System.Windows.Forms.ListView listView_placed;
        private System.Windows.Forms.TabPage tabPage_nonPlaced;
        private System.Windows.Forms.ListView listView_nonPlaced;
        private System.Windows.Forms.Label label_top_batch;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}