using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
    public partial class Meeting : Form
    {
        String title, stime, etime, location, description, createdBy;


        ArrayList allUsers = new ArrayList();

        ArrayList selUsers = new ArrayList();

        private void userBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        public Meeting()
        {
            InitializeComponent();
        }

        private void Meeting_Load(object sender, EventArgs e)
        {
            startTime.Items.Add("00:00");
            startTime.Items.Add("00:30");
            startTime.Items.Add("01:00");
            startTime.Items.Add("01:30");
            startTime.Items.Add("02:00");
            startTime.Items.Add("02:30");
            startTime.Items.Add("03:00");
            startTime.Items.Add("03:30");
            startTime.Items.Add("04:00");
            startTime.Items.Add("04:30");
            startTime.Items.Add("05:00");
            startTime.Items.Add("05:30");
            startTime.Items.Add("06:00");
            startTime.Items.Add("06:30");
            startTime.Items.Add("07:00");
            startTime.Items.Add("07:30");
            startTime.Items.Add("08:00");
            startTime.Items.Add("08:30");
            startTime.Items.Add("09:00");
            startTime.Items.Add("09:30");
            startTime.Items.Add("10:00");
            startTime.Items.Add("10:30");
            startTime.Items.Add("11:00");
            startTime.Items.Add("11:30");
            startTime.Items.Add("12:00");
            startTime.Items.Add("12:30");
            startTime.Items.Add("13:00");
            startTime.Items.Add("13:30");
            startTime.Items.Add("14:00");
            startTime.Items.Add("14:30");
            startTime.Items.Add("15:00");
            startTime.Items.Add("15:30");
            startTime.Items.Add("16:00");
            startTime.Items.Add("16:30");
            startTime.Items.Add("17:00");
            startTime.Items.Add("17:30");
            startTime.Items.Add("18:00");
            startTime.Items.Add("18:30");
            startTime.Items.Add("19:00");
            startTime.Items.Add("19:30");
            startTime.Items.Add("20:00");
            startTime.Items.Add("20:30");
            startTime.Items.Add("21:00");
            startTime.Items.Add("21:30");
            startTime.Items.Add("22:00");
            startTime.Items.Add("22:30");
            startTime.Items.Add("23:00");
            startTime.Items.Add("23:30");
            startTime.Items.Add("24:00");

            endTime.Items.Add("00:00");
            endTime.Items.Add("00:30");
            endTime.Items.Add("01:00");
            endTime.Items.Add("01:30");
            endTime.Items.Add("02:00");
            endTime.Items.Add("02:30");
            endTime.Items.Add("03:00");
            endTime.Items.Add("03:30");
            endTime.Items.Add("04:00");
            endTime.Items.Add("04:30");
            endTime.Items.Add("05:00");
            endTime.Items.Add("05:30");
            endTime.Items.Add("06:00");
            endTime.Items.Add("06:30");
            endTime.Items.Add("07:00");
            endTime.Items.Add("07:30");
            endTime.Items.Add("08:00");
            endTime.Items.Add("08:30");
            endTime.Items.Add("09:00");
            endTime.Items.Add("09:30");
            endTime.Items.Add("10:00");
            endTime.Items.Add("10:30");
            endTime.Items.Add("11:00");
            endTime.Items.Add("11:30");
            endTime.Items.Add("12:00");
            endTime.Items.Add("12:30");
            endTime.Items.Add("13:00");
            endTime.Items.Add("13:30");
            endTime.Items.Add("14:00");
            endTime.Items.Add("14:30");
            endTime.Items.Add("15:00");
            endTime.Items.Add("15:30");
            endTime.Items.Add("16:00");
            endTime.Items.Add("16:30");
            endTime.Items.Add("17:00");
            endTime.Items.Add("17:30");
            endTime.Items.Add("18:00");
            endTime.Items.Add("18:30");
            endTime.Items.Add("19:00");
            endTime.Items.Add("19:30");
            endTime.Items.Add("20:00");
            endTime.Items.Add("20:30");
            endTime.Items.Add("21:00");
            endTime.Items.Add("21:30");
            endTime.Items.Add("22:00");
            endTime.Items.Add("22:30");
            endTime.Items.Add("23:00");
            endTime.Items.Add("23:30");
            endTime.Items.Add("24:00");

            allUsers = User.retrieveUsers();
            string temp;
            List<string> names = new List<string>();
            foreach (User b in allUsers)
            {
                names.Add(b.getName());
            }

            userBox.DataSource = names;

           
        }
        private void savebtn_Click(object sender, EventArgs e)
        {
            string eventDate = "";

            title = titleBox.Text;
            eventDate = dateTimePicker.Value.ToString("MM-dd-yyyy", CultureInfo.InvariantCulture);
            stime = startTime.SelectedItem.ToString();
            etime = endTime.SelectedItem.ToString();
            location = locationBox.Text;
            description = descriptionBox.Text;
            int conf=0;

            int i;
            string s = "";
            for (i = 0; i <= (userBox.Items.Count - 1); i++)
            {
                if (userBox.GetItemChecked(i))
                {
                    s = userBox.Items[i].ToString();
                    foreach (User c in allUsers)
                    {
                        if (s.Contains(c.getName()))
                        {
                            selUsers.Add(c);
                            Console.WriteLine(c.getName());
                        }
                    }
                }

            }

            foreach (User d in selUsers)
            {
                string attendee = d.getUserId();
                Event newEvent = new Event(title, eventDate, stime, etime, location, description, Login.userIDNum, attendee);
                if (newEvent.checkConflict() == 1)
                {
                    MessageBox.Show("There is a schedule conflict. User: " + d.getName() + " already has an event scheduled at that time on " + eventDate);
                    conf = 1;
                    break;
                }
                else
                {
                    newEvent.saveMeeting();
                }
            }

            if(conf != 1) 
            {
                Calendar cal = new Calendar();
                MessageBox.Show("Meeting saved");
                this.Close();
                cal.Show();
            }
            
            
        }
    }
}
