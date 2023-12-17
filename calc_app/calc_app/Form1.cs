namespace calc_app
{
    public partial class Form1 : Form
    {

        float x = 0;
        decimal xx1 = 0;
        decimal xx2 = 0;
        decimal resultx = 0;
        string s = "";
        bool point = false;
        bool spanel = false;

        public Form1()
        {
            InitializeComponent();
            sign.Text = " ";
            sign.AutoSize = false;
            sign.TextAlign = ContentAlignment.MiddleRight;
            //Form1.Size(397; 476);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            x = 0;
        }

        public void nSumm_Click(object sender, EventArgs e)
        {
            
            xx2 = Main.Value;

            main2.Text = main2.Text + " " + sign.Text + " " + xx2;

            switch (sign.Text)
            {
                case "+":
                    resultx = xx1 + xx2;
                    Main.Value = resultx;
                    break;
                case "-":
                    resultx = xx1 - xx2;
                    Main.Value = resultx;
                    break;
                case "/":
                    resultx = xx1 / xx2;
                    Main.Value = resultx;
                    break;
                case "*":
                    resultx = xx1 * xx2;
                    Main.Value = resultx;
                    break;
                case "x^2":
                    resultx = xx1 * xx1;
                    Main.Value = resultx;
                    break;
                case "x^(1/2)":
                    resultx = 1;
                    Main.Value = resultx;
                    break;
                case "1/x":
                    resultx = 1 / xx1;
                    Main.Value = resultx;
                    break;
            }

            xx1 = Math.Round(xx1 * 100) / 100;
            xx2 = Math.Round(xx2 * 100) / 100;
            resultx = Math.Round(resultx * 100) / 100;
            history.Items.Add(xx1 + " " + sign.Text + " " + xx2 + " = " + resultx);
            sign.Text = "=";
            xx1 = resultx;
            xx2 = 0;
        }

        public void nPlus_Click(object sender, EventArgs e)
        {
            sign.Text = "+";
            xx1 = Main.Value;
            main2.Text = xx1.ToString();
            Main.Value = 0;

        }

        private void nMinus_Click(object sender, EventArgs e)
        {
            sign.Text = "-";
            xx1 = Main.Value;
            main2.Text = xx1.ToString();
            Main.Value = 0;
        }

        private void Main_ValueChanged(object sender, EventArgs e)
        {
            if (Math.Round(Main.Value) != Main.Value)
            {
                Main.DecimalPlaces = 2;
            }
            else
            {
                Main.DecimalPlaces = 0;
            }
        }

        private void n1_Click(object sender, EventArgs e)
        {
            if (sign.Text == " ")
            {
                xx1 = xx1 * 10 + 1;
                Main.Value = xx1;
            }
            else if (sign.Text != " ")
            {
                xx2 = xx2 * 10 + 1;
                Main.Value = xx2;
            }
            else if (sign.Text == "=")
            {
                xx2 = xx2 * 10 + 1;
                Main.Value = xx2;
            }
        }

        private void n2_Click(object sender, EventArgs e)
        {
            if (sign.Text == " ")
            {
                xx1 = xx1 * 10 + 2;
                Main.Value = xx1;
            }
            else if (sign.Text != " ")
            {
                xx2 = xx2 * 10 + 2;
                Main.Value = xx2;
            }
            else if (sign.Text == "=")
            {
                xx2 = xx2 * 10 + 2;
                Main.Value = xx2;
            }
        }

        private void n0_Click(object sender, EventArgs e)
        {
            if (sign.Text == " ")
            {
                xx1 = xx1 * 10 + 0;
                Main.Value = xx1;
            }
            else if (sign.Text != " ")
            {
                xx2 = xx2 * 10 + 0;
                Main.Value = xx2;
            }
            else if (sign.Text == "=")
            {
                xx2 = xx2 * 10 + 0;
                Main.Value = xx2;
            }
        }

        private void n3_Click(object sender, EventArgs e)
        {
            if (sign.Text == " ")
            {
                xx1 = xx1 * 10 + 3;
                Main.Value = xx1;
            }
            else if (sign.Text != " ")
            {
                xx2 = xx2 * 10 + 3;
                Main.Value = xx2;
            }
            else if (sign.Text == "=")
            {
                xx2 = xx2 * 10 + 3;
                Main.Value = xx2;
            }
        }

        private void n4_Click(object sender, EventArgs e)
        {
            if (sign.Text == " ")
            {
                xx1 = xx1 * 10 + 4;
                Main.Value = xx1;
            }
            else if (sign.Text != " ")
            {
                xx2 = xx2 * 10 + 4;
                Main.Value = xx2;
            }
            else if (sign.Text == "=")
            {
                xx2 = xx2 * 10 + 4;
                Main.Value = xx2;
            }
        }

        private void n5_Click(object sender, EventArgs e)
        {
            if (sign.Text == " ")
            {
                xx1 = xx1 * 10 + 5;
                Main.Value = xx1;
            }
            else if (sign.Text != " ")
            {
                xx2 = xx2 * 10 + 5;
                Main.Value = xx2;
            }
            else if (sign.Text == "=")
            {
                xx2 = xx2 * 10 + 5;
                Main.Value = xx2;
            }
        }

        private void n6_Click(object sender, EventArgs e)
        {
            if (sign.Text == " ")
            {
                xx1 = xx1 * 10 + 6;
                Main.Value = xx1;
            }
            else if (sign.Text != " ")
            {
                xx2 = xx2 * 10 + 6;
                Main.Value = xx2;
            }
            else if (sign.Text == "=")
            {
                xx2 = xx2 * 10 + 6;
                Main.Value = xx2;
            }
        }

        private void n7_Click(object sender, EventArgs e)
        {
            if (sign.Text == " ")
            {
                xx1 = xx1 * 10 + 7;
                Main.Value = xx1;
            }
            else if (sign.Text != " ")
            {
                xx2 = xx2 * 10 + 7;
                Main.Value = xx2;
            }
            else if (sign.Text == "=")
            {
                xx2 = xx2 * 10 + 7;
                Main.Value = xx2;
            }
        }

        private void n8_Click(object sender, EventArgs e)
        {
            if (sign.Text == " ")
            {
                xx1 = xx1 * 10 + 8;
                Main.Value = xx1;
            }
            else if (sign.Text != " ")
            {
                xx2 = xx2 * 10 + 8;
                Main.Value = xx2;
            }
            else if (sign.Text == "=")
            {
                xx2 = xx2 * 10 + 8;
                Main.Value = xx2;
            }
        }

        private void n9_Click(object sender, EventArgs e)
        {
            if (sign.Text == " ")
            {
                xx1 = xx1 * 10 + 9;
                Main.Value = xx1;
            }
            else if (sign.Text != " ")
            {
                xx2 = xx2 * 10 + 9;
                Main.Value = xx2;
            }
            else if (sign.Text == "=")
            {
                xx2 = xx2 * 10 + 9;
                Main.Value = xx2;
            }
        }

        private void nPoint_Click(object sender, EventArgs e)
        {
            point = true;

        }

        private void nSplit_Click(object sender, EventArgs e)
        {
            sign.Text = "/";
            xx1 = Main.Value;
            main2.Text = xx1.ToString();
            Main.Value = 0;
        }

        private void nUmnog_Click(object sender, EventArgs e)
        {
            sign.Text = "*";
            xx1 = Main.Value;
            main2.Text = xx1.ToString();
            Main.Value = 0;
        }

        private void x2_Click(object sender, EventArgs e)
        {
            sign.Text = "x^2";
            xx1 = Main.Value;
            main2.Text = xx1.ToString();
            Main.Value = 0;
            resultx = xx1 * xx1;
            Main.Value = resultx;
        }

        private void kX_Click(object sender, EventArgs e)
        {
            sign.Text = "x^(1/2)";
            xx1 = Main.Value;
            main2.Text = xx1.ToString();
            Main.Value = 0;
            double d = Math.Sqrt(decimal.ToDouble(xx1));
            resultx = Convert.ToDecimal(d);
            Main.Value = resultx;
        }

        private void n1delx_Click(object sender, EventArgs e)
        {
            sign.Text = "1/x";
            xx1 = Main.Value;
            main2.Text = xx1.ToString();
            Main.Value = 0;
            resultx = 1/xx1;
            Main.Value = resultx;
        }

        private void sign_Click(object sender, EventArgs e)
        {

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            xx1 = 0;
            xx2 = 0;
            sign.Text = " ";
            Main.Value = 0;
            main2.Text = "";
        }

        private void Del_Click(object sender, EventArgs e)
        {
            if (sign.Text == " ")
            {
                xx1 = Math.Round(xx1 / 10, MidpointRounding.ToZero);
                Main.Value = xx1;
            }
            else if (sign.Text != " ")
            {
                xx2 = Math.Round(xx2 / 10, MidpointRounding.ToZero);
                Main.Value = xx2;
            }
            else if (sign.Text == "=")
            {
                xx2 = Math.Round(xx2 / 10, MidpointRounding.ToZero);
                Main.Value = xx2;
            }
        }

        private void more_info_Click(object sender, EventArgs e)
        {
            if (spanel == false)
            {
                sin.Visible = true;
                cos.Visible = true;
                tg.Visible = true;
                ctg.Visible = true;
                arcsin.Visible = true;
                arccos.Visible = true;
                arcsin.Visible = true;
                arcctg.Visible = true;
                arctg.Visible = true;
                pi.Visible = true;

                sin.Enabled = true;
                cos.Enabled = true;
                tg.Enabled = true;
                ctg.Enabled = true;
                arcsin.Enabled = true;
                arccos.Enabled = true;
                arcsin.Enabled = true;
                arcctg.Enabled = true;
                arctg.Enabled = true;
                pi.Enabled = true;

                spanel = true;
            }else if (spanel)
            {
                sin.Visible = false;
                cos.Visible = false;
                tg.Visible = false;
                ctg.Visible = false;
                arcsin.Visible = false;
                arccos.Visible = false;
                arcsin.Visible = false;
                arcctg.Visible = false;
                arctg.Visible = false;
                pi.Visible = false;

                sin.Enabled = false;
                cos.Enabled = false;
                tg.Enabled = false;
                ctg.Enabled = false;
                arcsin.Enabled = false;
                arccos.Enabled = false;
                arcsin.Enabled = false;
                arcctg.Enabled = false;
                arctg.Enabled = false;
                pi.Enabled = false;
                spanel = false;
            }
            
        }

        private void sin_Click(object sender, EventArgs e)
        {
            sign.Text = "sin";
            xx1 = Main.Value;
            main2.Text = xx1.ToString();
            Main.Value = 0;
            double d = Math.Sin(decimal.ToDouble(xx1));
            resultx = Convert.ToDecimal(d);
            Main.Value = resultx;
            xx1 = Math.Round(xx1 * 100) / 100;
            resultx = Math.Round(resultx * 100) / 100;
            history.Items.Add(sign.Text + "(" + xx1 + ") = " + resultx);
        }

        private void cos_Click(object sender, EventArgs e)
        {
            sign.Text = "cos";
            xx1 = Main.Value;
            main2.Text = xx1.ToString();
            Main.Value = 0;
            double d = Math.Cos(decimal.ToDouble(xx1));
            resultx = Convert.ToDecimal(d);
            Main.Value = resultx;
            xx1 = Math.Round(xx1 * 100) / 100;
            resultx = Math.Round(resultx * 100) / 100;
            history.Items.Add(sign.Text + "(" + xx1 + ") = " + resultx);
        }

        private void tg_Click(object sender, EventArgs e)
        {
            sign.Text = "tg";
            xx1 = Main.Value;
            main2.Text = xx1.ToString();
            Main.Value = 0;
            double d = Math.Tan(decimal.ToDouble(xx1));
            resultx = Convert.ToDecimal(d);
            Main.Value = resultx;
            xx1 = Math.Round(xx1 * 100) / 100;
            resultx = Math.Round(resultx * 100) / 100;
            history.Items.Add(sign.Text + "(" + xx1 + ") = " + resultx);
        }

        private void ctg_Click(object sender, EventArgs e)
        {
            sign.Text = "ctg";
            xx1 = Main.Value;
            main2.Text = xx1.ToString();
            Main.Value = 0;
            double d = 1/Math.Tan(decimal.ToDouble(xx1));
            resultx = Convert.ToDecimal(d);
            Main.Value = resultx;
            xx1 = Math.Round(xx1 * 100) / 100;
            resultx = Math.Round(resultx * 100) / 100;
            history.Items.Add(sign.Text + "(" + xx1 + ") = " + resultx);
        }

        private void arcsin_Click(object sender, EventArgs e)
        {
            sign.Text = "arcsin";
            xx1 = Main.Value;
            main2.Text = xx1.ToString();
            Main.Value = 0;
            double d = Math.Asin(decimal.ToDouble(xx1));
            resultx = Convert.ToDecimal(d);
            Main.Value = resultx;
            xx1 = Math.Round(xx1 * 100) / 100;
            resultx = Math.Round(resultx * 100) / 100;
            history.Items.Add(sign.Text + "(" + xx1 + ") = " + resultx);
        }

        private void arccos_Click(object sender, EventArgs e)
        {
            sign.Text = "arccos";
            xx1 = Main.Value;
            main2.Text = xx1.ToString();
            Main.Value = 0;
            double d = Math.Acos(decimal.ToDouble(xx1));
            resultx = Convert.ToDecimal(d);
            Main.Value = resultx;
            xx1 = Math.Round(xx1 * 100) / 100;
            resultx = Math.Round(resultx * 100) / 100;
            history.Items.Add(sign.Text + "(" + xx1 + ") = " + resultx);
        }

        private void arctg_Click(object sender, EventArgs e)
        {
            sign.Text = "arctg";
            xx1 = Main.Value;
            main2.Text = xx1.ToString();
            Main.Value = 0;
            double d = 1/Math.Atan(decimal.ToDouble(xx1));
            resultx = Convert.ToDecimal(d);
            Main.Value = resultx;
            xx1 = Math.Round(xx1 * 100) / 100;
            resultx = Math.Round(resultx * 100) / 100;
            history.Items.Add(sign.Text + "(" + xx1 + ") = " + resultx);
        }

        private void arcctg_Click(object sender, EventArgs e)
        {
            sign.Text = "arcctg";
            xx1 = Main.Value;
            main2.Text = xx1.ToString();
            Main.Value = 0;
            double d = Math.Atan(decimal.ToDouble(xx1));
            resultx = Convert.ToDecimal(d);
            Main.Value = resultx;
            xx1 = Math.Round(xx1 * 100) / 100;
            resultx = Math.Round(resultx * 100) / 100;
            history.Items.Add(sign.Text + "(" + xx1 + ") = " + resultx);
        }

        private void pi_Click(object sender, EventArgs e)
        {
            xx1 = Convert.ToDecimal(Math.PI);
            Main.Value = xx1;
            sign.Text = "pi";
        }
    }
}
