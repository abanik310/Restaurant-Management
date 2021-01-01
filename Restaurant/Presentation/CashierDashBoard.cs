using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant.Presentation
{
    public partial class CashierDashBoard : UserControl
    {
        public CashierDashBoard()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            //UCAppetizers2 uCAppetizers2 = new UCAppetizers2();
            //pnlitemList.Controls.Add(uCAppetizers2);
            ////pnlManagerMain.Controls.Add(uCAppetizers2);
            //UCAppetizer uCAppetizer = new UCAppetizer();
            //pnlitemList.Controls.Add(uCAppetizer);
            pnlitemList.Controls.Clear();
            UCAppetizer uCAppetizer = new UCAppetizer();
            pnlitemList.Controls.Add(uCAppetizer);
        }

        private void pnlitemList_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlitemList_ControlAdded(object sender, ControlEventArgs e)
        {
            //UCAppetizers uCAppetizers2 = new UCAppetizers2();
            //pnlitemList.Controls.Add(uCAppetizers2);
            pnlitemList.Controls.Clear();
            UCAppetizer uCAppetizer = new UCAppetizer();
            pnlitemList.Controls.Add(uCAppetizer);
        }

        private void btnMainCourse_Click(object sender, EventArgs e)
        {
            //pnlitemList.Controls.Clear();
            UCMainDish uCMainDish = new UCMainDish();
            pnlitemList.Controls.Add(uCMainDish);
        }

        private void btnDessert_Click(object sender, EventArgs e)
        {
            
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnchickenwings_Click(object sender, EventArgs e)
        {

        }
    }
}
