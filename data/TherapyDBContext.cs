using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using therapyDB.data.model;

namespace therapyDB
{
    public class TherapyDBContext : DbContext
    {
        public TherapyDBContext() : base ("name=therapyDB.DatabaseConnectionString")
        {
        }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<Address> Addresses { get; set; }

        // This method adds the parameter class to it's DbSet and then saves the changes to the database
        public void Add<T>(T data) where T : class
        {
            Set<T>().Add(data);
            SaveChanges();
        }

        // This method removes the parameter class from it's DbSet and then saves the changes to the database
        public void Delete<T>(T data) where T : class
        {
            var entry = Entry(data);

            if (entry.State == EntityState.Detached)
            {
                Set<T>().Attach(data);
            }

            Set<T>().Remove(data);
            SaveChanges();
        }
    }
}
