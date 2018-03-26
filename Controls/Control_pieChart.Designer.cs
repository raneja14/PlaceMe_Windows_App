namespace Placement_Application
{
    partial class Control_pieChart
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Control_pieChart));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panel_left = new System.Windows.Forms.Panel();
            this.box_slideOut = new System.Windows.Forms.PictureBox();
            this.box_slideIn = new System.Windows.Forms.PictureBox();
            this.pieChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel_right = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.doghnut = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer_slideIn = new System.Windows.Forms.Timer(this.components);
            this.timer_slideOut = new System.Windows.Forms.Timer(this.components);
            this.panel_left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.box_slideOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box_slideIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieChart)).BeginInit();
            this.panel_right.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doghnut)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_left
            // 
            this.panel_left.Controls.Add(this.box_slideOut);
            this.panel_left.Controls.Add(this.box_slideIn);
            this.panel_left.Controls.Add(this.pieChart);
            this.panel_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_left.Location = new System.Drawing.Point(0, 0);
            this.panel_left.Name = "panel_left";
            this.panel_left.Size = new System.Drawing.Size(327, 510);
            this.panel_left.TabIndex = 0;
            // 
            // box_slideOut
            // 
            this.box_slideOut.BackColor = System.Drawing.Color.DimGray;
            this.box_slideOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.box_slideOut.Image = ((System.Drawing.Image)(resources.GetObject("box_slideOut.Image")));
            this.box_slideOut.Location = new System.Drawing.Point(3, 0);
            this.box_slideOut.Name = "box_slideOut";
            this.box_slideOut.Size = new System.Drawing.Size(28, 33);
            this.box_slideOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.box_slideOut.TabIndex = 3;
            this.box_slideOut.TabStop = false;
            this.box_slideOut.Click += new System.EventHandler(this.box_slideOut_Click);
            // 
            // box_slideIn
            // 
            this.box_slideIn.BackColor = System.Drawing.Color.DimGray;
            this.box_slideIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.box_slideIn.Image = ((System.Drawing.Image)(resources.GetObject("box_slideIn.Image")));
            this.box_slideIn.Location = new System.Drawing.Point(4, 0);
            this.box_slideIn.Name = "box_slideIn";
            this.box_slideIn.Size = new System.Drawing.Size(27, 33);
            this.box_slideIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.box_slideIn.TabIndex = 2;
            this.box_slideIn.TabStop = false;
            this.box_slideIn.Click += new System.EventHandler(this.box_slideIn_Click);
            // 
            // pieChart
            // 
            this.pieChart.BackColor = System.Drawing.Color.DimGray;
            this.pieChart.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            this.pieChart.BackSecondaryColor = System.Drawing.Color.Black;
            this.pieChart.BorderSkin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.pieChart.BorderSkin.BorderWidth = 3;
            this.pieChart.BorderSkin.PageColor = System.Drawing.Color.Maroon;
            chartArea3.Area3DStyle.Enable3D = true;
            chartArea3.BackColor = System.Drawing.Color.DimGray;
            chartArea3.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            chartArea3.BackSecondaryColor = System.Drawing.Color.Black;
            chartArea3.Name = "ChartArea1";
            this.pieChart.ChartAreas.Add(chartArea3);
            this.pieChart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pieChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.BackColor = System.Drawing.Color.DimGray;
            legend3.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
            legend3.BackSecondaryColor = System.Drawing.Color.Black;
            legend3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend3.ForeColor = System.Drawing.Color.White;
            legend3.IsTextAutoFit = false;
            legend3.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
            legend3.Name = "Legend1";
            this.pieChart.Legends.Add(legend3);
            this.pieChart.Location = new System.Drawing.Point(0, 0);
            this.pieChart.Name = "pieChart";
            series3.BackSecondaryColor = System.Drawing.Color.Black;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Color = System.Drawing.Color.Black;
            series3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series3.IsValueShownAsLabel = true;
            series3.IsXValueIndexed = true;
            series3.LabelForeColor = System.Drawing.Color.White;
            series3.LabelToolTip = "#VALX #PERCENT{P}";
            series3.Legend = "Legend1";
            series3.LegendToolTip = "#VAL";
            series3.Name = "Overall_Series";
            this.pieChart.Series.Add(series3);
            this.pieChart.Size = new System.Drawing.Size(327, 510);
            this.pieChart.TabIndex = 0;
            title3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title3.ForeColor = System.Drawing.Color.White;
            title3.Name = "Title1";
            title3.Text = "Overall Distribution";
            this.pieChart.Titles.Add(title3);
            // 
            // panel_right
            // 
            this.panel_right.BackColor = System.Drawing.Color.DimGray;
            this.panel_right.Controls.Add(this.label1);
            this.panel_right.Controls.Add(this.doghnut);
            this.panel_right.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_right.Location = new System.Drawing.Point(330, 0);
            this.panel_right.Name = "panel_right";
            this.panel_right.Size = new System.Drawing.Size(471, 510);
            this.panel_right.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(57, 207);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(40);
            this.label1.Size = new System.Drawing.Size(176, 107);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // doghnut
            // 
            this.doghnut.BackColor = System.Drawing.Color.DimGray;
            this.doghnut.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            this.doghnut.BackSecondaryColor = System.Drawing.Color.Black;
            this.doghnut.BorderSkin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.doghnut.BorderSkin.BorderWidth = 3;
            this.doghnut.BorderSkin.PageColor = System.Drawing.Color.Maroon;
            chartArea4.Area3DStyle.Enable3D = true;
            chartArea4.BackColor = System.Drawing.Color.DimGray;
            chartArea4.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            chartArea4.BackSecondaryColor = System.Drawing.Color.Black;
            chartArea4.Name = "ChartArea1";
            this.doghnut.ChartAreas.Add(chartArea4);
            this.doghnut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.doghnut.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.BackColor = System.Drawing.Color.DimGray;
            legend4.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
            legend4.BackSecondaryColor = System.Drawing.Color.Black;
            legend4.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend4.ForeColor = System.Drawing.Color.White;
            legend4.HeaderSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.DotLine;
            legend4.IsTextAutoFit = false;
            legend4.Name = "Legend1";
            legend4.TitleForeColor = System.Drawing.Color.DimGray;
            this.doghnut.Legends.Add(legend4);
            this.doghnut.Location = new System.Drawing.Point(0, 0);
            this.doghnut.Name = "doghnut";
            this.doghnut.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series4.IsValueShownAsLabel = true;
            series4.LabelForeColor = System.Drawing.Color.White;
            series4.LabelToolTip = " #VALX #PERCENT{P1}";
            series4.Legend = "Legend1";
            series4.LegendToolTip = "#VAL";
            series4.Name = "Distribution_Series";
            this.doghnut.Series.Add(series4);
            this.doghnut.Size = new System.Drawing.Size(471, 510);
            this.doghnut.TabIndex = 1;
            this.doghnut.Text = "chart2";
            title4.BackColor = System.Drawing.Color.DimGray;
            title4.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            title4.BackSecondaryColor = System.Drawing.Color.Black;
            title4.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title4.ForeColor = System.Drawing.Color.White;
            title4.Name = "Title1";
            title4.Text = "Entity Distribution";
            this.doghnut.Titles.Add(title4);
            // 
            // timer_slideIn
            // 
            this.timer_slideIn.Interval = 80;
            this.timer_slideIn.Tick += new System.EventHandler(this.timer_slide_Tick);
            // 
            // timer_slideOut
            // 
            this.timer_slideOut.Interval = 80;
            this.timer_slideOut.Tick += new System.EventHandler(this.timer_slideOut_Tick);
            // 
            // Control_pieChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_right);
            this.Controls.Add(this.panel_left);
            this.Name = "Control_pieChart";
            this.Size = new System.Drawing.Size(801, 510);
            this.Load += new System.EventHandler(this.Control_pieChart_Load);
            this.panel_left.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.box_slideOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box_slideIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieChart)).EndInit();
            this.panel_right.ResumeLayout(false);
            this.panel_right.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doghnut)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_left;
        private System.Windows.Forms.Panel panel_right;
        private System.Windows.Forms.DataVisualization.Charting.Chart pieChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart doghnut;
        private System.Windows.Forms.PictureBox box_slideIn;
        private System.Windows.Forms.Timer timer_slideIn;
        private System.Windows.Forms.PictureBox box_slideOut;
        private System.Windows.Forms.Timer timer_slideOut;
        private System.Windows.Forms.Label label1;
    }
}
