using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR22_3
{
    public partial class Form1 : Form
    {
        private List<string> shipList;
        public Form1()
        {
            InitializeComponent();
            shipList = new List<string>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string shipName = comboBox1.Text;
            int shipCount;

            if (int.TryParse(textBox1.Text, out shipCount))
            {
                for (int i = 0; i < shipCount; i++)
                {
                    shipList.Add(shipName);
                }

                UpdateObjectListBox();
            }
            else
            {
                MessageBox.Show("Please enter a valid count.");
            }
        }

        private void UpdateObjectListBox()
        {
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(shipList.ToArray());
        }
    }
}
