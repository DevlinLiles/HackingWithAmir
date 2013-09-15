using System.Data.Entity;
using Domain;

namespace UI
{
    public class OurContext : DbContext
    {
        public OurContext(string connection) : base(connection)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>();
        }
    }
}