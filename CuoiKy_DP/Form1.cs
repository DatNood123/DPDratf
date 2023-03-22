using CuoiKy_DP.DataObject;
using CuoiKy_DP.DataObject.Colors;
using CuoiKy_DP.DataObject.TypeCar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuoiKy_DP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bF_Click(object sender, EventArgs e)
        {
            
            Wheel w = new Wheel(1111, "1", "b");
            var c = (Wheel)w.Clone();
            //MessageBox.Show(c.size.ToString());
            //Console.WriteLine(c.size.ToString());
            Engine engine = new Engine(10, "Md", "10.2");
            CarColor color = new WhiteColor();
            
            GasolineCar car = new GasolineCar(w, engine, color, "GB", "Sedan", 1000, 0, "A95");
            GasolineCar car2 = (GasolineCar) car.Clone();

            /*
            MessageBox.Show(car.gearBox.GetHashCode().ToString());
            car.gearBox = "GBB";
            MessageBox.Show(car2.gearBox.GetHashCode().ToString());
            */
        }
    }
}
