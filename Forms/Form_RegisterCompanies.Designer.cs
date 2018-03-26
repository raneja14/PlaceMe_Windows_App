namespace Placement_Application
{
    partial class Form_RegisterCompanies
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_RegisterCompanies));
            this.panel_left = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.panel_logo = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel_top = new System.Windows.Forms.Panel();
            this.label_top_batch = new System.Windows.Forms.Label();
            this.picture_refresh = new System.Windows.Forms.PictureBox();
            this.label_date = new System.Windows.Forms.Label();
            this.label_time = new System.Windows.Forms.Label();
            this.picture_home = new System.Windows.Forms.PictureBox();
            this.picture_minimise = new System.Windows.Forms.PictureBox();
            this.picture_power = new System.Windows.Forms.PictureBox();
            this.panel_main = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.but_registerCompany = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dropown_status = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTime_dor = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_collegeName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dropdown_companyType = new System.Windows.Forms.ComboBox();
            this.textBox_companyName = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel_left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_refresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_minimise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_power)).BeginInit();
            this.panel_main.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_left
            // 
            this.panel_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.panel_left.Controls.Add(this.pictureBox6);
            this.panel_left.Controls.Add(this.panel_logo);
            this.panel_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_left.Location = new System.Drawing.Point(0, 0);
            this.panel_left.Name = "panel_left";
            this.panel_left.Size = new System.Drawing.Size(204, 610);
            this.panel_left.TabIndex = 4;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Image = global::Placement_Application.Properties.Resources.clipboard_with_pencil___4_;
            this.pictureBox6.Location = new System.Drawing.Point(-21, 231);
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
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.panel_top.Controls.Add(this.label_top_batch);
            this.panel_top.Controls.Add(this.picture_refresh);
            this.panel_top.Controls.Add(this.label_date);
            this.panel_top.Controls.Add(this.label_time);
            this.panel_top.Controls.Add(this.picture_home);
            this.panel_top.Controls.Add(this.picture_minimise);
            this.panel_top.Controls.Add(this.picture_power);
            this.panel_top.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(204, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(801, 100);
            this.panel_top.TabIndex = 3;
            this.panel_top.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_top_MouseMove);
            // 
            // label_top_batch
            // 
            this.label_top_batch.AutoSize = true;
            this.label_top_batch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_top_batch.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold);
            this.label_top_batch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(2)))));
            this.label_top_batch.Location = new System.Drawing.Point(2, 3);
            this.label_top_batch.Name = "label_top_batch";
            this.label_top_batch.Size = new System.Drawing.Size(101, 23);
            this.label_top_batch.TabIndex = 14;
            this.label_top_batch.Text = "xxxx-xx";
            // 
            // picture_refresh
            // 
            this.picture_refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picture_refresh.Dock = System.Windows.Forms.DockStyle.Right;
            this.picture_refresh.Image = global::Placement_Application.Properties.Resources.update_arrow__1_;
            this.picture_refresh.Location = new System.Drawing.Point(401, 0);
            this.picture_refresh.Name = "picture_refresh";
            this.picture_refresh.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.picture_refresh.Size = new System.Drawing.Size(100, 100);
            this.picture_refresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picture_refresh.TabIndex = 13;
            this.picture_refresh.TabStop = false;
            this.picture_refresh.Tag = "";
            this.picture_refresh.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_date.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_date.ForeColor = System.Drawing.Color.White;
            this.label_date.Location = new System.Drawing.Point(7, 77);
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
            this.label_time.Location = new System.Drawing.Point(7, 57);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(0, 17);
            this.label_time.TabIndex = 11;
            // 
            // picture_home
            // 
            this.picture_home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picture_home.Dock = System.Windows.Forms.DockStyle.Right;
            this.picture_home.Image = global::Placement_Application.Properties.Resources.house_outline1;
            this.picture_home.Location = new System.Drawing.Point(501, 0);
            this.picture_home.Name = "picture_home";
            this.picture_home.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.picture_home.Size = new System.Drawing.Size(100, 100);
            this.picture_home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picture_home.TabIndex = 10;
            this.picture_home.TabStop = false;
            this.picture_home.Tag = "";
            this.picture_home.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // picture_minimise
            // 
            this.picture_minimise.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picture_minimise.Dock = System.Windows.Forms.DockStyle.Right;
            this.picture_minimise.Image = global::Placement_Application.Properties.Resources.computer_screen;
            this.picture_minimise.Location = new System.Drawing.Point(601, 0);
            this.picture_minimise.Name = "picture_minimise";
            this.picture_minimise.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.picture_minimise.Size = new System.Drawing.Size(100, 100);
            this.picture_minimise.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picture_minimise.TabIndex = 1;
            this.picture_minimise.TabStop = false;
            this.picture_minimise.Tag = "";
            this.picture_minimise.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // picture_power
            // 
            this.picture_power.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picture_power.Dock = System.Windows.Forms.DockStyle.Right;
            this.picture_power.Image = global::Placement_Application.Properties.Resources.power_button_off;
            this.picture_power.Location = new System.Drawing.Point(701, 0);
            this.picture_power.Name = "picture_power";
            this.picture_power.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.picture_power.Size = new System.Drawing.Size(100, 100);
            this.picture_power.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picture_power.TabIndex = 0;
            this.picture_power.TabStop = false;
            this.picture_power.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.groupBox1);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_main.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel_main.Location = new System.Drawing.Point(204, 100);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(801, 510);
            this.panel_main.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.but_registerCompany);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dropown_status);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateTime_dor);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox_collegeName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dropdown_companyType);
            this.groupBox1.Controls.Add(this.textBox_companyName);
            this.groupBox1.Location = new System.Drawing.Point(37, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(733, 428);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(90, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "COMPANY";
            // 
            // but_registerCompany
            // 
            this.but_registerCompany.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.but_registerCompany.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_registerCompany.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.but_registerCompany.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.but_registerCompany.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_registerCompany.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_registerCompany.ForeColor = System.Drawing.Color.White;
            this.but_registerCompany.Image = global::Placement_Application.Properties.Resources.check_mark__4_;
            this.but_registerCompany.Location = new System.Drawing.Point(474, 343);
            this.but_registerCompany.Name = "but_registerCompany";
            this.but_registerCompany.Size = new System.Drawing.Size(203, 55);
            this.but_registerCompany.TabIndex = 12;
            this.but_registerCompany.Text = "REGISTER";
            this.but_registerCompany.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.but_registerCompany.UseVisualStyleBackColor = false;
            this.but_registerCompany.Click += new System.EventHandler(this.but_registerCompany_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label2.Location = new System.Drawing.Point(90, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "STATUS";
            // 
            // dropown_status
            // 
            this.dropown_status.BackColor = System.Drawing.Color.White;
            this.dropown_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropown_status.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropown_status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.dropown_status.FormattingEnabled = true;
            this.dropown_status.Location = new System.Drawing.Point(53, 365);
            this.dropown_status.Name = "dropown_status";
            this.dropown_status.Size = new System.Drawing.Size(177, 24);
            this.dropown_status.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label3.Location = new System.Drawing.Point(71, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "HOST COLLEGE";
            // 
            // dateTime_dor
            // 
            this.dateTime_dor.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.dateTime_dor.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.dateTime_dor.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.dateTime_dor.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.dateTime_dor.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.dateTime_dor.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime_dor.Location = new System.Drawing.Point(487, 235);
            this.dateTime_dor.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTime_dor.Name = "dateTime_dor";
            this.dateTime_dor.Size = new System.Drawing.Size(177, 22);
            this.dateTime_dor.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label4.Location = new System.Drawing.Point(541, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 27);
            this.label4.TabIndex = 5;
            this.label4.Text = "TYPE";
            // 
            // textBox_collegeName
            // 
            this.textBox_collegeName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox_collegeName.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_collegeName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.textBox_collegeName.Location = new System.Drawing.Point(53, 235);
            this.textBox_collegeName.Name = "textBox_collegeName";
            this.textBox_collegeName.Size = new System.Drawing.Size(177, 24);
            this.textBox_collegeName.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label5.Location = new System.Drawing.Point(497, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 27);
            this.label5.TabIndex = 6;
            this.label5.Text = "ESTD. D.O.R";
            // 
            // dropdown_companyType
            // 
            this.dropdown_companyType.BackColor = System.Drawing.Color.White;
            this.dropdown_companyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdown_companyType.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropdown_companyType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.dropdown_companyType.FormattingEnabled = true;
            this.dropdown_companyType.Location = new System.Drawing.Point(487, 103);
            this.dropdown_companyType.Name = "dropdown_companyType";
            this.dropdown_companyType.Size = new System.Drawing.Size(177, 24);
            this.dropdown_companyType.TabIndex = 8;
            this.dropdown_companyType.SelectedIndexChanged += new System.EventHandler(this.dropdown_companyType_SelectedIndexChanged);
            // 
            // textBox_companyName
            // 
            this.textBox_companyName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox_companyName.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_companyName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.textBox_companyName.Location = new System.Drawing.Point(53, 102);
            this.textBox_companyName.Name = "textBox_companyName";
            this.textBox_companyName.Size = new System.Drawing.Size(177, 24);
            this.textBox_companyName.TabIndex = 7;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // Form_RegisterCompanies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 610);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_top);
            this.Controls.Add(this.panel_left);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_RegisterCompanies";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterCompaniesForm";
            this.Load += new System.EventHandler(this.RegisterCompaniesForm_Load);
            this.panel_left.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel_logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_refresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_minimise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_power)).EndInit();
            this.panel_main.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_left;
        private System.Windows.Forms.Panel panel_logo;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.PictureBox picture_minimise;
        private System.Windows.Forms.PictureBox picture_power;
        private System.Windows.Forms.PictureBox picture_home;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.PictureBox picture_refresh;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_companyName;
        private System.Windows.Forms.ComboBox dropdown_companyType;
        private System.Windows.Forms.TextBox textBox_collegeName;
        private System.Windows.Forms.DateTimePicker dateTime_dor;
        private System.Windows.Forms.ComboBox dropown_status;
        private System.Windows.Forms.Button but_registerCompany;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_top_batch;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}