namespace Placement_Application
{
    partial class Control_Details
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dropdown_am_pm = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numeric_min = new System.Windows.Forms.NumericUpDown();
            this.numeric_hr = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTime_date = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dropdown_company = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_venue = new System.Windows.Forms.TextBox();
            this.groupBox_msg = new System.Windows.Forms.GroupBox();
            this.but_next = new System.Windows.Forms.Button();
            this.text_msg_content = new System.Windows.Forms.RichTextBox();
            this.but_msg = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_hr)).BeginInit();
            this.groupBox_msg.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox1.Controls.Add(this.dropdown_am_pm);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numeric_min);
            this.groupBox1.Controls.Add(this.numeric_hr);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTime_date);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dropdown_company);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_venue);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(16, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(762, 106);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // dropdown_am_pm
            // 
            this.dropdown_am_pm.BackColor = System.Drawing.SystemColors.Window;
            this.dropdown_am_pm.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropdown_am_pm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.dropdown_am_pm.FormattingEnabled = true;
            this.dropdown_am_pm.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.dropdown_am_pm.Location = new System.Drawing.Point(664, 69);
            this.dropdown_am_pm.Name = "dropdown_am_pm";
            this.dropdown_am_pm.Size = new System.Drawing.Size(52, 22);
            this.dropdown_am_pm.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Buxton Sketch", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label2.Location = new System.Drawing.Point(565, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 26);
            this.label2.TabIndex = 21;
            this.label2.Text = ":";
            // 
            // numeric_min
            // 
            this.numeric_min.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold);
            this.numeric_min.Location = new System.Drawing.Point(584, 69);
            this.numeric_min.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numeric_min.Name = "numeric_min";
            this.numeric_min.Size = new System.Drawing.Size(52, 21);
            this.numeric_min.TabIndex = 20;
            this.numeric_min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numeric_min.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // numeric_hr
            // 
            this.numeric_hr.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold);
            this.numeric_hr.Location = new System.Drawing.Point(521, 69);
            this.numeric_hr.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numeric_hr.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_hr.Name = "numeric_hr";
            this.numeric_hr.Size = new System.Drawing.Size(46, 21);
            this.numeric_hr.TabIndex = 19;
            this.numeric_hr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numeric_hr.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(23, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "COMPANY";
            // 
            // dateTime_date
            // 
            this.dateTime_date.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.dateTime_date.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.dateTime_date.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.dateTime_date.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.dateTime_date.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.dateTime_date.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime_date.Location = new System.Drawing.Point(520, 20);
            this.dateTime_date.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTime_date.Name = "dateTime_date";
            this.dateTime_date.Size = new System.Drawing.Size(195, 21);
            this.dateTime_date.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label5.Location = new System.Drawing.Point(432, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 22);
            this.label5.TabIndex = 14;
            this.label5.Text = "DATE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label4.Location = new System.Drawing.Point(432, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 22);
            this.label4.TabIndex = 13;
            this.label4.Text = "TIME";
            // 
            // dropdown_company
            // 
            this.dropdown_company.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.dropdown_company.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.dropdown_company.BackColor = System.Drawing.SystemColors.Window;
            this.dropdown_company.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropdown_company.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.dropdown_company.FormattingEnabled = true;
            this.dropdown_company.ItemHeight = 14;
            this.dropdown_company.Location = new System.Drawing.Point(137, 19);
            this.dropdown_company.MaxDropDownItems = 2;
            this.dropdown_company.Name = "dropdown_company";
            this.dropdown_company.Size = new System.Drawing.Size(176, 22);
            this.dropdown_company.TabIndex = 16;
            this.dropdown_company.SelectedIndexChanged += new System.EventHandler(this.dropdown_company_SelectedIndexChanged);
            this.dropdown_company.Leave += new System.EventHandler(this.dropdown_company_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label3.Location = new System.Drawing.Point(23, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 22);
            this.label3.TabIndex = 12;
            this.label3.Text = "VENUE";
            // 
            // textBox_venue
            // 
            this.textBox_venue.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox_venue.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_venue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.textBox_venue.Location = new System.Drawing.Point(137, 68);
            this.textBox_venue.Name = "textBox_venue";
            this.textBox_venue.Size = new System.Drawing.Size(176, 21);
            this.textBox_venue.TabIndex = 17;
            this.textBox_venue.Leave += new System.EventHandler(this.textBox_venue_Leave);
            // 
            // groupBox_msg
            // 
            this.groupBox_msg.Controls.Add(this.but_next);
            this.groupBox_msg.Controls.Add(this.text_msg_content);
            this.groupBox_msg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox_msg.Location = new System.Drawing.Point(16, 159);
            this.groupBox_msg.Name = "groupBox_msg";
            this.groupBox_msg.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox_msg.Size = new System.Drawing.Size(762, 339);
            this.groupBox_msg.TabIndex = 1;
            this.groupBox_msg.TabStop = false;
            this.groupBox_msg.Visible = false;
            // 
            // but_next
            // 
            this.but_next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(208)))), ((int)(((byte)(147)))));
            this.but_next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_next.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.but_next.FlatAppearance.BorderSize = 0;
            this.but_next.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(208)))), ((int)(((byte)(147)))));
            this.but_next.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(228)))), ((int)(((byte)(147)))));
            this.but_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_next.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_next.ForeColor = System.Drawing.Color.White;
            this.but_next.Location = new System.Drawing.Point(0, 296);
            this.but_next.Name = "but_next";
            this.but_next.Size = new System.Drawing.Size(762, 43);
            this.but_next.TabIndex = 33;
            this.but_next.Text = "NEXT";
            this.but_next.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.but_next.UseVisualStyleBackColor = false;
            this.but_next.Click += new System.EventHandler(this.but_next_Click);
            // 
            // text_msg_content
            // 
            this.text_msg_content.BackColor = System.Drawing.Color.WhiteSmoke;
            this.text_msg_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.text_msg_content.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_msg_content.Location = new System.Drawing.Point(0, 13);
            this.text_msg_content.Name = "text_msg_content";
            this.text_msg_content.Size = new System.Drawing.Size(762, 326);
            this.text_msg_content.TabIndex = 21;
            this.text_msg_content.Text = "";
            // 
            // but_msg
            // 
            this.but_msg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.but_msg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_msg.Enabled = false;
            this.but_msg.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.but_msg.FlatAppearance.BorderSize = 2;
            this.but_msg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.but_msg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.but_msg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_msg.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_msg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.but_msg.Image = global::Placement_Application.Properties.Resources.chat_comment_oval_speech_bubble_with_text_lines__2_;
            this.but_msg.Location = new System.Drawing.Point(325, 113);
            this.but_msg.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.but_msg.Name = "but_msg";
            this.but_msg.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.but_msg.Size = new System.Drawing.Size(117, 48);
            this.but_msg.TabIndex = 20;
            this.but_msg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_msg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.but_msg.UseVisualStyleBackColor = false;
            this.but_msg.Click += new System.EventHandler(this.but_msg_Click);
            this.but_msg.MouseHover += new System.EventHandler(this.but_msg_MouseHover);
            // 
            // Control_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.but_msg);
            this.Controls.Add(this.groupBox_msg);
            this.Controls.Add(this.groupBox1);
            this.Name = "Control_Details";
            this.Size = new System.Drawing.Size(801, 510);
            this.Load += new System.EventHandler(this.Control_Details_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_hr)).EndInit();
            this.groupBox_msg.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox_msg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_venue;
        private System.Windows.Forms.ComboBox dropdown_company;
        private System.Windows.Forms.DateTimePicker dateTime_date;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numeric_min;
        private System.Windows.Forms.NumericUpDown numeric_hr;
        private System.Windows.Forms.ComboBox dropdown_am_pm;
        public System.Windows.Forms.Button but_msg;
        private System.Windows.Forms.RichTextBox text_msg_content;
        private System.Windows.Forms.Button but_next;


    }
}
