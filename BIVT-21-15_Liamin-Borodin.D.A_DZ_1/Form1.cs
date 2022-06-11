using System;
using System.Windows.Forms;
namespace BIVT_21_15_Liamin_Borodin.D.A_DZ_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText(text: " ");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText(text: "0");
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "0";
            }
            else
            {
                richTextBox1.AppendText(text: "-");
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "0";
            }
            else
            {
                richTextBox1.AppendText(text: "1");
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "0";
            }
            else
            {
                richTextBox1.AppendText(text: "2");
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "0";
            }
            else
            {
                richTextBox1.AppendText(text: "3");
            }
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "0";
            }
            else
            {
                richTextBox1.AppendText(text: "4");
            }
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "0";
            }
            else
            {
                richTextBox1.AppendText(text: "5");
            }
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "0";
            }
            else
            {
                richTextBox1.AppendText(text: "6");
            }
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "0";
            }
            else
            {
                richTextBox1.AppendText(text: "7");
            }
        }
        private void Button12_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "0";
            }
            else
            {
                richTextBox1.AppendText(text: "8");
            }
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "0";
            }
            else
            {
                richTextBox1.AppendText(text: "9");
            }
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator(str_1: richTextBox1.Text);
            calculator.Result();
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void RichTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }

    internal class Calculator
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }
        public float[] Vs { get; set; } = new float[12];

        public Calculator(string str_1)
        {
            try
            {
                for (int i = 0; i < str_1.Split(' ').Length; i++)
                {
                    Vs[i] = int.Parse(((string[])str_1.Split(' '))[i]);
                }
            }
            catch (Exception) { }
            float a1 = Vs[0];
            float b1 = Vs[1];
            float c1 = Vs[2];
            float d1 = Vs[3];
            float a2 = Vs[4];
            float b2 = Vs[5];
            float c2 = Vs[6];
            float d2 = Vs[7];
            float a3 = Vs[8];
            float b3 = Vs[9];
            float c3 = Vs[10];
            float d3 = Vs[11];
            X = (float)((d1 * b2 * c3)
                        + (b1 * c2 * d3)
                        + (c1 * d2 * b3)
                        - (c1 * b2 * d3)
                        - (b1 * d2 * c3)
                        - (d1 * c2 * b3)) /
                (float)((a1 * b2 * c3)
                        + (b1 * c2 * a3)
                        + (c1 * a2 * b3)
                        - (c1 * b2 * a3)
                        - (b1 * a2 * c3)
                        - (a1 * c2 * b3));
            Y = (float)((a1 * d2 * c3)
                        + (c1 * a2 * d3)
                        + (d1 * c2 * a3)
                        - (c1 * d2 * a3)
                        - (d1 * a2 * c3)
                        - (a1 * c2 * d3)) / 
                (float)((a1 * b2 * c3)
                        + (b1 * c2 * a3)
                        + (c1 * a2 * b3)
                        - (c1 * b2 * a3)
                        - (b1 * a2 * c3)
                        - (a1 * c2 * b3));
            Z = (float)((a1 * b2 * d3)
                        + (b1 * d2 * a3)
                        + (d1 * a2 * b3)
                        - (d1 * b2 * a3)
                        - (b1 * a2 * d3)
                        - (a1 * d2 * b3)) / 
                (float)((a1 * b2 * c3)
                        + (b1 * c2 * a3)
                        + (c1 * a2 * b3)
                        - (c1 * b2 * a3)
                        - (b1 * a2 * c3)
                        - (a1 * c2 * b3));
            if (X == -0)
            {
                X = 0;
            }
            if (Y == -0)
            {
                Y = 0;
            }
            if (Z == -0)
            {
                Z = 0;
            }
            X.ToString();
            Y.ToString();
            Z.ToString();
        }
        public void Result()
        {
            string result = $"Сиситема уравненеий:\n\n"
                            + $"{Vs[0]}*x1 + {Vs[1]}*y1 + {Vs[2]} * z1 = {Vs[3]}\n"
                            + $"{Vs[4]}*x2 + {Vs[5]}*y2 + {Vs[6]} * z2 = {Vs[7]}\n"
                            + $"{Vs[8]}*x3 + {Vs[9]}*y3 + {Vs[10]} * z3 = {Vs[11]}\n\n"
                            + $"Ответ: X = {X}, Y = {Y}, Z = {Z}";
            MessageBox.Show(text: result);
        }
    }
}