using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DGVPrinterHelper;

namespace Restaurant.Presentation
{
    public partial class CashierDashBoard2 : UserControl

    {
        int index;
        double SubTotal;
        int FriedChicken, FrenchFry, Wedges, Soup, Dumpllings, Biriyani, SetMenu, Burger, Pizza, Noodles, Sandwich, Faluda, Custurd, Donut;

        private void DGVCashier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCashierPlaceOrder_Click(object sender, EventArgs e)
        {
            DGVPrinter dGVPrinter = new DGVPrinter();
            dGVPrinter.Title = "Order";
            dGVPrinter.PageNumbers = true;
            dGVPrinter.PageNumberInHeader = false;
            dGVPrinter.HeaderCellAlignment = StringAlignment.Near;
            dGVPrinter.Footer = "Restaurant";
            dGVPrinter.FooterSpacing = 15;
            dGVPrinter.PrintDataGridView(DGVCashier);
        }

        private void btnCashierCancel_Click(object sender, EventArgs e)
        {

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            
                double Vat = SubTotal / double.Parse(tbxCashierVat.Text);
                double Discount = SubTotal / double.Parse(tbxCashierDiscount.Text);
                SubTotal += Vat;
                SubTotal -= Discount;
                tbxCashierGrandTotal.Text = SubTotal.ToString();
                tbxCashierReturnAmount.Text = Math.Abs((double.Parse(tbxCashierPaidAmount.Text) - SubTotal)).ToString();
                tbxCashierReturnAmount.ReadOnly = true;
           
        }
        public bool EmptyCheck()
        {
            if(tbxCashierSubTotal.Text == "" || tbxCashierVat.Text =="5" || tbxCashierDiscount.Text =="5" || tbxCashierGrandTotal.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbxFC_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void Checked()
        {
            if(cbxFC.Checked)
            {
                DGVCashier.Rows[index].Cells[0].Value = "Fried Chicken";
                DGVCashier.Rows[index].Cells[1].Value = cmbxFC.SelectedItem.ToString();
                DGVCashier.Rows[index].Cells[2].Value = "120";

                SubTotal += double.Parse(cmbxFC.SelectedItem.ToString()) * 120;
                
                cbxFC.Checked = false;

            }

             if (cbxFFry.Checked)
            {
                DGVCashier.Rows[index].Cells[0].Value = "French Fry";
                DGVCashier.Rows[index].Cells[1].Value = cmbxFFry.SelectedItem.ToString();
                DGVCashier.Rows[index].Cells[2].Value = "80";

                SubTotal += double.Parse(cmbxFFry.SelectedItem.ToString()) * 80;
                
                cbxFFry.Checked = false;

            }

            if(cbxWedges.Checked)
            {
                DGVCashier.Rows[index].Cells[0].Value = "Wedges";
                DGVCashier.Rows[index].Cells[1].Value = cmbxWedges.SelectedItem.ToString();
                DGVCashier.Rows[index].Cells[2].Value = "80";

                SubTotal += double.Parse(cmbxWedges.SelectedItem.ToString()) * 80;
                
                cbxWedges.Checked = false;

            }

            else if (cbxSoup.Checked)
            {
                DGVCashier.Rows[index].Cells[0].Value = "Soup";
                DGVCashier.Rows[index].Cells[1].Value = cmbxSoup.SelectedItem.ToString();
                DGVCashier.Rows[index].Cells[2].Value = "140";

                SubTotal += double.Parse(cmbxSoup.SelectedItem.ToString()) * 140;
                cbxSoup.Checked = false;

            }

            else if (cbxDumpllings.Checked)
            {
                DGVCashier.Rows[index].Cells[0].Value = "Dumpllings";
                DGVCashier.Rows[index].Cells[1].Value = cmbxDumpllings.SelectedItem.ToString();
                DGVCashier.Rows[index].Cells[2].Value = "150";

                SubTotal += double.Parse(cmbxDumpllings.SelectedItem.ToString()) * 150;
                cbxDumpllings.Checked = false;

            }

            else if (cbxBiriyani.Checked)
            {
                DGVCashier.Rows[index].Cells[0].Value = "Biriyani";
                DGVCashier.Rows[index].Cells[1].Value = cmbxBiriyani.SelectedItem.ToString();
                DGVCashier.Rows[index].Cells[2].Value = "220";

                SubTotal += double.Parse(cmbxBiriyani.SelectedItem.ToString()) * 220;
                cbxBiriyani.Checked = false;

            }

            else if (cbxSetMenu.Checked)
            {
                DGVCashier.Rows[index].Cells[0].Value = "Set Menu";
                DGVCashier.Rows[index].Cells[1].Value = cmbxSetMenu.SelectedItem.ToString();
                DGVCashier.Rows[index].Cells[2].Value = "180";

                SubTotal += double.Parse(cmbxSetMenu.SelectedItem.ToString()) * 180;
                cbxSetMenu.Checked = false;

            }

            else if (cbxBurger.Checked)
            {
                DGVCashier.Rows[index].Cells[0].Value = "Burger";
                DGVCashier.Rows[index].Cells[1].Value = cmbxBurger.SelectedItem.ToString();
                DGVCashier.Rows[index].Cells[2].Value = "160";

                SubTotal += double.Parse(cmbxBurger.SelectedItem.ToString()) * 160;
                cbxBurger.Checked = false;

            }

            else if (cbxPizza.Checked)
            {
                DGVCashier.Rows[index].Cells[0].Value = "Pizza";
                DGVCashier.Rows[index].Cells[1].Value = cmbxPizza.SelectedItem.ToString();
                DGVCashier.Rows[index].Cells[2].Value = "350";

                SubTotal += double.Parse(cmbxPizza.SelectedItem.ToString()) * 350;
                cbxPizza.Checked = false;

            }

            else if (cbxNoodles.Checked)
            {
                DGVCashier.Rows[index].Cells[0].Value = "Noodles";
                DGVCashier.Rows[index].Cells[1].Value = cmbxNoodles.SelectedItem.ToString();
                DGVCashier.Rows[index].Cells[2].Value = "150";

                SubTotal += double.Parse(cmbxNoodles.SelectedItem.ToString()) * 150;
                cbxNoodles.Checked = false;

            }

            else if (cbxSandwich.Checked)
            {
                DGVCashier.Rows[index].Cells[0].Value = "Sandwich";
                DGVCashier.Rows[index].Cells[1].Value = cmbxSandwich.SelectedItem.ToString();
                DGVCashier.Rows[index].Cells[2].Value = "100";

                SubTotal += double.Parse(cmbxSandwich.SelectedItem.ToString()) * 100;
                cbxSandwich.Checked = false;

            }

            else if (cbxFaluda.Checked)
            {
                DGVCashier.Rows[index].Cells[0].Value = "Faluda";
                DGVCashier.Rows[index].Cells[1].Value = cmbxFaluda.SelectedItem.ToString();
                DGVCashier.Rows[index].Cells[2].Value = "180";

                SubTotal += double.Parse(cmbxFaluda.SelectedItem.ToString()) * 180;
                cbxFaluda.Checked = false;

            }

            else if (cbxCusturd.Checked)
            {
                DGVCashier.Rows[index].Cells[0].Value = "Custurd";
                DGVCashier.Rows[index].Cells[1].Value = cmbxCusturd.SelectedItem.ToString();
                DGVCashier.Rows[index].Cells[2].Value = "180";

                SubTotal += double.Parse(cmbxCusturd.SelectedItem.ToString()) * 180;
                cbxCusturd.Checked = false;

            }

            else if (cbxDonut.Checked)
            {
                DGVCashier.Rows[index].Cells[0].Value = "Donut";
                DGVCashier.Rows[index].Cells[1].Value = cmbxDonut.SelectedItem.ToString();
                DGVCashier.Rows[index].Cells[2].Value = "80";

                SubTotal += double.Parse(cmbxDonut.SelectedItem.ToString()) * 80;
                cbxDonut.Checked = false;

            }
        }
        private void btnCashierAdd_Click(object sender, EventArgs e)
        {

            index = DGVCashier.Rows.Add();
            Checked();
            tbxCashierSubTotal.Text = SubTotal.ToString();

            


        }

        public CashierDashBoard2()
        {
            InitializeComponent();
        }
    }
}
