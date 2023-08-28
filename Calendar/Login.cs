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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public static String userIDNum;
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\KATE\DESKTOP\CALENDAR\CALENDAR\CALDB.MDF;Integrated Security=True;Connect Timeout=30");

        private void loginbtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from [User] where userID='" + userIDBox.Text + "' and password='" + passBox.Text + "';", Con);
            DataTable dt1 = new DataTable();
            sda.Fill(dt1);
            if (dt1.Rows[0][0].ToString() == "1")
            {
                userIDNum = userIDBox.Text;
                Calendar newCal = new Calendar();
                newCal.Show();
                this.Hide();
                Con.Close();
            }
            else
            {
                MessageBox.Show("Wrong username or password.");
            }

            Con.Close();
        }

    }
}
