using System.Collections.Generic;
using System.Linq;
using Domain;
using UI.Properties;

namespace UI
{
    public class Cars
    {
        private OurContext _context;

        public Cars()
        {
            _context = new OurContext(Settings.Default.Connection);
        }

        public IEnumerable<Car> GetCarByColor(string color)
        {
            return All().Where(x => x.Color == color);
        }

        public IQueryable<Car> All()
        {
            return _context.Set<Car>();
        }
    }
}