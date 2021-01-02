using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant.Presentation
{
    public partial class Users : UserControl
    {
        public Users()
        {
            InitializeComponent();
        }

        private void btnAddUsers_Click(object sender, EventArgs e)
        {
            SqlConnection c = new SqlConnection(ConfigurationManager.ConnectionStrings["RestaurantDB"].ConnectionString);
            c.Open();
            string q = "Insert into Users(Name,User Name,Password,Email,Contact Number,Date of birth,Blood Group,Present Address,Parmanent Address,Designation,Joinning date)" + "Values('" + tbxUsersName.Text + "','" + tbxUsersUserName.Text + "','" + tbxUsersPassword.Text + "','" + tbxUsersEmail.Text + "','" + tbxUsersContactNmbr.Text + "','" + tbxUsersDOB.Text + "','" + tbxUsersBloodGroup.Text + "','" + tbxUsersPresentAddress.Text + "','" + tbxUsersParmanentAdd.Text + "','" + tbxUsersDesignation.Text + "','" + tbxUsersJoinDate.Text + "')";
            SqlCommand cm = new SqlCommand(q, c);
            cm.ExecuteNonQuery();
            c.Close();



            MessageBox.Show("Users Added Successfully!");
        }

        public void RefreshTable()
        {​​​​​

            UserDataAccess userDataAccess = new UserDataAccess();
            UsersDataGridView.DataSource = userDataAccess.ReturnDataTable(this.ID);
            UsersDataGridView.Refresh();
            UsersDataGridView.ClearSelection();
        }​​​​​


        private void btnFrshUsers_Click(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private void btnSearchUsers_Click(object sender, EventArgs e)
        {

        }
    }
}
