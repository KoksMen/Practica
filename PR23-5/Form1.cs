using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR23_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            Form2 form2 = new Form2();
            form2.label1.Text = $"Result is: {(Math.Pow(x, 2) + x) / (x - 2)}";
            form2.Show();
            this.Hide();
        }
    }
}
