using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
/* 
 * Developed by Greig Fields 12/15/2021 to support ASE Course
 * Permission to freely destribute as long as this header is attached
 */
namespace ASE_Code_Examples
{
    public partial class frmStart : Form
    {
        public frmStart()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {

        }

        private void tbMaxValue_TextChanged(object sender, EventArgs e)
        {
            if (tbMaxValue.Text.Length > 0 && int.TryParse(tbMaxValue.Text, out int result) == false)
                MessageBox.Show(tbMaxValue.Text + " Not a valid integer");
        }
        private int[] OriginalPrimes = new int[0];
        private int[] RefactoredPrimes = new int[0];
        private void btnGeneratePrimes_Click(object sender, EventArgs e)
        {

            int.TryParse(tbMaxValue.Text, out int result);
            DateTime StartTime = DateTime.Now;

            OriginalPrimes = Primes.generatePrimes(result);
            DateTime EndTime = DateTime.Now;
            TimeSpan Duration = EndTime.Subtract(StartTime);
            lblDuration.Text = OriginalPrimes.Length.ToString() + " Primes Found. Took: " + Duration.ToString();
            if (cbShowOutput.Checked == true)
            {
                showOutput(OriginalPrimes);
            }
        }

        private void btnRefactoredPrimes_Click(object sender, EventArgs e)
        {

            int.TryParse(tbMaxValue.Text, out int result);
            DateTime StartTime = DateTime.Now;

            RefactoredPrimes = Primes.generatePrimesBaseRefactor(result);
            DateTime EndTime = DateTime.Now;
            TimeSpan Duration = EndTime.Subtract(StartTime);
            lblDuration.Text = RefactoredPrimes.Length.ToString() + " Primes Found. Took: " + Duration.ToString();
            if (cbShowOutput.Checked == true)
            {
                showOutput(RefactoredPrimes);
            }
        }
        void showOutput(int[] s)
        {
            string OutputString = null;
            tbOutputTextBox.Text = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (i > 0)
                    OutputString += " ";
                OutputString += s[i].ToString();
                if (i < s.Length - 1)
                    OutputString += ",";
            }
            tbOutputTextBox.Text = OutputString;
        }

        private void btnCompareResults_Click(object sender, EventArgs e)
        {
            if (OriginalPrimes == null || RefactoredPrimes == null)
            {
                MessageBox.Show("One of Results Arrays are null");
                return;
            }
            if (OriginalPrimes.Length != RefactoredPrimes.Length)
            {
                MessageBox.Show("Number of Primes Different Original: " + OriginalPrimes.Length + " Refactored: " + RefactoredPrimes.Length);
                return;
            }
            for (int i = 0; i < OriginalPrimes.Length; i++)
            {
                if (OriginalPrimes[i] != RefactoredPrimes[i])
                {
                    MessageBox.Show("Difference Found at item " + i + " Original = " + OriginalPrimes[i] + " Refactored = " + RefactoredPrimes[i]);
                }
            }
            MessageBox.Show("Original and Refactored returned the same list of Primes");
        }

        private void frmStart_Load(object sender, EventArgs e)
        {

        }


