using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace Calendar
{
    class User
    {
        String id;
        String password;
        String name;
        String manager;
        Boolean isManager; 
        
        public User(String i, String p, String n, String m)
        {
            id = i;
            password = p;
            name = n;
            manager = m;

        }

        public User()
        {

        }
        public String getUserId()
        {
            return id;
        }

        public String getName()
        {
            return name;
        }

        public String getPassword() 
        {
            return password;
        }

        public String getManager()
        {
            return manager;
        }

        public bool isMan(String manager)
        {

            if (manager.Equals("TRUE"))
            {
                isManager = true;
            }
            else
            {
                isManager = false;
            }

            return isManager;
        }


        public static ArrayList retrieveUsers()
        {
            ArrayList userList = new ArrayList();

            DataTable myTable = new DataTable();
            SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\KATE\DESKTOP\CALENDAR\CALENDAR\CALDB.MDF;Integrated Security=True;Connect Timeout=30");
            try
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * from [User]", Con);
                sda.Fill(myTable);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Con.Close();

            foreach (DataRow row in myTable.Rows)
            {
                User newUser = new User();
                newUser.id = row["userId"].ToString();
                newUser.password = row["password"].ToString();
                newUser.name = row["name"].ToString();
                newUser.manager = row["isManager"].ToString(); ;
                userList.Add(newUser);
            }
            return userList;
        }
    }
}
