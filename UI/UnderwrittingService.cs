using System.Collections.Generic;
using Domain;

namespace UI
{
    public class UnderwrittingService
    {
        private Cars _cars;

        public UnderwrittingService()
        {
            _cars = new Cars();
        }
        public IEnumerable<Car> HighRiskCars()
        {
            return _cars.GetCarByColor("Red");
        }
    }
}