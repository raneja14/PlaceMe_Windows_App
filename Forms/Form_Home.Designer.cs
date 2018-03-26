namespace Placement_Application
{
    partial class Form_Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Home));
            this.panel_left = new System.Windows.Forms.Panel();
            this.but_logout_side_panel = new System.Windows.Forms.Button();
            this.but_settings_side_panel = new System.Windows.Forms.Button();
            this.but_manageUsers_sidePanel = new System.Windows.Forms.Button();
            this.but_user_side_panel = new System.Windows.Forms.Button();
            this.but_home_side_panel = new System.Windows.Forms.Button();
            this.panel_logo = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel_top = new System.Windows.Forms.Panel();
            this.label_top_batch = new System.Windows.Forms.Label();
            this.label_notification_count = new System.Windows.Forms.Label();
            this.pictureBox_notification = new System.Windows.Forms.PictureBox();
            this.label_date = new System.Windows.Forms.Label();
            this.label_time = new System.Windows.Forms.Label();
            this.pictureBox_minimise = new System.Windows.Forms.PictureBox();
            this.pictureBox_power = new System.Windows.Forms.PictureBox();
            this.panel_main = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel_left.SuspendLayout();
            this.panel_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_notification)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_minimise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_power)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_left
            // 
            this.panel_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.panel_left.Controls.Add(this.but_logout_side_panel);
            this.panel_left.Controls.Add(this.but_settings_side_panel);
            this.panel_left.Controls.Add(this.but_manageUsers_sidePanel);
            this.panel_left.Controls.Add(this.but_user_side_panel);
            this.panel_left.Controls.Add(this.but_home_side_panel);
            this.panel_left.Controls.Add(this.panel_logo);
            this.panel_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_left.Location = new System.Drawing.Point(0, 0);
            this.panel_left.Name = "panel_left";
            this.panel_left.Size = new System.Drawing.Size(204, 610);
            this.panel_left.TabIndex = 1;
            // 
            // but_logout_side_panel
            // 
            this.but_logout_side_panel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_logout_side_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.but_logout_side_panel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.but_logout_side_panel.FlatAppearance.BorderSize = 2;
            this.but_logout_side_panel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.but_logout_side_panel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_logout_side_panel.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_logout_side_panel.ForeColor = System.Drawing.Color.White;
            this.but_logout_side_panel.Image = global::Placement_Application.Properties.Resources.power_button_off__2_;
            this.but_logout_side_panel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_logout_side_panel.Location = new System.Drawing.Point(0, 365);
            this.but_logout_side_panel.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.but_logout_side_panel.Name = "but_logout_side_panel";
            this.but_logout_side_panel.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.but_logout_side_panel.Size = new System.Drawing.Size(204, 66);
            this.but_logout_side_panel.TabIndex = 4;
            this.but_logout_side_panel.Text = "LogOut";
            this.but_logout_side_panel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_logout_side_panel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.but_logout_side_panel.UseVisualStyleBackColor = true;
            this.but_logout_side_panel.Click += new System.EventHandler(this.but_logout_side_panel_Click);
            // 
            // but_settings_side_panel
            // 
            this.but_settings_side_panel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_settings_side_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.but_settings_side_panel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.but_settings_side_panel.FlatAppearance.BorderSize = 2;
            this.but_settings_side_panel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.but_settings_side_panel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_settings_side_panel.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_settings_side_panel.ForeColor = System.Drawing.Color.White;
            this.but_settings_side_panel.Image = global::Placement_Application.Properties.Resources.settings_work_tool__2_;
            this.but_settings_side_panel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_settings_side_panel.Location = new System.Drawing.Point(0, 299);
            this.but_settings_side_panel.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.but_settings_side_panel.Name = "but_settings_side_panel";
            this.but_settings_side_panel.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.but_settings_side_panel.Size = new System.Drawing.Size(204, 66);
            this.but_settings_side_panel.TabIndex = 3;
            this.but_settings_side_panel.Text = "Settings";
            this.but_settings_side_panel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_settings_side_panel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.but_settings_side_panel.UseVisualStyleBackColor = true;
            this.but_settings_side_panel.Click += new System.EventHandler(this.but_settings_side_panel_Click);
            // 
            // but_manageUsers_sidePanel
            // 
            this.but_manageUsers_sidePanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_manageUsers_sidePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.but_manageUsers_sidePanel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.but_manageUsers_sidePanel.FlatAppearance.BorderSize = 2;
            this.but_manageUsers_sidePanel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.but_manageUsers_sidePanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_manageUsers_sidePanel.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_manageUsers_sidePanel.ForeColor = System.Drawing.Color.White;
            this.but_manageUsers_sidePanel.Image = global::Placement_Application.Properties.Resources.multiple_users;
            this.but_manageUsers_sidePanel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_manageUsers_sidePanel.Location = new System.Drawing.Point(0, 233);
            this.but_manageUsers_sidePanel.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.but_manageUsers_sidePanel.Name = "but_manageUsers_sidePanel";
            this.but_manageUsers_sidePanel.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.but_manageUsers_sidePanel.Size = new System.Drawing.Size(204, 66);
            this.but_manageUsers_sidePanel.TabIndex = 5;
            this.but_manageUsers_sidePanel.Text = "Manage Users";
            this.but_manageUsers_sidePanel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_manageUsers_sidePanel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.but_manageUsers_sidePanel.UseVisualStyleBackColor = true;
            this.but_manageUsers_sidePanel.Visible = false;
            this.but_manageUsers_sidePanel.Click += new System.EventHandler(this.but_manageUsers_sidePanel_Click);
            // 
            // but_user_side_panel
            // 
            this.but_user_side_panel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_user_side_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.but_user_side_panel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.but_user_side_panel.FlatAppearance.BorderSize = 2;
            this.but_user_side_panel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.but_user_side_panel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_user_side_panel.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_user_side_panel.ForeColor = System.Drawing.Color.White;
            this.but_user_side_panel.Image = global::Placement_Application.Properties.Resources.black_user_shape__2_;
            this.but_user_side_panel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_user_side_panel.Location = new System.Drawing.Point(0, 167);
            this.but_user_side_panel.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.but_user_side_panel.Name = "but_user_side_panel";
            this.but_user_side_panel.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.but_user_side_panel.Size = new System.Drawing.Size(204, 66);
            this.but_user_side_panel.TabIndex = 2;
            this.but_user_side_panel.Text = "User";
            this.but_user_side_panel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_user_side_panel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.but_user_side_panel.UseVisualStyleBackColor = true;
            this.but_user_side_panel.Click += new System.EventHandler(this.but_user_side_panel_Click);
            // 
            // but_home_side_panel
            // 
            this.but_home_side_panel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_home_side_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.but_home_side_panel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.but_home_side_panel.FlatAppearance.BorderSize = 2;
            this.but_home_side_panel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.but_home_side_panel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_home_side_panel.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_home_side_panel.ForeColor = System.Drawing.Color.White;
            this.but_home_side_panel.Image = global::Placement_Application.Properties.Resources.house_outline__2_;
            this.but_home_side_panel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_home_side_panel.Location = new System.Drawing.Point(0, 100);
            this.but_home_side_panel.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.but_home_side_panel.Name = "but_home_side_panel";
            this.but_home_side_panel.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.but_home_side_panel.Size = new System.Drawing.Size(204, 67);
            this.but_home_side_panel.TabIndex = 1;
            this.but_home_side_panel.Text = "Home";
            this.but_home_side_panel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_home_side_panel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.but_home_side_panel.UseVisualStyleBackColor = true;
            this.but_home_side_panel.Click += new System.EventHandler(this.but_home_side_panel_Click);
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
            this.panel_top.Controls.Add(this.label_top_batch);
            this.panel_top.Controls.Add(this.label_notification_count);
            this.panel_top.Controls.Add(this.pictureBox_notification);
            this.panel_top.Controls.Add(this.label_date);
            this.panel_top.Controls.Add(this.label_time);
            this.panel_top.Controls.Add(this.pictureBox_minimise);
            this.panel_top.Controls.Add(this.pictureBox_power);
            this.panel_top.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(204, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(801, 100);
            this.panel_top.TabIndex = 2;
            this.panel_top.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_top_MouseMove);
            // 
            // label_top_batch
            // 
            this.label_top_batch.AutoSize = true;
            this.label_top_batch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_top_batch.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_top_batch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(2)))));
            this.label_top_batch.Location = new System.Drawing.Point(3, 4);
            this.label_top_batch.Name = "label_top_batch";
            this.label_top_batch.Size = new System.Drawing.Size(49, 23);
            this.label_top_batch.TabIndex = 11;
            this.label_top_batch.Text = "N.C";
            this.label_top_batch.Visible = false;
            // 
            // label_notification_count
            // 
            this.label_notification_count.AutoSize = true;
            this.label_notification_count.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(235)))), ((int)(((byte)(234)))));
            this.label_notification_count.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_notification_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_notification_count.Location = new System.Drawing.Point(547, 28);
            this.label_notification_count.Name = "label_notification_count";
            this.label_notification_count.Size = new System.Drawing.Size(13, 13);
            this.label_notification_count.TabIndex = 4;
            this.label_notification_count.Text = "0";
            this.label_notification_count.Visible = false;
            // 
            // pictureBox_notification
            // 
            this.pictureBox_notification.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_notification.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox_notification.Image = global::Placement_Application.Properties.Resources.notification_top;
            this.pictureBox_notification.Location = new System.Drawing.Point(507, 0);
            this.pictureBox_notification.Name = "pictureBox_notification";
            this.pictureBox_notification.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.pictureBox_notification.Size = new System.Drawing.Size(94, 100);
            this.pictureBox_notification.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_notification.TabIndex = 10;
            this.pictureBox_notification.TabStop = false;
            this.pictureBox_notification.Tag = "";
            this.pictureBox_notification.Visible = false;
            this.pictureBox_notification.Click += new System.EventHandler(this.pictureBox_notification_Click);
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_date.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_date.ForeColor = System.Drawing.Color.White;
            this.label_date.Location = new System.Drawing.Point(6, 80);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(0, 17);
            this.label_date.TabIndex = 9;
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_time.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_time.ForeColor = System.Drawing.Color.White;
            this.label_time.Location = new System.Drawing.Point(6, 60);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(0, 17);
            this.label_time.TabIndex = 8;
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
            this.panel_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(177)))));
            this.panel_main.Location = new System.Drawing.Point(204, 100);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(801, 510);
            this.panel_main.TabIndex = 3;
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
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipText = "Exporting To Excel";
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "PlaceMe";
            this.notifyIcon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDown);
            // 
            // Form_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 610);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_top);
            this.Controls.Add(this.panel_left);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeForm";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.panel_left.ResumeLayout(false);
            this.panel_logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_notification)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_minimise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_power)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_left;
        private System.Windows.Forms.Button but_logout_side_panel;
        private System.Windows.Forms.Button but_settings_side_panel;
        private System.Windows.Forms.Button but_user_side_panel;
        private System.Windows.Forms.Button but_home_side_panel;
        private System.Windows.Forms.Panel panel_logo;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.PictureBox pictureBox_minimise;
        private System.Windows.Forms.PictureBox pictureBox_power;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.PictureBox pictureBox_notification;
        private System.Windows.Forms.Label label_notification_count;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public System.Windows.Forms.Label label_top_batch;
        public System.Windows.Forms.Button but_manageUsers_sidePanel;
        public System.Windows.Forms.NotifyIcon notifyIcon;

    }
}