namespace Placement_Application.Controls
{
    partial class ListControl_ViewUsers
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_top_info = new System.Windows.Forms.Panel();
            this.panel_userControls = new System.Windows.Forms.Panel();
            this.pic_deleteUser = new System.Windows.Forms.PictureBox();
            this.pic_editUser = new System.Windows.Forms.PictureBox();
            this.pic_addUser = new System.Windows.Forms.PictureBox();
            this.panel_deleteUser = new System.Windows.Forms.Panel();
            this.pic_backDel = new System.Windows.Forms.PictureBox();
            this.pic_delete = new System.Windows.Forms.PictureBox();
            this.panel_activationControls = new System.Windows.Forms.Panel();
            this.pic_back = new System.Windows.Forms.PictureBox();
            this.pic_deactivate = new System.Windows.Forms.PictureBox();
            this.pic_activate = new System.Windows.Forms.PictureBox();
            this.label_deactiveUsersCount = new System.Windows.Forms.Label();
            this.label_activeUsersCount = new System.Windows.Forms.Label();
            this.label_totalUsersCount = new System.Windows.Forms.Label();
            this.label_deactiveUsers = new System.Windows.Forms.Label();
            this.label_activeUsers = new System.Windows.Forms.Label();
            this.label_totalUsers = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel_top_info.SuspendLayout();
            this.panel_userControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_deleteUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_editUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_addUser)).BeginInit();
            this.panel_deleteUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_backDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_delete)).BeginInit();
            this.panel_activationControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_deactivate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_activate)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_top_info
            // 
            this.panel_top_info.BackColor = System.Drawing.SystemColors.Control;
            this.panel_top_info.Controls.Add(this.panel_userControls);
            this.panel_top_info.Controls.Add(this.panel_deleteUser);
            this.panel_top_info.Controls.Add(this.panel_activationControls);
            this.panel_top_info.Controls.Add(this.label_deactiveUsersCount);
            this.panel_top_info.Controls.Add(this.label_activeUsersCount);
            this.panel_top_info.Controls.Add(this.label_totalUsersCount);
            this.panel_top_info.Controls.Add(this.label_deactiveUsers);
            this.panel_top_info.Controls.Add(this.label_activeUsers);
            this.panel_top_info.Controls.Add(this.label_totalUsers);
            this.panel_top_info.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top_info.Location = new System.Drawing.Point(0, 0);
            this.panel_top_info.Name = "panel_top_info";
            this.panel_top_info.Size = new System.Drawing.Size(801, 86);
            this.panel_top_info.TabIndex = 4;
            // 
            // panel_userControls
            // 
            this.panel_userControls.BackColor = System.Drawing.SystemColors.Control;
            this.panel_userControls.Controls.Add(this.pic_deleteUser);
            this.panel_userControls.Controls.Add(this.pic_editUser);
            this.panel_userControls.Controls.Add(this.pic_addUser);
            this.panel_userControls.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_userControls.Location = new System.Drawing.Point(0, 0);
            this.panel_userControls.Name = "panel_userControls";
            this.panel_userControls.Size = new System.Drawing.Size(301, 86);
            this.panel_userControls.TabIndex = 43;
            // 
            // pic_deleteUser
            // 
            this.pic_deleteUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_deleteUser.Dock = System.Windows.Forms.DockStyle.Left;
            this.pic_deleteUser.Image = global::Placement_Application.Properties.Resources.delete_user;
            this.pic_deleteUser.Location = new System.Drawing.Point(204, 0);
            this.pic_deleteUser.Name = "pic_deleteUser";
            this.pic_deleteUser.Size = new System.Drawing.Size(103, 86);
            this.pic_deleteUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic_deleteUser.TabIndex = 45;
            this.pic_deleteUser.TabStop = false;
            this.pic_deleteUser.Click += new System.EventHandler(this.pic_deleteUser_Click);
            this.pic_deleteUser.MouseHover += new System.EventHandler(this.pic_deleteUser_MouseHover);
            // 
            // pic_editUser
            // 
            this.pic_editUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_editUser.Dock = System.Windows.Forms.DockStyle.Left;
            this.pic_editUser.Image = global::Placement_Application.Properties.Resources.editUser;
            this.pic_editUser.Location = new System.Drawing.Point(101, 0);
            this.pic_editUser.Name = "pic_editUser";
            this.pic_editUser.Size = new System.Drawing.Size(103, 86);
            this.pic_editUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic_editUser.TabIndex = 44;
            this.pic_editUser.TabStop = false;
            this.pic_editUser.Click += new System.EventHandler(this.pic_editUser_Click);
            this.pic_editUser.MouseHover += new System.EventHandler(this.pic_editUser_MouseHover);
            // 
            // pic_addUser
            // 
            this.pic_addUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_addUser.Dock = System.Windows.Forms.DockStyle.Left;
            this.pic_addUser.Image = global::Placement_Application.Properties.Resources.addUser;
            this.pic_addUser.Location = new System.Drawing.Point(0, 0);
            this.pic_addUser.Name = "pic_addUser";
            this.pic_addUser.Size = new System.Drawing.Size(101, 86);
            this.pic_addUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic_addUser.TabIndex = 43;
            this.pic_addUser.TabStop = false;
            this.pic_addUser.Click += new System.EventHandler(this.pic_addUser_Click);
            this.pic_addUser.MouseHover += new System.EventHandler(this.pic_addUser_MouseHover);
            // 
            // panel_deleteUser
            // 
            this.panel_deleteUser.BackColor = System.Drawing.SystemColors.Control;
            this.panel_deleteUser.Controls.Add(this.pic_backDel);
            this.panel_deleteUser.Controls.Add(this.pic_delete);
            this.panel_deleteUser.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_deleteUser.Location = new System.Drawing.Point(301, 0);
            this.panel_deleteUser.Name = "panel_deleteUser";
            this.panel_deleteUser.Size = new System.Drawing.Size(196, 86);
            this.panel_deleteUser.TabIndex = 45;
            this.panel_deleteUser.Visible = false;
            // 
            // pic_backDel
            // 
            this.pic_backDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_backDel.Dock = System.Windows.Forms.DockStyle.Left;
            this.pic_backDel.Image = global::Placement_Application.Properties.Resources.previous;
            this.pic_backDel.Location = new System.Drawing.Point(102, 0);
            this.pic_backDel.Name = "pic_backDel";
            this.pic_backDel.Size = new System.Drawing.Size(92, 86);
            this.pic_backDel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic_backDel.TabIndex = 2;
            this.pic_backDel.TabStop = false;
            this.pic_backDel.Click += new System.EventHandler(this.pic_backDel_Click);
            this.pic_backDel.MouseHover += new System.EventHandler(this.pic_backDel_MouseHover);
            // 
            // pic_delete
            // 
            this.pic_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_delete.Dock = System.Windows.Forms.DockStyle.Left;
            this.pic_delete.Image = global::Placement_Application.Properties.Resources.bulbDelete;
            this.pic_delete.Location = new System.Drawing.Point(0, 0);
            this.pic_delete.Name = "pic_delete";
            this.pic_delete.Size = new System.Drawing.Size(102, 86);
            this.pic_delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic_delete.TabIndex = 1;
            this.pic_delete.TabStop = false;
            this.pic_delete.Click += new System.EventHandler(this.pic_delete_Click);
            this.pic_delete.MouseHover += new System.EventHandler(this.pic_delete_MouseHover);
            // 
            // panel_activationControls
            // 
            this.panel_activationControls.BackColor = System.Drawing.SystemColors.Control;
            this.panel_activationControls.Controls.Add(this.pic_back);
            this.panel_activationControls.Controls.Add(this.pic_deactivate);
            this.panel_activationControls.Controls.Add(this.pic_activate);
            this.panel_activationControls.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_activationControls.Location = new System.Drawing.Point(497, 0);
            this.panel_activationControls.Name = "panel_activationControls";
            this.panel_activationControls.Size = new System.Drawing.Size(304, 86);
            this.panel_activationControls.TabIndex = 44;
            this.panel_activationControls.Visible = false;
            // 
            // pic_back
            // 
            this.pic_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_back.Dock = System.Windows.Forms.DockStyle.Left;
            this.pic_back.Image = global::Placement_Application.Properties.Resources.previous;
            this.pic_back.Location = new System.Drawing.Point(209, 0);
            this.pic_back.Name = "pic_back";
            this.pic_back.Size = new System.Drawing.Size(92, 86);
            this.pic_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic_back.TabIndex = 2;
            this.pic_back.TabStop = false;
            this.pic_back.Click += new System.EventHandler(this.pic_back_Click);
            this.pic_back.MouseHover += new System.EventHandler(this.pic_back_MouseHover);
            // 
            // pic_deactivate
            // 
            this.pic_deactivate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_deactivate.Dock = System.Windows.Forms.DockStyle.Left;
            this.pic_deactivate.Image = global::Placement_Application.Properties.Resources.bulbDeactivate;
            this.pic_deactivate.Location = new System.Drawing.Point(107, 0);
            this.pic_deactivate.Name = "pic_deactivate";
            this.pic_deactivate.Size = new System.Drawing.Size(102, 86);
            this.pic_deactivate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic_deactivate.TabIndex = 1;
            this.pic_deactivate.TabStop = false;
            this.pic_deactivate.Click += new System.EventHandler(this.pic_deactivate_Click);
            this.pic_deactivate.MouseHover += new System.EventHandler(this.pic_deactivate_MouseHover);
            // 
            // pic_activate
            // 
            this.pic_activate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_activate.Dock = System.Windows.Forms.DockStyle.Left;
            this.pic_activate.Image = global::Placement_Application.Properties.Resources.bulbActivate;
            this.pic_activate.Location = new System.Drawing.Point(0, 0);
            this.pic_activate.Name = "pic_activate";
            this.pic_activate.Size = new System.Drawing.Size(107, 86);
            this.pic_activate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic_activate.TabIndex = 0;
            this.pic_activate.TabStop = false;
            this.pic_activate.Click += new System.EventHandler(this.pic_activate_Click);
            this.pic_activate.MouseHover += new System.EventHandler(this.pic_activate_MouseHover);
            // 
            // label_deactiveUsersCount
            // 
            this.label_deactiveUsersCount.AutoSize = true;
            this.label_deactiveUsersCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_deactiveUsersCount.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_deactiveUsersCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.label_deactiveUsersCount.Location = new System.Drawing.Point(245, 58);
            this.label_deactiveUsersCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_deactiveUsersCount.Name = "label_deactiveUsersCount";
            this.label_deactiveUsersCount.Size = new System.Drawing.Size(17, 17);
            this.label_deactiveUsersCount.TabIndex = 42;
            this.label_deactiveUsersCount.Text = "0";
            // 
            // label_activeUsersCount
            // 
            this.label_activeUsersCount.AutoSize = true;
            this.label_activeUsersCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_activeUsersCount.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_activeUsersCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.label_activeUsersCount.Location = new System.Drawing.Point(245, 36);
            this.label_activeUsersCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_activeUsersCount.Name = "label_activeUsersCount";
            this.label_activeUsersCount.Size = new System.Drawing.Size(17, 17);
            this.label_activeUsersCount.TabIndex = 41;
            this.label_activeUsersCount.Text = "0";
            // 
            // label_totalUsersCount
            // 
            this.label_totalUsersCount.AutoSize = true;
            this.label_totalUsersCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_totalUsersCount.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_totalUsersCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.label_totalUsersCount.Location = new System.Drawing.Point(245, 12);
            this.label_totalUsersCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_totalUsersCount.Name = "label_totalUsersCount";
            this.label_totalUsersCount.Size = new System.Drawing.Size(17, 17);
            this.label_totalUsersCount.TabIndex = 40;
            this.label_totalUsersCount.Text = "0";
            // 
            // label_deactiveUsers
            // 
            this.label_deactiveUsers.AutoSize = true;
            this.label_deactiveUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_deactiveUsers.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_deactiveUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label_deactiveUsers.Location = new System.Drawing.Point(89, 58);
            this.label_deactiveUsers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_deactiveUsers.Name = "label_deactiveUsers";
            this.label_deactiveUsers.Size = new System.Drawing.Size(152, 17);
            this.label_deactiveUsers.TabIndex = 39;
            this.label_deactiveUsers.Text = "Deactive Users: ";
            // 
            // label_activeUsers
            // 
            this.label_activeUsers.AutoSize = true;
            this.label_activeUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_activeUsers.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_activeUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label_activeUsers.Location = new System.Drawing.Point(89, 36);
            this.label_activeUsers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_activeUsers.Name = "label_activeUsers";
            this.label_activeUsers.Size = new System.Drawing.Size(134, 17);
            this.label_activeUsers.TabIndex = 38;
            this.label_activeUsers.Text = "Active Users: ";
            // 
            // label_totalUsers
            // 
            this.label_totalUsers.AutoSize = true;
            this.label_totalUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_totalUsers.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_totalUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label_totalUsers.Location = new System.Drawing.Point(89, 12);
            this.label_totalUsers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_totalUsers.Name = "label_totalUsers";
            this.label_totalUsers.Size = new System.Drawing.Size(125, 17);
            this.label_totalUsers.TabIndex = 37;
            this.label_totalUsers.Text = "Total Users: ";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.White;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.listView1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(0, 86);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(801, 424);
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // ListControl_ViewUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel_top_info);
            this.Name = "ListControl_ViewUsers";
            this.Size = new System.Drawing.Size(801, 510);
            this.Load += new System.EventHandler(this.ListControl_ViewUsers_Load);
            this.panel_top_info.ResumeLayout(false);
            this.panel_top_info.PerformLayout();
            this.panel_userControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_deleteUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_editUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_addUser)).EndInit();
            this.panel_deleteUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_backDel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_delete)).EndInit();
            this.panel_activationControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_deactivate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_activate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_top_info;
        private System.Windows.Forms.Label label_totalUsers;
        private System.Windows.Forms.Label label_deactiveUsers;
        private System.Windows.Forms.Label label_activeUsers;
        private System.Windows.Forms.Label label_deactiveUsersCount;
        private System.Windows.Forms.Label label_activeUsersCount;
        private System.Windows.Forms.Label label_totalUsersCount;
        private System.Windows.Forms.PictureBox pic_addUser;
        private System.Windows.Forms.Panel panel_userControls;
        private System.Windows.Forms.PictureBox pic_editUser;
        private System.Windows.Forms.Panel panel_activationControls;
        private System.Windows.Forms.PictureBox pic_deactivate;
        private System.Windows.Forms.PictureBox pic_activate;
        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.PictureBox pic_back;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pic_deleteUser;
        private System.Windows.Forms.Panel panel_deleteUser;
        private System.Windows.Forms.PictureBox pic_backDel;
        private System.Windows.Forms.PictureBox pic_delete;
    }
}
