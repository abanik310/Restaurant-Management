using Restaurant.Presentation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);

            AdminDashBoard adminDashBoard = new AdminDashBoard();
            pnlAdminUI.Controls.Add(adminDashBoard);
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdminLeftPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            pnlManagerMain.Controls.Clear();
            Employee employee = new Employee();
            pnlManagerMain.Controls.Add(employee);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            pnlManagerMain.Controls.Clear();
            Users users = new Users();
            pnlManagerMain.Controls.Add(users);
        }

        private void btnAdminSettings_Click(object sender, EventArgs e)
        {
            pnlManagerMain.Controls.Clear();
            SettingControl settingControl = new SettingControl();
            pnlManagerMain.Controls.Add(settingControl);
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            pnlManagerMain.Controls.Clear();
            Food food = new Food();
            pnlManagerMain.Controls.Add(food);

        }

        private void btnPurchases_Click(object sender, EventArgs e)
        {
            pnlManagerMain.Controls.Clear();
            PurchasesAll purchasesAll = new PurchasesAll();
            pnlManagerMain.Controls.Add(purchasesAll);
        }

        private void btnAdminLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
