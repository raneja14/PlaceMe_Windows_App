namespace Placement_Application
{
    partial class Form_Notification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Notification));
            this.panel_left = new System.Windows.Forms.Panel();
            this.but_notify = new System.Windows.Forms.Button();
            this.but_details = new System.Windows.Forms.Button();
            this.but_resultList = new System.Windows.Forms.Button();
            this.but_criteria = new System.Windows.Forms.Button();
            this.panel_logo = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel_top = new System.Windows.Forms.Panel();
            this.label_top_batch = new System.Windows.Forms.Label();
            this.pictureBox_refresh = new System.Windows.Forms.PictureBox();
            this.label_date = new System.Windows.Forms.Label();
            this.label_time = new System.Windows.Forms.Label();
            this.pictureBox_home = new System.Windows.Forms.PictureBox();
            this.pictureBox_minimise = new System.Windows.Forms.PictureBox();
            this.pictureBox_power = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel_main = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel_left.SuspendLayout();
            this.panel_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_refresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_minimise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_power)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_left
            // 
            this.panel_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.panel_left.Controls.Add(this.but_notify);
            this.panel_left.Controls.Add(this.but_details);
            this.panel_left.Controls.Add(this.but_resultList);
            this.panel_left.Controls.Add(this.but_criteria);
            this.panel_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_left.Location = new System.Drawing.Point(0, 100);
            this.panel_left.Name = "panel_left";
            this.panel_left.Size = new System.Drawing.Size(204, 510);
            this.panel_left.TabIndex = 6;
            // 
            // but_notify
            // 
            this.but_notify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_notify.Dock = System.Windows.Forms.DockStyle.Top;
            this.but_notify.Enabled = false;
            this.but_notify.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.but_notify.FlatAppearance.BorderSize = 2;
            this.but_notify.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.but_notify.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.but_notify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_notify.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_notify.ForeColor = System.Drawing.Color.White;
            this.but_notify.Image = global::Placement_Application.Properties.Resources.sms_message__2_;
            this.but_notify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_notify.Location = new System.Drawing.Point(0, 201);
            this.but_notify.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.but_notify.Name = "but_notify";
            this.but_notify.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.but_notify.Size = new System.Drawing.Size(204, 67);
            this.but_notify.TabIndex = 22;
            this.but_notify.Text = "Notify";
            this.but_notify.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_notify.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.but_notify.UseVisualStyleBackColor = true;
            this.but_notify.Visible = false;
            this.but_notify.Click += new System.EventHandler(this.but_notify_Click);
            // 
            // but_details
            // 
            this.but_details.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_details.Dock = System.Windows.Forms.DockStyle.Top;
            this.but_details.Enabled = false;
            this.but_details.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.but_details.FlatAppearance.BorderSize = 2;
            this.but_details.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.but_details.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.but_details.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_details.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_details.ForeColor = System.Drawing.Color.White;
            this.but_details.Image = global::Placement_Application.Properties.Resources.web;
            this.but_details.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_details.Location = new System.Drawing.Point(0, 134);
            this.but_details.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.but_details.Name = "but_details";
            this.but_details.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.but_details.Size = new System.Drawing.Size(204, 67);
            this.but_details.TabIndex = 19;
            this.but_details.Text = "Details";
            this.but_details.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_details.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.but_details.UseVisualStyleBackColor = true;
            this.but_details.Visible = false;
            this.but_details.Click += new System.EventHandler(this.but_details_Click);
            // 
            // but_resultList
            // 
            this.but_resultList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_resultList.Dock = System.Windows.Forms.DockStyle.Top;
            this.but_resultList.Enabled = false;
            this.but_resultList.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.but_resultList.FlatAppearance.BorderSize = 2;
            this.but_resultList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.but_resultList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.but_resultList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_resultList.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_resultList.ForeColor = System.Drawing.Color.White;
            this.but_resultList.Image = global::Placement_Application.Properties.Resources.positive_verified_symbol_of_a_clipboard__2_;
            this.but_resultList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_resultList.Location = new System.Drawing.Point(0, 67);
            this.but_resultList.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.but_resultList.Name = "but_resultList";
            this.but_resultList.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.but_resultList.Size = new System.Drawing.Size(204, 67);
            this.but_resultList.TabIndex = 18;
            this.but_resultList.Text = "Result List";
            this.but_resultList.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_resultList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.but_resultList.UseVisualStyleBackColor = true;
            this.but_resultList.Click += new System.EventHandler(this.but_resultList_Click);
            // 
            // but_criteria
            // 
            this.but_criteria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.but_criteria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_criteria.Dock = System.Windows.Forms.DockStyle.Top;
            this.but_criteria.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.but_criteria.FlatAppearance.BorderSize = 2;
            this.but_criteria.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.but_criteria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.but_criteria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_criteria.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_criteria.ForeColor = System.Drawing.Color.White;
            this.but_criteria.Image = global::Placement_Application.Properties.Resources.filter_outline__2_;
            this.but_criteria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_criteria.Location = new System.Drawing.Point(0, 0);
            this.but_criteria.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.but_criteria.Name = "but_criteria";
            this.but_criteria.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.but_criteria.Size = new System.Drawing.Size(204, 67);
            this.but_criteria.TabIndex = 16;
            this.but_criteria.Text = "Criteria";
            this.but_criteria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_criteria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.but_criteria.UseVisualStyleBackColor = false;
            this.but_criteria.Click += new System.EventHandler(this.but_criteria_Click);
            // 
            // panel_logo
            // 
            this.panel_logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(119)))), ((int)(((byte)(120)))));
            this.panel_logo.Controls.Add(this.pictureBox3);
            this.panel_logo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_logo.Location = new System.Drawing.Point(0, 0);
            this.panel_logo.Name = "panel_logo";
            this.panel_logo.Size = new System.Drawing.Size(204, 100);
            this.panel_logo.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Image = global::Placement_Application.Properties.Resources.lion;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(204, 100);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_top_MouseMove);
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.panel_top.Controls.Add(this.label_top_batch);
            this.panel_top.Controls.Add(this.panel_logo);
            this.panel_top.Controls.Add(this.pictureBox_refresh);
            this.panel_top.Controls.Add(this.label_date);
            this.panel_top.Controls.Add(this.label_time);
            this.panel_top.Controls.Add(this.pictureBox_home);
            this.panel_top.Controls.Add(this.pictureBox_minimise);
            this.panel_top.Controls.Add(this.pictureBox_power);
            this.panel_top.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(1005, 100);
            this.panel_top.TabIndex = 7;
            this.panel_top.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_top_MouseMove);
            // 
            // label_top_batch
            // 
            this.label_top_batch.AutoSize = true;
            this.label_top_batch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_top_batch.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold);
            this.label_top_batch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(2)))));
            this.label_top_batch.Location = new System.Drawing.Point(208, 3);
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
            this.pictureBox_refresh.Location = new System.Drawing.Point(605, 0);
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
            this.label_date.Location = new System.Drawing.Point(210, 80);
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
            this.label_time.Location = new System.Drawing.Point(210, 60);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(0, 17);
            this.label_time.TabIndex = 11;
            // 
            // pictureBox_home
            // 
            this.pictureBox_home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_home.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox_home.Image = global::Placement_Application.Properties.Resources.house_outline1;
            this.pictureBox_home.Location = new System.Drawing.Point(705, 0);
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
            this.pictureBox_minimise.Location = new System.Drawing.Point(805, 0);
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
            this.pictureBox_power.Location = new System.Drawing.Point(905, 0);
            this.pictureBox_power.Name = "pictureBox_power";
            this.pictureBox_power.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.pictureBox_power.Size = new System.Drawing.Size(100, 100);
            this.pictureBox_power.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_power.TabIndex = 0;
            this.pictureBox_power.TabStop = false;
            this.pictureBox_power.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel_main
            // 
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(204, 100);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(801, 510);
            this.panel_main.TabIndex = 8;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // Form_Notification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 610);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_left);
            this.Controls.Add(this.panel_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form_Notification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Notification";
            this.Load += new System.EventHandler(this.Form_Notification_Load);
            this.panel_left.ResumeLayout(false);
            this.panel_logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_refresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_minimise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_power)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_left;
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
        private System.Windows.Forms.Panel panel_main;
        public System.Windows.Forms.Button but_notify;
        public System.Windows.Forms.Button but_details;
        public System.Windows.Forms.Button but_resultList;
        public System.Windows.Forms.Button but_criteria;
        private System.Windows.Forms.Label label_top_batch;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}