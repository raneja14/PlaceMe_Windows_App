namespace Placement_Application
{
    partial class Control_ContactUs
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
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_number = new System.Windows.Forms.TextBox();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.textBox_subject = new System.Windows.Forms.TextBox();
            this.richTextBox_query = new System.Windows.Forms.RichTextBox();
            this.but_sendEmail = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxHidden = new System.Windows.Forms.TextBox();
            this.label_filePath = new System.Windows.Forms.Label();
            this.but_addAttachment = new System.Windows.Forms.Button();
            this.checkBox_loggerFile = new System.Windows.Forms.CheckBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_website = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.label_phone = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_name
            // 
            this.textBox_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_name.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.textBox_name.Location = new System.Drawing.Point(292, 32);
            this.textBox_name.MaxLength = 20;
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(273, 25);
            this.textBox_name.TabIndex = 6;
            this.textBox_name.Text = "Name";
            this.textBox_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_name.Enter += new System.EventHandler(this.textBox_name_Enter);
            this.textBox_name.Leave += new System.EventHandler(this.textBox_name_Leave);
            this.textBox_name.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.textBox_name_PreviewKeyDown);
            // 
            // textBox_number
            // 
            this.textBox_number.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_number.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_number.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_number.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.textBox_number.Location = new System.Drawing.Point(292, 85);
            this.textBox_number.MaxLength = 10;
            this.textBox_number.Name = "textBox_number";
            this.textBox_number.Size = new System.Drawing.Size(273, 25);
            this.textBox_number.TabIndex = 8;
            this.textBox_number.Text = "Contact";
            this.textBox_number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_number.Enter += new System.EventHandler(this.textBox_number_Enter);
            this.textBox_number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_number_KeyPress);
            this.textBox_number.Leave += new System.EventHandler(this.textBox_number_Leave);
            // 
            // textBox_email
            // 
            this.textBox_email.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_email.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.textBox_email.Location = new System.Drawing.Point(292, 137);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(273, 25);
            this.textBox_email.TabIndex = 9;
            this.textBox_email.Text = "Email";
            this.textBox_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_email.Enter += new System.EventHandler(this.textBox_email_Enter);
            this.textBox_email.Leave += new System.EventHandler(this.textBox_email_Leave);
            // 
            // textBox_subject
            // 
            this.textBox_subject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_subject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_subject.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_subject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.textBox_subject.Location = new System.Drawing.Point(292, 194);
            this.textBox_subject.Name = "textBox_subject";
            this.textBox_subject.Size = new System.Drawing.Size(273, 25);
            this.textBox_subject.TabIndex = 10;
            this.textBox_subject.Text = "Subject";
            this.textBox_subject.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_subject.Enter += new System.EventHandler(this.textBox_subject_Enter);
            this.textBox_subject.Leave += new System.EventHandler(this.textBox_subject_Leave);
            // 
            // richTextBox_query
            // 
            this.richTextBox_query.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox_query.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_query.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.richTextBox_query.Location = new System.Drawing.Point(292, 245);
            this.richTextBox_query.Name = "richTextBox_query";
            this.richTextBox_query.Size = new System.Drawing.Size(273, 111);
            this.richTextBox_query.TabIndex = 11;
            this.richTextBox_query.Text = "Query";
            this.richTextBox_query.Enter += new System.EventHandler(this.richTextBox_query_Enter);
            this.richTextBox_query.Leave += new System.EventHandler(this.richTextBox_query_Leave);
            // 
            // but_sendEmail
            // 
            this.but_sendEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.but_sendEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_sendEmail.Dock = System.Windows.Forms.DockStyle.Right;
            this.but_sendEmail.FlatAppearance.BorderSize = 0;
            this.but_sendEmail.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.but_sendEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_sendEmail.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_sendEmail.ForeColor = System.Drawing.Color.White;
            this.but_sendEmail.Image = global::Placement_Application.Properties.Resources.send_symbol__3_;
            this.but_sendEmail.Location = new System.Drawing.Point(659, 0);
            this.but_sendEmail.Name = "but_sendEmail";
            this.but_sendEmail.Size = new System.Drawing.Size(142, 510);
            this.but_sendEmail.TabIndex = 11;
            this.but_sendEmail.Text = "Send";
            this.but_sendEmail.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.but_sendEmail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.but_sendEmail.UseVisualStyleBackColor = false;
            this.but_sendEmail.Click += new System.EventHandler(this.but_sendEmail_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox1.Controls.Add(this.textBoxHidden);
            this.groupBox1.Controls.Add(this.label_filePath);
            this.groupBox1.Controls.Add(this.but_addAttachment);
            this.groupBox1.Controls.Add(this.checkBox_loggerFile);
            this.groupBox1.Controls.Add(this.textBox_name);
            this.groupBox1.Controls.Add(this.textBox_number);
            this.groupBox1.Controls.Add(this.richTextBox_query);
            this.groupBox1.Controls.Add(this.textBox_email);
            this.groupBox1.Controls.Add(this.textBox_subject);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(659, 510);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // textBoxHidden
            // 
            this.textBoxHidden.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxHidden.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxHidden.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxHidden.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHidden.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.textBoxHidden.Location = new System.Drawing.Point(292, 11);
            this.textBoxHidden.Name = "textBoxHidden";
            this.textBoxHidden.ReadOnly = true;
            this.textBoxHidden.Size = new System.Drawing.Size(1, 15);
            this.textBoxHidden.TabIndex = 7;
            this.textBoxHidden.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_filePath
            // 
            this.label_filePath.AutoSize = true;
            this.label_filePath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_filePath.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_filePath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.label_filePath.Location = new System.Drawing.Point(288, 446);
            this.label_filePath.Name = "label_filePath";
            this.label_filePath.Size = new System.Drawing.Size(21, 15);
            this.label_filePath.TabIndex = 14;
            this.label_filePath.Text = "??";
            this.label_filePath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_filePath.Visible = false;
            // 
            // but_addAttachment
            // 
            this.but_addAttachment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.but_addAttachment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_addAttachment.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.but_addAttachment.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.but_addAttachment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.but_addAttachment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(119)))), ((int)(((byte)(121)))));
            this.but_addAttachment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_addAttachment.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_addAttachment.ForeColor = System.Drawing.Color.White;
            this.but_addAttachment.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.but_addAttachment.Location = new System.Drawing.Point(292, 411);
            this.but_addAttachment.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.but_addAttachment.Name = "but_addAttachment";
            this.but_addAttachment.Size = new System.Drawing.Size(153, 27);
            this.but_addAttachment.TabIndex = 13;
            this.but_addAttachment.Text = "Add Attahment";
            this.but_addAttachment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.but_addAttachment.UseVisualStyleBackColor = false;
            this.but_addAttachment.Click += new System.EventHandler(this.but_addAttachment_Click);
            // 
            // checkBox_loggerFile
            // 
            this.checkBox_loggerFile.AutoSize = true;
            this.checkBox_loggerFile.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.checkBox_loggerFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.checkBox_loggerFile.Location = new System.Drawing.Point(292, 376);
            this.checkBox_loggerFile.Name = "checkBox_loggerFile";
            this.checkBox_loggerFile.Size = new System.Drawing.Size(199, 23);
            this.checkBox_loggerFile.TabIndex = 12;
            this.checkBox_loggerFile.Text = "Include Logger File";
            this.checkBox_loggerFile.UseVisualStyleBackColor = true;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_website);
            this.panel1.Controls.Add(this.label_email);
            this.panel1.Controls.Add(this.label_phone);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 510);
            this.panel1.TabIndex = 13;
            // 
            // label_website
            // 
            this.label_website.AutoSize = true;
            this.label_website.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_website.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_website.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.label_website.Location = new System.Drawing.Point(15, 454);
            this.label_website.Name = "label_website";
            this.label_website.Size = new System.Drawing.Size(144, 19);
            this.label_website.TabIndex = 11;
            this.label_website.Text = "www.roarTek.com";
            this.label_website.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_website.Visible = false;
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_email.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.label_email.Location = new System.Drawing.Point(17, 128);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(243, 19);
            this.label_email.TabIndex = 10;
            this.label_email.Text = "roarteksolutions@gmail.com";
            this.label_email.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_phone
            // 
            this.label_phone.AutoSize = true;
            this.label_phone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_phone.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.label_phone.Location = new System.Drawing.Point(42, 413);
            this.label_phone.Name = "label_phone";
            this.label_phone.Size = new System.Drawing.Size(99, 19);
            this.label_phone.TabIndex = 9;
            this.label_phone.Text = "8754538506";
            this.label_phone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Placement_Application.Properties.Resources.domain;
            this.pictureBox3.Location = new System.Drawing.Point(34, 355);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(117, 126);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Placement_Application.Properties.Resources.opened_email_envelope;
            this.pictureBox2.Location = new System.Drawing.Point(32, 31);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(117, 126);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Placement_Application.Properties.Resources.smartphone_call;
            this.pictureBox1.Location = new System.Drawing.Point(34, 306);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Control_ContactUs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.but_sendEmail);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Control_ContactUs";
            this.Size = new System.Drawing.Size(801, 510);
            this.Load += new System.EventHandler(this.Control_ContactUs_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_number;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.TextBox textBox_subject;
        private System.Windows.Forms.RichTextBox richTextBox_query;
        private System.Windows.Forms.Button but_sendEmail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_website;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label_phone;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBox_loggerFile;
        private System.Windows.Forms.Label label_filePath;
        private System.Windows.Forms.Button but_addAttachment;
        private System.Windows.Forms.TextBox textBoxHidden;
    }
}
