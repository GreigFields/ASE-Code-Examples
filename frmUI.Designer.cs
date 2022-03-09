
namespace ASE_Code_Examples
{
    partial class frmStart
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRun = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMaxValue = new System.Windows.Forms.TextBox();
            this.btnGeneratePrimes = new System.Windows.Forms.Button();
            this.lblDuration = new System.Windows.Forms.Label();
            this.btnRefactoredPrimes = new System.Windows.Forms.Button();
            this.btnCompareResults = new System.Windows.Forms.Button();
            this.btnFindFactors = new System.Windows.Forms.Button();
            this.tbFindFactorsNumberMin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFindFactorsNumberMax = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tcASECodeExamples = new System.Windows.Forms.TabControl();
            this.tpPrimeFactors = new System.Windows.Forms.TabPage();
            this.gbResults = new System.Windows.Forms.GroupBox();
            this.dgvPFResults = new System.Windows.Forms.DataGridView();
            this.tbOutputTextBox = new System.Windows.Forms.TextBox();
            this.cbShowOutput = new System.Windows.Forms.CheckBox();
            this.tpSLFExamples = new System.Windows.Forms.TabPage();
            this.nudPrimeFactorsThreads = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.tcASECodeExamples.SuspendLayout();
            this.tpPrimeFactors.SuspendLayout();
            this.gbResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPFResults)).BeginInit();
            this.tpSLFExamples.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrimeFactorsThreads)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(54, 15);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 1;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Max Number";
            // 
            // tbMaxValue
            // 
            this.tbMaxValue.Location = new System.Drawing.Point(164, 35);
            this.tbMaxValue.Name = "tbMaxValue";
            this.tbMaxValue.Size = new System.Drawing.Size(100, 23);
            this.tbMaxValue.TabIndex = 3;
            this.tbMaxValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbMaxValue.TextChanged += new System.EventHandler(this.tbMaxValue_TextChanged);
            // 
            // btnGeneratePrimes
            // 
            this.btnGeneratePrimes.Location = new System.Drawing.Point(283, 24);
            this.btnGeneratePrimes.Name = "btnGeneratePrimes";
            this.btnGeneratePrimes.Size = new System.Drawing.Size(76, 42);
            this.btnGeneratePrimes.TabIndex = 4;
            this.btnGeneratePrimes.Text = "Original Primes";
            this.btnGeneratePrimes.UseVisualStyleBackColor = true;
            this.btnGeneratePrimes.Click += new System.EventHandler(this.btnGeneratePrimes_Click);
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(51, 125);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(35, 15);
            this.lblDuration.TabIndex = 6;
            this.lblDuration.Text = "Took:";
            // 
            // btnRefactoredPrimes
            // 
            this.btnRefactoredPrimes.Location = new System.Drawing.Point(365, 24);
            this.btnRefactoredPrimes.Name = "btnRefactoredPrimes";
            this.btnRefactoredPrimes.Size = new System.Drawing.Size(76, 42);
            this.btnRefactoredPrimes.TabIndex = 8;
            this.btnRefactoredPrimes.Text = "ReFactored Primes";
            this.btnRefactoredPrimes.UseVisualStyleBackColor = true;
            this.btnRefactoredPrimes.Click += new System.EventHandler(this.btnRefactoredPrimes_Click);
            // 
            // btnCompareResults
            // 
            this.btnCompareResults.Location = new System.Drawing.Point(447, 24);
            this.btnCompareResults.Name = "btnCompareResults";
            this.btnCompareResults.Size = new System.Drawing.Size(76, 42);
            this.btnCompareResults.TabIndex = 9;
            this.btnCompareResults.Text = "Compare Results";
            this.btnCompareResults.UseVisualStyleBackColor = true;
            this.btnCompareResults.Click += new System.EventHandler(this.btnCompareResults_Click);
            // 
            // btnFindFactors
            // 
            this.btnFindFactors.Location = new System.Drawing.Point(316, 67);
            this.btnFindFactors.Name = "btnFindFactors";
            this.btnFindFactors.Size = new System.Drawing.Size(76, 42);
            this.btnFindFactors.TabIndex = 12;
            this.btnFindFactors.Text = "Find Factors";
            this.btnFindFactors.UseVisualStyleBackColor = true;
            this.btnFindFactors.Click += new System.EventHandler(this.btnFindFactors_Click);
            // 
            // tbFindFactorsNumberMin
            // 
            this.tbFindFactorsNumberMin.Location = new System.Drawing.Point(164, 85);
            this.tbFindFactorsNumberMin.Name = "tbFindFactorsNumberMin";
            this.tbFindFactorsNumberMin.Size = new System.Drawing.Size(70, 23);
            this.tbFindFactorsNumberMin.TabIndex = 11;
            this.tbFindFactorsNumberMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbFindFactorsNumberMin.TextChanged += new System.EventHandler(this.tbFindFactorsNumber_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Find Factors Value";
            // 
            // tbFindFactorsNumberMax
            // 
            this.tbFindFactorsNumberMax.Location = new System.Drawing.Point(240, 85);
            this.tbFindFactorsNumberMax.Name = "tbFindFactorsNumberMax";
            this.tbFindFactorsNumberMax.Size = new System.Drawing.Size(70, 23);
            this.tbFindFactorsNumberMax.TabIndex = 13;
            this.tbFindFactorsNumberMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbFindFactorsNumberMax.TextChanged += new System.EventHandler(this.tbFindFactorsNumberMax_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Min";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(254, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Max";
            // 
            // tcASECodeExamples
            // 
            this.tcASECodeExamples.Controls.Add(this.tpPrimeFactors);
            this.tcASECodeExamples.Controls.Add(this.tpSLFExamples);
            this.tcASECodeExamples.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcASECodeExamples.Location = new System.Drawing.Point(0, 0);
            this.tcASECodeExamples.Name = "tcASECodeExamples";
            this.tcASECodeExamples.SelectedIndex = 0;
            this.tcASECodeExamples.Size = new System.Drawing.Size(724, 501);
            this.tcASECodeExamples.TabIndex = 16;
            // 
            // tpPrimeFactors
            // 
            this.tpPrimeFactors.Controls.Add(this.label5);
            this.tpPrimeFactors.Controls.Add(this.nudPrimeFactorsThreads);
            this.tpPrimeFactors.Controls.Add(this.gbResults);
            this.tpPrimeFactors.Controls.Add(this.cbShowOutput);
            this.tpPrimeFactors.Controls.Add(this.label1);
            this.tpPrimeFactors.Controls.Add(this.label4);
            this.tpPrimeFactors.Controls.Add(this.lblDuration);
            this.tpPrimeFactors.Controls.Add(this.tbMaxValue);
            this.tpPrimeFactors.Controls.Add(this.label3);
            this.tpPrimeFactors.Controls.Add(this.btnGeneratePrimes);
            this.tpPrimeFactors.Controls.Add(this.tbFindFactorsNumberMax);
            this.tpPrimeFactors.Controls.Add(this.btnRefactoredPrimes);
            this.tpPrimeFactors.Controls.Add(this.btnFindFactors);
            this.tpPrimeFactors.Controls.Add(this.btnCompareResults);
            this.tpPrimeFactors.Controls.Add(this.tbFindFactorsNumberMin);
            this.tpPrimeFactors.Controls.Add(this.label2);
            this.tpPrimeFactors.Location = new System.Drawing.Point(4, 24);
            this.tpPrimeFactors.Name = "tpPrimeFactors";
            this.tpPrimeFactors.Padding = new System.Windows.Forms.Padding(3);
            this.tpPrimeFactors.Size = new System.Drawing.Size(716, 473);
            this.tpPrimeFactors.TabIndex = 0;
            this.tpPrimeFactors.Text = "Prime Factors";
            this.tpPrimeFactors.UseVisualStyleBackColor = true;
            // 
            // gbResults
            // 
            this.gbResults.Controls.Add(this.dgvPFResults);
            this.gbResults.Controls.Add(this.tbOutputTextBox);
            this.gbResults.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbResults.Location = new System.Drawing.Point(3, 156);
            this.gbResults.Name = "gbResults";
            this.gbResults.Size = new System.Drawing.Size(710, 314);
            this.gbResults.TabIndex = 19;
            this.gbResults.TabStop = false;
            this.gbResults.Text = "Results";
            // 
            // dgvPFResults
            // 
            this.dgvPFResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPFResults.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvPFResults.Location = new System.Drawing.Point(3, 19);
            this.dgvPFResults.Name = "dgvPFResults";
            this.dgvPFResults.RowTemplate.Height = 25;
            this.dgvPFResults.Size = new System.Drawing.Size(704, 139);
            this.dgvPFResults.TabIndex = 18;
            // 
            // tbOutputTextBox
            // 
            this.tbOutputTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbOutputTextBox.Location = new System.Drawing.Point(3, 164);
            this.tbOutputTextBox.Multiline = true;
            this.tbOutputTextBox.Name = "tbOutputTextBox";
            this.tbOutputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbOutputTextBox.Size = new System.Drawing.Size(704, 147);
            this.tbOutputTextBox.TabIndex = 16;
            // 
            // cbShowOutput
            // 
            this.cbShowOutput.AutoSize = true;
            this.cbShowOutput.Checked = true;
            this.cbShowOutput.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowOutput.Location = new System.Drawing.Point(611, 141);
            this.cbShowOutput.Name = "cbShowOutput";
            this.cbShowOutput.Size = new System.Drawing.Size(96, 19);
            this.cbShowOutput.TabIndex = 17;
            this.cbShowOutput.Text = "Show Output";
            this.cbShowOutput.UseVisualStyleBackColor = true;
            // 
            // tpSLFExamples
            // 
            this.tpSLFExamples.Controls.Add(this.btnRun);
            this.tpSLFExamples.Location = new System.Drawing.Point(4, 24);
            this.tpSLFExamples.Name = "tpSLFExamples";
            this.tpSLFExamples.Padding = new System.Windows.Forms.Padding(3);
            this.tpSLFExamples.Size = new System.Drawing.Size(716, 473);
            this.tpSLFExamples.TabIndex = 1;
            this.tpSLFExamples.Text = "SLF Examples";
            this.tpSLFExamples.UseVisualStyleBackColor = true;
            // 
            // nudPrimeFactorsThreads
            // 
            this.nudPrimeFactorsThreads.Location = new System.Drawing.Point(411, 86);
            this.nudPrimeFactorsThreads.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.nudPrimeFactorsThreads.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPrimeFactorsThreads.Name = "nudPrimeFactorsThreads";
            this.nudPrimeFactorsThreads.Size = new System.Drawing.Size(57, 23);
            this.nudPrimeFactorsThreads.TabIndex = 20;
            this.nudPrimeFactorsThreads.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudPrimeFactorsThreads.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(411, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 15);
            this.label5.TabIndex = 21;
            this.label5.Text = "Threads";
            // 
            // frmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 501);
            this.Controls.Add(this.tcASECodeExamples);
            this.Name = "frmStart";
            this.Text = "frmInitialForm";
            this.Load += new System.EventHandler(this.frmStart_Load);
            this.tcASECodeExamples.ResumeLayout(false);
            this.tpPrimeFactors.ResumeLayout(false);
            this.tpPrimeFactors.PerformLayout();
            this.gbResults.ResumeLayout(false);
            this.gbResults.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPFResults)).EndInit();
            this.tpSLFExamples.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudPrimeFactorsThreads)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMaxValue;
        private System.Windows.Forms.Button btnGeneratePrimes;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Button btnRefactoredPrimes;
        private System.Windows.Forms.Button btnCompareResults;
        private System.Windows.Forms.Button btnFindFactors;
        private System.Windows.Forms.TextBox tbFindFactorsNumberMin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbFindFactorsNumberMax;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tcASECodeExamples;
        private System.Windows.Forms.TabPage tpPrimeFactors;
        private System.Windows.Forms.TabPage tpSLFExamples;
        private System.Windows.Forms.CheckBox cbShowOutput;
        private System.Windows.Forms.TextBox tbOutputTextBox;
        private System.Windows.Forms.GroupBox gbResults;
        private System.Windows.Forms.DataGridView dgvPFResults;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudPrimeFactorsThreads;
    }
}

