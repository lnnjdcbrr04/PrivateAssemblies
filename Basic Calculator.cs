using CalculatorPrivateAssembly;

namespace PrivateAssemblies
{
    public partial class FrmBasicComputation : Form
    {
        public FrmBasicComputation()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            float num1, num2, result = 0;

            if (!float.TryParse(txtFNum.Text, out num1))
            {
                MessageBox.Show("Please enter a valid first number.");
                return;
            }

            if (!float.TryParse(txtSecNum.Text, out num2))
            {
                MessageBox.Show("Please enter a valid second number.");
                return;
            }

            if (cmbOperation.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an operation.");
                return;
            }

            string operation = cmbOperation.SelectedItem.ToString();

            switch (operation)
            {
                case "Addition":
                case "+":

                    result = BasicComputation.Addition(num1, num2);
                    break;

                case "Subtraction":
                case "-":
                    result = BasicComputation.Subtraction(num1, num2);
                    break;

                case "Multiplication":
                case "*":
                    result = BasicComputation.Multiplication(num1, num2);
                    break;

                case "Division":
                case "/":
                    if (num2 == 0)
                    {
                        MessageBox.Show("Cannot divide by zero.");
                        return;
                    }

                    result = BasicComputation.Division(num1, num2);
                    break;

                default:
                    MessageBox.Show("Invalid operation selected.");
                    return;
            }

            lblResult.Text = result.ToString();
        }
    }
}
