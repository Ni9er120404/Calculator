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
            richTextBox1.Text += " ";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "0";
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "0";
            }
            else
            {
                richTextBox1.Text += "-";
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
                richTextBox1.AppendText("1");
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
                richTextBox1.AppendText("2");
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
                richTextBox1.AppendText("3");
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
                richTextBox1.AppendText("4");
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
                richTextBox1.AppendText("5");
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
                richTextBox1.AppendText("6");
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
                richTextBox1.AppendText("7");
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
                richTextBox1.AppendText("8");
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
                richTextBox1.AppendText("9");
            }
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "")
            {
                MessageBox.Show("Ошибка");
            }
            else
            {
                Calculator calculator = new Calculator(richTextBox1.Text);
                textBox1.Text = calculator.vs[0].ToString();
                textBox2.Text = calculator.vs[1].ToString();
                textBox3.Text = calculator.vs[2].ToString();
                textBox4.Text = calculator.vs[3].ToString();
                textBox5.Text = calculator.vs[4].ToString();
                textBox6.Text = calculator.vs[5].ToString();
                textBox7.Text = calculator.vs[6].ToString();
                textBox8.Text = calculator.vs[7].ToString();
                textBox9.Text = calculator.vs[8].ToString();
                textBox10.Text = calculator.vs[9].ToString();
                textBox11.Text = calculator.vs[10].ToString();
                textBox12.Text = calculator.vs[11].ToString();
                richTextBox2.Text = $"x = {calculator.x}\t y = {calculator.y}\t z = {calculator.z}";
            }
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void RichTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }

    internal class Calculator
    {
        public float[] vs = new float[12];
        public float x;
        public float y;
        public float z;
        public Calculator(string str_1)
        {
            string[] strArr = str_1.Split(' ');
            for (int i = 0; i < strArr.Length; i++)
            {
                vs[i] = int.Parse(strArr[i]);
            }
            float a1 = vs[0];
            float b1 = vs[1];
            float c1 = vs[2];
            float d1 = vs[3];
            float a2 = vs[4];
            float b2 = vs[5];
            float c2 = vs[6];
            float d2 = vs[7];
            float a3 = vs[8];
            float b3 = vs[9];
            float c3 = vs[10];
            float d3 = vs[11];
            x = (float)((d1 * b2 * c3) + (b1 * c2 * d3) + (c1 * d2 * b3) - (c1 * b2 * d3) - (b1 * d2 * c3) - (d1 * c2 * b3)) / (float)((a1 * b2 * c3) + (b1 * c2 * a3) + (c1 * a2 * b3) - (c1 * b2 * a3) - (b1 * a2 * c3) - (a1 * c2 * b3));
            y = (float)((a1 * d2 * c3) + (c1 * a2 * d3) + (d1 * c2 * a3) - (c1 * d2 * a3) - (d1 * a2 * c3) - (a1 * c2 * d3)) / (float)((a1 * b2 * c3) + (b1 * c2 * a3) + (c1 * a2 * b3) - (c1 * b2 * a3) - (b1 * a2 * c3) - (a1 * c2 * b3));
            z = (float)((a1 * b2 * d3) + (b1 * d2 * a3) + (d1 * a2 * b3) - (d1 * b2 * a3) - (b1 * a2 * d3) - (a1 * d2 * b3)) / (float)((a1 * b2 * c3) + (b1 * c2 * a3) + (c1 * a2 * b3) - (c1 * b2 * a3) - (b1 * a2 * c3) - (a1 * c2 * b3));
            if (x == -0)
            {
                x = 0;
            }
            if (y == -0)
            {
                y = 0;
            }
            if (z == -0)
            {
                z = 0;
            }
            x.ToString();
            y.ToString();
            z.ToString();
        }
    }
}