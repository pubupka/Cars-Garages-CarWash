using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Машины__гаражи__мойка
{
    internal class Garage
    {
        private string name;
        public List<Car> cars;

        public Garage(string name)
        {
            this.name = name;
            this.cars = new List<Car>();
        }

        public void Show_Cars()
        {
            Console.WriteLine(this.name);
            Console.WriteLine();

            foreach (Car car in this.cars)
            {
                if(car.IsClean)
                    Console.WriteLine($"{car.Name}: {car.Description}. Чистая");
                else
                    Console.WriteLine($"{car.Name}: {car.Description}. Грязная");
            }

            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
