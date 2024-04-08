using System.Collections.Generic;
using System.Data.Entity;

namespace TPsema.Models
{
    
    public partial class ModelTP : DbContext
    {
        public ModelTP()
            : base("name=ModelTP1")
        {
        }

        public virtual DbSet<Customer> Customer { get; set; }
        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
    }
}