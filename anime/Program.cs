using anime;

namespace Lessons
{
    class Program
    {
        static void Main(string[] args)
        {
            Autopark Nekitas_help = new Autopark("ya el gvozdi");
            PassengerCar car1 = new PassengerCar() { mark = "Uas", power = 360, year = 2001, quantity_of_passengers = 4 };
            PassengerCar car2 = new PassengerCar() { mark = "hammer", power = 500, year = 2005, quantity_of_passengers = 5};
            Truck truck1 = new Truck() { mark = "KAMAZ", power = 1000, year = 2006, name = "Vasiliy Ivanovich", max_load_capacity = 200};
            Truck truck2 = new Truck() { mark = "KAMAZ", power = 1100, year = 2008, name = "Nikita Tvar", max_load_capacity = 200 };
            Nekitas_help.cars.Add(car1);
            Nekitas_help.cars.Add(car2);
            Nekitas_help.cars.Add(truck1);
            Nekitas_help.cars.Add(truck2);
            Console.WriteLine(Nekitas_help);
        }
    }
}

