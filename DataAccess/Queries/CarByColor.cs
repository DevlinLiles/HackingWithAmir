using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Highway.Data;

namespace DataAccess.Queries
{
    public class CarByColor : Scalar<Car>
    {
        public CarByColor(string color)
        {
            ContextQuery = c => c.AsQueryable<Car>().SingleOrDefault(x => x.Color == color);
        }

    }
}
