using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Машины__гаражи__мойка
{
    internal class Car
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsClean { get; set; }
        public Car(string name, string description, bool isclean) 
        {
            this.Name = name;
            this.Description = description;
            this.IsClean = isclean;
        }
    }
}
