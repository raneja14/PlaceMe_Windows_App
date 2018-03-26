namespace Placement_Application
{
    partial class Control_DropFile
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
            this.subpanel_top = new System.Windows.Forms.Panel();
            this.label_fileLocation = new System.Windows.Forms.Label();
            this.but_browseFile = new System.Windows.Forms.Button();
            this.subpanel_bottom = new System.Windows.Forms.Panel();
            this.subpanel_center = new System.Windows.Forms.Panel();
            this.panel_excel = new System.Windows.Forms.Panel();
            this.label_panel_filename = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_title = new System.Windows.Forms.Label();
            this.but_cancel = new System.Windows.Forms.Button();
            this.but_upload = new System.Windows.Forms.Button();
            this.subpanel_top.SuspendLayout();
            this.subpanel_bottom.SuspendLayout();
            this.subpanel_center.SuspendLayout();
            this.panel_excel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // subpanel_top
            // 
            this.subpanel_top.Controls.Add(this.label_fileLocation);
            this.subpanel_top.Controls.Add(this.but_browseFile);
            this.subpanel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.subpanel_top.Location = new System.Drawing.Point(0, 0);
            this.subpanel_top.Name = "subpanel_top";
            this.subpanel_top.Size = new System.Drawing.Size(801, 42);
            this.subpanel_top.TabIndex = 0;
            // 
            // label_fileLocation
            // 
            this.label_fileLocation.AutoSize = true;
            this.label_fileLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_fileLocation.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_fileLocation.ForeColor = System.Drawing.Color.Red;
            this.label_fileLocation.Location = new System.Drawing.Point(176, 7);
            this.label_fileLocation.Name = "label_fileLocation";
            this.label_fileLocation.Size = new System.Drawing.Size(30, 25);
            this.label_fileLocation.TabIndex = 6;
            this.label_fileLocation.Text = "??";
            // 
            // but_browseFile
            // 
            this.but_browseFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.but_browseFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_browseFile.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.but_browseFile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.but_browseFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.but_browseFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(119)))), ((int)(((byte)(121)))));
            this.but_browseFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_browseFile.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_browseFile.ForeColor = System.Drawing.Color.White;
            this.but_browseFile.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.but_browseFile.Location = new System.Drawing.Point(10, 9);
            this.but_browseFile.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.but_browseFile.Name = "but_browseFile";
            this.but_browseFile.Size = new System.Drawing.Size(153, 27);
            this.but_browseFile.TabIndex = 5;
            this.but_browseFile.Text = "Browse File";
            this.but_browseFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.but_browseFile.UseVisualStyleBackColor = false;
            this.but_browseFile.Click += new System.EventHandler(this.but_browseFile_Click);
            // 
            // subpanel_bottom
            // 
            this.subpanel_bottom.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.subpanel_bottom.Controls.Add(this.but_cancel);
            this.subpanel_bottom.Controls.Add(this.but_upload);
            this.subpanel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.subpanel_bottom.Location = new System.Drawing.Point(0, 466);
            this.subpanel_bottom.Name = "subpanel_bottom";
            this.subpanel_bottom.Size = new System.Drawing.Size(801, 44);
            this.subpanel_bottom.TabIndex = 1;
            // 
            // subpanel_center
            // 
            this.subpanel_center.AllowDrop = true;
            this.subpanel_center.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.subpanel_center.BackgroundImage = global::Placement_Application.Properties.Resources.dropbox;
            this.subpanel_center.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.subpanel_center.Controls.Add(this.panel_excel);
            this.subpanel_center.Controls.Add(this.label_title);
            this.subpanel_center.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subpanel_center.Location = new System.Drawing.Point(0, 42);
            this.subpanel_center.Name = "subpanel_center";
            this.subpanel_center.Size = new System.Drawing.Size(801, 424);
            this.subpanel_center.TabIndex = 2;
            this.subpanel_center.DragDrop += new System.Windows.Forms.DragEventHandler(this.subpanel_center_DragDrop);
            this.subpanel_center.DragEnter += new System.Windows.Forms.DragEventHandler(this.subpanel_center_DragEnter);
            // 
            // panel_excel
            // 
            this.panel_excel.Controls.Add(this.label_panel_filename);
            this.panel_excel.Controls.Add(this.pictureBox1);
            this.panel_excel.Location = new System.Drawing.Point(168, 105);
            this.panel_excel.Name = "panel_excel";
            this.panel_excel.Size = new System.Drawing.Size(455, 211);
            this.panel_excel.TabIndex = 8;
            // 
            // label_panel_filename
            // 
            this.label_panel_filename.AutoSize = true;
            this.label_panel_filename.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_panel_filename.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_panel_filename.ForeColor = System.Drawing.Color.White;
            this.label_panel_filename.Location = new System.Drawing.Point(183, 178);
            this.label_panel_filename.Name = "label_panel_filename";
            this.label_panel_filename.Size = new System.Drawing.Size(30, 25);
            this.label_panel_filename.TabIndex = 8;
            this.label_panel_filename.Text = "??";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Placement_Application.Properties.Resources.excelfile2;
            this.pictureBox1.Location = new System.Drawing.Point(151, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_title.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.label_title.Location = new System.Drawing.Point(298, 3);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(219, 28);
            this.label_title.TabIndex = 2;
            this.label_title.Text = "Drop Your File Here !";
            // 
            // but_cancel
            // 
            this.but_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.but_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.but_cancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.but_cancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.but_cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.but_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(119)))), ((int)(((byte)(121)))));
            this.but_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_cancel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_cancel.ForeColor = System.Drawing.Color.White;
            this.but_cancel.Image = global::Placement_Application.Properties.Resources.cancel_music;
            this.but_cancel.Location = new System.Drawing.Point(401, 0);
            this.but_cancel.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.but_cancel.Name = "but_cancel";
            this.but_cancel.Size = new System.Drawing.Size(400, 44);
            this.but_cancel.TabIndex = 5;
            this.but_cancel.Text = "Cancel";
            this.but_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.but_cancel.UseVisualStyleBackColor = false;
            this.but_cancel.Click += new System.EventHandler(this.but_cancel_Click);
            // 
            // but_upload
            // 
            this.but_upload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.but_upload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_upload.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.but_upload.Dock = System.Windows.Forms.DockStyle.Left;
            this.but_upload.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.but_upload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.but_upload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(119)))), ((int)(((byte)(121)))));
            this.but_upload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_upload.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_upload.ForeColor = System.Drawing.Color.White;
            this.but_upload.Image = global::Placement_Application.Properties.Resources.upload_medium;
            this.but_upload.Location = new System.Drawing.Point(0, 0);
            this.but_upload.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.but_upload.Name = "but_upload";
            this.but_upload.Size = new System.Drawing.Size(394, 44);
            this.but_upload.TabIndex = 4;
            this.but_upload.Text = "Upload";
            this.but_upload.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_upload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.but_upload.UseVisualStyleBackColor = false;
            this.but_upload.Click += new System.EventHandler(this.but_upload_Click);
            // 
            // Control_DropFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.subpanel_center);
            this.Controls.Add(this.subpanel_bottom);
            this.Controls.Add(this.subpanel_top);
            this.Name = "Control_DropFile";
            this.Size = new System.Drawing.Size(801, 510);
            this.Load += new System.EventHandler(this.DropFileControl_Load);
            this.subpanel_top.ResumeLayout(false);
            this.subpanel_top.PerformLayout();
            this.subpanel_bottom.ResumeLayout(false);
            this.subpanel_center.ResumeLayout(false);
            this.subpanel_center.PerformLayout();
            this.panel_excel.ResumeLayout(false);
            this.panel_excel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel subpanel_top;
        private System.Windows.Forms.Panel subpanel_bottom;
        private System.Windows.Forms.Panel subpanel_center;
        private System.Windows.Forms.Button but_cancel;
        private System.Windows.Forms.Button but_upload;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_fileLocation;
        private System.Windows.Forms.Button but_browseFile;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel_excel;
        private System.Windows.Forms.Label label_panel_filename;
    }
}
