using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Машины__гаражи__мойка
{
    internal class CarWash
    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public CarWash(string name, string adress) 
        {
            this.Name = name;
            this.Adress = adress;
        }

        public void Wash_Car(Car car)
        {
            if (car.IsClean == false)
                car.IsClean = true;
            else
                Console.WriteLine("Машина и так чистая!");
        }

        public void Wash_All_Cars(Garage garage)
        {
            foreach (Car car in garage.cars)
            {
                Wash_Car(car);
            }
        }
    }
}
