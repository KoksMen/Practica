using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR23_1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty && textBox2.Text != string.Empty)
            {
                string login = textBox1.Text;
                string password = textBox2.Text;

                if (password == "12345")
                {
                    Form1 form1 = new Form1() { Text = login };
                    form1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Password");
                }
            }
        }
    }
}
