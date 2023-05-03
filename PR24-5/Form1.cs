using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR24_5
{
    public partial class Form1 : Form
    {
        private int[] array = new int[] { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };

        public Form1()
        {
            InitializeComponent();
        }

        private void выполнитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int d = Convert.ToInt32(textBox1.Text);
            int c = Convert.ToInt32(textBox2.Text);

            int sum = array.Where(x => x < d).Sum();

            int count = array.Where((x, index) => index % 2 == 0 && x > c).Count();

            MessageBox.Show($"Сумма чисел меньших {d}: {sum}\n" +
                            $"Количество чисел на четных местах больших {c}: {count}");
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            array = null;
            listView1.Items.Clear();
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var item in array)
            {
                listView1.Items.Add(item.ToString());
            }
        }
    }
}
