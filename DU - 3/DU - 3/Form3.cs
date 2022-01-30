using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DU___3
{
    public partial class Form3 : Form
    {
        Form parentForm;
        private static Random rng = new Random();
        public Form3(Form opener)
        {
            InitializeComponent();
            parentForm = opener;
            this.FormClosing += Form_Closeing;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            try
            {
                int n = int.Parse(textBox1.Text);
                if (n < 1)
                    int.Parse("error");

                listBox1.Items.Clear();
                for (int i = 1; i <= n; i++)
                {
                    double x = rng.NextDouble() * 25 - 5;

                    listBox1.Items.Add(Math.Round(x, 2));
                    if (x > 2 && x <= 5)
                    {
                        label3.Text = "V posloupnosti je minimalně jedno číslo v intervalu (2,5>";
                        break;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Neplatný počet čísel!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            try
            {
                int n = int.Parse(textBox1.Text);
                if (n < 1)
                    int.Parse("error");
                bool interval = false;

                listBox1.Items.Clear();
                for (int i = 1; i <= n && !interval; i++)
                {
                    double x = rng.NextDouble() * 25 - 5;
                    if (x > 2 && x <= 5)
                        interval = true;

                    listBox1.Items.Add(Math.Round(x, 2));
                }
                if (interval)
                    label3.Text = "V posloupnosti je minimalně jedno číslo v intervalu (2,5>";
            }
            catch
            {
                MessageBox.Show("Neplatný počet čísel!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            try
            {
                int n = int.Parse(textBox1.Text);
                if (n < 1)
                    int.Parse("error");
                bool interval = false;
                int i = 1;

                listBox1.Items.Clear();
                while (i <= n && !interval)
                {
                    double x = rng.NextDouble() * 25 - 5;
                    if (x > 2 && x <= 5)
                        interval = true;

                    listBox1.Items.Add(Math.Round(x, 2));
                    i++;
                }
                if (interval)
                    label3.Text = "V posloupnosti je minimalně jedno číslo v intervalu (2,5>";
            }
            catch
            {
                MessageBox.Show("Neplatný počet čísel!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            try
            {
                int n = int.Parse(textBox1.Text);
                if (n < 1)
                    int.Parse("error");
                bool interval = false;
                int i = 1;

                listBox1.Items.Clear();
                do
                {
                    double x = rng.NextDouble() * 25 - 5;
                    if (x > 2 && x <= 5)
                        interval = true;

                    listBox1.Items.Add(Math.Round(x, 2));
                    i++;
                } while (i <= n && !interval);
                if (interval)
                    label3.Text = "V posloupnosti je minimalně jedno číslo v intervalu (2,5>";
            }
            catch
            {
                MessageBox.Show("Neplatný počet čísel!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Form_Closeing(object sender, FormClosingEventArgs e)
        {
            parentForm.Visible = true;
        }
    }
}
