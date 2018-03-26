namespace Placement_Application
{
    partial class Control_Login
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
            this.textBox_userID = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.but_forgot = new System.Windows.Forms.Button();
            this.but_login = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_expiry_msg = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_userID
            // 
            this.textBox_userID.BackColor = System.Drawing.Color.White;
            this.textBox_userID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_userID.Dock = System.Windows.Forms.DockStyle.Right;
            this.textBox_userID.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_userID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.textBox_userID.Location = new System.Drawing.Point(79, 0);
            this.textBox_userID.MaxLength = 4;
            this.textBox_userID.Name = "textBox_userID";
            this.textBox_userID.Size = new System.Drawing.Size(282, 34);
            this.textBox_userID.TabIndex = 0;
            this.textBox_userID.Tag = "";
            this.textBox_userID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_userID.Enter += new System.EventHandler(this.textBox_userID_Enter);
            this.textBox_userID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_userID_KeyDown);
            this.textBox_userID.Leave += new System.EventHandler(this.textBox_userID_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.textBox_userID);
            this.panel1.Location = new System.Drawing.Point(108, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 59);
            this.panel1.TabIndex = 1;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::Placement_Application.Properties.Resources.black_user_shape__2_1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.textBox_password);
            this.panel2.Location = new System.Drawing.Point(108, 165);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(361, 59);
            this.panel2.TabIndex = 2;
            this.panel2.Click += new System.EventHandler(this.panel2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = global::Placement_Application.Properties.Resources.house_key__2_;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(73, 59);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // textBox_password
            // 
            this.textBox_password.BackColor = System.Drawing.Color.White;
            this.textBox_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_password.Dock = System.Windows.Forms.DockStyle.Right;
            this.textBox_password.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.textBox_password.Location = new System.Drawing.Point(79, 0);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '*';
            this.textBox_password.Size = new System.Drawing.Size(282, 34);
            this.textBox_password.TabIndex = 0;
            this.textBox_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_password.Enter += new System.EventHandler(this.textBox_password_Enter);
            this.textBox_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_password_KeyDown);
            this.textBox_password.Leave += new System.EventHandler(this.textBox_password_Leave);
            // 
            // but_forgot
            // 
            this.but_forgot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.but_forgot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_forgot.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.but_forgot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.but_forgot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_forgot.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_forgot.ForeColor = System.Drawing.Color.White;
            this.but_forgot.Image = global::Placement_Application.Properties.Resources.man_thinking__2_;
            this.but_forgot.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_forgot.Location = new System.Drawing.Point(108, 255);
            this.but_forgot.Name = "but_forgot";
            this.but_forgot.Size = new System.Drawing.Size(134, 45);
            this.but_forgot.TabIndex = 4;
            this.but_forgot.Text = "Forgot Password";
            this.but_forgot.UseVisualStyleBackColor = false;
            this.but_forgot.Click += new System.EventHandler(this.but_forgot_Click);
            // 
            // but_login
            // 
            this.but_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.but_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.but_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.but_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_login.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_login.ForeColor = System.Drawing.Color.White;
            this.but_login.Image = global::Placement_Application.Properties.Resources.black;
            this.but_login.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_login.Location = new System.Drawing.Point(248, 255);
            this.but_login.Name = "but_login";
            this.but_login.Size = new System.Drawing.Size(221, 45);
            this.but_login.TabIndex = 3;
            this.but_login.Text = "LOGIN";
            this.but_login.UseVisualStyleBackColor = false;
            this.but_login.Click += new System.EventHandler(this.but_login_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox1.Controls.Add(this.label_expiry_msg);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.but_forgot);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.but_login);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(119, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(579, 392);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // label_expiry_msg
            // 
            this.label_expiry_msg.AutoSize = true;
            this.label_expiry_msg.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_expiry_msg.ForeColor = System.Drawing.Color.Red;
            this.label_expiry_msg.Location = new System.Drawing.Point(104, 16);
            this.label_expiry_msg.Name = "label_expiry_msg";
            this.label_expiry_msg.Size = new System.Drawing.Size(47, 19);
            this.label_expiry_msg.TabIndex = 6;
            this.label_expiry_msg.Text = "label1";
            this.label_expiry_msg.Visible = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // Control_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.groupBox1);
            this.Name = "Control_Login";
            this.Size = new System.Drawing.Size(801, 510);
            this.Load += new System.EventHandler(this.LoginControl_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_userID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button but_login;
        private System.Windows.Forms.Button but_forgot;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label_expiry_msg;
    }
}
