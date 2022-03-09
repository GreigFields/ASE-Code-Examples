namespace ASE_Code_Examples
{
    partial class frmLoadStatus
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbLoadStatus = new System.Windows.Forms.TextBox();
            this.pbLoadStatus = new System.Windows.Forms.ProgressBar();
            this.btnLoadStatusCancel = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblLoadStatusPctComplete = new System.Windows.Forms.Label();
            this.lblLoadStatusAvgTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Status: ";
            // 
            // tbLoadStatus
            // 
            this.tbLoadStatus.Location = new System.Drawing.Point(71, 12);
            this.tbLoadStatus.Name = "tbLoadStatus";
            this.tbLoadStatus.Size = new System.Drawing.Size(390, 23);
            this.tbLoadStatus.TabIndex = 1;
            // 
            // pbLoadStatus
            // 
            this.pbLoadStatus.Location = new System.Drawing.Point(142, 41);
            this.pbLoadStatus.Name = "pbLoadStatus";
            this.pbLoadStatus.Size = new System.Drawing.Size(319, 23);
            this.pbLoadStatus.TabIndex = 2;
            // 
            // btnLoadStatusCancel
            // 
            this.btnLoadStatusCancel.Location = new System.Drawing.Point(213, 107);
            this.btnLoadStatusCancel.Name = "btnLoadStatusCancel";
            this.btnLoadStatusCancel.Size = new System.Drawing.Size(75, 23);
            this.btnLoadStatusCancel.TabIndex = 3;
            this.btnLoadStatusCancel.Text = "Cancel";
            this.btnLoadStatusCancel.UseVisualStyleBackColor = true;
            this.btnLoadStatusCancel.Click += new System.EventHandler(this.btnLoadStatusCancel_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(142, 78);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(319, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // lblLoadStatusPctComplete
            // 
            this.lblLoadStatusPctComplete.AutoSize = true;
            this.lblLoadStatusPctComplete.Location = new System.Drawing.Point(12, 41);
            this.lblLoadStatusPctComplete.Name = "lblLoadStatusPctComplete";
            this.lblLoadStatusPctComplete.Size = new System.Drawing.Size(111, 15);
            this.lblLoadStatusPctComplete.TabIndex = 5;
            this.lblLoadStatusPctComplete.Text = "% Complete (00%): ";
            // 
            // lblLoadStatusAvgTime
            // 
            this.lblLoadStatusAvgTime.AutoSize = true;
            this.lblLoadStatusAvgTime.Location = new System.Drawing.Point(12, 78);
            this.lblLoadStatusAvgTime.Name = "lblLoadStatusAvgTime";
            this.lblLoadStatusAvgTime.Size = new System.Drawing.Size(92, 15);
            this.lblLoadStatusAvgTime.TabIndex = 6;
            this.lblLoadStatusAvgTime.Text = "Avg Time (     ) : ";
            // 
            // frmLoadStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 131);
            this.Controls.Add(this.lblLoadStatusAvgTime);
            this.Controls.Add(this.lblLoadStatusPctComplete);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnLoadStatusCancel);
            this.Controls.Add(this.pbLoadStatus);
            this.Controls.Add(this.tbLoadStatus);
            this.Controls.Add(this.label1);
            this.Name = "frmLoadStatus";
            this.Text = "frmLoadStatus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbLoadStatus;
        private System.Windows.Forms.ProgressBar pbLoadStatus;
        private System.Windows.Forms.Button btnLoadStatusCancel;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblLoadStatusPctComplete;
        private System.Windows.Forms.Label lblLoadStatusAvgTime;
    }
}