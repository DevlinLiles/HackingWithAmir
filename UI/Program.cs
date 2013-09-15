using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Logging;
using Common.Logging.Simple;
using DataAccess;
using Domain;
using Highway.Data;
using UI.Properties;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            var repo = new Repository(new DataContext(Settings.Default.Connection, new Mappings(), new ConsoleOutLogger("Test",LogLevel.All, true,true,true,string.Empty)));

            var car = new Car();

            repo.Context.Add(car);

            var changes = repo.Context.Commit();

            Console.WriteLine(changes);
            Console.ReadKey();
        }
    }

    internal class Mappings : IMappingConfiguration
    {
        public void ConfigureModelBuilder(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>();
        }
    }
}
