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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PR22_4
{
    public partial class Form1 : Form
    {
        private List<Ship> shipList;
        public Form1()
        {
            InitializeComponent();
            shipList = ShipFileManager.ReadShipsFromFile();
            UpdateObjectListBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string shipName = comboBox1.Text;
            int shipCount = (int)numericUpDown1.Value;

            if (shipList.Find(x => x.ShipName == shipName) != null)
            {
                domainUpDown1.Text = shipList.Find(x => x.ShipName == shipName).ShipName;
                numericUpDown1.Text = Convert.ToString(shipList.Find(x => x.ShipName == shipName).ShipCount);
            }
            else if (shipList.Find(x => x.ShipName == shipName) == null)
            {
                Ship newship = new Ship() { ShipName = domainUpDown1.Text, ShipCount = Convert.ToInt32(numericUpDown1.Text) };
                shipList.Add(newship);

                UpdateObjectListBox();
                ShipFileManager.AddShipToFile(newship);
            }
        }

        private void UpdateObjectListBox()
        {
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(shipList.ToArray());
        }
    }

    public class Ship
    {
        public string ShipName;
        public int ShipCount;

        public override string ToString()
        {
            return ShipName;
        }
    }

    public class ShipFileManager
    {
        private const string FilePath = "ships.txt";

        public static void AddShipToFile(Ship ship)
        {
            using (StreamWriter writer = new StreamWriter(FilePath, true))
            {
                writer.WriteLine($"{ship.ShipName},{ship.ShipCount}");
            }
        }

        public static List<Ship> ReadShipsFromFile()
        {
            List<Ship> ships = new List<Ship>();

            using (StreamReader reader = new StreamReader(FilePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 2)
                    {
                        Ship ship = new Ship
                        {
                            ShipName = parts[0],
                            ShipCount = int.Parse(parts[1])
                        };
                        ships.Add(ship);
                    }
                }
            }

            return ships;
        }
    }
}
