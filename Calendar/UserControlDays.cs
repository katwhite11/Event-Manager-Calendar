using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
    public partial class UserControlDays : UserControl
    {
        public static string static_day;
        public UserControlDays()
        {
            InitializeComponent();
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        public void days(int numday)
        {
            lbdays.Text = numday+"";
        }

        private void UserControlDays_DoubleClick(object sender, EventArgs e)
        {
            static_day = lbdays.Text;
            EventForm newEvent = new EventForm(1);
            newEvent.Show();
        }

        private void UserControlDays_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.Gainsboro;
            //Cursor.Current = Cursors.Hand;
        }

        private void UserControlDays_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //displayEvent();
        }
    }
}
