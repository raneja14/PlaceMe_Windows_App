namespace Placement_Application.Dialogs
{
    partial class Dialog_UpdateUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dialog_UpdateUser));
            this.picture_close = new System.Windows.Forms.PictureBox();
            this.label_studentId = new System.Windows.Forms.Label();
            this.label_title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.but_update = new System.Windows.Forms.Button();
            this.textBox_userName = new System.Windows.Forms.TextBox();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.textBox_contact = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.picture_close)).BeginInit();
            this.SuspendLayout();
            // 
            // picture_close
            // 
            this.picture_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picture_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picture_close.Image = global::Placement_Application.Properties.Resources.cancel_music;
            this.picture_close.Location = new System.Drawing.Point(321, 1);
            this.picture_close.Name = "picture_close";
            this.picture_close.Size = new System.Drawing.Size(24, 30);
            this.picture_close.TabIndex = 6;
            this.picture_close.TabStop = false;
            this.picture_close.Click += new System.EventHandler(this.picture_close_Click);
            // 
            // label_studentId
            // 
            this.label_studentId.AutoSize = true;
            this.label_studentId.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_studentId.ForeColor = System.Drawing.Color.White;
            this.label_studentId.Location = new System.Drawing.Point(111, 9);
            this.label_studentId.Name = "label_studentId";
            this.label_studentId.Size = new System.Drawing.Size(103, 27);
            this.label_studentId.TabIndex = 7;
            this.label_studentId.Text = "User Info";
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_title.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label_title.Location = new System.Drawing.Point(12, 58);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(98, 18);
            this.label_title.TabIndex = 8;
            this.label_title.Text = "USERNAME:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(12, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "CONTACT:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label2.Location = new System.Drawing.Point(12, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "EMAIL ID:";
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
            this.but_update.Location = new System.Drawing.Point(16, 218);
            this.but_update.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.but_update.Name = "but_update";
            this.but_update.Size = new System.Drawing.Size(312, 44);
            this.but_update.TabIndex = 14;
            this.but_update.Text = "Update";
            this.but_update.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_update.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.but_update.UseVisualStyleBackColor = true;
            this.but_update.Click += new System.EventHandler(this.but_update_Click);
            // 
            // textBox_userName
            // 
            this.textBox_userName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_userName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_userName.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold);
            this.textBox_userName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.textBox_userName.Location = new System.Drawing.Point(141, 57);
            this.textBox_userName.MaxLength = 30;
            this.textBox_userName.Name = "textBox_userName";
            this.textBox_userName.Size = new System.Drawing.Size(187, 22);
            this.textBox_userName.TabIndex = 15;
            // 
            // textBox_email
            // 
            this.textBox_email.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_email.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold);
            this.textBox_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.textBox_email.Location = new System.Drawing.Point(141, 113);
            this.textBox_email.MaxLength = 30;
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(187, 22);
            this.textBox_email.TabIndex = 16;
            // 
            // textBox_contact
            // 
            this.textBox_contact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_contact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_contact.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold);
            this.textBox_contact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.textBox_contact.Location = new System.Drawing.Point(141, 164);
            this.textBox_contact.MaxLength = 10;
            this.textBox_contact.Name = "textBox_contact";
            this.textBox_contact.Size = new System.Drawing.Size(187, 22);
            this.textBox_contact.TabIndex = 17;
            this.textBox_contact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_contact_KeyPress);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // Dialog_UpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(345, 270);
            this.Controls.Add(this.textBox_contact);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.textBox_userName);
            this.Controls.Add(this.but_update);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.label_studentId);
            this.Controls.Add(this.picture_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Dialog_UpdateUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dialog_UpdateUser";
            ((System.ComponentModel.ISupportInitialize)(this.picture_close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture_close;
        private System.Windows.Forms.Label label_studentId;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button but_update;
        private System.Windows.Forms.TextBox textBox_userName;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.TextBox textBox_contact;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}