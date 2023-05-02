using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR22_1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var path = new GraphicsPath();

            path.AddEllipse(0, 0, 500, 500);
            Region = new Region(path);
            Button closeButton = new Button();
            closeButton.Text = "Закрыть";
            closeButton.Size = new Size(80, 30);
            closeButton.Location = new Point(200, 215);
            closeButton.Click += CloseButton_Click;
            Controls.Add(closeButton);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
