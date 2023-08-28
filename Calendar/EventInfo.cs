using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
    public partial class EventInfo : Form
    {
        string title, date, startTime, endTime, location, description, createdBy, attendee;

        private void button1_Click(object sender, EventArgs e)
        {
            Calendar cal = new Calendar();
            this.Close();
            cal.Show();
        }

        public static string static_title, static_date;

        public EventInfo(string t, string d, string st, string et, string l, string dp, string cb, string at)
        {
            InitializeComponent();
            title = t;
            date = d;
            startTime = st;
            endTime = et;
            location = l;
            description = dp;
            createdBy = cb;
            attendee = at;
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            static_title = title;
            static_date = date;
            EventForm en = new EventForm(2);
            en.Show();
            this.Close();
        }

        private void EventInfo_Load(object sender, EventArgs e)
        {
            titletxt.Text = title;
            datetxt.Text = date;
            starttxt.Text = startTime;
            endtxt.Text = endTime;
            locationtxt.Text = location;
            descriptiontxt.Text = description;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            Delete df = new Delete(title, date, startTime, endTime, location, description, createdBy, attendee);
            this.Close(); 
            df.Show();
            
        }

        
    }
}
