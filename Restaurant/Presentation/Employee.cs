using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Restaurant.Presentation
{
    public partial class Employee : UserControl
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            SqlConnection c = new SqlConnection(ConfigurationManager.ConnectionStrings["RestaurantDB"].ConnectionString);
            c.Open();
            string q = "Insert into Employees(Name,User Name,Password,Email,Contact Number,Date of birth,Blood Group,Present Address,Parmanent Address,Designation,Joinning date)" + "Values('" + tbxEmployeeName.Text + "','" + tbxEmployeeUserName.Text + "','" + tbxEmployeePassword.Text + "','" + tbxEmployeeEmail.Text + "','" + tbxEmployeeContactNmbr.Text + "','" + tbxEmployeeDOB.Text + "','" + tbxEmployeeBloodGroup.Text + "','" + tbxEmployeePresentAddress.Text + "','" + tbxEmployeeParmanentAdd.Text + "','" + tbxEmployeeDesignation.Text + "','" + tbxEmployeeJoinDate.Text + "')";
            SqlCommand cm = new SqlCommand(q, c);
            cm.ExecuteNonQuery();
            c.Close();

            MessageBox.Show("Employee Added Successfully!");
        }

        private void btnFrshEmployee_Click(object sender, EventArgs e)
        {
            SqlConnection c = new SqlConnection(ConfigurationManager.ConnectionStrings["RestaurantDB"].ConnectionString);
            c.Open();
            string q = "Insert into Employees(Name,User Name,Password,Email,Contact Number,Date of birth,Blood Group,Present Address,Parmanent Address,Designation,Joinning date)" + "Values('" + tbxEmployeeName.Text + "','" + tbxEmployeeUserName.Text + "','" + tbxEmployeePassword.Text + "','" + tbxEmployeeEmail.Text + "','" + tbxEmployeeContactNmbr.Text + "','" + tbxEmployeeDOB.Text + "','" + tbxEmployeeBloodGroup.Text + "','" + tbxEmployeePresentAddress.Text + "','" + tbxEmployeeParmanentAdd.Text + "','" + tbxEmployeeDesignation.Text + "','" + tbxEmployeeJoinDate.Text + "')";
            SqlCommand cm = new SqlCommand(q, c);

            SqlDataReader reader = command.ExecuteReader();
            List<Class1> list = new List<Class1>();
            while (reader.Read())
            {
                Class1 cw = new Class1(); 
                cw.Name = reader["Name"].ToString();
                cw.UserName = reader["User Name"].ToString();
                cw.Password = reader["Password"].ToString();
                cw.Email = reader["Email"].ToString();
                cw.ContactNumber = reader["Contact Number"].ToString();
                cw.Dateofbirth = reader["Date of birth"].ToString();
                cw.BloodGroup = reader["Blood Group"].ToString();
                cw.PresentAddress = reader["Present Address"].ToString(); 
                cw.ParmanentAddress = reader["Parmanent Address"].ToString();
                cw.Designation = reader["Designation"].ToString();
                cw.JoinningDate = reader["Joinning Date"].ToString();

                list.Add(cw);
            } 

            c.Close();
            dataGridView1.DataSource = list;
            reader.Close();
            
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {

        }
    }
}
