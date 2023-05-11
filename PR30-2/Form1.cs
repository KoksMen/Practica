using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR30_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cookingBookDataSet.Products". При необходимости она может быть перемещена или удалена.
            this.productsTableAdapter.Fill(this.cookingBookDataSet.Products);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cookingBookDataSet.Dishs". При необходимости она может быть перемещена или удалена.
            this.dishsTableAdapter.Fill(this.cookingBookDataSet.Dishs);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cookingBookDataSet.CookingBook". При необходимости она может быть перемещена или удалена.
            this.cookingBookTableAdapter.Fill(this.cookingBookDataSet.CookingBook);

        }
    }
}
