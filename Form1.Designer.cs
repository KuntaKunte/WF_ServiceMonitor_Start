namespace WF_ServiceMonitor_Start
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FDC_STATUS = new System.Windows.Forms.Label();
            this.Tme_Date = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LAST_ST_DT = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "FDC Service";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "STATUS :";
            // 
            // FDC_STATUS
            // 
            this.FDC_STATUS.Location = new System.Drawing.Point(154, 92);
            this.FDC_STATUS.Name = "FDC_STATUS";
            this.FDC_STATUS.Size = new System.Drawing.Size(218, 23);
            this.FDC_STATUS.TabIndex = 2;
            this.FDC_STATUS.Click += new System.EventHandler(this.FDC_STATUS_Click);
            // 
            // Tme_Date
            // 
            this.Tme_Date.AutoSize = true;
            this.Tme_Date.Location = new System.Drawing.Point(154, 160);
            this.Tme_Date.Name = "Tme_Date";
            this.Tme_Date.Size = new System.Drawing.Size(0, 13);
            this.Tme_Date.TabIndex = 4;
            this.Tme_Date.Click += new System.EventHandler(this.Tme_Date_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Last Refreshed :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Last Service STOP :";
            // 
            // LAST_ST_DT
            // 
            this.LAST_ST_DT.AutoSize = true;
            this.LAST_ST_DT.Location = new System.Drawing.Point(194, 212);
            this.LAST_ST_DT.Name = "LAST_ST_DT";
            this.LAST_ST_DT.Size = new System.Drawing.Size(0, 13);
            this.LAST_ST_DT.TabIndex = 7;
            this.LAST_ST_DT.Click += new System.EventHandler(this.LAST_ST_DT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 278);
            this.ControlBox = false;
            this.Controls.Add(this.LAST_ST_DT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Tme_Date);
            this.Controls.Add(this.FDC_STATUS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FDC_Server_AutoStart";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label FDC_STATUS;
        private System.Windows.Forms.Label Tme_Date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LAST_ST_DT;
    }
}

