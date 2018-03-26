namespace Placement_Application
{
    partial class Dialog_MyMessageBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dialog_MyMessageBox));
            this.label_mymessage = new System.Windows.Forms.Label();
            this.but_yes = new System.Windows.Forms.Button();
            this.but_no = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_mymessage
            // 
            this.label_mymessage.AutoSize = true;
            this.label_mymessage.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_mymessage.Location = new System.Drawing.Point(12, 18);
            this.label_mymessage.Name = "label_mymessage";
            this.label_mymessage.Size = new System.Drawing.Size(209, 26);
            this.label_mymessage.TabIndex = 0;
            this.label_mymessage.Text = "Do you want to exit ??";
            // 
            // but_yes
            // 
            this.but_yes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_yes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.but_yes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.but_yes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_yes.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_yes.ForeColor = System.Drawing.Color.White;
            this.but_yes.Image = global::Placement_Application.Properties.Resources.check_mark__4_;
            this.but_yes.Location = new System.Drawing.Point(0, 76);
            this.but_yes.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.but_yes.Name = "but_yes";
            this.but_yes.Size = new System.Drawing.Size(171, 44);
            this.but_yes.TabIndex = 2;
            this.but_yes.Text = "Yes";
            this.but_yes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_yes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.but_yes.UseVisualStyleBackColor = true;
            this.but_yes.Click += new System.EventHandler(this.but_yes_Click);
            // 
            // but_no
            // 
            this.but_no.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_no.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.but_no.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.but_no.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.but_no.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_no.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_no.ForeColor = System.Drawing.Color.White;
            this.but_no.Image = global::Placement_Application.Properties.Resources.cancel_music;
            this.but_no.Location = new System.Drawing.Point(0, 76);
            this.but_no.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.but_no.Name = "but_no";
            this.but_no.Size = new System.Drawing.Size(346, 44);
            this.but_no.TabIndex = 3;
            this.but_no.Text = "No";
            this.but_no.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_no.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.but_no.UseVisualStyleBackColor = true;
            this.but_no.Click += new System.EventHandler(this.but_no_Click);
            // 
            // Dialog_MyMessageBox
            // 
            this.AcceptButton = this.but_yes;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.CancelButton = this.but_no;
            this.ClientSize = new System.Drawing.Size(351, 123);
            this.Controls.Add(this.but_no);
            this.Controls.Add(this.but_yes);
            this.Controls.Add(this.label_mymessage);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Dialog_MyMessageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyMessageBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_yes;
        private System.Windows.Forms.Button but_no;
        private System.Windows.Forms.Label label_mymessage;
    }
}