using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopAuto
{
    public class HatchBack : Shop
    {
        public HatchBack() { }
        public HatchBack(string Name, int MaxSpeed, int Cost, double Discount)
        : base(Name, MaxSpeed, Cost, Discount)
        { }
        public void Inf()
        {
            MessageBox.Show("Тип хэтч-бэк",this.ToString());
        }
    }
}
