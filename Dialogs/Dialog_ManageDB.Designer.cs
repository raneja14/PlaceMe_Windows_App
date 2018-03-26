namespace Placement_Application.Dialogs
{
    partial class Dialog_ManageDB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dialog_ManageDB));
            this.label_studentId = new System.Windows.Forms.Label();
            this.radioInsertData = new System.Windows.Forms.RadioButton();
            this.radioUploadData = new System.Windows.Forms.RadioButton();
            this.label_excelName = new System.Windows.Forms.Label();
            this.but_uploadData = new System.Windows.Forms.Button();
            this.but_importExcel = new System.Windows.Forms.Button();
            this.picture_close = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.picture_close)).BeginInit();
            this.SuspendLayout();
            // 
            // label_studentId
            // 
            this.label_studentId.AutoSize = true;
            this.label_studentId.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_studentId.ForeColor = System.Drawing.Color.White;
            this.label_studentId.Location = new System.Drawing.Point(80, 27);
            this.label_studentId.Name = "label_studentId";
            this.label_studentId.Size = new System.Drawing.Size(173, 27);
            this.label_studentId.TabIndex = 9;
            this.label_studentId.Text = "Choose Operation";
            // 
            // radioInsertData
            // 
            this.radioInsertData.AutoSize = true;
            this.radioInsertData.Checked = true;
            this.radioInsertData.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioInsertData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(2)))));
            this.radioInsertData.Location = new System.Drawing.Point(26, 78);
            this.radioInsertData.Name = "radioInsertData";
            this.radioInsertData.Size = new System.Drawing.Size(109, 23);
            this.radioInsertData.TabIndex = 10;
            this.radioInsertData.TabStop = true;
            this.radioInsertData.Text = "New Records";
            this.radioInsertData.UseVisualStyleBackColor = true;
            this.radioInsertData.CheckedChanged += new System.EventHandler(this.radioInsertData_CheckedChanged);
            // 
            // radioUploadData
            // 
            this.radioUploadData.AutoSize = true;
            this.radioUploadData.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioUploadData.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.radioUploadData.Location = new System.Drawing.Point(190, 78);
            this.radioUploadData.Name = "radioUploadData";
            this.radioUploadData.Size = new System.Drawing.Size(127, 23);
            this.radioUploadData.TabIndex = 11;
            this.radioUploadData.Text = "Update Records";
            this.radioUploadData.UseVisualStyleBackColor = true;
            // 
            // label_excelName
            // 
            this.label_excelName.AutoSize = true;
            this.label_excelName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_excelName.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.label_excelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label_excelName.Location = new System.Drawing.Point(82, 154);
            this.label_excelName.Name = "label_excelName";
            this.label_excelName.Size = new System.Drawing.Size(21, 15);
            this.label_excelName.TabIndex = 14;
            this.label_excelName.Text = "??";
            this.label_excelName.Visible = false;
            // 
            // but_uploadData
            // 
            this.but_uploadData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.but_uploadData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_uploadData.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.but_uploadData.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.but_uploadData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(119)))), ((int)(((byte)(121)))));
            this.but_uploadData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_uploadData.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_uploadData.ForeColor = System.Drawing.Color.White;
            this.but_uploadData.Image = global::Placement_Application.Properties.Resources.upload_medium;
            this.but_uploadData.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.but_uploadData.Location = new System.Drawing.Point(26, 213);
            this.but_uploadData.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.but_uploadData.Name = "but_uploadData";
            this.but_uploadData.Size = new System.Drawing.Size(291, 45);
            this.but_uploadData.TabIndex = 15;
            this.but_uploadData.Text = "Upload Data";
            this.but_uploadData.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_uploadData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.but_uploadData.UseMnemonic = false;
            this.but_uploadData.UseVisualStyleBackColor = false;
            this.but_uploadData.Visible = false;
            this.but_uploadData.Click += new System.EventHandler(this.but_uploadData_Click);
            // 
            // but_importExcel
            // 
            this.but_importExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.but_importExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_importExcel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.but_importExcel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.but_importExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(119)))), ((int)(((byte)(121)))));
            this.but_importExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_importExcel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_importExcel.ForeColor = System.Drawing.Color.White;
            this.but_importExcel.Image = global::Placement_Application.Properties.Resources.excel_medium;
            this.but_importExcel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.but_importExcel.Location = new System.Drawing.Point(85, 117);
            this.but_importExcel.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.but_importExcel.Name = "but_importExcel";
            this.but_importExcel.Size = new System.Drawing.Size(153, 34);
            this.but_importExcel.TabIndex = 13;
            this.but_importExcel.Text = "Import Excel";
            this.but_importExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_importExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.but_importExcel.UseMnemonic = false;
            this.but_importExcel.UseVisualStyleBackColor = false;
            this.but_importExcel.Click += new System.EventHandler(this.but_importExcel_Click);
            // 
            // picture_close
            // 
            this.picture_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picture_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picture_close.Image = global::Placement_Application.Properties.Resources.cancel_music;
            this.picture_close.Location = new System.Drawing.Point(318, 3);
            this.picture_close.Name = "picture_close";
            this.picture_close.Size = new System.Drawing.Size(24, 30);
            this.picture_close.TabIndex = 8;
            this.picture_close.TabStop = false;
            this.picture_close.Click += new System.EventHandler(this.picture_close_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // Dialog_ManageDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(345, 270);
            this.Controls.Add(this.but_uploadData);
            this.Controls.Add(this.label_excelName);
            this.Controls.Add(this.but_importExcel);
            this.Controls.Add(this.radioUploadData);
            this.Controls.Add(this.radioInsertData);
            this.Controls.Add(this.label_studentId);
            this.Controls.Add(this.picture_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Dialog_ManageDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dialog_ManageDB";
            ((System.ComponentModel.ISupportInitialize)(this.picture_close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_studentId;
        private System.Windows.Forms.PictureBox picture_close;
        private System.Windows.Forms.RadioButton radioInsertData;
        private System.Windows.Forms.RadioButton radioUploadData;
        private System.Windows.Forms.Button but_importExcel;
        private System.Windows.Forms.Label label_excelName;
        private System.Windows.Forms.Button but_uploadData;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}