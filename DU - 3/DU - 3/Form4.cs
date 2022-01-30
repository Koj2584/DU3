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
    }
}
