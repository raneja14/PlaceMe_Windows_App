namespace Placement_Application
{
    partial class Form_ViewCompanies
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ViewCompanies));
            this.panel_left = new System.Windows.Forms.Panel();
            this.panel_search = new System.Windows.Forms.Panel();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.button_search = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.panel_logo = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel_top = new System.Windows.Forms.Panel();
            this.pic_delete = new System.Windows.Forms.PictureBox();
            this.pictureBox_notifyCompany = new System.Windows.Forms.PictureBox();
            this.label_top_batch = new System.Windows.Forms.Label();
            this.pictureBox_refresh = new System.Windows.Forms.PictureBox();
            this.label_date = new System.Windows.Forms.Label();
            this.label_time = new System.Windows.Forms.Label();
            this.pictureBox_home = new System.Windows.Forms.PictureBox();
            this.pictureBox_minimise = new System.Windows.Forms.PictureBox();
            this.pictureBox_power = new System.Windows.Forms.PictureBox();
            this.panel_main = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.panel_left.SuspendLayout();
            this.panel_search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.button_search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_notifyCompany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_refresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_minimise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_power)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_left
            // 
            this.panel_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.panel_left.Controls.Add(this.panel_search);
            this.panel_left.Controls.Add(this.pictureBox6);
            this.panel_left.Controls.Add(this.panel_logo);
            this.panel_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_left.Location = new System.Drawing.Point(0, 0);
            this.panel_left.Name = "panel_left";
            this.panel_left.Size = new System.Drawing.Size(204, 610);
            this.panel_left.TabIndex = 5;
            // 
            // panel_search
            // 
            this.panel_search.BackColor = System.Drawing.SystemColors.Control;
            this.panel_search.Controls.Add(this.textBox_search);
            this.panel_search.Controls.Add(this.button_search);
            this.panel_search.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_search.Location = new System.Drawing.Point(0, 100);
            this.panel_search.Name = "panel_search";
            this.panel_search.Size = new System.Drawing.Size(204, 25);
            this.panel_search.TabIndex = 15;
            // 
            // textBox_search
            // 
            this.textBox_search.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBox_search.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox_search.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_search.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox_search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_search.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.textBox_search.Location = new System.Drawing.Point(0, 0);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(174, 24);
            this.textBox_search.TabIndex = 1;
            this.textBox_search.TextChanged += new System.EventHandler(this.textBox_search_TextChanged);
            this.textBox_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_search_KeyDown);
            // 
            // button_search
            // 
            this.button_search.BackColor = System.Drawing.SystemColors.Control;
            this.button_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_search.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_search.Image = ((System.Drawing.Image)(resources.GetObject("button_search.Image")));
            this.button_search.Location = new System.Drawing.Point(174, 0);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(30, 25);
            this.button_search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.button_search.TabIndex = 0;
            this.button_search.TabStop = false;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Image = global::Placement_Application.Properties.Resources.eye__4_;
            this.pictureBox6.Location = new System.Drawing.Point(-43, 230);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.pictureBox6.Size = new System.Drawing.Size(286, 256);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox6.TabIndex = 14;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "";
            // 
            // panel_logo
            // 
            this.panel_logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(119)))), ((int)(((byte)(120)))));
            this.panel_logo.Controls.Add(this.pictureBox3);
            this.panel_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_logo.Location = new System.Drawing.Point(0, 0);
            this.panel_logo.Name = "panel_logo";
            this.panel_logo.Size = new System.Drawing.Size(204, 100);
            this.panel_logo.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox3.Image = global::Placement_Application.Properties.Resources.lion;
            this.pictureBox3.Location = new System.Drawing.Point(4, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(200, 100);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseMove);
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.panel_top.Controls.Add(this.pic_delete);
            this.panel_top.Controls.Add(this.pictureBox_notifyCompany);
            this.panel_top.Controls.Add(this.label_top_batch);
            this.panel_top.Controls.Add(this.pictureBox_refresh);
            this.panel_top.Controls.Add(this.label_date);
            this.panel_top.Controls.Add(this.label_time);
            this.panel_top.Controls.Add(this.pictureBox_home);
            this.panel_top.Controls.Add(this.pictureBox_minimise);
            this.panel_top.Controls.Add(this.pictureBox_power);
            this.panel_top.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(204, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(801, 100);
            this.panel_top.TabIndex = 6;
            this.panel_top.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_top_MouseMove);
            // 
            // pic_delete
            // 
            this.pic_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.pic_delete.Image = global::Placement_Application.Properties.Resources.deleteBin;
            this.pic_delete.Location = new System.Drawing.Point(207, 0);
            this.pic_delete.Name = "pic_delete";
            this.pic_delete.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.pic_delete.Size = new System.Drawing.Size(94, 100);
            this.pic_delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic_delete.TabIndex = 16;
            this.pic_delete.TabStop = false;
            this.pic_delete.Tag = "";
            this.pic_delete.Click += new System.EventHandler(this.pic_delete_Click);
            // 
            // pictureBox_notifyCompany
            // 
            this.pictureBox_notifyCompany.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_notifyCompany.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox_notifyCompany.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_notifyCompany.Image")));
            this.pictureBox_notifyCompany.Location = new System.Drawing.Point(301, 0);
            this.pictureBox_notifyCompany.Name = "pictureBox_notifyCompany";
            this.pictureBox_notifyCompany.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.pictureBox_notifyCompany.Size = new System.Drawing.Size(100, 100);
            this.pictureBox_notifyCompany.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_notifyCompany.TabIndex = 15;
            this.pictureBox_notifyCompany.TabStop = false;
            this.pictureBox_notifyCompany.Tag = "";
            this.pictureBox_notifyCompany.Visible = false;
            this.pictureBox_notifyCompany.Click += new System.EventHandler(this.pictureBox_notifyCompany_Click);
            // 
            // label_top_batch
            // 
            this.label_top_batch.AutoSize = true;
            this.label_top_batch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_top_batch.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold);
            this.label_top_batch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(2)))));
            this.label_top_batch.Location = new System.Drawing.Point(3, 4);
            this.label_top_batch.Name = "label_top_batch";
            this.label_top_batch.Size = new System.Drawing.Size(101, 23);
            this.label_top_batch.TabIndex = 14;
            this.label_top_batch.Text = "xxxx-xx";
            // 
            // pictureBox_refresh
            // 
            this.pictureBox_refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_refresh.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox_refresh.Image = global::Placement_Application.Properties.Resources.update_arrow__1_;
            this.pictureBox_refresh.Location = new System.Drawing.Point(401, 0);
            this.pictureBox_refresh.Name = "pictureBox_refresh";
            this.pictureBox_refresh.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.pictureBox_refresh.Size = new System.Drawing.Size(100, 100);
            this.pictureBox_refresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_refresh.TabIndex = 13;
            this.pictureBox_refresh.TabStop = false;
            this.pictureBox_refresh.Tag = "";
            this.pictureBox_refresh.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_date.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_date.ForeColor = System.Drawing.Color.White;
            this.label_date.Location = new System.Drawing.Point(3, 80);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(0, 17);
            this.label_date.TabIndex = 12;
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_time.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_time.ForeColor = System.Drawing.Color.White;
            this.label_time.Location = new System.Drawing.Point(3, 60);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(0, 17);
            this.label_time.TabIndex = 11;
            // 
            // pictureBox_home
            // 
            this.pictureBox_home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_home.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox_home.Image = global::Placement_Application.Properties.Resources.house_outline1;
            this.pictureBox_home.Location = new System.Drawing.Point(501, 0);
            this.pictureBox_home.Name = "pictureBox_home";
            this.pictureBox_home.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.pictureBox_home.Size = new System.Drawing.Size(100, 100);
            this.pictureBox_home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_home.TabIndex = 10;
            this.pictureBox_home.TabStop = false;
            this.pictureBox_home.Tag = "";
            this.pictureBox_home.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox_minimise
            // 
            this.pictureBox_minimise.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_minimise.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox_minimise.Image = global::Placement_Application.Properties.Resources.computer_screen;
            this.pictureBox_minimise.Location = new System.Drawing.Point(601, 0);
            this.pictureBox_minimise.Name = "pictureBox_minimise";
            this.pictureBox_minimise.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.pictureBox_minimise.Size = new System.Drawing.Size(100, 100);
            this.pictureBox_minimise.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_minimise.TabIndex = 1;
            this.pictureBox_minimise.TabStop = false;
            this.pictureBox_minimise.Tag = "";
            this.pictureBox_minimise.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox_power
            // 
            this.pictureBox_power.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_power.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox_power.Image = global::Placement_Application.Properties.Resources.power_button_off;
            this.pictureBox_power.Location = new System.Drawing.Point(701, 0);
            this.pictureBox_power.Name = "pictureBox_power";
            this.pictureBox_power.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.pictureBox_power.Size = new System.Drawing.Size(100, 100);
            this.pictureBox_power.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_power.TabIndex = 0;
            this.pictureBox_power.TabStop = false;
            this.pictureBox_power.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel_main
            // 
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.panel_main.Location = new System.Drawing.Point(204, 100);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(801, 510);
            this.panel_main.TabIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            this.backgroundWorker2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker2_RunWorkerCompleted);
            // 
            // Form_ViewCompanies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 610);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_top);
            this.Controls.Add(this.panel_left);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_ViewCompanies";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewCompaniesForm";
            this.Load += new System.EventHandler(this.ViewCompaniesForm_Load);
            this.panel_left.ResumeLayout(false);
            this.panel_search.ResumeLayout(false);
            this.panel_search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.button_search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel_logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_notifyCompany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_refresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_minimise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_power)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_left;
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
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox button_search;
        public System.Windows.Forms.Panel panel_main;
        public System.Windows.Forms.Panel panel_search;
        private System.Windows.Forms.Label label_top_batch;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox_notifyCompany;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        public System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.PictureBox pic_delete;
    }
}