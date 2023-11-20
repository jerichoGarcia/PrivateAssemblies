using System.Collections;
using CalculatorPrivateAssembly;

namespace BasicCalculator
{
    public partial class frmBasicCalculator : Form
    {
        public frmBasicCalculator()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            float firstNum, SecondNum, total;

            firstNum = Convert.ToInt64(txtFirstNum.Text);
            SecondNum = Convert.ToInt64(txtSecondNumber.Text);


            if (cbOperation.Text == "+")
            {
                total = (BasicComputation.addition(firstNum, SecondNum));
                lblTotal.Text = total.ToString();
            }
            else if (cbOperation.Text == "-")
            {
                total = BasicComputation.subraction(firstNum, SecondNum);
                lblTotal.Text = total.ToString();
            }
            else if (cbOperation.Text == "*")
            {
                total = BasicComputation.multiplication(firstNum, SecondNum);
                lblTotal.Text = total.ToString();
            }
            else if (cbOperation.Text == "/")
            {
                total = BasicComputation.division(firstNum, SecondNum);
                lblTotal.Text = total.ToString();
            }
            else
            {
                MessageBox.Show("Invalid Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmBasicCalculator_Load(object sender, EventArgs e)
        {
            cbOperation.Items.Add("+");
            cbOperation.Items.Add("*");
            cbOperation.Items.Add("-");
            cbOperation.Items.Add("/");

        }

        private void txtFirstNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSecondNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}