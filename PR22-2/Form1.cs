using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR22_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int n = 23;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(10 + n, 10 + n);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Application.Exit();
            }
            else if (radioButton2.Checked)
            {
                tabControl1.SelectedTab = tabPage1;
            }
            else
            {
                MessageBox.Show("Select Radio Button");
            }
        }
    }
}
