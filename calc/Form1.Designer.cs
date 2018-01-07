namespace calc
{
    partial class Form1
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.illuminationPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.illumOutput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.illumArea = new System.Windows.Forms.TextBox();
            this.illumLumens = new System.Windows.Forms.TextBox();
            this.Luminance = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.luminArea = new System.Windows.Forms.TextBox();
            this.luminTransFactor = new System.Windows.Forms.TextBox();
            this.luminNumber = new System.Windows.Forms.TextBox();
            this.luminLumens = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.illumCU = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.illumMF = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.illuminationPanel.SuspendLayout();
            this.Luminance.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Illumination",
            "Luminance",
            "Number of Fixtures",
            "2D Point-by-point",
            "3D Point-by-point"});
            this.comboBox1.Location = new System.Drawing.Point(2, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(187, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "--choose method--";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(2, -1);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(59, 17);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "English";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(93, -1);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(54, 17);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Metric";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // illuminationPanel
            // 
            this.illuminationPanel.Controls.Add(this.label15);
            this.illuminationPanel.Controls.Add(this.label16);
            this.illuminationPanel.Controls.Add(this.textBox2);
            this.illuminationPanel.Controls.Add(this.label14);
            this.illuminationPanel.Controls.Add(this.label13);
            this.illuminationPanel.Controls.Add(this.illumMF);
            this.illuminationPanel.Controls.Add(this.label12);
            this.illuminationPanel.Controls.Add(this.illumCU);
            this.illuminationPanel.Controls.Add(this.label4);
            this.illuminationPanel.Controls.Add(this.label3);
            this.illuminationPanel.Controls.Add(this.illumOutput);
            this.illuminationPanel.Controls.Add(this.label2);
            this.illuminationPanel.Controls.Add(this.label1);
            this.illuminationPanel.Controls.Add(this.illumArea);
            this.illuminationPanel.Controls.Add(this.illumLumens);
            this.illuminationPanel.Location = new System.Drawing.Point(12, 63);
            this.illuminationPanel.Name = "illuminationPanel";
            this.illuminationPanel.Size = new System.Drawing.Size(244, 284);
            this.illuminationPanel.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Illumination";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "lux / footcandles";
            // 
            // illumOutput
            // 
            this.illumOutput.Location = new System.Drawing.Point(12, 205);
            this.illumOutput.Name = "illumOutput";
            this.illumOutput.Size = new System.Drawing.Size(100, 20);
            this.illumOutput.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "m^2 / ft^2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "lumens";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // illumArea
            // 
            this.illumArea.Location = new System.Drawing.Point(12, 69);
            this.illumArea.Name = "illumArea";
            this.illumArea.Size = new System.Drawing.Size(100, 20);
            this.illumArea.TabIndex = 1;
            // 
            // illumLumens
            // 
            this.illumLumens.Location = new System.Drawing.Point(12, 42);
            this.illumLumens.Name = "illumLumens";
            this.illumLumens.Size = new System.Drawing.Size(100, 20);
            this.illumLumens.TabIndex = 0;
            this.illumLumens.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Luminance
            // 
            this.Luminance.Controls.Add(this.label10);
            this.Luminance.Controls.Add(this.textBox1);
            this.Luminance.Controls.Add(this.label9);
            this.Luminance.Controls.Add(this.label8);
            this.Luminance.Controls.Add(this.label7);
            this.Luminance.Controls.Add(this.label6);
            this.Luminance.Controls.Add(this.luminArea);
            this.Luminance.Controls.Add(this.luminTransFactor);
            this.Luminance.Controls.Add(this.luminNumber);
            this.Luminance.Controls.Add(this.luminLumens);
            this.Luminance.Controls.Add(this.label5);
            this.Luminance.Location = new System.Drawing.Point(276, 63);
            this.Luminance.Name = "Luminance";
            this.Luminance.Size = new System.Drawing.Size(232, 188);
            this.Luminance.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(123, 154);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "footlambert / millilambert";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 151);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(123, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "area of diffuser";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(122, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "transmission factor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(122, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "number of lamps";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(122, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "lumens";
            // 
            // luminArea
            // 
            this.luminArea.Location = new System.Drawing.Point(16, 121);
            this.luminArea.Name = "luminArea";
            this.luminArea.Size = new System.Drawing.Size(100, 20);
            this.luminArea.TabIndex = 4;
            // 
            // luminTransFactor
            // 
            this.luminTransFactor.Location = new System.Drawing.Point(16, 95);
            this.luminTransFactor.Name = "luminTransFactor";
            this.luminTransFactor.Size = new System.Drawing.Size(100, 20);
            this.luminTransFactor.TabIndex = 3;
            // 
            // luminNumber
            // 
            this.luminNumber.Location = new System.Drawing.Point(16, 65);
            this.luminNumber.Name = "luminNumber";
            this.luminNumber.Size = new System.Drawing.Size(100, 20);
            this.luminNumber.TabIndex = 2;
            // 
            // luminLumens
            // 
            this.luminLumens.Location = new System.Drawing.Point(16, 37);
            this.luminLumens.Name = "luminLumens";
            this.luminLumens.Size = new System.Drawing.Size(100, 20);
            this.luminLumens.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Luminance";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label11);
            this.panel1.Location = new System.Drawing.Point(523, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 188);
            this.panel1.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Number of Fixtures";
            // 
            // illumCU
            // 
            this.illumCU.Location = new System.Drawing.Point(12, 95);
            this.illumCU.Name = "illumCU";
            this.illumCU.Size = new System.Drawing.Size(100, 20);
            this.illumCU.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(118, 98);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "coefficient of utilization";
            // 
            // illumMF
            // 
            this.illumMF.Location = new System.Drawing.Point(12, 124);
            this.illumMF.Name = "illumMF";
            this.illumMF.Size = new System.Drawing.Size(100, 20);
            this.illumMF.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(118, 128);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "maintenance factor";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 189);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "Initial";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 229);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 13);
            this.label15.TabIndex = 15;
            this.label15.Text = "Maintenance";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(118, 248);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(86, 13);
            this.label16.TabIndex = 14;
            this.label16.Text = "lux / footcandles";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 245);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 688);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Luminance);
            this.Controls.Add(this.illuminationPanel);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.comboBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Illumination Design Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.illuminationPanel.ResumeLayout(false);
            this.illuminationPanel.PerformLayout();
            this.Luminance.ResumeLayout(false);
            this.Luminance.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Panel illuminationPanel;
        private System.Windows.Forms.TextBox illumLumens;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox illumArea;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox illumOutput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel Luminance;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox luminArea;
        private System.Windows.Forms.TextBox luminTransFactor;
        private System.Windows.Forms.TextBox luminNumber;
        private System.Windows.Forms.TextBox luminLumens;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox illumMF;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox illumCU;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label14;
    }
}

