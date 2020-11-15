using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.Entities.Abstractions;

namespace WindowsFormsApp2.Entities
{
    public class CarFactory : IToyFactory
    {
        public Toy Createnew()
        {
            return new Car();
        }
    }
}
