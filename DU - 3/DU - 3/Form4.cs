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
    public partial class Form4 : Form
    {
        Form parentForm;
        public Form4(Form opener)
        {
            InitializeComponent();
            parentForm = opener;
            this.FormClosing += Form_Closeing;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int lichych = 0, min = int.MaxValue, max = int.MinValue, soucin = 1, cifSoucet = 0;
                bool test = false;
                foreach (string x in textBox1.Lines)
                {
                    int y = int.Parse(x);
                    if (y % 2 != 0)
                        lichych++;
                    if (y < min)
                        min = y;
                    if (y > max)
                        max = y;
                    if (y >= 5 && y < 20)
                    {
                        soucin *= y;
                        test = true;
                    }
                }
                while(max>0)
                {
                    int cifra = max % 10;
                    max /= 10;
                    cifSoucet += cifra;
                }
                if(min==0&&max==0)
                    label3.Text = "Zadla jset pouze nuly";
                else if(!test)
                    label3.Text = "Min: " + min + "\nLichých čísel: " +lichych+ "\nCiferný součet max čísla: " + cifSoucet;
                else
                    label3.Text = "Min: " + min + "\nLichých čísel: " + lichych + "\nSoučin v intervalu: " + soucin + "\nCiferný součet max čísla: " + cifSoucet;
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
