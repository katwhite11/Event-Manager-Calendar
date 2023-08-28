using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    class Event
    {
        String title;
        String startTime;
        String endTime;
        String reminder;
        String location;
        String date;
        String description;
        String createdBy;
        String attendee;
        User[] attendees;

        public Event(String t, String d, String st, String et, String l, String ds, String cb, String a)
        {
            title = t;
            startTime = st;
            endTime = et;
            location = l;
            date = d;
            description = ds;
            createdBy = cb;
            attendee = a;
        }

        public Event()
        {

        }

        public int checkConflict()
        {
            SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\KATE\DESKTOP\CALENDAR\CALENDAR\CALDB.MDF;Integrated Security=True;Connect Timeout=30");

            try
            {
                Con.Open();
                string sql = "SELECT * FROM [Event] WHERE date=@date AND startTime=@startTime AND attendee=@attendee;";
                SqlCommand cmd = new SqlCommand(sql, Con);
                cmd.Parameters.Add(new SqlParameter("@date", date));
                cmd.Parameters.Add(new SqlParameter("@startTIme", startTime));
                cmd.Parameters.Add(new SqlParameter("@attendee", attendee));
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    Con.Close();
                    return 1;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Con.Close();
            return 0;

        }

        public void updateEventValue(String t, String d, String st, String et, String l, String ds, String cb, String a)
        {
            title = t;
            date = d;
            startTime = st;
            endTime = et;
            location = l;
            description = ds;
            createdBy = cb;
            attendee = a;
        }
        public String getStartTime()
        {
            return startTime;
        }

        public String getEndTime()
        {
            return endTime;
        }

        public String getLocation()
        {
            return location;
        }
        public String getTitle()
        {
            return title;
        }

        public String getDescription()
        {
            return description;
        }

        public String getCreator()
        {
            return createdBy; 
        }

        public String getDate()
        {
            return date;
        }

        public String getAttendee()
        {
            return attendee;
        }
        public static ArrayList retrieveEvents(String id)
        {
            ArrayList eventList = new ArrayList();
            
            DataTable myTable = new DataTable();
            SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\KATE\DESKTOP\CALENDAR\CALENDAR\CALDB.MDF;Integrated Security=True;Connect Timeout=30");
            try
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * from [Event] where attendee=@id", Con);
                sda.SelectCommand.Parameters.Add(new SqlParameter("@id", id));
                sda.Fill(myTable);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Con.Close();

            foreach (DataRow row in myTable.Rows)
            {
                Event newEvent = new Event();
                newEvent.title = row["title"].ToString();
                newEvent.date = row["date"].ToString();
                newEvent.startTime = row["startTime"].ToString();
                newEvent.endTime = row["endTime"].ToString();
                newEvent.location = row["location"].ToString();
                newEvent.description = row["description"].ToString();
                newEvent.createdBy = row["createdBy"].ToString();
                newEvent.attendee = row["attendee"].ToString();
                eventList.Add(newEvent);
            }
            return eventList;
        }


        public void saveEvent()
        {
            
            SqlConnection Con2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\KATE\DESKTOP\CALENDAR\CALENDAR\CALDB.MDF;Integrated Security=True;Connect Timeout=30");
            try
            {
                Con2.Open();
                string sql = "INSERT INTO [Event] (title, date, startTime, endTime, location, description, createdBy, attendee)" +
                " VALUES (@title, @date, @startTime, @endTime, @location, @description, @createdBy, @attendee);";
                SqlCommand cmd = new SqlCommand(sql, Con2);
                cmd.Parameters.Add(new SqlParameter("@title", title));
                cmd.Parameters.Add(new SqlParameter("@date", date));
                cmd.Parameters.Add(new SqlParameter("@startTime", startTime));
                cmd.Parameters.Add(new SqlParameter("@endTime", endTime));
                cmd.Parameters.Add(new SqlParameter("@location", location));
                cmd.Parameters.Add(new SqlParameter("@description", description));
                cmd.Parameters.Add(new SqlParameter("@createdBy", Login.userIDNum));
                cmd.Parameters.Add(new SqlParameter("@attendee", Login.userIDNum));
                
                cmd.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            Con2.Close();
        }

        public void saveMeeting()
        {

            SqlConnection Con2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\KATE\DESKTOP\CALENDAR\CALENDAR\CALDB.MDF;Integrated Security=True;Connect Timeout=30");
            try
            {
                Con2.Open();
                string sql = "INSERT INTO [Event] (title, date, startTime, endTime, location, description, createdBy, attendee)" +
                " VALUES (@title, @date, @startTime, @endTime, @location, @description, @createdBy, @attendee);";
                SqlCommand cmd = new SqlCommand(sql, Con2);
                cmd.Parameters.Add(new SqlParameter("@title", title));
                cmd.Parameters.Add(new SqlParameter("@date", date));
                cmd.Parameters.Add(new SqlParameter("@startTime", startTime));
                cmd.Parameters.Add(new SqlParameter("@endTime", endTime));
                cmd.Parameters.Add(new SqlParameter("@location", location));
                cmd.Parameters.Add(new SqlParameter("@description", description));
                cmd.Parameters.Add(new SqlParameter("@createdBy", Login.userIDNum));
                cmd.Parameters.Add(new SqlParameter("@attendee", attendee));

                cmd.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            Con2.Close();
        }


        public void deleteEvent()
        {
            SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\KATE\DESKTOP\CALENDAR\CALENDAR\CALDB.MDF;Integrated Security=True;Connect Timeout=30");

            try
            {
                Con.Open();
                string sql = "DELETE FROM [Event] WHERE title=@title AND date=@date;";
                SqlCommand cmd = new SqlCommand(sql, Con);
                cmd.Parameters.Add(new SqlParameter("@title", title));
                cmd.Parameters.Add(new SqlParameter("@date", date));
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Con.Close();

        }


    }

}
