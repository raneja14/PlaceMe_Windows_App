namespace Placement_Application.Dialogs
{
    partial class Dialog_UpdatePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dialog_UpdatePassword));
            this.textBox_confirmPassword = new System.Windows.Forms.TextBox();
            this.textBox_newPassword = new System.Windows.Forms.TextBox();
            this.textBox_oldPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_title = new System.Windows.Forms.Label();
            this.label_studentId = new System.Windows.Forms.Label();
            this.but_update = new System.Windows.Forms.Button();
            this.picture_close = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.picture_close)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_confirmPassword
            // 
            this.textBox_confirmPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_confirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_confirmPassword.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold);
            this.textBox_confirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.textBox_confirmPassword.Location = new System.Drawing.Point(144, 166);
            this.textBox_confirmPassword.MaxLength = 15;
            this.textBox_confirmPassword.Name = "textBox_confirmPassword";
            this.textBox_confirmPassword.PasswordChar = '#';
            this.textBox_confirmPassword.Size = new System.Drawing.Size(187, 22);
            this.textBox_confirmPassword.TabIndex = 26;
            // 
            // textBox_newPassword
            // 
            this.textBox_newPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_newPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_newPassword.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold);
            this.textBox_newPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.textBox_newPassword.Location = new System.Drawing.Point(144, 112);
            this.textBox_newPassword.MaxLength = 15;
            this.textBox_newPassword.Name = "textBox_newPassword";
            this.textBox_newPassword.PasswordChar = '#';
            this.textBox_newPassword.Size = new System.Drawing.Size(187, 22);
            this.textBox_newPassword.TabIndex = 25;
            // 
            // textBox_oldPassword
            // 
            this.textBox_oldPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_oldPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_oldPassword.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold);
            this.textBox_oldPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.textBox_oldPassword.Location = new System.Drawing.Point(144, 59);
            this.textBox_oldPassword.MaxLength = 15;
            this.textBox_oldPassword.Name = "textBox_oldPassword";
            this.textBox_oldPassword.PasswordChar = '*';
            this.textBox_oldPassword.Size = new System.Drawing.Size(187, 22);
            this.textBox_oldPassword.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label2.Location = new System.Drawing.Point(6, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 18);
            this.label2.TabIndex = 22;
            this.label2.Text = "NEW PWD:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(6, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 18);
            this.label1.TabIndex = 21;
            this.label1.Text = "CONFIRM PWD:";
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_title.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.label_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label_title.Location = new System.Drawing.Point(6, 59);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(88, 18);
            this.label_title.TabIndex = 20;
            this.label_title.Text = "OLD PWD:";
            // 
            // label_studentId
            // 
            this.label_studentId.AutoSize = true;
            this.label_studentId.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_studentId.ForeColor = System.Drawing.Color.White;
            this.label_studentId.Location = new System.Drawing.Point(108, 10);
            this.label_studentId.Name = "label_studentId";
            this.label_studentId.Size = new System.Drawing.Size(123, 27);
            this.label_studentId.TabIndex = 19;
            this.label_studentId.Text = "PASSWORD";
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
            this.but_update.Location = new System.Drawing.Point(13, 219);
            this.but_update.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.but_update.Name = "but_update";
            this.but_update.Size = new System.Drawing.Size(318, 44);
            this.but_update.TabIndex = 23;
            this.but_update.Text = "Update";
            this.but_update.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_update.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.but_update.UseVisualStyleBackColor = true;
            this.but_update.Click += new System.EventHandler(this.but_update_Click);
            // 
            // picture_close
            // 
            this.picture_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picture_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picture_close.Image = global::Placement_Application.Properties.Resources.cancel_music;
            this.picture_close.Location = new System.Drawing.Point(318, 2);
            this.picture_close.Name = "picture_close";
            this.picture_close.Size = new System.Drawing.Size(24, 30);
            this.picture_close.TabIndex = 18;
            this.picture_close.TabStop = false;
            this.picture_close.Click += new System.EventHandler(this.picture_close_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // Dialog_UpdatePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(345, 270);
            this.Controls.Add(this.textBox_confirmPassword);
            this.Controls.Add(this.textBox_newPassword);
            this.Controls.Add(this.textBox_oldPassword);
            this.Controls.Add(this.but_update);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.label_studentId);
            this.Controls.Add(this.picture_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Dialog_UpdatePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dialog_UpdatePassword";
            ((System.ComponentModel.ISupportInitialize)(this.picture_close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_confirmPassword;
        private System.Windows.Forms.TextBox textBox_newPassword;
        private System.Windows.Forms.TextBox textBox_oldPassword;
        private System.Windows.Forms.Button but_update;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_studentId;
        private System.Windows.Forms.PictureBox picture_close;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}