using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anime
{
    internal class Truck : Car
    {
        public int max_load_capacity;
        public string name;
        public Dictionary<string, int> current_load = new Dictionary<string, int>();

        public Truck(int max_load_capacity = 0, string name = "") : base()
        {
            this.max_load_capacity = max_load_capacity;
            this.name = name;
        }

        public void change_name(string new_name)
        {
            Console.WriteLine("Сменили имя!");
            this.name = new_name;
        }

        public void Add_load(string name, int weight)
        {
            current_load.Add(name, weight);
        }

        public void Delete_load(string name)
        {
            current_load.Remove(name);
        }

        public void Show_load()
        {
            foreach (var item in current_load)
            {
                Console.WriteLine($"Part - {item.Key}, year - {item.Value}");
            }
        }

        public override string ToString()
        {
            return $"{mark} {power} {year} {name} {max_load_capacity}";
        }
    }
}
