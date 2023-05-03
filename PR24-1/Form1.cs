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

namespace PR24_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string folderPath = textBox1.Text;

            if (Directory.Exists(folderPath))
            {
                listView1.Items.Clear();

                string[] directories = Directory.GetDirectories(folderPath);
                foreach (string directory in directories)
                {
                    DirectoryInfo dirInfo = new DirectoryInfo(directory);
                    ListViewItem item = new ListViewItem(dirInfo.Name);
                    item.SubItems.Add(dirInfo.LastWriteTime.ToString());
                    item.SubItems.Add("Folder");
                    listView1.Items.Add(item);
                }

                string[] files = Directory.GetFiles(folderPath);
                foreach (string file in files)
                {
                    FileInfo fileInfo = new FileInfo(file);
                    ListViewItem item = new ListViewItem(fileInfo.Name);
                    item.SubItems.Add(fileInfo.LastWriteTime.ToString());
                    item.SubItems.Add(fileInfo.Extension);
                    listView1.Items.Add(item);
                }

                MessageBox.Show($"Count of programming languages:{checkedListBox1.CheckedItems.Count}");
            }
            else
            {
                MessageBox.Show("Папка не существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] programmingLanguages = { "C#", "Java", "Python", "C++", "JavaScript", "Ruby", "Go", "Swift", "Kotlin" };

            foreach (string language in programmingLanguages)
            {
                checkedListBox1.Items.Add(language);
            }
        }
    }
}
