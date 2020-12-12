using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_11_12
{
    public partial class Form4 : Form
    {
        public Form4(Form f)
        {
            InitializeComponent();

            List<string> states = new List<string>
        {
            "Сайты", "Игры", "Программы", "Работа с данными", "Скрипты"

        };

            // добавляем список элементов
            domainUpDown1.Items.AddRange(states);
            domainUpDown2.Items.AddRange(states);
            domainUpDown3.Items.AddRange(states);
            domainUpDown4.Items.AddRange(states);
            domainUpDown5.Items.AddRange(states);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form4 newForm = new Form4(this);
            newForm.Close();
        }
    }

}