        static int[][][] factorArrray;
        int[][][] uniqueFactorArray;
        static string[][] FactorStrings;
        static double[] CompletionPct;
        static double[] AvgDuration;
        private void btnFindFactors_Click(object sender, EventArgs e)
        {
            if(nudPrimeFactorsThreads.Value >1)
            {
                FindFactorsMultiThread();
                return;
            }            
            int.TryParse(tbFindFactorsNumberMin.Text, out int resultMin);
            int.TryParse(tbFindFactorsNumberMax.Text, out int resultMax);

            if (resultMin > resultMax)
            {
                MessageBox.Show("Min Value " + resultMin + " is Greater Than " + resultMax);
                return;
            }

            int NumVals = (resultMax - resultMin) + 1;
            factorArrray = new int[NumVals][][];
         
            frmLoadStatus FormLoadStatus = new frmLoadStatus();
            ProjectGlobals.LoadStatusPct = Convert.ToDouble(1) / Convert.ToDouble(NumVals);
            FormLoadStatus.UpdateLoadStatus("Finding Factors for " + NumVals + " Samples", .001, 1, TimeSpan.TicksPerSecond*2);
            FormLoadStatus.Show();
            
            TimeSpan TotalTime = new TimeSpan();
            long[] lastThreeTicks = new long[3];
            long minTicks = 0;
            long maxTicks = 100;
            for (int i = 0; i < NumVals; i++)
            {
                if (i % 10 == 0)
                {
                    long avgticks = (lastThreeTicks[0] + lastThreeTicks[1] + lastThreeTicks[2]) / 3;
                    ProjectGlobals.LoadStatusPct = Convert.ToDouble(i + 1) / Convert.ToDouble(NumVals);
                    FormLoadStatus.UpdateLoadStatus("Finding Primes for " + (i + 1+resultMin).ToString() 
                        + " To " + ( i+ 10 + resultMin).ToString(), 
                        Convert.ToDouble(Convert.ToDouble(i + 1) / Convert.ToDouble(NumVals)),avgticks, minTicks, maxTicks );
                }
                
                DateTime StartTime = DateTime.Now;
                factorArrray[i] = Primes.GetFactors(resultMin + i);
                int x = factorArrray[i].Length;
                DateTime EndTime = DateTime.Now;
                TimeSpan Duration = EndTime.Subtract(StartTime);
                lastThreeTicks[0] = lastThreeTicks[1];
                lastThreeTicks[1] = lastThreeTicks[2];
                lastThreeTicks[2] = Duration.Ticks;
                
                if(minTicks ==0) minTicks = Duration.Ticks;
                if(Duration.Ticks < minTicks)
                    minTicks = Duration.Ticks;
                if (Duration.Ticks > maxTicks) maxTicks = Duration.Ticks;

                lblDuration.Text = factorArrray[i].Length.ToString() + " Prime Factors for " + resultMin + i + " Found. Took: " + Duration.ToString();
                TotalTime += Duration;
                Refresh();
                if(FormLoadStatus.CancelClicked() == true)
                {
                    switch(MessageBox.Show("Operation Cancelled Show Results?","Operation Cancelled",MessageBoxButtons.YesNoCancel))
                    {
                        case DialogResult.Yes:
                        break;
                        case DialogResult.No:
                        FormLoadStatus.Hide();
                        return;
                    }
                }
            }
            FormLoadStatus.Hide();
            lblDuration.Text = factorArrray.Length.ToString() + " Prime Factors for " + NumVals + " Found. Took: " + TotalTime.ToString();
            tbOutputTextBox.Text = "";
            string[][] FactorStrings = new string[NumVals][];
            for (int i = 0; i < NumVals; i++)
            {
                FactorStrings[i] = new string[3];
                string[] retstrings = showOutputPrimeFactors(factorArrray[i], true);
                FactorStrings[i] = retstrings;
            }
            loadFindPrimesDGV(FactorStrings);
        }
 
