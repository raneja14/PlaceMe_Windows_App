namespace Placement_Application.Dialogs
{
    partial class Dialog_ForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dialog_ForgotPassword));
            this.picture_close = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_title = new System.Windows.Forms.Label();
            this.text_email = new System.Windows.Forms.TextBox();
            this.text_contact = new System.Windows.Forms.TextBox();
            this.but_verify = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.picture_close)).BeginInit();
            this.SuspendLayout();
            // 
            // picture_close
            // 
            this.picture_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picture_close.Image = global::Placement_Application.Properties.Resources.cancel_music;
            this.picture_close.Location = new System.Drawing.Point(302, 3);
            this.picture_close.Name = "picture_close";
            this.picture_close.Size = new System.Drawing.Size(24, 30);
            this.picture_close.TabIndex = 6;
            this.picture_close.TabStop = false;
            this.picture_close.Click += new System.EventHandler(this.picture_close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(7, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "EMAIL:";
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_title.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label_title.Location = new System.Drawing.Point(5, 122);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(88, 18);
            this.label_title.TabIndex = 9;
            this.label_title.Text = "CONTACT:";
            // 
            // text_email
            // 
            this.text_email.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.text_email.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold);
            this.text_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.text_email.Location = new System.Drawing.Point(115, 66);
            this.text_email.MaxLength = 30;
            this.text_email.Name = "text_email";
            this.text_email.Size = new System.Drawing.Size(202, 24);
            this.text_email.TabIndex = 19;
            // 
            // text_contact
            // 
            this.text_contact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.text_contact.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold);
            this.text_contact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.text_contact.Location = new System.Drawing.Point(115, 123);
            this.text_contact.MaxLength = 10;
            this.text_contact.Name = "text_contact";
            this.text_contact.Size = new System.Drawing.Size(202, 24);
            this.text_contact.TabIndex = 20;
            this.text_contact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_contact_KeyPress);
            // 
            // but_verify
            // 
            this.but_verify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_verify.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.but_verify.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.but_verify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_verify.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.but_verify.ForeColor = System.Drawing.Color.White;
            this.but_verify.Image = global::Placement_Application.Properties.Resources.check_mark__4_;
            this.but_verify.Location = new System.Drawing.Point(5, 176);
            this.but_verify.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.but_verify.Name = "but_verify";
            this.but_verify.Size = new System.Drawing.Size(312, 44);
            this.but_verify.TabIndex = 21;
            this.but_verify.Text = "Verify";
            this.but_verify.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_verify.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.but_verify.UseVisualStyleBackColor = true;
            this.but_verify.Click += new System.EventHandler(this.but_verify_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // Dialog_ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(329, 225);
            this.Controls.Add(this.but_verify);
            this.Controls.Add(this.text_contact);
            this.Controls.Add(this.text_email);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.picture_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Dialog_ForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dialog_ForgotPassword";
            ((System.ComponentModel.ISupportInitialize)(this.picture_close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture_close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.TextBox text_email;
        private System.Windows.Forms.TextBox text_contact;
        private System.Windows.Forms.Button but_verify;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}