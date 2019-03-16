namespace Matrix_Hub
{
    partial class Main
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_table = new System.Windows.Forms.DataGridView();
            this.numericVariable = new System.Windows.Forms.NumericUpDown();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btn_genRandom = new MetroFramework.Controls.MetroButton();
            this.btn_solve = new MetroFramework.Controls.MetroButton();
            this.dgv_original_matrix = new System.Windows.Forms.DataGridView();
            this.lbl_gaussian = new MetroFramework.Controls.MetroLabel();
            this.lbl_orig = new MetroFramework.Controls.MetroLabel();
            this.list_roots = new System.Windows.Forms.ListBox();
            this.list_console = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_stop = new MetroFramework.Controls.MetroButton();
            this.btn_restart = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericVariable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_original_matrix)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_table
            // 
            this.dgv_table.AllowUserToAddRows = false;
            this.dgv_table.AllowUserToDeleteRows = false;
            this.dgv_table.AllowUserToResizeColumns = false;
            this.dgv_table.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_table.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_table.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Format = "N4";
            dataGridViewCellStyle2.NullValue = "0.0000";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Format = "N4";
            dataGridViewCellStyle3.NullValue = "0.00";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_table.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_table.GridColor = System.Drawing.Color.Black;
            this.dgv_table.Location = new System.Drawing.Point(23, 63);
            this.dgv_table.MultiSelect = false;
            this.dgv_table.Name = "dgv_table";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Format = "N4";
            dataGridViewCellStyle4.NullValue = "0.0000";
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_table.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_table.RowHeadersVisible = false;
            this.dgv_table.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.Format = "N4";
            dataGridViewCellStyle5.NullValue = "0.0000";
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_table.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_table.RowTemplate.Height = 30;
            this.dgv_table.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgv_table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_table.Size = new System.Drawing.Size(513, 457);
            this.dgv_table.TabIndex = 0;
            // 
            // numericVariable
            // 
            this.numericVariable.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.numericVariable.Location = new System.Drawing.Point(167, 531);
            this.numericVariable.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.numericVariable.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericVariable.Name = "numericVariable";
            this.numericVariable.Size = new System.Drawing.Size(120, 27);
            this.numericVariable.TabIndex = 1;
            this.numericVariable.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericVariable.ValueChanged += new System.EventHandler(this.numericVariable_ValueChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(39, 534);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(97, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Variable Count:";
            // 
            // btn_genRandom
            // 
            this.btn_genRandom.Enabled = false;
            this.btn_genRandom.Location = new System.Drawing.Point(35, 566);
            this.btn_genRandom.Name = "btn_genRandom";
            this.btn_genRandom.Size = new System.Drawing.Size(127, 48);
            this.btn_genRandom.TabIndex = 3;
            this.btn_genRandom.Text = "Generate Random";
            this.btn_genRandom.Click += new System.EventHandler(this.btn_genRandom_Click);
            // 
            // btn_solve
            // 
            this.btn_solve.Enabled = false;
            this.btn_solve.Location = new System.Drawing.Point(168, 566);
            this.btn_solve.Name = "btn_solve";
            this.btn_solve.Size = new System.Drawing.Size(119, 48);
            this.btn_solve.TabIndex = 4;
            this.btn_solve.Text = "Solve Unkown";
            this.btn_solve.Click += new System.EventHandler(this.btn_solve_Click);
            // 
            // dgv_original_matrix
            // 
            this.dgv_original_matrix.AllowUserToAddRows = false;
            this.dgv_original_matrix.AllowUserToDeleteRows = false;
            this.dgv_original_matrix.AllowUserToResizeColumns = false;
            this.dgv_original_matrix.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_original_matrix.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_original_matrix.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_original_matrix.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_original_matrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.Format = "N4";
            dataGridViewCellStyle8.NullValue = "0";
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_original_matrix.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_original_matrix.GridColor = System.Drawing.Color.Black;
            this.dgv_original_matrix.Location = new System.Drawing.Point(542, 63);
            this.dgv_original_matrix.MultiSelect = false;
            this.dgv_original_matrix.Name = "dgv_original_matrix";
            this.dgv_original_matrix.RowHeadersVisible = false;
            this.dgv_original_matrix.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Light", 11.25F);
            dataGridViewCellStyle9.Format = "N4";
            dataGridViewCellStyle9.NullValue = "0";
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_original_matrix.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_original_matrix.RowTemplate.Height = 30;
            this.dgv_original_matrix.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgv_original_matrix.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_original_matrix.Size = new System.Drawing.Size(476, 228);
            this.dgv_original_matrix.TabIndex = 5;
            // 
            // lbl_gaussian
            // 
            this.lbl_gaussian.AutoSize = true;
            this.lbl_gaussian.Location = new System.Drawing.Point(35, 480);
            this.lbl_gaussian.Name = "lbl_gaussian";
            this.lbl_gaussian.Size = new System.Drawing.Size(127, 19);
            this.lbl_gaussian.TabIndex = 7;
            this.lbl_gaussian.Text = "Gaussian Elimination";
            this.lbl_gaussian.MouseEnter += new System.EventHandler(this.lbl_gaussian_MouseEnter);
            this.lbl_gaussian.MouseLeave += new System.EventHandler(this.lbl_gaussian_MouseLeave);
            // 
            // lbl_orig
            // 
            this.lbl_orig.AutoSize = true;
            this.lbl_orig.Location = new System.Drawing.Point(562, 253);
            this.lbl_orig.Name = "lbl_orig";
            this.lbl_orig.Size = new System.Drawing.Size(97, 19);
            this.lbl_orig.TabIndex = 8;
            this.lbl_orig.Text = "Original Matrix";
            this.lbl_orig.MouseEnter += new System.EventHandler(this.lbl_orig_MouseEnter);
            this.lbl_orig.MouseLeave += new System.EventHandler(this.lbl_orig_MouseLeave);
            // 
            // list_roots
            // 
            this.list_roots.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.list_roots.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_roots.FormattingEnabled = true;
            this.list_roots.ItemHeight = 32;
            this.list_roots.Location = new System.Drawing.Point(542, 297);
            this.list_roots.Name = "list_roots";
            this.list_roots.Size = new System.Drawing.Size(476, 226);
            this.list_roots.TabIndex = 10;
            // 
            // list_console
            // 
            this.list_console.BackColor = System.Drawing.Color.Black;
            this.list_console.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.list_console.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_console.ForeColor = System.Drawing.Color.Lime;
            this.list_console.FormattingEnabled = true;
            this.list_console.HorizontalScrollbar = true;
            this.list_console.Items.AddRange(new object[] {
            "Ready..."});
            this.list_console.Location = new System.Drawing.Point(305, 532);
            this.list_console.Name = "list_console";
            this.list_console.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.list_console.Size = new System.Drawing.Size(713, 143);
            this.list_console.TabIndex = 11;
            this.list_console.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.list_console_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(25, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 30);
            this.label1.TabIndex = 12;
            this.label1.Text = "MATRIX HUB";
            // 
            // btn_stop
            // 
            this.btn_stop.Enabled = false;
            this.btn_stop.Location = new System.Drawing.Point(168, 627);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(119, 48);
            this.btn_stop.TabIndex = 13;
            this.btn_stop.Text = "Stop Solving";
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_restart
            // 
            this.btn_restart.Location = new System.Drawing.Point(35, 627);
            this.btn_restart.Name = "btn_restart";
            this.btn_restart.Size = new System.Drawing.Size(127, 48);
            this.btn_restart.TabIndex = 14;
            this.btn_restart.Text = "Restart";
            this.btn_restart.Visible = false;
            this.btn_restart.Click += new System.EventHandler(this.btn_restart_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1041, 689);
            this.Controls.Add(this.btn_restart);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.list_console);
            this.Controls.Add(this.list_roots);
            this.Controls.Add(this.lbl_orig);
            this.Controls.Add(this.lbl_gaussian);
            this.Controls.Add(this.dgv_original_matrix);
            this.Controls.Add(this.btn_solve);
            this.Controls.Add(this.btn_genRandom);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.numericVariable);
            this.Controls.Add(this.dgv_table);
            this.DisplayHeader = false;
            this.MaximizeBox = false;
            this.Movable = false;
            this.Name = "Main";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.Text = "Matrix Hub";
            this.TransparencyKey = System.Drawing.Color.Red;
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericVariable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_original_matrix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_table;
        private System.Windows.Forms.NumericUpDown numericVariable;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btn_genRandom;
        private MetroFramework.Controls.MetroButton btn_solve;
        private System.Windows.Forms.DataGridView dgv_original_matrix;
        private MetroFramework.Controls.MetroLabel lbl_gaussian;
        private MetroFramework.Controls.MetroLabel lbl_orig;
        private System.Windows.Forms.ListBox list_roots;
        private System.Windows.Forms.ListBox list_console;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton btn_stop;
        private MetroFramework.Controls.MetroButton btn_restart;
    }
}

