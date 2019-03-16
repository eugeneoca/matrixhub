using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Globalization;
using System.Text.RegularExpressions;
using System.IO;
using System.Threading;
using System.Speech.Synthesis;
using System.Speech.Recognition;

namespace Matrix_Hub
{
    public partial class Main : MetroFramework.Forms.MetroForm
    {

        SpeechSynthesizer synth = new SpeechSynthesizer();
        PromptBuilder pBuilder = new PromptBuilder();
        SpeechRecognitionEngine engine = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("en-US"));
        public Main()
        {
            InitializeComponent();
            synth.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Teen);
            synth.Rate = 1;
            Say("System has been started, please input your desired number of variables.");
        }
        public void Say(String text)
        {
            pBuilder.ClearContent();
            pBuilder.AppendText(text);
            synth.Speak(pBuilder);
        }

        private void Main_Load(object sender, EventArgs e)
        {
        }

        private void addVariable(int size){
            DataTable m = new DataTable("matrix");
            for (int k = 1; k <= size; k++)
            {
                m.Columns.Add("X"+(k));
            }
            for (int k = 1; k <= size; k++)
            {
                m.Rows.Add();
            }
            DataSet database = new DataSet();
            database.Tables.Add(m);
            dgv_table.AutoGenerateColumns = true;
            dgv_table.DataSource = database;
            dgv_table.DataMember = "matrix";
            m.Columns.Add("C");
        }

        private void numericVariable_ValueChanged(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(Math.Round(numericVariable.Value, 0));
            addVariable(count);
            btn_genRandom.Enabled = true;
            btn_solve.Enabled = true;
            Say((count).ToString() + " variables?");
        }

        private void btn_genRandom_Click(object sender, EventArgs e)
        {
            // Fill the table with random numbers.
            Random rand = new Random();
            for (int i = 0; i < dgv_table.Rows.Count; i++)
            {
                for (int z = 0; z < dgv_table.Rows[i].Cells.Count; z++)
                {
                    dgv_table.Rows[i].Cells[z].Value = rand.Next(1, 100);
                }
            }
            Say("Random number has been generated.");
        }

        string db;
        Thread task;
        Thread handler;
        private void btn_solve_Click(object sender, EventArgs e)
        {
            Say("Solving...");
            ListBox.CheckForIllegalCrossThreadCalls = false;
            try
            {
                task = null;
                task = new Thread(new ThreadStart(thread_task));
                handler = new Thread(new ThreadStart(taskEventHandler));
                task.Start();
                handler.Start();
                btn_solve.Enabled = false;
                btn_stop.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Can not work with threads. Calling the function normally.");
                thread_task();
            }
        }

        private void taskEventHandler()
        {
            while(true){
                try
                {
                    if (!this.task.IsAlive)
                    {
                        ThreadSafe.DisableBTN(btn_stop);
                        ThreadSafe.DisableBTN(btn_solve);
                        Say("Solving is done.");
                        break;
                    }
                }
                catch
                {
                    ThreadSafe.DisableBTN(btn_stop);
                    ThreadSafe.DisableBTN(btn_solve);
                    Say("Solving is done.");
                    break;
                }
            }
        }

        private void thread_task()
        {
            try
            {
                //list_roots.Items.Clear(); // UI Thread
                //list_console.Items.Clear(); // UI Thread
                ThreadSafe.ClearList(list_roots);
                ThreadSafe.ClearList(list_console);
                this.db = "log-" + DateTime.Now.Month + "-" + DateTime.Now.Day + "-" + DateTime.Now.Hour + "-" + DateTime.Now.Minute + "-" + DateTime.Now.Second + ".txt";
                log("Process has been started.");
                log("General Equation: A-B(W/D)");
                log("");
                clone(dgv_table, dgv_original_matrix); // UI Thread
                int size = dgv_table.Rows.Count;
                int k = size - 1;
                int r = 0;
                int s = 0;
                int t = 1;
                while (k > 0)
                {
                    Thread.Sleep(100);
                    // Iteration
                    r = 0;
                    while (r < k)
                    {
                        Thread.Sleep(100);
                        log("------------------------");
                        log("Iteration Count " + t + ": ");
                        float z = SafeParse(data_get(dgv_table, (r + 2 + s) - 1, (s + 1) - 1)) / SafeParse(data_get(dgv_table, (s + 1) - 1, (s + 1) - 1)); // UI Thread

                        // Entire row operation
                        for (int q = 0; q < dgv_table.Rows[(r + 2 + s) - 1].Cells.Count; q++)
                        {
                            Thread.Sleep(100);
                            float a = SafeParse(data_get(dgv_table, (r + 2 + s) - 1, q));
                            float b = SafeParse(data_get(dgv_table, (1 + s) - 1, q));
                            float c = (a - (b * z));
                            if (c.ToString().Length > 10)
                            {
                                c = 0;
                            }
                            data_set(dgv_table, (r + 2 + s) - 1, q, c); // UI Thread
                            log("R" + (r + 2 + s) + (q + 1) + "-->> R" + (r + 2 + s) + (q + 1) + " - R" + (1 + s) + (q + 1) + "(R" + (r + 2 + s) + (1 + s) + "/R" + (1 + s) + (1 + s) + ") == " + c);
                        }

                        log("");
                        log("Iteration Matrix:");
                        log("n = [");

                        // for matrix logging
                        string row = "";
                        foreach (DataGridViewRow l in dgv_table.Rows)
                        {
                            row = "";
                            foreach (DataGridViewCell item in l.Cells)
                            {
                                row += item.Value.ToString() + " ";
                            }
                            log(row);
                        }

                        log("]");
                        log("");
                        t++;
                        r++;
                    }
                    log("Iteration Matrix (Column " + (s + 1) + ") :");
                    log("n = [");

                    // for matrix logging
                    string roww = "";
                    foreach (DataGridViewRow l in dgv_table.Rows)
                    {
                        roww = "";
                        foreach (DataGridViewCell item in l.Cells)
                        {
                            roww += item.Value.ToString() + " ";
                        }
                        log(roww);

                    }

                    log("]");
                    log("");
                    s++;
                    k--;
                }

                // Computing the roots.

                int y = size - 1;
                float w = 0;// Constant
                float d = 0;// Divider
                float i = 0;// Subtraction Elements
                List<float> roots = new List<float>();
                int subtr;
                while (y >= 0)
                {
                    string row = "";
                    w = SafeParse(dgv_table.Rows[y].Cells[dgv_table.Rows[y].Cells.Count - 1].Value.ToString());
                    d = SafeParse(dgv_table.Rows[y].Cells[y].Value.ToString());
                    row += w;
                    subtr = size - y - 1;
                    if (subtr > 0)
                    {
                        while (subtr > 0)
                        {
                            i = SafeParse(dgv_table.Rows[y].Cells[size - subtr].Value.ToString());
                            if (roots.Count != 0)
                            {
                                i *= roots[subtr - 1];
                                row += "-(" + i + ")(" + roots[subtr - 1] + ")";
                            }
                            w -= i;
                            subtr--;
                        }
                    }
                    float rootx = (w / d);
                    roots.Add(rootx);
                    //list_roots.Items.Add("X" + (y + 1) + "=\t\t" + rootx.ToString()); // UI Thread
                    ThreadSafe.AddList(list_roots, "X" + (y + 1) + "=\t\t" + rootx.ToString());
                    row = "(" + row + ")/(" + d + ")";
                    log("X" + (y + 1) + " = " + row + " == " + rootx.ToString());
                    y--;
                }
                log("");
                btn_restart.BackColor = Color.Red;
            }
            catch (Exception ex)
            {
                Random r = new Random();
                MessageBox.Show("Error occur: " + ex.Message, "Info");
                //btn_stop.Enabled = false; // UI Thread
                ThreadSafe.DisableBTN(btn_stop);
            }
        }

        private void log(string data){
            //list_console.Items.Add(data); // UI Thread
            ThreadSafe.AddList(list_console, data);
            //list_console.TopIndex = list_console.Items.Count - 1; // UI Thread
            ThreadSafe.SetIndexList(list_console, (list_console.Items.Count - 1));
            using (StreamWriter w = File.AppendText(db))
            {
                w.WriteLine(data);
            }
        }

        private float SafeParse(string input)
        {
            int errorCounter = Regex.Matches(input, @"[a-zA-Z]").Count;
            if (errorCounter > 0)
            {
                MessageBox.Show("Restricted Value: "+input+" replaced by zero.");
                return 0.0000f;
            }
            if (String.IsNullOrEmpty(input)) { return 0.0000f; }

            float res;
            if (Single.TryParse(input, NumberStyles.Float, CultureInfo.InvariantCulture, out res))
            {
                return res;
            }

            return 0.0000f;
        }

        private void clone(DataGridView dgv_table, DataGridView dgv_original_matrix)
        {
            int size = dgv_table.Rows.Count;
            DataTable m = new DataTable("matrix");
            for (int k = 1; k <= size; k++)
            {
                m.Columns.Add("X" + (k));
            }
            for (int k = 1; k <= size; k++)
            {
                m.Rows.Add();
            }
            DataSet database = new DataSet();
            database.Tables.Add(m);
            dgv_original_matrix.AutoGenerateColumns = true;
            dgv_original_matrix.DataSource = database;
            dgv_original_matrix.DataMember = "matrix";
            m.Columns.Add("C");
            for (int k = 0; k < size; k++)
            {
                for (int w = 0; w <= size; w++)
                {
                    dgv_original_matrix.Rows[k].Cells[w].Value = dgv_table.Rows[k].Cells[w].Value;
                }
            }
            // for matrix logging
            log("Given Matrix:");
            log("n = [");
            string roww = "";
            foreach (DataGridViewRow l in dgv_original_matrix.Rows)
            {
                roww = "";
                foreach (DataGridViewCell item in l.Cells)
                {
                    roww += item.Value.ToString() + " ";
                }
                log(roww);
            }
            //roww +="]";
            log("]");
        }



        private void data_set(DataGridView dgv, int row, int col, float value)
        {
            dgv.Rows[row].Cells[col].Value = value.ToString();
        }

        private string data_get(DataGridView dgv, int row, int col)
        {
            return dgv.Rows[row].Cells[col].Value.ToString();
        }

        private void lbl_gaussian_MouseLeave(object sender, EventArgs e)
        {
            lbl_gaussian.Visible = true;
        }

        private void lbl_gaussian_MouseEnter(object sender, EventArgs e)
        {
            lbl_gaussian.Visible = false;
        }

        private void lbl_orig_MouseEnter(object sender, EventArgs e)
        {
            lbl_orig.Visible = false;
        }

        private void lbl_orig_MouseLeave(object sender, EventArgs e)
        {
            lbl_orig.Visible = true;
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            try
            {
                task.Abort();
                task = null;
            }
            catch
            {
                MessageBox.Show("System is not yet computing.");
            }
        }

        private void btn_restart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void list_console_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.task.Abort();
        }
    }
}
