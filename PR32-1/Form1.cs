using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PR32_1
{
    public partial class Form1 : Form
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=CookiesDB;Integrated Security=True";
        private SqlConnection connection;
        private SqlDataAdapter dataAdapter;
        private DataSet dataSet;
        private DataTable dataTable;
        private SqlCommandBuilder commandBuilder;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();

            string selectQuery = "SELECT * FROM Dishes";

            dataAdapter = new SqlDataAdapter(selectQuery, connection);
            commandBuilder = new SqlCommandBuilder(dataAdapter);
            dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataTable = dataSet.Tables[0];

            dataGridView1.DataSource = dataTable;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            connection.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int RowIndex = dataGridView1.SelectedRows[0].Index;

                int rowIndex = dataGridView1.SelectedRows[0].Index;
                DataRow row = dataTable.Rows[rowIndex];

                row["DishType"] = textBox6.Text;
                row["DishWeight"] = textBox7.Text;
                row["PreparationOrder"] = textBox8.Text;
                row["CaloryCount"] = textBox9.Text;
                row["CarbCount"] = textBox10.Text;

                dataAdapter.Update(dataTable);
                MessageBox.Show("Изменение элемента успешно сохранено.");
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            DataRow newRow = dataTable.NewRow();
            dataTable.Rows.Add(new object[] { 0, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text});
            dataAdapter.Update(dataTable);
            MessageBox.Show("Добавление элемента успешно сохранено.");
            
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }

            dataAdapter.Update(dataTable);
            MessageBox.Show("Удаление элемента успешно сохранено.");
        }
    }
}
