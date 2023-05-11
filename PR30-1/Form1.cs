using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR30_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pR30LabaDataSet.Products". При необходимости она может быть перемещена или удалена.
            this.productsTableAdapter.Fill(this.pR30LabaDataSet.Products);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pR30LabaDataSet.Dishs". При необходимости она может быть перемещена или удалена.
            this.dishsTableAdapter.Fill(this.pR30LabaDataSet.Dishs);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pR30LabaDataSet.CookingBook". При необходимости она может быть перемещена или удалена.
            this.cookingBookTableAdapter.Fill(this.pR30LabaDataSet.CookingBook);
        }
    }
}
