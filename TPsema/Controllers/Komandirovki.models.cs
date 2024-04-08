using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using TPsema.Models;

namespace TPsema.Models
{
    public partial class KomandirovkiDB : DbContext
    {
        public KomandirovkiDB()
            : base("name=KomandirovkiDB")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        private DbSet<Customer> customer;

        public virtual DbSet<Customer> GetCustomer()
        {
            return customer;
        }

        public virtual void SetCustomer(DbSet<Customer> value)
        {
            customer = value;
        }
    }
}

