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
    public partial class Form2 : Form
    {
        Form parentForm;
        private static Random rng = new Random();

        public Form2(Form opener)
        {
            InitializeComponent();
            parentForm = opener;
            this.FormClosing += Form_Closeing;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(textBox1.Text);
                if (n < 1)
                    int.Parse("error");
                int min = int.MaxValue;
                int pocetMin = 0;
                int poziceMin = 0;
                int max = int.MinValue;
                int pocetMax = 0;
                int poziceMax = 0;
                int soucet = 0;
                listBox1.Items.Clear();
                for(int i = 1; i <= n; i++)
                {
                    int x = rng.Next(-15, 60);
                    if(x<min)
                    {
                        min = x;
                        pocetMin = 0;
                        poziceMin = i;
                    }
                    if(x>max)
                    {
                        max = x;
                        pocetMax = 0;
                        poziceMax = i;
                    }
                    if (x == min)
                    {
                        pocetMin++;
                    }
                    if (x == max)
                    {
                        pocetMax++;
                        poziceMax = i;
                    }
                    soucet += x;
                    listBox1.Items.Add(x);
                }
                label3.Text = "Min: " + min + " na pozici " + poziceMin + "\nPočet min: " + pocetMin + "\nMax: " + max + " na pozici " + poziceMax + "\nPočet max: " + pocetMax
                    + "\nA průměr bez min a max: " + Math.Round(((double)(soucet-max*pocetMax-min*pocetMin)/(n-pocetMin-pocetMax)),2);
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
