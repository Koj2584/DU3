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
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int lichych = 0, min = int.MaxValue, max = int.MinValue, soucin = 1; ;
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
                        soucin *= y;
                }
                label3.Text = 
            }
            catch
            {

            }
        }
    }
}
