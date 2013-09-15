using System.Linq;
using Domain;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test.Properties;
using UI;

namespace Test
{
    [TestClass]
    public class CarTests
    {
        [TestMethod]
        public void ShouldGetPrettyCars()
        {
            var context = new OurContext(Settings.Default.Connection);
            context.Set<Car>().Add(new Car() { Color = "Blue" });
            context.Set<Car>().Add(new Car() { Color = "Red" });
            context.SaveChanges();

            var service = new AstheticService();

            var results = service.GetPrettyCars();

            results.All(x => x.Color == "Red").Should().BeTrue();
            DeleteCars(context);
        }

        [TestMethod]
        public void ShouldGetUglyCars()
        {
            var service = new AstheticService();
            service.Cars = () => new[]
                {
                    new Car() { Color = "Orange" }, 
                    new Car() { Color = "Gray" }
                }.AsQueryable();

            var results = service.GetUglyCars();

            results.All(x => x.Color == "Orange").Should().BeTrue();

        }

        [TestMethod]
        public void ShouldGetMediocoreCars()
        {
            var service = new AstheticService();
            service.Cars = () => new[]
                {
                    new Car() { Color = "Orange" }, 
                    new Car() { Color = "Gray" }
                }.AsQueryable();
            var results = service.GetMediocoreCars();

            results.All(x => x.Color == "Gray").Should().BeTrue();

        }
        
        private void DeleteCars(OurContext context)
        {
            foreach (var result in context.Set<Car>())
            {
                context.Set<Car>().Remove(result);
            }
            context.SaveChanges();
        }
    }
}