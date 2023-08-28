namespace Calendar
{
    partial class Calendar
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
            this.daycontainer = new System.Windows.Forms.FlowLayoutPanel();
            this.btnext = new System.Windows.Forms.Button();
            this.btprevious = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LBDATE = new System.Windows.Forms.Label();
            this.addbtn = new System.Windows.Forms.Button();
            this.addMeeting = new System.Windows.Forms.Button();
            this.eventList = new System.Windows.Forms.ListBox();
            this.eventslbl = new System.Windows.Forms.Label();
            this.delbtn = new System.Windows.Forms.Button();
            this.logoutbtn = new System.Windows.Forms.Button();
            this.firstLast = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // daycontainer
            // 
            this.daycontainer.Location = new System.Drawing.Point(312, 146);
            this.daycontainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.daycontainer.Name = "daycontainer";
            this.daycontainer.Size = new System.Drawing.Size(764, 486);
            this.daycontainer.TabIndex = 0;
            // 
            // btnext
            // 
            this.btnext.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnext.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnext.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.btnext.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnext.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnext.ForeColor = System.Drawing.Color.Navy;
            this.btnext.Location = new System.Drawing.Point(977, 646);
            this.btnext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnext.Name = "btnext";
            this.btnext.Size = new System.Drawing.Size(101, 34);
            this.btnext.TabIndex = 10;
            this.btnext.Text = "Next";
            this.btnext.UseVisualStyleBackColor = false;
            this.btnext.Click += new System.EventHandler(this.btnext_Click);
            // 
            // btprevious
            // 
            this.btprevious.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btprevious.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btprevious.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.btprevious.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btprevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btprevious.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btprevious.ForeColor = System.Drawing.Color.Navy;
            this.btprevious.Location = new System.Drawing.Point(869, 646);
            this.btprevious.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btprevious.Name = "btprevious";
            this.btprevious.Size = new System.Drawing.Size(101, 34);
            this.btprevious.TabIndex = 11;
            this.btprevious.Text = "Previous";
            this.btprevious.UseVisualStyleBackColor = false;
            this.btprevious.Click += new System.EventHandler(this.btprevious_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(338, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Sunday";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(441, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Monday";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(649, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Wednesday";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(549, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Tuesday";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(886, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Friday";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(769, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Thursday";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(982, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Saturday";
            // 
            // LBDATE
            // 
            this.LBDATE.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBDATE.ForeColor = System.Drawing.Color.Navy;
            this.LBDATE.Location = new System.Drawing.Point(369, 40);
            this.LBDATE.Name = "LBDATE";
            this.LBDATE.Size = new System.Drawing.Size(680, 49);
            this.LBDATE.TabIndex = 20;
            this.LBDATE.Text = "MONTH YEAR";
            this.LBDATE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.addbtn.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.addbtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.addbtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addbtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.ForeColor = System.Drawing.Color.Navy;
            this.addbtn.Location = new System.Drawing.Point(234, 642);
            this.addbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(41, 37);
            this.addbtn.TabIndex = 22;
            this.addbtn.Text = "+";
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // addMeeting
            // 
            this.addMeeting.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.addMeeting.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.addMeeting.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.addMeeting.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.addMeeting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMeeting.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMeeting.ForeColor = System.Drawing.Color.Navy;
            this.addMeeting.Location = new System.Drawing.Point(29, 642);
            this.addMeeting.Margin = new System.Windows.Forms.Padding(4);
            this.addMeeting.Name = "addMeeting";
            this.addMeeting.Size = new System.Drawing.Size(145, 37);
            this.addMeeting.TabIndex = 23;
            this.addMeeting.Text = "Add Meeting";
            this.addMeeting.UseVisualStyleBackColor = false;
            this.addMeeting.Click += new System.EventHandler(this.addMeeting_Click);
            // 
            // eventList
            // 
            this.eventList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eventList.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventList.ForeColor = System.Drawing.Color.Navy;
            this.eventList.FormattingEnabled = true;
            this.eventList.ItemHeight = 20;
            this.eventList.Location = new System.Drawing.Point(29, 146);
            this.eventList.Name = "eventList";
            this.eventList.Size = new System.Drawing.Size(246, 464);
            this.eventList.TabIndex = 24;
            this.eventList.SelectedIndexChanged += new System.EventHandler(this.eventList_SelectedIndexChanged);
            this.eventList.DoubleClick += new System.EventHandler(this.eventList_DoubleClick);
            // 
            // eventslbl
            // 
            this.eventslbl.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventslbl.ForeColor = System.Drawing.Color.Navy;
            this.eventslbl.Location = new System.Drawing.Point(24, 104);
            this.eventslbl.Name = "eventslbl";
            this.eventslbl.Size = new System.Drawing.Size(240, 30);
            this.eventslbl.TabIndex = 25;
            this.eventslbl.Text = "Events On: MM-DD-YYYY";
            this.eventslbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // delbtn
            // 
            this.delbtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.delbtn.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.delbtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.delbtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.delbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delbtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delbtn.ForeColor = System.Drawing.Color.Navy;
            this.delbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.delbtn.Location = new System.Drawing.Point(187, 642);
            this.delbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.delbtn.Name = "delbtn";
            this.delbtn.Size = new System.Drawing.Size(41, 37);
            this.delbtn.TabIndex = 26;
            this.delbtn.Text = "-";
            this.delbtn.UseVisualStyleBackColor = false;
            this.delbtn.Click += new System.EventHandler(this.delbtn_Click);
            // 
            // logoutbtn
            // 
            this.logoutbtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.logoutbtn.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.logoutbtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.logoutbtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.logoutbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutbtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutbtn.ForeColor = System.Drawing.Color.Navy;
            this.logoutbtn.Location = new System.Drawing.Point(986, 11);
            this.logoutbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(82, 34);
            this.logoutbtn.TabIndex = 27;
            this.logoutbtn.Text = "Logout";
            this.logoutbtn.UseVisualStyleBackColor = false;
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click);
            // 
            // firstLast
            // 
            this.firstLast.AutoSize = true;
            this.firstLast.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstLast.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.firstLast.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.firstLast.Location = new System.Drawing.Point(133, 24);
            this.firstLast.Name = "firstLast";
            this.firstLast.Size = new System.Drawing.Size(110, 31);
            this.firstLast.TabIndex = 29;
            this.firstLast.Text = "First Last";
            this.firstLast.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(19, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 38);
            this.label8.TabIndex = 28;
            this.label8.Text = "HELLO,";
            // 
            // Calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1103, 699);
            this.Controls.Add(this.firstLast);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.logoutbtn);
            this.Controls.Add(this.delbtn);
            this.Controls.Add(this.eventslbl);
            this.Controls.Add(this.eventList);
            this.Controls.Add(this.addMeeting);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.LBDATE);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btprevious);
            this.Controls.Add(this.daycontainer);
            this.Controls.Add(this.btnext);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Calendar";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calendar Management System";
            this.Load += new System.EventHandler(this.Calendar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel daycontainer;
        private System.Windows.Forms.Button btnext;
        private System.Windows.Forms.Button btprevious;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LBDATE;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button addMeeting;
        private System.Windows.Forms.ListBox eventList;
        private System.Windows.Forms.Label eventslbl;
        private System.Windows.Forms.Button delbtn;
        private System.Windows.Forms.Button logoutbtn;
        private System.Windows.Forms.Label firstLast;
        private System.Windows.Forms.Label label8;
    }
}

