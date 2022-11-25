using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anime
{
    internal class Autopark
    {
        public string name;
        public List<Car> cars = new List<Car>();

        public Autopark(string name = "") : base()
        {
            this.name = name;
            Console.WriteLine($"Автопарк {name}");
        }

        public override string ToString()
        {
            string res = "";
            foreach (var item in cars)
            {
                res += $"{item.ToString()}\n";
            }
            return res;
        }
    }
}
