namespace Placement_Application
{
    partial class Control_Settings1
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
            this.label_DBconf = new System.Windows.Forms.Label();
            this.but_configure = new System.Windows.Forms.Button();
            this.but_password = new System.Windows.Forms.Button();
            this.but_userDetails = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox1.Controls.Add(this.label_DBconf);
            this.groupBox1.Controls.Add(this.but_configure);
            this.groupBox1.Controls.Add(this.but_password);
            this.groupBox1.Controls.Add(this.but_userDetails);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(15, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(766, 449);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // label_DBconf
            // 
            this.label_DBconf.AutoSize = true;
            this.label_DBconf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_DBconf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_DBconf.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DBconf.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_DBconf.Location = new System.Drawing.Point(647, 16);
            this.label_DBconf.Name = "label_DBconf";
            this.label_DBconf.Size = new System.Drawing.Size(105, 22);
            this.label_DBconf.TabIndex = 5;
            this.label_DBconf.Text = "Configure DB";
            this.label_DBconf.Click += new System.EventHandler(this.label_DBconf_Click);
            // 
            // but_configure
            // 
            this.but_configure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.but_configure.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_configure.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.but_configure.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(244)))));
            this.but_configure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_configure.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_configure.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.but_configure.Image = global::Placement_Application.Properties.Resources.settings_gears;
            this.but_configure.Location = new System.Drawing.Point(21, 72);
            this.but_configure.Name = "but_configure";
            this.but_configure.Size = new System.Drawing.Size(204, 289);
            this.but_configure.TabIndex = 5;
            this.but_configure.Text = "App Configure";
            this.but_configure.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.but_configure.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.but_configure.UseVisualStyleBackColor = false;
            this.but_configure.Click += new System.EventHandler(this.but_configure_Click);
            // 
            // but_password
            // 
            this.but_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(197)))), ((int)(((byte)(107)))));
            this.but_password.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_password.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(197)))), ((int)(((byte)(107)))));
            this.but_password.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(217)))), ((int)(((byte)(107)))));
            this.but_password.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_password.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_password.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.but_password.Image = global::Placement_Application.Properties.Resources.padlock;
            this.but_password.Location = new System.Drawing.Point(276, 72);
            this.but_password.Name = "but_password";
            this.but_password.Size = new System.Drawing.Size(204, 289);
            this.but_password.TabIndex = 4;
            this.but_password.Text = "Password";
            this.but_password.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.but_password.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.but_password.UseVisualStyleBackColor = false;
            this.but_password.Click += new System.EventHandler(this.but_password_Click);
            // 
            // but_userDetails
            // 
            this.but_userDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.but_userDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_userDetails.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.but_userDetails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.but_userDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_userDetails.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_userDetails.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.but_userDetails.Image = global::Placement_Application.Properties.Resources.update_business_user__4_;
            this.but_userDetails.Location = new System.Drawing.Point(535, 72);
            this.but_userDetails.Name = "but_userDetails";
            this.but_userDetails.Size = new System.Drawing.Size(204, 289);
            this.but_userDetails.TabIndex = 3;
            this.but_userDetails.Text = "User Details";
            this.but_userDetails.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.but_userDetails.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.but_userDetails.UseVisualStyleBackColor = false;
            this.but_userDetails.Click += new System.EventHandler(this.but_userDetails_Click);
            // 
            // Control_Settings1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "Control_Settings1";
            this.Size = new System.Drawing.Size(801, 510);
            this.Load += new System.EventHandler(this.Control_Settings1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button but_userDetails;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button but_configure;
        private System.Windows.Forms.Button but_password;
        private System.Windows.Forms.Label label_DBconf;
    }
}
