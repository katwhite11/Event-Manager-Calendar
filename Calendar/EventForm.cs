using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace Calendar
{
    public partial class EventForm : Form
    {
        String title, stime, etime, location, description;
        int type;

        public EventForm(int t)
        {
            InitializeComponent();
            type = t;
        }

        private void EventForm_Load(object sender, EventArgs e)
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

            if(type == 0)
            {
                dateTimePicker.Enabled = true;
            }
            else if(type == 1)
            {
                dateTimePicker.Enabled = false;
            }
        }

        private void startTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void endTime_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            string eventDate="";

            title = titleBox.Text;

          
            if(type == 1)
            {
            eventDate = Calendar.static_month.ToString()+"-"+UserControlDays.static_day.ToString()+"-"+Calendar.static_year.ToString(); 
            }
            else
            {
            eventDate = dateTimePicker.Value.ToString("MM-dd-yyyy", CultureInfo.InvariantCulture);
            }

            stime = startTime.SelectedItem.ToString();
            etime = endTime.SelectedItem.ToString();
            location = locationBox.Text;
            description = descriptionBox.Text;
            
            
            Event newEvent = new Event(title, eventDate, stime, etime, location, description, Login.userIDNum, Login.userIDNum);

            if (newEvent.checkConflict() == 1)
            {
                MessageBox.Show("There is already an event with that date and start time.");
            }
            else
            {
                if (type == 2)
                {
                    SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\KATE\DESKTOP\CALENDAR\CALENDAR\CALDB.MDF;Integrated Security=True;Connect Timeout=30");

                    try
                    {
                        Con.Open();
                        string sql = "DELETE FROM [Event] WHERE title=@title AND date=@date;";
                        SqlCommand cmd = new SqlCommand(sql, Con);
                        cmd.Parameters.Add(new SqlParameter("@title", EventInfo.static_title));
                        cmd.Parameters.Add(new SqlParameter("@date", EventInfo.static_date));
                        cmd.ExecuteNonQuery();

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                    newEvent.saveEvent();
                    MessageBox.Show("Event updated.");

                    Con.Close();
                }
                else
                {
                    MessageBox.Show("Event saved.");
                    newEvent.saveEvent();
                }
                
            }
            Calendar cal = new Calendar();
            this.Close();
            cal.Show();
        }

    }
}
