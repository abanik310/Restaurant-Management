using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //int w = Screen.PrimaryScreen.Bounds.Width;
            //int h = Screen.PrimaryScreen.Bounds.Height;
            //this.Location = new Point(0, 0);
            //this.Size = new Size(w, h);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
             Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["RestaurantDB"].ConnectionString);
            connection.Open();
            string query = "Select * from Users where ID='" + tbxUserName.Text + "'and Password='" + tbxUserPassword.Text + "'";
            SqlCommand command = new SqlCommand(query, connection);
            int result = command.ExecuteNonQuery();

            if (tbxUserName.lengthTostring)
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["RestaurantDB"].ConnectionString);
            connection.Open();
            string query = "Select * from Users where ID='" + tbxUserName.Text + "'and Password='" + tbxUserPassword.Text + "'";
            SqlCommand command = new SqlCommand(query, connection);
            int result = command.ExecuteNonQuery();

            if (tbxUserName.lengthTostring)
        }
    }
}
