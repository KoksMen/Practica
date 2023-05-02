using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR23_3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.pictureBox1.Image = Image.FromFile(@"C:\Users\rinsh\Pictures\Screenshots\Снимок экрана 2023-04-29 095516.png");
            form1.button1.Enabled = false;
            form1.Show();
            this.Hide();
        }
    }
}
