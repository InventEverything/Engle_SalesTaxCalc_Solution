using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Engle_SalesTaxCalc_Project
{
    public partial class frmVehicleSalesTaxCalculator : Form
    {
        public frmVehicleSalesTaxCalculator()
        {
            InitializeComponent();
        }
        //Run calculation method and display results
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string ValidResult = Calculate(txtVehiclePrice.Text, cboWarranty.SelectedIndex, cboState.SelectedItem);
            if (ValidResult != "")
            {
                lblGrandTotal.Text = ValidResult;
                lblTotalCost.Visible = true;
            }
        }
        //Exit application on "exit" button click
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Resets the form to default on "clear" button click
        private void btnClear_Click(object sender, EventArgs e)
        {
            lblTotalCost.Visible = false;
            txtVehiclePrice.Text = "";
            cboWarranty.SelectedIndex = 0;
            cboState.SelectedIndex = 0;
            lblGrandTotal.Text = "";
            txtVehiclePrice.Focus();
        }
        //Allows enter to calculate from the vehicle price text box
        private void txtVehiclePrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string ValidResult = Calculate(txtVehiclePrice.Text, cboWarranty.SelectedIndex, cboState.SelectedItem);
                if (ValidResult != "")
                {
                    lblGrandTotal.Text = ValidResult;
                    lblTotalCost.Visible = true;
                }
            }
        }
        //Allows enter to calculate from the warranty combo box
        private void cboWarranty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string ValidResult = Calculate(txtVehiclePrice.Text, cboWarranty.SelectedIndex, cboState.SelectedItem);
                if (ValidResult != "")
                {
                    lblGrandTotal.Text = ValidResult;
                    lblTotalCost.Visible = true;
                }
            }
        }
        //Allows enter to calculate from the state combo box
        private void cboState_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string ValidResult = Calculate(txtVehiclePrice.Text, cboWarranty.SelectedIndex, cboState.SelectedItem);
                if (ValidResult != "")
                {
                    lblGrandTotal.Text = ValidResult;
                    lblTotalCost.Visible = true;
                }
            }
        }
        //Method for calculating the grand total for the selected vehicle options
        static string Calculate(string Price, int Warranty, object State)
        {
            string Total;
            decimal VehiclePrice;
            if (decimal.TryParse(Price, out VehiclePrice) == true)
            {
                decimal Subtotal = VehiclePrice + (1000 * (Warranty));
                if (State.Equals("WA"))
                    return (Subtotal * 1.086m).ToString("c");
                else if (State.Equals("OR"))
                    return Subtotal.ToString("c");
            }
            return "";
        }
    }
}