        void FindFactorsMultiThread() // Should be past the minimum and max numbers as well number of threads then could be in Primes.cs
        {
            int.TryParse(tbFindFactorsNumberMin.Text, out int resultMin);
            int.TryParse(tbFindFactorsNumberMax.Text, out int resultMax);

            if (resultMin > resultMax)
            {
                MessageBox.Show("Min Value " + resultMin + " is Greater Than " + resultMax);
                return;
            }

            int NumVals = (resultMax - resultMin) + 1;
            int numThreads = Convert.ToInt16(nudPrimeFactorsThreads.Value);
            int[][] threadArray = new int[Convert.ToInt16(nudPrimeFactorsThreads.Value)][];
            int numValsForThreads = Convert.ToInt32(Math.Floor(Convert.ToDecimal(NumVals / numThreads)));
            for(int i = 0; i < numThreads; i++)
            {
                threadArray[i] = new int[2];
                if(i!=0)
                    threadArray[i][0] = threadArray[i-1][1]+1;
                else
                    threadArray[i][0] = resultMin;
                threadArray[i][1] = (numValsForThreads*i) + numValsForThreads + resultMin;
            }
            threadArray[numThreads - 1][1] = resultMax;
            CompletionPct = new double[numThreads];
            Thread[] Threads = new Thread[numThreads];
            factorArrray = new int[NumVals][][];
            AvgDuration = new double[numThreads];
            for(int i = 0; i < numThreads;i++)
            {
                Threads[i] = new Thread(() => { FindPrimeFactorMultiThread(resultMin, threadArray); });
                Threads[i].Name = i.ToString();
                Threads[i].Start();
            }


            ThreadState[] ThreadStates = new ThreadState[numThreads];
            bool active = true;
            DateTime QStart = DateTime.Now;
            frmLoadStatus FormLoadStatus = new frmLoadStatus();
            FormLoadStatus.Show();
            while (active == true)
            {
                active = false;
                for (int s = 0; s <  numThreads; s++)
                {
                    ThreadStates[s] = Threads[s].ThreadState;
                    if ((ThreadStates[s] & (ThreadState.Stopped | ThreadState.Unstarted)) == 0)
                    {
                        active = true;
                        break;
                    }
                }

                Thread.Sleep(500);
                double tdone = 0;
                for (int s = 0; s < numThreads; s++)
                    tdone += CompletionPct[s];
                

                DateTime Ctime = DateTime.Now;
                TimeSpan diff = Ctime.Subtract(QStart);
                double secs = diff.TotalSeconds;
                double togo;
                if (tdone != 0)
                    togo = (secs / tdone) * (numThreads - tdone);
                else
                    togo = 1;
                TimeSpan ts = TimeSpan.FromSeconds(togo);


                ProjectGlobals.LoadStatus = numThreads + " Threads " + Convert.ToInt16(NumVals/numThreads).ToString() + " Items per Thread " + (tdone / numThreads).ToString("P") + " Done" + " Took " + diff.ToString("mm\\:ss") + " - " + ts.ToString("mm\\:ss") + " left"; ;
                ProjectGlobals.LoadStatusPct = (tdone + .00001) / numThreads;
                FormLoadStatus.UpdateLoadStatus();

                if (FormLoadStatus.CancelClicked() == true)
                {
                    for (int s = 0; s <  numThreads; s++)
                    {
                        ThreadStates[s] = Threads[s].ThreadState;
                        if ((ThreadStates[s] & (ThreadState.Stopped | ThreadState.Unstarted)) == 0)
                        {
                            //Threads[s].Suspend();
                        }
                    }
                    for (int s = 0; s < numThreads; s++)
                    {
                        Threads[s].Join();
                    }
                    FormLoadStatus.Hide();
                    Refresh();
                    MessageBox.Show("Cancelled");
                    return;
                }

            }
            for (int s = 0; s <  numThreads; s++)
            {
                Threads[s].Join();
            }
            FormLoadStatus.Hide();


            lblDuration.Text = factorArrray.Length.ToString() + " Prime Factors for " + NumVals + " Found. Took: " + DateTime.Now.Subtract(QStart).ToString();
            tbOutputTextBox.Text = "";
            string[][] FactorStrings = new string[NumVals][];
            for (int i = 0; i < NumVals; i++)
            {
                FactorStrings[i] = new string[3];
                string[] retstrings = showOutputPrimeFactors(factorArrray[i], true);
                FactorStrings[i] = retstrings;
            }
            loadFindPrimesDGV(FactorStrings);
        }
        private static void FindPrimeFactorMultiThread(int MinVal,  int[][] numbers) // Should pass the factor Array in and combine
        {
            Thread th = Thread.CurrentThread;
            int index = Convert.ToInt16(th.Name);
            int NumVals = (numbers[index][1] - numbers[index][0])+1;
            TimeSpan TotalTime = new TimeSpan();

            long[] lastThreeTicks = new long[3];
            for (int i = 0; i < NumVals; i++)
            {
                if (i % 1 == 0)
                {
                    CompletionPct[index] = Convert.ToDouble(i + 1) / Convert.ToDouble(NumVals);
                }

                DateTime StartTime = DateTime.Now;
                factorArrray[(numbers[index][0] - MinVal) +i] = Primes.GetFactors(numbers[index][0] + i);

                DateTime EndTime = DateTime.Now;
                TimeSpan Duration = EndTime.Subtract(StartTime);
                lastThreeTicks[0] = lastThreeTicks[1];
                lastThreeTicks[1] = lastThreeTicks[2];
                lastThreeTicks[2] = Duration.Ticks;


                AvgDuration[index] = Convert.ToDouble(lastThreeTicks[0] + lastThreeTicks[1] + lastThreeTicks[2]) / 3;
                TotalTime += Duration;

                if (ProjectGlobals.LoadStatusCancelClicked == true)
                {
                    return;
                }
            }    
        }
        string[] showOutputPrimeFactors(int[][] Factors, bool append = false)
        {
            string FactorOutputString = null;
            string RawFactorOutputString = null;
            if (append == false)
                tbOutputTextBox.Text = "";
            else
                tbOutputTextBox.AppendText("\r\n");
            for (int i = 0; i < Factors.Length; i++)
            {
                RawFactorOutputString += Factors[i][0].ToString();
                if (i < Factors.Length - 1)
                    RawFactorOutputString += " x ";
            }
            int[][] uniquefactors = Primes.findUniqueFactors(Factors);
            int TotalPrimeFactor = Factors[0][0];
            for (int i = 1; i < Factors.Length; i++) // lets go through each of the factors the first entry is already added
            {
                TotalPrimeFactor *= Factors[i][0]; // multiply the current value times the next prime factor
            }
            
            for (int i = 0; i < uniquefactors.Length; i++)
            {
                FactorOutputString += uniquefactors[i][0].ToString() + (uniquefactors[i][1] > 1 ? "^" + uniquefactors[i][1].ToString() : "");
                if (i < uniquefactors.Length - 1)
                    FactorOutputString += " x ";
            }

            tbOutputTextBox.AppendText(TotalPrimeFactor + " = " + RawFactorOutputString +" = " + FactorOutputString);

            string[] retstring = { TotalPrimeFactor.ToString(), RawFactorOutputString, FactorOutputString };
            return(retstring);

        }

