using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Машины__гаражи__мойка
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car bmw = new Car("BMW X5", "3 литра дизель", false);
            Car audi = new Car("AUDI RS6", "600 сил пушка гонка", true);
            Car porcshe = new Car("PORSCHE Panamera", "Turbo S ратататататата", false);

            Garage garage1 = new Garage("Гараж Михалыча");
            garage1.cars.Add(bmw);
            garage1.cars.Add(audi);
            garage1.cars.Add(porcshe);

            Car lada = new Car("LADA Niva", "Снегоболотоход", false);
            Car lifan = new Car("LIFAN Solano", "Хоть бы по дороге не развалилась", false);
            Car daewoo = new Car("DAEWOO Nexia", "Доставка плова", false);

            Garage garage2 = new Garage("Гараж Петровича");
            garage2.cars.Add(lada);
            garage2.cars.Add(lifan);
            garage2.cars.Add(daewoo);

            CarWash carwash1 = new CarWash("Мойка Сидоровича", "Ул. Кукуева 6");

            // машины до мойки
            garage1.Show_Cars();
            garage2.Show_Cars();


            Console.WriteLine();
            carwash1.Wash_Car(porcshe);
            carwash1.Wash_All_Cars(garage2);

            garage1.Show_Cars();
            garage2.Show_Cars();

            Console.ReadLine();
        }
    }
}
