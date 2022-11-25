using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anime
{
    internal class PassengerCar : Car
    {
        public int quantity_of_passengers;
        public Dictionary<string, int> repair_book = new Dictionary<string, int>();
        public PassengerCar(int quantity_of_passengers = 0) : base()
        {
            this.quantity_of_passengers = quantity_of_passengers;
        }

        public void Add_to_book(string spare_part, int year_of_repair)
        {
            repair_book.Add(spare_part, year_of_repair);
        }

        public void Show_the_year(string name_of_part)
        {
            Console.WriteLine($"Year_of_change for {name_of_part} => {repair_book[name_of_part]}");
        }

        public void Show_history()
        {
            foreach (var pair in repair_book)
            {
                Console.WriteLine($"Part - {pair.Key}, year - {pair.Value}");
            }
        }

        public override string ToString()
        {
            return $"{mark} {power} {year} {quantity_of_passengers}";
        }
    }
}
