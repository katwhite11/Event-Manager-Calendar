namespace Calendar
{
    partial class Delete
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
            this.LBDATE = new System.Windows.Forms.Label();
            this.yesbtn = new System.Windows.Forms.Button();
            this.nobtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBDATE
            // 
            this.LBDATE.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBDATE.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LBDATE.Location = new System.Drawing.Point(31, 76);
            this.LBDATE.Name = "LBDATE";
            this.LBDATE.Size = new System.Drawing.Size(388, 25);
            this.LBDATE.TabIndex = 22;
            this.LBDATE.Text = "Are you sure you want to delete this event? ";
            this.LBDATE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yesbtn
            // 
            this.yesbtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.yesbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.yesbtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.yesbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yesbtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yesbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.yesbtn.Location = new System.Drawing.Point(114, 153);
            this.yesbtn.Name = "yesbtn";
            this.yesbtn.Size = new System.Drawing.Size(102, 41);
            this.yesbtn.TabIndex = 31;
            this.yesbtn.Text = "YES";
            this.yesbtn.UseVisualStyleBackColor = false;
            this.yesbtn.Click += new System.EventHandler(this.yesbtn_Click);
            // 
            // nobtn
            // 
            this.nobtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.nobtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.nobtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.nobtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nobtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nobtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nobtn.Location = new System.Drawing.Point(237, 153);
            this.nobtn.Name = "nobtn";
            this.nobtn.Size = new System.Drawing.Size(102, 41);
            this.nobtn.TabIndex = 32;
            this.nobtn.Text = "NO";
            this.nobtn.UseVisualStyleBackColor = false;
            this.nobtn.Click += new System.EventHandler(this.nobtn_Click);
            // 
            // Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 275);
            this.Controls.Add(this.nobtn);
            this.Controls.Add(this.yesbtn);
            this.Controls.Add(this.LBDATE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Delete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LBDATE;
        private System.Windows.Forms.Button yesbtn;
        private System.Windows.Forms.Button nobtn;
    }
}