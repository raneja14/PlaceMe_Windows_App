namespace Placement_Application
{
    partial class Control_Notify
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Control_Notify));
            this.but_otp = new System.Windows.Forms.Button();
            this.groupBox_verify = new System.Windows.Forms.GroupBox();
            this.label_sec_msg = new System.Windows.Forms.Label();
            this.label_secLeft = new System.Windows.Forms.Label();
            this.but_verify = new System.Windows.Forms.Button();
            this.text_otp = new System.Windows.Forms.TextBox();
            this.groupBox_notify = new System.Windows.Forms.GroupBox();
            this.but_notify = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_msg = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label_eligible = new System.Windows.Forms.Label();
            this.label_time = new System.Windows.Forms.Label();
            this.label_venue = new System.Windows.Forms.Label();
            this.label_date = new System.Windows.Forms.Label();
            this.label_company = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_status = new System.Windows.Forms.Label();
            this.label_xii = new System.Windows.Forms.Label();
            this.label_x = new System.Windows.Forms.Label();
            this.label_arrears = new System.Windows.Forms.Label();
            this.label_branch = new System.Windows.Forms.Label();
            this.label_cgpa = new System.Windows.Forms.Label();
            this.label_degree = new System.Windows.Forms.Label();
            this.label_batch = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer_second = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox_verify.SuspendLayout();
            this.groupBox_notify.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // but_otp
            // 
            this.but_otp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.but_otp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_otp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.but_otp.FlatAppearance.BorderSize = 2;
            this.but_otp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.but_otp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.but_otp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_otp.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_otp.ForeColor = System.Drawing.Color.White;
            this.but_otp.Image = ((System.Drawing.Image)(resources.GetObject("but_otp.Image")));
            this.but_otp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_otp.Location = new System.Drawing.Point(60, 28);
            this.but_otp.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.but_otp.Name = "but_otp";
            this.but_otp.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.but_otp.Size = new System.Drawing.Size(162, 42);
            this.but_otp.TabIndex = 22;
            this.but_otp.Text = "SEND OTP";
            this.but_otp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_otp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.but_otp.UseVisualStyleBackColor = false;
            this.but_otp.Click += new System.EventHandler(this.but_otp_Click);
            // 
            // groupBox_verify
            // 
            this.groupBox_verify.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox_verify.Controls.Add(this.label_sec_msg);
            this.groupBox_verify.Controls.Add(this.label_secLeft);
            this.groupBox_verify.Controls.Add(this.but_verify);
            this.groupBox_verify.Controls.Add(this.text_otp);
            this.groupBox_verify.Controls.Add(this.but_otp);
            this.groupBox_verify.Location = new System.Drawing.Point(24, 3);
            this.groupBox_verify.Name = "groupBox_verify";
            this.groupBox_verify.Size = new System.Drawing.Size(741, 100);
            this.groupBox_verify.TabIndex = 23;
            this.groupBox_verify.TabStop = false;
            // 
            // label_sec_msg
            // 
            this.label_sec_msg.AutoSize = true;
            this.label_sec_msg.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sec_msg.ForeColor = System.Drawing.Color.Tomato;
            this.label_sec_msg.Location = new System.Drawing.Point(67, 73);
            this.label_sec_msg.Name = "label_sec_msg";
            this.label_sec_msg.Size = new System.Drawing.Size(128, 16);
            this.label_sec_msg.TabIndex = 27;
            this.label_sec_msg.Text = "Resend OTP in :";
            this.label_sec_msg.Visible = false;
            // 
            // label_secLeft
            // 
            this.label_secLeft.AutoSize = true;
            this.label_secLeft.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_secLeft.ForeColor = System.Drawing.Color.Tomato;
            this.label_secLeft.Location = new System.Drawing.Point(192, 73);
            this.label_secLeft.Name = "label_secLeft";
            this.label_secLeft.Size = new System.Drawing.Size(24, 16);
            this.label_secLeft.TabIndex = 26;
            this.label_secLeft.Text = "60";
            this.label_secLeft.Visible = false;
            // 
            // but_verify
            // 
            this.but_verify.AutoEllipsis = true;
            this.but_verify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.but_verify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_verify.Enabled = false;
            this.but_verify.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.but_verify.FlatAppearance.BorderSize = 2;
            this.but_verify.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.but_verify.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.but_verify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_verify.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_verify.ForeColor = System.Drawing.Color.Chartreuse;
            this.but_verify.Image = global::Placement_Application.Properties.Resources.verification_of_delivery_list_clipboard_symbol__2_;
            this.but_verify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_verify.Location = new System.Drawing.Point(540, 28);
            this.but_verify.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.but_verify.Name = "but_verify";
            this.but_verify.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.but_verify.Size = new System.Drawing.Size(145, 42);
            this.but_verify.TabIndex = 25;
            this.but_verify.Text = "VERIFY";
            this.but_verify.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_verify.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.but_verify.UseVisualStyleBackColor = false;
            this.but_verify.Click += new System.EventHandler(this.but_verify_Click);
            // 
            // text_otp
            // 
            this.text_otp.BackColor = System.Drawing.Color.White;
            this.text_otp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_otp.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_otp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.text_otp.Location = new System.Drawing.Point(315, 28);
            this.text_otp.MaxLength = 4;
            this.text_otp.Name = "text_otp";
            this.text_otp.Size = new System.Drawing.Size(147, 41);
            this.text_otp.TabIndex = 24;
            this.text_otp.Tag = "";
            this.text_otp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.text_otp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_otp_KeyDown);
            // 
            // groupBox_notify
            // 
            this.groupBox_notify.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox_notify.Controls.Add(this.but_notify);
            this.groupBox_notify.Controls.Add(this.groupBox2);
            this.groupBox_notify.Controls.Add(this.groupBox1);
            this.groupBox_notify.Location = new System.Drawing.Point(24, 109);
            this.groupBox_notify.Name = "groupBox_notify";
            this.groupBox_notify.Size = new System.Drawing.Size(741, 374);
            this.groupBox_notify.TabIndex = 24;
            this.groupBox_notify.TabStop = false;
            this.groupBox_notify.Visible = false;
            // 
            // but_notify
            // 
            this.but_notify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.but_notify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_notify.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.but_notify.FlatAppearance.BorderSize = 2;
            this.but_notify.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.but_notify.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.but_notify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_notify.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_notify.ForeColor = System.Drawing.Color.Chartreuse;
            this.but_notify.Image = global::Placement_Application.Properties.Resources.sms_message__2_;
            this.but_notify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_notify.Location = new System.Drawing.Point(571, 151);
            this.but_notify.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.but_notify.Name = "but_notify";
            this.but_notify.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.but_notify.Size = new System.Drawing.Size(145, 88);
            this.but_notify.TabIndex = 27;
            this.but_notify.Text = "NOTIFY";
            this.but_notify.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_notify.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.but_notify.UseVisualStyleBackColor = false;
            this.but_notify.Click += new System.EventHandler(this.but_notify_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.label_msg);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label_eligible);
            this.groupBox2.Controls.Add(this.label_time);
            this.groupBox2.Controls.Add(this.label_venue);
            this.groupBox2.Controls.Add(this.label_date);
            this.groupBox2.Controls.Add(this.label_company);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Location = new System.Drawing.Point(270, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(281, 305);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // label_msg
            // 
            this.label_msg.AutoSize = true;
            this.label_msg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_msg.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_msg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.label_msg.Location = new System.Drawing.Point(88, 263);
            this.label_msg.Name = "label_msg";
            this.label_msg.Size = new System.Drawing.Size(134, 16);
            this.label_msg.TabIndex = 22;
            this.label_msg.Text = "Dear Student .....";
            this.label_msg.MouseHover += new System.EventHandler(this.label_msg_MouseHover);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label9.Location = new System.Drawing.Point(6, 263);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "MESSAGE:";
            // 
            // label_eligible
            // 
            this.label_eligible.AutoSize = true;
            this.label_eligible.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_eligible.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.label_eligible.Location = new System.Drawing.Point(88, 214);
            this.label_eligible.Name = "label_eligible";
            this.label_eligible.Size = new System.Drawing.Size(29, 16);
            this.label_eligible.TabIndex = 20;
            this.label_eligible.Text = " 25";
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.label_time.Location = new System.Drawing.Point(88, 168);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(64, 16);
            this.label_time.TabIndex = 19;
            this.label_time.Text = "10:30 AM";
            // 
            // label_venue
            // 
            this.label_venue.AutoSize = true;
            this.label_venue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_venue.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_venue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.label_venue.Location = new System.Drawing.Point(88, 121);
            this.label_venue.Name = "label_venue";
            this.label_venue.Size = new System.Drawing.Size(169, 16);
            this.label_venue.TabIndex = 18;
            this.label_venue.Text = "T.P.GANESHAN AUDITORIUM";
            this.label_venue.MouseHover += new System.EventHandler(this.label_venue_MouseHover);
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.label_date.Location = new System.Drawing.Point(88, 75);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(85, 16);
            this.label_date.TabIndex = 17;
            this.label_date.Text = "14-APR-2016";
            // 
            // label_company
            // 
            this.label_company.AutoSize = true;
            this.label_company.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_company.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_company.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.label_company.Location = new System.Drawing.Point(88, 33);
            this.label_company.Name = "label_company";
            this.label_company.Size = new System.Drawing.Size(50, 16);
            this.label_company.TabIndex = 16;
            this.label_company.Text = "GOOGLE";
            this.label_company.MouseHover += new System.EventHandler(this.label_company_MouseHover);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label17.Location = new System.Drawing.Point(6, 168);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 17);
            this.label17.TabIndex = 11;
            this.label17.Text = "TIME:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label18.Location = new System.Drawing.Point(6, 214);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(89, 17);
            this.label18.TabIndex = 10;
            this.label18.Text = "ELIGIBLE:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label19.Location = new System.Drawing.Point(6, 121);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(62, 17);
            this.label19.TabIndex = 9;
            this.label19.Text = "VENUE:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label20.Location = new System.Drawing.Point(6, 75);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(53, 17);
            this.label20.TabIndex = 8;
            this.label20.Text = "DATE:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label21.Location = new System.Drawing.Point(6, 33);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(80, 17);
            this.label21.TabIndex = 7;
            this.label21.Text = "COMPANY:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.label_status);
            this.groupBox1.Controls.Add(this.label_xii);
            this.groupBox1.Controls.Add(this.label_x);
            this.groupBox1.Controls.Add(this.label_arrears);
            this.groupBox1.Controls.Add(this.label_branch);
            this.groupBox1.Controls.Add(this.label_cgpa);
            this.groupBox1.Controls.Add(this.label_degree);
            this.groupBox1.Controls.Add(this.label_batch);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(22, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 348);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.label_status.Location = new System.Drawing.Point(125, 322);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(98, 17);
            this.label_status.TabIndex = 15;
            this.label_status.Text = "NON-PLACED";
            // 
            // label_xii
            // 
            this.label_xii.AutoSize = true;
            this.label_xii.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_xii.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.label_xii.Location = new System.Drawing.Point(125, 279);
            this.label_xii.Name = "label_xii";
            this.label_xii.Size = new System.Drawing.Size(35, 17);
            this.label_xii.TabIndex = 14;
            this.label_xii.Text = "70%";
            // 
            // label_x
            // 
            this.label_x.AutoSize = true;
            this.label_x.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_x.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.label_x.Location = new System.Drawing.Point(125, 238);
            this.label_x.Name = "label_x";
            this.label_x.Size = new System.Drawing.Size(35, 17);
            this.label_x.TabIndex = 13;
            this.label_x.Text = "70%";
            // 
            // label_arrears
            // 
            this.label_arrears.AutoSize = true;
            this.label_arrears.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_arrears.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.label_arrears.Location = new System.Drawing.Point(125, 197);
            this.label_arrears.Name = "label_arrears";
            this.label_arrears.Size = new System.Drawing.Size(17, 17);
            this.label_arrears.TabIndex = 12;
            this.label_arrears.Text = "1";
            // 
            // label_branch
            // 
            this.label_branch.AutoSize = true;
            this.label_branch.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_branch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.label_branch.Location = new System.Drawing.Point(125, 151);
            this.label_branch.Name = "label_branch";
            this.label_branch.Size = new System.Drawing.Size(17, 17);
            this.label_branch.TabIndex = 11;
            this.label_branch.Text = "3";
            // 
            // label_cgpa
            // 
            this.label_cgpa.AutoSize = true;
            this.label_cgpa.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cgpa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.label_cgpa.Location = new System.Drawing.Point(125, 104);
            this.label_cgpa.Name = "label_cgpa";
            this.label_cgpa.Size = new System.Drawing.Size(35, 17);
            this.label_cgpa.TabIndex = 10;
            this.label_cgpa.Text = "7.0";
            // 
            // label_degree
            // 
            this.label_degree.AutoSize = true;
            this.label_degree.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_degree.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.label_degree.Location = new System.Drawing.Point(125, 58);
            this.label_degree.Name = "label_degree";
            this.label_degree.Size = new System.Drawing.Size(62, 17);
            this.label_degree.TabIndex = 9;
            this.label_degree.Text = "B.TECH";
            // 
            // label_batch
            // 
            this.label_batch.AutoSize = true;
            this.label_batch.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_batch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.label_batch.Location = new System.Drawing.Point(125, 16);
            this.label_batch.Name = "label_batch";
            this.label_batch.Size = new System.Drawing.Size(44, 17);
            this.label_batch.TabIndex = 8;
            this.label_batch.Text = "2012";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label8.Location = new System.Drawing.Point(6, 322);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "STATUS:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label7.Location = new System.Drawing.Point(6, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "BRANCH:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label6.Location = new System.Drawing.Point(6, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "XII%:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label5.Location = new System.Drawing.Point(6, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "X%:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label4.Location = new System.Drawing.Point(6, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "ARREARS:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label3.Location = new System.Drawing.Point(6, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "CGPA:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "DEGREE:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "BATCH:";
            // 
            // timer_second
            // 
            this.timer_second.Interval = 1000;
            this.timer_second.Tick += new System.EventHandler(this.timer_second_Tick);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // Control_Notify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox_notify);
            this.Controls.Add(this.groupBox_verify);
            this.Name = "Control_Notify";
            this.Size = new System.Drawing.Size(801, 510);
            this.Load += new System.EventHandler(this.Control_Verify_Load);
            this.groupBox_verify.ResumeLayout(false);
            this.groupBox_verify.PerformLayout();
            this.groupBox_notify.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button but_otp;
        private System.Windows.Forms.GroupBox groupBox_verify;
        private System.Windows.Forms.TextBox text_otp;
        public System.Windows.Forms.Button but_verify;
        private System.Windows.Forms.Label label_secLeft;
        private System.Windows.Forms.GroupBox groupBox_notify;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_batch;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.Label label_xii;
        private System.Windows.Forms.Label label_x;
        private System.Windows.Forms.Label label_arrears;
        private System.Windows.Forms.Label label_branch;
        private System.Windows.Forms.Label label_cgpa;
        private System.Windows.Forms.Label label_degree;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label_company;
        private System.Windows.Forms.Label label_eligible;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Label label_venue;
        private System.Windows.Forms.Label label_date;
        public System.Windows.Forms.Button but_notify;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label_msg;
        private System.Windows.Forms.Label label_sec_msg;
        private System.Windows.Forms.Timer timer_second;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
