using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PR24_4
{
    public partial class Form1 : Form
    {
        private string Text;
        public Form1()
        {
            InitializeComponent();
        }

        private void открытьФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Text = File.ReadAllText("old.txt", Encoding.UTF8);
        }

        private void удалитьБуквыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;

            if (!string.IsNullOrEmpty(name))
            {
                string text = Text;

                foreach (char letter in name)
                {
                    text = text.Replace(letter.ToString(), "");
                }
                
                Text = text;
            }
            else
            {
                MessageBox.Show("Введите имя для удаления букв.");
            }
        }

        private void сохранитьФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string modifiedText = Text;

            if (!string.IsNullOrEmpty(modifiedText))
            {
                File.WriteAllText("new.txt", modifiedText, Encoding.UTF8);
                MessageBox.Show("Текст успешно записан в файл.");
            }
            else
            {
                MessageBox.Show("Текст отсутствует. Введите текст для сохранения.");
            }
        }
    }
}
