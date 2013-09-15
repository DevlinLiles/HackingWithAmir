using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using UI.Properties;

namespace UI
{
    public class AstheticService
    {
        private readonly Cars _cars;

        public AstheticService()
        {
            Cars = CarsFunction;
            _cars = new Cars();
        }

        public IEnumerable<Car> GetPrettyCars()
        {
            return _cars.GetCarByColor("Red");
        }

        public IEnumerable<Car> GetUglyCars()
        {
            return _cars.GetCarByColor("Orange");
        }

        public IEnumerable<Car> GetMediocoreCars()
        {
            return _cars.GetCarByColor("Gray");
        }

        public Func<IQueryable<Car>> Cars { get; set; }

        public IQueryable<Car> CarsFunction()
        {
            return _cars.All();
        }
    }
}
