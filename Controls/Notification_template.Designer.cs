namespace Placement_Application.Controls
{
    partial class Notification_template
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
            this.label_company = new System.Windows.Forms.Label();
            this.label_studentCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_staff = new System.Windows.Forms.Label();
            this.label_date = new System.Windows.Forms.Label();
            this.label_viewDate = new System.Windows.Forms.Label();
            this.label_viewDateVal = new System.Windows.Forms.Label();
            this.label_viewedTime = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.notifyIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.notifyIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // label_company
            // 
            this.label_company.AutoSize = true;
            this.label_company.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_company.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.label_company.Location = new System.Drawing.Point(3, 0);
            this.label_company.Name = "label_company";
            this.label_company.Size = new System.Drawing.Size(88, 23);
            this.label_company.TabIndex = 1;
            this.label_company.Text = "GOOGLE";
            this.label_company.Click += new System.EventHandler(this.Notification_template_Click);
            this.label_company.MouseLeave += new System.EventHandler(this.Notification_template_MouseLeave);
            this.label_company.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label_staff_MouseMove);
            // 
            // label_studentCount
            // 
            this.label_studentCount.AutoSize = true;
            this.label_studentCount.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_studentCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(2)))));
            this.label_studentCount.Location = new System.Drawing.Point(318, 8);
            this.label_studentCount.Name = "label_studentCount";
            this.label_studentCount.Size = new System.Drawing.Size(128, 18);
            this.label_studentCount.TabIndex = 2;
            this.label_studentCount.Text = "450 Students";
            this.label_studentCount.Click += new System.EventHandler(this.Notification_template_Click);
            this.label_studentCount.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label_staff_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.label2.Location = new System.Drawing.Point(211, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Notified By:";
            this.label2.Click += new System.EventHandler(this.Notification_template_Click);
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label_staff_MouseMove);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.label3.Location = new System.Drawing.Point(212, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Notified On:";
            this.label3.Click += new System.EventHandler(this.Notification_template_Click);
            this.label3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label_staff_MouseMove);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(211, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Notified To:";
            this.label4.Click += new System.EventHandler(this.Notification_template_Click);
            this.label4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label_staff_MouseMove);
            // 
            // label_staff
            // 
            this.label_staff.AutoSize = true;
            this.label_staff.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_staff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(2)))));
            this.label_staff.Location = new System.Drawing.Point(318, 37);
            this.label_staff.Name = "label_staff";
            this.label_staff.Size = new System.Drawing.Size(48, 18);
            this.label_staff.TabIndex = 6;
            this.label_staff.Text = "User";
            this.label_staff.Click += new System.EventHandler(this.Notification_template_Click);
            this.label_staff.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label_staff_MouseMove);
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(2)))));
            this.label_date.Location = new System.Drawing.Point(318, 64);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(138, 18);
            this.label_date.TabIndex = 7;
            this.label_date.Text = "20th Aug,2016";
            this.label_date.Click += new System.EventHandler(this.Notification_template_Click);
            this.label_date.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label_staff_MouseMove);
            // 
            // label_viewDate
            // 
            this.label_viewDate.AutoSize = true;
            this.label_viewDate.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_viewDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.label_viewDate.Location = new System.Drawing.Point(646, 19);
            this.label_viewDate.Name = "label_viewDate";
            this.label_viewDate.Size = new System.Drawing.Size(88, 17);
            this.label_viewDate.TabIndex = 8;
            this.label_viewDate.Text = "Viewed On:";
            this.label_viewDate.Visible = false;
            this.label_viewDate.Click += new System.EventHandler(this.Notification_template_Click);
            this.label_viewDate.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label_staff_MouseMove);
            // 
            // label_viewDateVal
            // 
            this.label_viewDateVal.AutoSize = true;
            this.label_viewDateVal.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_viewDateVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(2)))));
            this.label_viewDateVal.Location = new System.Drawing.Point(646, 37);
            this.label_viewDateVal.Name = "label_viewDateVal";
            this.label_viewDateVal.Size = new System.Drawing.Size(44, 17);
            this.label_viewDateVal.TabIndex = 9;
            this.label_viewDateVal.Text = "Date";
            this.label_viewDateVal.Visible = false;
            this.label_viewDateVal.Click += new System.EventHandler(this.Notification_template_Click);
            this.label_viewDateVal.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label_staff_MouseMove);
            // 
            // label_viewedTime
            // 
            this.label_viewedTime.AutoSize = true;
            this.label_viewedTime.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_viewedTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(2)))));
            this.label_viewedTime.Location = new System.Drawing.Point(646, 54);
            this.label_viewedTime.Name = "label_viewedTime";
            this.label_viewedTime.Size = new System.Drawing.Size(40, 16);
            this.label_viewedTime.TabIndex = 10;
            this.label_viewedTime.Text = "Time";
            this.label_viewedTime.Visible = false;
            this.label_viewedTime.Click += new System.EventHandler(this.Notification_template_Click);
            this.label_viewedTime.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label_staff_MouseMove);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Image = global::Placement_Application.Properties.Resources.notification_top;
            this.notifyIcon.Location = new System.Drawing.Point(0, 0);
            this.notifyIcon.Name = "notifyIcon";
            this.notifyIcon.Size = new System.Drawing.Size(120, 125);
            this.notifyIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.notifyIcon.TabIndex = 0;
            this.notifyIcon.TabStop = false;
            this.notifyIcon.Click += new System.EventHandler(this.Notification_template_Click);
            this.notifyIcon.MouseLeave += new System.EventHandler(this.Notification_template_MouseLeave);
            this.notifyIcon.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label_staff_MouseMove);
            // 
            // Notification_template
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label_viewedTime);
            this.Controls.Add(this.label_viewDateVal);
            this.Controls.Add(this.label_viewDate);
            this.Controls.Add(this.label_staff);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_studentCount);
            this.Controls.Add(this.label_company);
            this.Controls.Add(this.notifyIcon);
            this.Controls.Add(this.label_date);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Notification_template";
            this.Size = new System.Drawing.Size(795, 123);
            this.Load += new System.EventHandler(this.Notification_template_Load_1);
            this.Click += new System.EventHandler(this.Notification_template_Click);
            this.MouseLeave += new System.EventHandler(this.Notification_template_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label_staff_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.notifyIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_company;
        private System.Windows.Forms.Label label_studentCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_staff;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.Label label_viewDate;
        private System.Windows.Forms.Label label_viewDateVal;
        private System.Windows.Forms.Label label_viewedTime;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox notifyIcon;
    }
}
