using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ASE_Code_Examples
{

    public partial class frmLoadStatus : Form
    {
        bool frmLoadStatusCancel = false;
        public frmLoadStatus()
        {
            InitializeComponent();
            frmLoadStatusCancel = false;
            ProjectGlobals.LoadStatusCancelClicked = false;
        }
        public void UpdateLoadStatus()
        {
            tbLoadStatus.Text = ProjectGlobals.LoadStatus;

            if (ProjectGlobals.LoadStatusPct > 0 && ProjectGlobals.LoadStatusPct <= 1)
                pbLoadStatus.Value = Convert.ToInt16(ProjectGlobals.LoadStatusPct * 100);
            lblLoadStatusPctComplete.Text = "Complete: " + ProjectGlobals.LoadStatusPct.ToString("P");
            Application.DoEvents();
        }
        public void UpdateLoadStatus(string Status, double Pct, long ticks = 0, long minticks = 0, long maxticks = 0 )
        {
            tbLoadStatus.Text = Status;
            pbLoadStatus.Value = Convert.ToInt16(Pct * 100);
            lblLoadStatusPctComplete.Text = "Complete: " + Pct.ToString("P");

            TimeSpan ts = TimeSpan.FromTicks(ticks);
            double avgticks = Convert.ToDouble(ticks - minticks) / Convert.ToDouble(maxticks);
            lblLoadStatusAvgTime.Text = "Avg. Time: "+ ts.TotalSeconds.ToString();
            if(avgticks>0 && avgticks<1)
                progressBar1.Value = Convert.ToInt16(avgticks*100);
            Application.DoEvents();
        }

        private void frmLoadStatus_Load(object sender, EventArgs e)
        {

        }
        public bool CancelClicked()
        {
            
            return frmLoadStatusCancel;
        }
        public bool CancelClicked(bool set)
        {
            bool oldval = frmLoadStatusCancel;
            ProjectGlobals.LoadStatusCancelClicked = set;
            frmLoadStatusCancel = set;
            return oldval;
        }
        private void btnLoadStatusCancel_Click(object sender, EventArgs e)
        {
            CancelClicked(true);
        }
    }
}
