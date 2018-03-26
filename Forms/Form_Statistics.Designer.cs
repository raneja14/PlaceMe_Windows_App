namespace Placement_Application
{
    partial class Form_Statistics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Statistics));
            this.panel_left = new System.Windows.Forms.Panel();
            this.but_yearly_stats = new System.Windows.Forms.Button();
            this.but_monthly_stats = new System.Windows.Forms.Button();
            this.but_comp_stats = new System.Windows.Forms.Button();
            this.but_student_stats = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.panel_logo = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel_top = new System.Windows.Forms.Panel();
            this.label_top_batch = new System.Windows.Forms.Label();
            this.label_date = new System.Windows.Forms.Label();
            this.label_time = new System.Windows.Forms.Label();
            this.pictureBox_home = new System.Windows.Forms.PictureBox();
            this.pictureBox_minimise = new System.Windows.Forms.PictureBox();
            this.pictureBox_power = new System.Windows.Forms.PictureBox();
            this.panel_main = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.but_home_side_panel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel_left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_minimise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_power)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_left
            // 
            this.panel_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.panel_left.Controls.Add(this.but_yearly_stats);
            this.panel_left.Controls.Add(this.but_monthly_stats);
            this.panel_left.Controls.Add(this.but_comp_stats);
            this.panel_left.Controls.Add(this.but_student_stats);
            this.panel_left.Controls.Add(this.pictureBox6);
            this.panel_left.Controls.Add(this.panel_logo);
            this.panel_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_left.Location = new System.Drawing.Point(0, 0);
            this.panel_left.Name = "panel_left";
            this.panel_left.Size = new System.Drawing.Size(204, 610);
            this.panel_left.TabIndex = 5;
            // 
            // but_yearly_stats
            // 
            this.but_yearly_stats.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_yearly_stats.Dock = System.Windows.Forms.DockStyle.Top;
            this.but_yearly_stats.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.but_yearly_stats.FlatAppearance.BorderSize = 2;
            this.but_yearly_stats.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.but_yearly_stats.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.but_yearly_stats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_yearly_stats.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_yearly_stats.ForeColor = System.Drawing.Color.White;
            this.but_yearly_stats.Image = global::Placement_Application.Properties.Resources.bar_graph__2_;
            this.but_yearly_stats.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_yearly_stats.Location = new System.Drawing.Point(0, 301);
            this.but_yearly_stats.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.but_yearly_stats.Name = "but_yearly_stats";
            this.but_yearly_stats.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.but_yearly_stats.Size = new System.Drawing.Size(204, 67);
            this.but_yearly_stats.TabIndex = 18;
            this.but_yearly_stats.Text = "Yearly Stats";
            this.but_yearly_stats.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_yearly_stats.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.but_yearly_stats.UseVisualStyleBackColor = true;
            this.but_yearly_stats.Click += new System.EventHandler(this.but_yearly_stats_Click);
            // 
            // but_monthly_stats
            // 
            this.but_monthly_stats.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_monthly_stats.Dock = System.Windows.Forms.DockStyle.Top;
            this.but_monthly_stats.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.but_monthly_stats.FlatAppearance.BorderSize = 2;
            this.but_monthly_stats.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.but_monthly_stats.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.but_monthly_stats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_monthly_stats.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_monthly_stats.ForeColor = System.Drawing.Color.White;
            this.but_monthly_stats.Image = global::Placement_Application.Properties.Resources.bar_graph__2_;
            this.but_monthly_stats.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_monthly_stats.Location = new System.Drawing.Point(0, 234);
            this.but_monthly_stats.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.but_monthly_stats.Name = "but_monthly_stats";
            this.but_monthly_stats.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.but_monthly_stats.Size = new System.Drawing.Size(204, 67);
            this.but_monthly_stats.TabIndex = 17;
            this.but_monthly_stats.Text = "Monthly Stats";
            this.but_monthly_stats.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_monthly_stats.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.but_monthly_stats.UseVisualStyleBackColor = true;
            this.but_monthly_stats.Click += new System.EventHandler(this.but_monthly_stats_Click);
            // 
            // but_comp_stats
            // 
            this.but_comp_stats.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_comp_stats.Dock = System.Windows.Forms.DockStyle.Top;
            this.but_comp_stats.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.but_comp_stats.FlatAppearance.BorderSize = 2;
            this.but_comp_stats.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.but_comp_stats.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.but_comp_stats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_comp_stats.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_comp_stats.ForeColor = System.Drawing.Color.White;
            this.but_comp_stats.Image = global::Placement_Application.Properties.Resources.pie_chart_stats__2_;
            this.but_comp_stats.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_comp_stats.Location = new System.Drawing.Point(0, 167);
            this.but_comp_stats.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.but_comp_stats.Name = "but_comp_stats";
            this.but_comp_stats.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.but_comp_stats.Size = new System.Drawing.Size(204, 67);
            this.but_comp_stats.TabIndex = 16;
            this.but_comp_stats.Text = "Company Stats";
            this.but_comp_stats.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_comp_stats.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.but_comp_stats.UseVisualStyleBackColor = true;
            this.but_comp_stats.Click += new System.EventHandler(this.but_comp_stats_Click);
            // 
            // but_student_stats
            // 
            this.but_student_stats.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_student_stats.Dock = System.Windows.Forms.DockStyle.Top;
            this.but_student_stats.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.but_student_stats.FlatAppearance.BorderSize = 2;
            this.but_student_stats.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.but_student_stats.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.but_student_stats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_student_stats.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_student_stats.ForeColor = System.Drawing.Color.White;
            this.but_student_stats.Image = global::Placement_Application.Properties.Resources.pie_chart_stats__2_;
            this.but_student_stats.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_student_stats.Location = new System.Drawing.Point(0, 100);
            this.but_student_stats.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.but_student_stats.Name = "but_student_stats";
            this.but_student_stats.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.but_student_stats.Size = new System.Drawing.Size(204, 67);
            this.but_student_stats.TabIndex = 15;
            this.but_student_stats.Text = "Student Stats";
            this.but_student_stats.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_student_stats.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.but_student_stats.UseVisualStyleBackColor = true;
            this.but_student_stats.Click += new System.EventHandler(this.but_student_stats_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Image = global::Placement_Application.Properties.Resources.profit_chart__4_;
            this.pictureBox6.Location = new System.Drawing.Point(-28, 354);
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
            this.pictureBox3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_top_MouseMove);
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.panel_top.Controls.Add(this.label_top_batch);
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
            // label_top_batch
            // 
            this.label_top_batch.AutoSize = true;
            this.label_top_batch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_top_batch.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold);
            this.label_top_batch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(2)))));
            this.label_top_batch.Location = new System.Drawing.Point(3, 4);
            this.label_top_batch.Name = "label_top_batch";
            this.label_top_batch.Size = new System.Drawing.Size(101, 23);
            this.label_top_batch.TabIndex = 13;
            this.label_top_batch.Text = "xxxx-xx";
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_date.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_date.ForeColor = System.Drawing.Color.White;
            this.label_date.Location = new System.Drawing.Point(3, 80);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(0, 20);
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
            this.label_time.Size = new System.Drawing.Size(0, 20);
            this.label_time.TabIndex = 11;
            // 
            // pictureBox_home
            // 
            this.pictureBox_home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_home.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox_home.Image = global::Placement_Application.Properties.Resources.house_outline;
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
            this.panel_main.TabIndex = 8;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // but_home_side_panel
            // 
            this.but_home_side_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.but_home_side_panel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.but_home_side_panel.FlatAppearance.BorderSize = 2;
            this.but_home_side_panel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.but_home_side_panel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_home_side_panel.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_home_side_panel.ForeColor = System.Drawing.Color.White;
            this.but_home_side_panel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_home_side_panel.Location = new System.Drawing.Point(0, 100);
            this.but_home_side_panel.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.but_home_side_panel.Name = "but_home_side_panel";
            this.but_home_side_panel.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.but_home_side_panel.Size = new System.Drawing.Size(204, 67);
            this.but_home_side_panel.TabIndex = 15;
            this.but_home_side_panel.Text = "Student Stats";
            this.but_home_side_panel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_home_side_panel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.but_home_side_panel.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 167);
            this.button1.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(204, 67);
            this.button1.TabIndex = 16;
            this.button1.Text = "Company Stats";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 234);
            this.button2.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(204, 67);
            this.button2.TabIndex = 17;
            this.button2.Text = "Overall Stats";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // Form_Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 610);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_top);
            this.Controls.Add(this.panel_left);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form_Statistics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Statistics";
            this.Load += new System.EventHandler(this.Form_Statistics_Load);
            this.panel_left.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel_logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
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
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.PictureBox pictureBox_home;
        private System.Windows.Forms.PictureBox pictureBox_minimise;
        private System.Windows.Forms.PictureBox pictureBox_power;
        public System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button but_monthly_stats;
        private System.Windows.Forms.Button but_comp_stats;
        private System.Windows.Forms.Button but_student_stats;
        private System.Windows.Forms.Button but_home_side_panel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button but_yearly_stats;
        private System.Windows.Forms.Label label_top_batch;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}