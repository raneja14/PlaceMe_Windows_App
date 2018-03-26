namespace Placement_Application
{
    partial class ListControl_ResultList
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
            this.panel_top_info = new System.Windows.Forms.Panel();
            this.label_eligibleCount = new System.Windows.Forms.Label();
            this.dropdown_branch = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.but_next = new System.Windows.Forms.Button();
            this.panel_top_info.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_top_info
            // 
            this.panel_top_info.BackColor = System.Drawing.SystemColors.Control;
            this.panel_top_info.Controls.Add(this.but_next);
            this.panel_top_info.Controls.Add(this.label_eligibleCount);
            this.panel_top_info.Controls.Add(this.dropdown_branch);
            this.panel_top_info.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top_info.Location = new System.Drawing.Point(0, 0);
            this.panel_top_info.Name = "panel_top_info";
            this.panel_top_info.Size = new System.Drawing.Size(801, 60);
            this.panel_top_info.TabIndex = 3;
            // 
            // label_eligibleCount
            // 
            this.label_eligibleCount.AutoSize = true;
            this.label_eligibleCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_eligibleCount.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_eligibleCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label_eligibleCount.Location = new System.Drawing.Point(217, 21);
            this.label_eligibleCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_eligibleCount.Name = "label_eligibleCount";
            this.label_eligibleCount.Size = new System.Drawing.Size(285, 22);
            this.label_eligibleCount.TabIndex = 37;
            this.label_eligibleCount.Text = "0 ELIGIBLE STUDENTS FOUND";
            // 
            // dropdown_branch
            // 
            this.dropdown_branch.BackColor = System.Drawing.Color.White;
            this.dropdown_branch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdown_branch.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropdown_branch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.dropdown_branch.FormattingEnabled = true;
            this.dropdown_branch.Location = new System.Drawing.Point(15, 19);
            this.dropdown_branch.Name = "dropdown_branch";
            this.dropdown_branch.Size = new System.Drawing.Size(147, 24);
            this.dropdown_branch.TabIndex = 35;
            this.dropdown_branch.SelectedIndexChanged += new System.EventHandler(this.dropdown_branch_SelectedIndexChanged);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.White;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.listView1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(0, 60);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(801, 450);
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // but_next
            // 
            this.but_next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(208)))), ((int)(((byte)(147)))));
            this.but_next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_next.FlatAppearance.BorderSize = 0;
            this.but_next.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(208)))), ((int)(((byte)(147)))));
            this.but_next.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(228)))), ((int)(((byte)(147)))));
            this.but_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_next.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_next.ForeColor = System.Drawing.Color.White;
            this.but_next.Location = new System.Drawing.Point(605, 0);
            this.but_next.Name = "but_next";
            this.but_next.Size = new System.Drawing.Size(195, 60);
            this.but_next.TabIndex = 32;
            this.but_next.Text = "NEXT";
            this.but_next.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.but_next.UseVisualStyleBackColor = false;
            this.but_next.Visible = false;
            this.but_next.Click += new System.EventHandler(this.but_next_Click);
            // 
            // ListControl_ResultList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel_top_info);
            this.Name = "ListControl_ResultList";
            this.Size = new System.Drawing.Size(801, 510);
            this.Load += new System.EventHandler(this.ListControl_ResultList_Load);
            this.panel_top_info.ResumeLayout(false);
            this.panel_top_info.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_top_info;
        private System.Windows.Forms.ComboBox dropdown_branch;
        private System.Windows.Forms.Label label_eligibleCount;
        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button but_next;
    }
}
