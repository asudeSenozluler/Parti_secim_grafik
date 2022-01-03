namespace Parti_secim_grafik
{
    partial class frmgrafikler
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.progressBara = new System.Windows.Forms.ProgressBar();
            this.progressBarb = new System.Windows.Forms.ProgressBar();
            this.progressBarc = new System.Windows.Forms.ProgressBar();
            this.progressBard = new System.Windows.Forms.ProgressBar();
            this.progressBare = new System.Windows.Forms.ProgressBar();
            this.lbla = new System.Windows.Forms.Label();
            this.lble = new System.Windows.Forms.Label();
            this.lbld = new System.Windows.Forms.Label();
            this.lblc = new System.Windows.Forms.Label();
            this.lblb = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chart1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(936, 303);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grafikler";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(3, 26);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Partiler";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(930, 274);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblb);
            this.groupBox2.Controls.Add(this.lblc);
            this.groupBox2.Controls.Add(this.lbld);
            this.groupBox2.Controls.Add(this.lble);
            this.groupBox2.Controls.Add(this.lbla);
            this.groupBox2.Controls.Add(this.progressBare);
            this.groupBox2.Controls.Add(this.progressBard);
            this.groupBox2.Controls.Add(this.progressBarc);
            this.groupBox2.Controls.Add(this.progressBarb);
            this.groupBox2.Controls.Add(this.progressBara);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 321);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(936, 280);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İlçe Değerleri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "İlçe Seçin:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(208, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(169, 32);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "A Parti:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "B Parti:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "C Parti: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(115, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "D Parti:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(116, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "E Parti:";
            // 
            // progressBara
            // 
            this.progressBara.Location = new System.Drawing.Point(208, 99);
            this.progressBara.Maximum = 200;
            this.progressBara.Name = "progressBara";
            this.progressBara.Size = new System.Drawing.Size(169, 23);
            this.progressBara.TabIndex = 8;
            // 
            // progressBarb
            // 
            this.progressBarb.Location = new System.Drawing.Point(209, 133);
            this.progressBarb.Maximum = 200;
            this.progressBarb.Name = "progressBarb";
            this.progressBarb.Size = new System.Drawing.Size(169, 23);
            this.progressBarb.TabIndex = 10;
            // 
            // progressBarc
            // 
            this.progressBarc.Location = new System.Drawing.Point(208, 171);
            this.progressBarc.Maximum = 200;
            this.progressBarc.Name = "progressBarc";
            this.progressBarc.Size = new System.Drawing.Size(169, 23);
            this.progressBarc.TabIndex = 11;
            // 
            // progressBard
            // 
            this.progressBard.Location = new System.Drawing.Point(208, 208);
            this.progressBard.Maximum = 200;
            this.progressBard.Name = "progressBard";
            this.progressBard.Size = new System.Drawing.Size(169, 23);
            this.progressBard.TabIndex = 12;
            // 
            // progressBare
            // 
            this.progressBare.Location = new System.Drawing.Point(208, 244);
            this.progressBare.Maximum = 200;
            this.progressBare.Name = "progressBare";
            this.progressBare.Size = new System.Drawing.Size(169, 23);
            this.progressBare.TabIndex = 13;
            // 
            // lbla
            // 
            this.lbla.AutoSize = true;
            this.lbla.Location = new System.Drawing.Point(396, 99);
            this.lbla.Name = "lbla";
            this.lbla.Size = new System.Drawing.Size(24, 24);
            this.lbla.TabIndex = 14;
            this.lbla.Text = "0";
            // 
            // lble
            // 
            this.lble.AutoSize = true;
            this.lble.Location = new System.Drawing.Point(396, 243);
            this.lble.Name = "lble";
            this.lble.Size = new System.Drawing.Size(24, 24);
            this.lble.TabIndex = 16;
            this.lble.Text = "0";
            // 
            // lbld
            // 
            this.lbld.AutoSize = true;
            this.lbld.Location = new System.Drawing.Point(396, 208);
            this.lbld.Name = "lbld";
            this.lbld.Size = new System.Drawing.Size(24, 24);
            this.lbld.TabIndex = 17;
            this.lbld.Text = "0";
            // 
            // lblc
            // 
            this.lblc.AutoSize = true;
            this.lblc.Location = new System.Drawing.Point(396, 170);
            this.lblc.Name = "lblc";
            this.lblc.Size = new System.Drawing.Size(24, 24);
            this.lblc.TabIndex = 18;
            this.lblc.Text = "0";
            // 
            // lblb
            // 
            this.lblb.AutoSize = true;
            this.lblb.Location = new System.Drawing.Point(396, 136);
            this.lblb.Name = "lblb";
            this.lblb.Size = new System.Drawing.Size(24, 24);
            this.lblb.TabIndex = 19;
            this.lblb.Text = "0";
            // 
            // frmgrafikler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(960, 603);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmgrafikler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seçim İstatistik Deneme";
            this.Load += new System.EventHandler(this.frmgrafikler_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblb;
        private System.Windows.Forms.Label lblc;
        private System.Windows.Forms.Label lbld;
        private System.Windows.Forms.Label lble;
        private System.Windows.Forms.Label lbla;
        private System.Windows.Forms.ProgressBar progressBare;
        private System.Windows.Forms.ProgressBar progressBard;
        private System.Windows.Forms.ProgressBar progressBarc;
        private System.Windows.Forms.ProgressBar progressBarb;
        private System.Windows.Forms.ProgressBar progressBara;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}