using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Car : Entity
    {
        public ICollection<Wheel> Wheels { get; set; }
        public string VIN { get; set; }
        public string Color { get; set; }
    }
}
