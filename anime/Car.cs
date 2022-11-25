using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anime
{
    internal class Car
    {
        public string mark;
        public int power;
        public int year;
        public Car(string mark_input = "", int power_input = 0, int year_input = 0)
        {
            this.mark = mark_input;
            this.power = power_input;
            this.year = year_input;
        }
        public override string ToString()
        {
            return $"mark - {mark}, power - {power}, year - {year}";
        }
    }
}
