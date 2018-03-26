namespace Placement_Application
{
    partial class Dialog_UpdateStudentCompany
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dialog_UpdateStudentCompany));
            this.label_studentId = new System.Windows.Forms.Label();
            this.label_title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTime_dor = new System.Windows.Forms.DateTimePicker();
            this.dropdown_company = new System.Windows.Forms.ComboBox();
            this.but_update = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_studentId
            // 
            this.label_studentId.AutoSize = true;
            this.label_studentId.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_studentId.ForeColor = System.Drawing.Color.White;
            this.label_studentId.Location = new System.Drawing.Point(100, 21);
            this.label_studentId.Name = "label_studentId";
            this.label_studentId.Size = new System.Drawing.Size(100, 27);
            this.label_studentId.TabIndex = 1;
            this.label_studentId.Text = "StudenID";
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_title.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.label_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label_title.Location = new System.Drawing.Point(4, 95);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(108, 18);
            this.label_title.TabIndex = 7;
            this.label_title.Text = "PLACED IN:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(4, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "PLACED ON:";
            // 
            // dateTime_dor
            // 
            this.dateTime_dor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTime_dor.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.dateTime_dor.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.dateTime_dor.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.dateTime_dor.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.dateTime_dor.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.dateTime_dor.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime_dor.Location = new System.Drawing.Point(143, 157);
            this.dateTime_dor.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTime_dor.Name = "dateTime_dor";
            this.dateTime_dor.Size = new System.Drawing.Size(177, 22);
            this.dateTime_dor.TabIndex = 12;
            // 
            // dropdown_company
            // 
            this.dropdown_company.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dropdown_company.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.dropdown_company.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.dropdown_company.BackColor = System.Drawing.SystemColors.Window;
            this.dropdown_company.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dropdown_company.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold);
            this.dropdown_company.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.dropdown_company.FormattingEnabled = true;
            this.dropdown_company.ItemHeight = 17;
            this.dropdown_company.Location = new System.Drawing.Point(144, 93);
            this.dropdown_company.MaxDropDownItems = 2;
            this.dropdown_company.Name = "dropdown_company";
            this.dropdown_company.Size = new System.Drawing.Size(176, 25);
            this.dropdown_company.TabIndex = 17;
            this.dropdown_company.SelectedIndexChanged += new System.EventHandler(this.dropdown_company_SelectedIndexChanged);
            // 
            // but_update
            // 
            this.but_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_update.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.but_update.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.but_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_update.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.but_update.ForeColor = System.Drawing.Color.White;
            this.but_update.Image = global::Placement_Application.Properties.Resources.check_mark__4_;
            this.but_update.Location = new System.Drawing.Point(8, 218);
            this.but_update.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.but_update.Name = "but_update";
            this.but_update.Size = new System.Drawing.Size(312, 44);
            this.but_update.TabIndex = 13;
            this.but_update.Text = "Update";
            this.but_update.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_update.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.but_update.UseVisualStyleBackColor = true;
            this.but_update.Click += new System.EventHandler(this.but_update_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Placement_Application.Properties.Resources.cancel_music;
            this.pictureBox1.Location = new System.Drawing.Point(296, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 30);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // Dialog_UpdateStudentCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(329, 274);
            this.Controls.Add(this.dropdown_company);
            this.Controls.Add(this.but_update);
            this.Controls.Add(this.dateTime_dor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_studentId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Dialog_UpdateStudentCompany";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateStudentCompany";
            this.Load += new System.EventHandler(this.Dialog_UpdateStudentCompany_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_studentId;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTime_dor;
        private System.Windows.Forms.Button but_update;
        private System.Windows.Forms.ComboBox dropdown_company;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}