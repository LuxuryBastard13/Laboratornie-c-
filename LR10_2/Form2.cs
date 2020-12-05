using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR10_2
{
    public partial class Form2 : Form
    {
        

        public Form2(Form1 f)
        {
            InitializeComponent();
            f.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 newForm = new Form3(this);
            newForm.ShowDialog();
        }
    }
}
