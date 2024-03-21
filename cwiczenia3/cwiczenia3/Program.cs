using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cwiczenia3.Containers;
using cwiczenia3.Ships;
namespace cwiczenia3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ship ship = new Ship(100.0, 5, 1000);
            LiquidContainer lc = new LiquidContainer(100, 5, 5, 5, 'C',150, "biezpieczny");
            GasContainer gc = new GasContainer(100, 5,,5,'D',150,50.0);
            CoolingContainer cc = new CoolingContainer(100, 10, 7, 8, 150, PossibleProducts.Bananas, 50);
            ship.LoadContainer(lc);
            ship.LoadContainer(gc);
            ship.newLiquidContainer(5, 10, 8, 'C', 200, "niebezpieczny");


        }

    }
}
