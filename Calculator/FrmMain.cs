using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Calculator
{
    public partial class FrmMain : Form
    {
        public static List<char> inputStr = new List<char>(1000);
        public FrmMain()
        {
            InitializeComponent();
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            inputStr.Add('0');
            textBox1.AppendText("0");
        }

        private void BtnDot_Click(object sender, EventArgs e)
        {
            inputStr.Add('.');
            textBox1.AppendText(".");
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            inputStr.Add('1');
            textBox1.AppendText("1");
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            inputStr.Add('2');
            textBox1.AppendText("2");
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            inputStr.Add('3');
            textBox1.AppendText("3");
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            inputStr.Add('4');
            textBox1.AppendText("4");
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            inputStr.Add('5');
            textBox1.AppendText("5");
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            inputStr.Add('6');
            textBox1.AppendText("6");
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            inputStr.Add('7');
            textBox1.AppendText("7");
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            inputStr.Add('8');
            textBox1.AppendText("8");
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            inputStr.Add('9');
            textBox1.AppendText("9");
        }

        private void BtnLeft_Click(object sender, EventArgs e)
        {
            inputStr.Add('(');
            textBox1.AppendText("(");
        }

        private void BtnRig_Click(object sender, EventArgs e)
        {
            inputStr.Add(')');
            textBox1.AppendText(")");
        }

        List<double> iNums = new List<double>();
        private void BtnEqual_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("=");
            textBox2.Text = textBox1.Text;
            textBox1.Text = DataOp.DataMain();

            string temp = DataOp.DataMain();
            inputStr.Clear();
            for (int i = 0; i < temp.Length; i++)
            {
                inputStr.Add(temp[i]);
            }

            double temp1 = Convert.ToDouble(DataOp.DataMain());
            iNums.Add(temp1);
            Font font = new System.Drawing.Font("Arial", 9, FontStyle.Regular);
            Graphics graphics = CreateGraphics();
            Pen pen = new Pen(Brushes.Black, 2);
            graphics.DrawLine(pen, 80, 360, 720, 360);//X
            graphics.DrawLine(pen, 80, 360, 80, 30);//Y
            String[] n = { "1.0", "2.0", "3.0", "4.0", "5.0", "6.0", "7.0", "8.0", "9.0", "10.0" };
            int xb = 80;
            for (int i = 0; i < 10; i++)
            {
                graphics.DrawString(n[i].ToString(), font, Brushes.Red, xb, 360);
                xb = xb + 40;
            }
            String[] m = { "10", "9", "8", "7", "6", "5", "4", "3", "2", "1" };
            int y = 80;
            for (int i = 0; i < 10; i++)
            {
                graphics.DrawString(m[i].ToString(), font, Brushes.Red, 50, y);
                y = y + 30;
            }

            Graphics g = CreateGraphics();
            int x_s = 80;
            int y_s = 360;
            for (int i = 0; i < iNums.Count; i++)
            {
                int x1 = (int)iNums[i] + x_s + 40 * i;
                int y1 = y_s - i * 30;
                g.FillEllipse(Brushes.Black, x1, y1 - 5, 5, 5);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            inputStr.Add('+');
            textBox1.AppendText("+");
        }

        private void BtnSubt_Click(object sender, EventArgs e)
        {
            inputStr.Add('-');
            textBox1.AppendText("-");
        }

        private void BtnMul_Click(object sender, EventArgs e)
        {
            inputStr.Add('*');
            textBox1.AppendText("*");
        }

        private void BtnDivi_Click(object sender, EventArgs e)
        {
            inputStr.Add('/');
            textBox1.AppendText("/");
        }

        private void BtnCe_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            inputStr.Clear();
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                inputStr.RemoveAt(inputStr.Count - 1);
                textBox1.Text = "";
                for (int i = 0; i < inputStr.Count; i++)
                {
                    textBox1.Text += inputStr[i];
                }
            }
        }

    }
}
