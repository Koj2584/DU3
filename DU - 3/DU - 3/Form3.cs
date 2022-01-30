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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(textBox1.Text);
                
                listBox1.Items.Clear();
                for (int i = 1; i <= n; i++)
                {
                    int x = rng.Next(-15, 60);
                    
                    listBox1.Items.Add(x);
                }
                label3.Text = "";
            }
            catch
            {
                MessageBox.Show("Neplatný počet čísel!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
