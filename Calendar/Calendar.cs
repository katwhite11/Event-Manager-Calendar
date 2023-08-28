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

namespace Calendar
{
    public partial class Calendar : Form
    {
        int month, year;
        public static string static_month, static_year, static_day;
        Event selectedEvent = new Event();
        User currentUser = new User();
        ArrayList userEventList = new ArrayList();
        ArrayList allUsers = new ArrayList();

        public Calendar()
        {
            InitializeComponent();
        }

        private void Calendar_Load(object sender, EventArgs e)
        {
            displayDays();
            static_month = DateTime.Now.ToString("MM");
            static_year = year.ToString();
            static_day = DateTime.Now.ToString("dd");

            allUsers = User.retrieveUsers();

            foreach(User a in allUsers)
            {
                if (a.getUserId().Equals(Login.userIDNum)){
                    currentUser = a;
                }
            }

            firstLast.Text = currentUser.getName();

            eventslbl.Text = "Events on " + static_month +"/"+static_year;

            userEventList = Event.retrieveEvents(currentUser.getUserId());

            string temp;
            List<string> events = new List<string>();

            foreach (Event el in userEventList)
            {
                temp = el.getDate();
                if (temp.Contains(static_month + "-") && temp.Contains("-"+static_year))
                { 
                    events.Add(el.getTitle() + " " + el.getDate());
                }
            }

            eventList.DataSource = events;

        }

        private void displayDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;

            static_month = DateTime.Now.ToString();
            static_year = year.ToString();

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = monthname + " " + year;

            DateTime startofthemonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);

            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }

            for (int i = 1; i<= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }


        }

        private void eventList_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(Event ef in userEventList)
            {
                string s = eventList.SelectedItem.ToString();
                if(s.Contains(ef.getTitle()) && s.Contains(ef.getDate())){
                    selectedEvent = ef;
                }
            }
        }
        
        private void addbtn_Click(object sender, EventArgs e)
        {
            EventForm ef = new EventForm(0);
            this.Close();
            ef.Show();
        }

        private void eventList_DoubleClick(object sender, EventArgs e)
        {
            EventInfo ei = new EventInfo(selectedEvent.getTitle(), selectedEvent.getDate(), selectedEvent.getStartTime(), selectedEvent.getEndTime(), selectedEvent.getLocation(), selectedEvent.getDescription(), selectedEvent.getCreator(), Login.userIDNum);
            this.Close(); 
            ei.Show();
            
        }

        private void addMeeting_Click(object sender, EventArgs e)
        {
            if (currentUser.isMan(currentUser.getManager()))
            {
                Meeting nm = new Meeting();
                this.Close();
                nm.Show();
            }
            else
            {
                MessageBox.Show("Only managers may create meetings.");
            }
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Close();
            login.Show();
        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            Delete df = new Delete(selectedEvent.getTitle(), selectedEvent.getDate(),selectedEvent.getStartTime(), selectedEvent.getEndTime(), selectedEvent.getLocation(), selectedEvent.getDescription(), selectedEvent.getCreator(), Login.userIDNum);
            df.Show();
            this.Close();
        }
        
        private void btprevious_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();
            if (month > 1)
            {
                month--;
            }
            else
            {
                year--;
                month = 12;
            }

            if(month < 10)
            {
                static_month = "0" + month.ToString();
            }
            else
            {
                static_month = month.ToString();
            }

            static_year = year.ToString();

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = monthname + " " + year;
            DateTime startofthemonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);

            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }

            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }

            eventslbl.Text = "Events on " + static_month + "/" + static_year;

            string temp;
            List<string> events = new List<string>();

            foreach (Event el in userEventList)
            {
                temp = el.getDate();
                if (temp.Contains(static_month + "-") && temp.Contains("-" + static_year))
                {
                    events.Add(el.getTitle() + " " + el.getDate());
                }
            }

            eventList.DataSource = events;
        }
        
        
        private void btnext_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();
            
            if(month < 12) 
            { 
                month++; 
            }
            else {
                year++;
                month = 1;
            }

            if (month < 10)
            {
                static_month = "0" + month.ToString();
            }
            else
            {
                static_month = month.ToString();
            }
            static_year = year.ToString();

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = monthname + " " + year;
            DateTime startofthemonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);

            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }

            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }

            eventslbl.Text = "Events on " + static_month + "/" + static_year;

            string temp;
            List<string> events = new List<string>();

            foreach (Event el in userEventList)
            {
                temp = el.getDate();
                if (temp.Contains(static_month + "-") && temp.Contains("-" + static_year))
                {
                    events.Add(el.getTitle() + " " + el.getDate());
                }
            }

            eventList.DataSource = events;
        }
    }
}
