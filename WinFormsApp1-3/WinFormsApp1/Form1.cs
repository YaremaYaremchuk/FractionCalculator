namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        string n1, n2, n3, n4, n5, n6;
        string ope;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("yo");
                return;
            }
            else
            {
                e.Handled = true;
            }
        }



        private void firsttopbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                return;
            }
            else e.Handled = true;
        }

        private void secondtopbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                return;
            }
            else e.Handled = true;
        }

        private void secondbotbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                return;
            }
            else e.Handled = true;
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton but = (RadioButton)sender;
            if (but.Checked)
            {
                ope = but.Text;
            }
            else
            {
                ope = "";
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton but = (RadioButton)sender;
            if (but.Checked)
            {
                ope = but.Text;
            }
            else
            {
                ope = "";
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void DoCalculation()
        {
            (n1, n2, n3, n4) = (firsttopbox.Text, firstbotbox.Text, secondtopbox.Text, secondbotbox.Text);
            Fraction num1 = new Fraction(n1,n2);
            Fraction num2 = new Fraction(n3, n4);

            if(ope == "+")
            {
                Fraction res = num1 + num2;
                res.Deconstruct(out n5, out n6);
            }
            else if(ope == "-") {
                Fraction res = num1 - num2;
                res.Deconstruct(out n5, out n6);
            }
            else if (ope == "*") {
                Fraction res = num1 * num2;
                res.Deconstruct(out n5, out n6);
            }
            else if (ope == "/") {
                Fraction res = num1 / num2;
                res.Deconstruct(out n5, out n6);
            }

            (restopbox.Text, resbotbox.Text) = (n5,n6);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoCalculation();
        }

        private void firstbotbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void secondtopbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton but = (RadioButton)sender;
            if (but.Checked)
            {
                ope = but.Text;
            }
            else
            {
                ope = "";
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton but = (RadioButton)sender;
            if(but.Checked)
            {
                ope = but.Text;
            }
            else
            {
                ope = "";
            }
        }
    }
}
