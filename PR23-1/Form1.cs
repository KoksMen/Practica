using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR23_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetupForm();
        }

        private void SetupForm()
        {
            StartPosition = FormStartPosition.CenterScreen;

            Opacity = 0.85;

            BackColor = Color.Green; 

            Text = "Nishpor";
        }

    

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            var rand = new Random();
            var newX = rand.Next(0, ClientSize.Width - (sender as Button).Width);
            var newY = rand.Next(0, ClientSize.Height - (sender as Button).Height);

            (sender as Button).Location = new Point(newX, newY);
        }
    }
}