        private void tbFindFactorsNumber_TextChanged(object sender, EventArgs e)
        {
            if (tbFindFactorsNumberMin.Text.Length > 0 && int.TryParse(tbFindFactorsNumberMin.Text, out int result) == false)
                MessageBox.Show(tbFindFactorsNumberMin.Text + " Not a valid integer");
        }
        private void tbFindFactorsNumberMax_TextChanged(object sender, EventArgs e)
        {
            if (tbFindFactorsNumberMin.Text.Length > 0 && int.TryParse(tbFindFactorsNumberMin.Text, out int result) == false)
                MessageBox.Show(tbFindFactorsNumberMin.Text + " Not a valid integer");
        }
        private void loadFindPrimesDGV(string[][] data)
        {
            dgvPFResults.Rows.Clear();
            dgvPFResults.Columns.Clear();
            string[] headings = { "Number", "Raw Primes", "Primes" };
            DataGridViewColumn[] Cols = new DataGridViewColumn[3];
            int ii = 0;
            foreach (string Field in headings)
            {
                Cols[ii] = new DataGridViewColumn();
                Cols[ii].HeaderText = Field;
                switch (Field)
                {
                    case "Raw Primes":
                        Cols[ii].Width = 300;
                        break;
                    case "Number":
                        Cols[ii].Width = 150;
                        break;
                    case "Primes":
                        Cols[ii].Width = 200;
                        break;
                    default:
                        Cols[ii].Width = 70;
                        break;
                }
                Cols[ii].CellTemplate = new DataGridViewTextBoxCell();
                dgvPFResults.Columns.Add(Cols[ii]);
                ii++;
            }
            for (int s = 0; s < data.Length; s++)
            {
                ii = 0;
                DataGridViewRow r = new DataGridViewRow();
                DataGridViewTextBoxCell[] c = new DataGridViewTextBoxCell[3];
                c[ii] = new DataGridViewTextBoxCell();
                c[ii].Value = data[s][ii];
                r.Cells.Add(c[ii]);
                ii++;
                c[ii] = new DataGridViewTextBoxCell();
                c[ii].Value = data[s][ii];
                r.Cells.Add(c[ii]);
                ii++;
                c[ii] = new DataGridViewTextBoxCell();
                c[ii].Value = data[s][ii];
                r.Cells.Add(c[ii]);
                dgvPFResults.Rows.Add(r);
            }
        }
    }
    
    
}
