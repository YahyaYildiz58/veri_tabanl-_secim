namespace veri_tabanlı_secim
{
    partial class FrmGrafikler
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.grpgrafik = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.prbaparti = new System.Windows.Forms.ProgressBar();
            this.prbbparti = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.prbcparti = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.prbdparti = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.prbeparti = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.lbla = new System.Windows.Forms.Label();
            this.lblb = new System.Windows.Forms.Label();
            this.lblc = new System.Windows.Forms.Label();
            this.lbld = new System.Windows.Forms.Label();
            this.lble = new System.Windows.Forms.Label();
            this.grpgrafik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpgrafik
            // 
            this.grpgrafik.Controls.Add(this.chart1);
            this.grpgrafik.Location = new System.Drawing.Point(12, 12);
            this.grpgrafik.Name = "grpgrafik";
            this.grpgrafik.Size = new System.Drawing.Size(508, 166);
            this.grpgrafik.TabIndex = 0;
            this.grpgrafik.TabStop = false;
            this.grpgrafik.Text = "GRAFİKLER";
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(3, 16);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "PARTİLER";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(502, 147);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lble);
            this.groupBox1.Controls.Add(this.lbld);
            this.groupBox1.Controls.Add(this.lblc);
            this.groupBox1.Controls.Add(this.lblb);
            this.groupBox1.Controls.Add(this.lbla);
            this.groupBox1.Controls.Add(this.prbeparti);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.prbdparti);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.prbcparti);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.prbbparti);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.prbaparti);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 184);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(508, 205);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İLÇE DEĞERLERİ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "İLÇE SEÇİN: ";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(106, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(356, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "A PARTİ: ";
            // 
            // prbaparti
            // 
            this.prbaparti.Location = new System.Drawing.Point(106, 47);
            this.prbaparti.Maximum = 500;
            this.prbaparti.Name = "prbaparti";
            this.prbaparti.Size = new System.Drawing.Size(356, 23);
            this.prbaparti.TabIndex = 4;
            // 
            // prbbparti
            // 
            this.prbbparti.Location = new System.Drawing.Point(106, 76);
            this.prbbparti.Maximum = 500;
            this.prbbparti.Name = "prbbparti";
            this.prbbparti.Size = new System.Drawing.Size(356, 23);
            this.prbbparti.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "B PARTİ: ";
            // 
            // prbcparti
            // 
            this.prbcparti.Location = new System.Drawing.Point(106, 105);
            this.prbcparti.Maximum = 500;
            this.prbcparti.Name = "prbcparti";
            this.prbcparti.Size = new System.Drawing.Size(356, 23);
            this.prbcparti.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "C PARTİ: ";
            // 
            // prbdparti
            // 
            this.prbdparti.Location = new System.Drawing.Point(106, 134);
            this.prbdparti.Maximum = 500;
            this.prbdparti.Name = "prbdparti";
            this.prbdparti.Size = new System.Drawing.Size(356, 23);
            this.prbdparti.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "D PARTİ: ";
            // 
            // prbeparti
            // 
            this.prbeparti.Location = new System.Drawing.Point(106, 163);
            this.prbeparti.Maximum = 500;
            this.prbeparti.Name = "prbeparti";
            this.prbeparti.Size = new System.Drawing.Size(356, 23);
            this.prbeparti.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "E PARTİ: ";
            // 
            // lbla
            // 
            this.lbla.AutoSize = true;
            this.lbla.Location = new System.Drawing.Point(468, 57);
            this.lbla.Name = "lbla";
            this.lbla.Size = new System.Drawing.Size(13, 13);
            this.lbla.TabIndex = 13;
            this.lbla.Text = "0";
            // 
            // lblb
            // 
            this.lblb.AutoSize = true;
            this.lblb.Location = new System.Drawing.Point(468, 86);
            this.lblb.Name = "lblb";
            this.lblb.Size = new System.Drawing.Size(13, 13);
            this.lblb.TabIndex = 14;
            this.lblb.Text = "0";
            // 
            // lblc
            // 
            this.lblc.AutoSize = true;
            this.lblc.Location = new System.Drawing.Point(468, 115);
            this.lblc.Name = "lblc";
            this.lblc.Size = new System.Drawing.Size(13, 13);
            this.lblc.TabIndex = 15;
            this.lblc.Text = "0";
            // 
            // lbld
            // 
            this.lbld.AutoSize = true;
            this.lbld.Location = new System.Drawing.Point(468, 144);
            this.lbld.Name = "lbld";
            this.lbld.Size = new System.Drawing.Size(13, 13);
            this.lbld.TabIndex = 16;
            this.lbld.Text = "0";
            // 
            // lble
            // 
            this.lble.AutoSize = true;
            this.lble.Location = new System.Drawing.Point(468, 173);
            this.lble.Name = "lble";
            this.lble.Size = new System.Drawing.Size(13, 13);
            this.lble.TabIndex = 17;
            this.lble.Text = "0";
            // 
            // FrmGrafikler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.ClientSize = new System.Drawing.Size(530, 401);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpgrafik);
            this.Name = "FrmGrafikler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VTGS";
            this.Load += new System.EventHandler(this.FrmGrafikler_Load);
            this.grpgrafik.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpgrafik;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar prbeparti;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar prbdparti;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar prbcparti;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar prbbparti;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar prbaparti;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lble;
        private System.Windows.Forms.Label lbld;
        private System.Windows.Forms.Label lblc;
        private System.Windows.Forms.Label lblb;
        private System.Windows.Forms.Label lbla;
    }
}