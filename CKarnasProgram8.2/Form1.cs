using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CKarnasProgram8._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreatePaySlip_Click(object sender, EventArgs e)
        {
            // declare local (method level) variables

            string strName;
            decimal hoursWorked, payRate, payCheck;

            PaySlip aPaySlip;

            // assign input data into variables

            strName = txtEmployeeName.Text;
            hoursWorked = Convert.ToDecimal(nudHours.Value);
            payRate = Convert.ToDecimal(nudPayRate.Value);

            // instantiate a PaySlip object

            aPaySlip = new PaySlip(strName, hoursWorked, payRate);

            //access the NetPayCheck property

            payCheck = aPaySlip.NetPayCheck;

            // display the property

            lblPayCheckAmount.Text = payCheck.ToString("c");

            // disable controls

            btnCreatePaySlip.Enabled = false;
        }

        private void btnDisplaySummary_Click(object sender, EventArgs e)
        {
            // display

            string strMessage = $"Total # of Pay Slips: {PaySlip.TotalPaySlips.ToString("N0")} \nTotal Gross Pay: {PaySlip.TotalGrossPay.ToString("C")} " +
                $"\nTotal Net Pay: {PaySlip.TotalNetPay.ToString("C")} \nTotal Average Pay: {PaySlip.CalculateAvgNetPay().ToString("c")}";

            // display the result in a message box

            MessageBox.Show(strMessage, "Summary", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // disable controls

            btnCreatePaySlip.Enabled = false;
        }

        private void btnReset1_Click(object sender, EventArgs e)
        {
            // reset the values in the first groupbox

            txtEmployeeName.Text = null;
            nudHours.Value = 0;
            nudPayRate.Value = 0;
            lblPayCheckAmount.Text = null;

            //enable controls

            btnCreatePaySlip.Enabled = true;
        }

       
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
