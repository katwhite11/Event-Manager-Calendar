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
    public partial class Delete : Form
    {
        string title, date, startTime, endTime, location, description, createdBy, attendee;
        
        public Delete(string t, string d, string st, string et, string l, string dp, string cb, string a)
        {
            InitializeComponent();
            title = t;
            date = d;
            startTime = st;
            endTime = et;
            location = l;
            description = dp; 
            createdBy = cb;
            attendee = a;
        }

        private void nobtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void yesbtn_Click(object sender, EventArgs e)
        {
            Event selectedEvent = new Event(title, date, startTime, endTime, location, description, createdBy, attendee);
            selectedEvent.deleteEvent();
            
            Calendar newCal = new Calendar();
            this.Close();
            newCal.Show();

        }
    }
}
