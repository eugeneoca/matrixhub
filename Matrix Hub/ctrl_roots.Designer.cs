namespace Matrix_Hub
{
    partial class ctrl_roots
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
            this.lbl_root = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_root
            // 
            this.lbl_root.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_root.AutoSize = true;
            this.lbl_root.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_root.Location = new System.Drawing.Point(3, 2);
            this.lbl_root.Name = "lbl_root";
            this.lbl_root.Size = new System.Drawing.Size(150, 32);
            this.lbl_root.TabIndex = 0;
            this.lbl_root.Text = ">> X1 = 100";
            // 
            // ctrl_roots
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lbl_root);
            this.Name = "ctrl_roots";
            this.Size = new System.Drawing.Size(458, 36);
            this.Load += new System.EventHandler(this.ctrl_roots_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_root;
    }
}
