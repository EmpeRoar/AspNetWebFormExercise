using JBX.DataModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace JBX.EF
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base("AspNetWebFormsExercise")
        {
            this.Database.Connection.ConnectionString = "Data Source=LAP0148;Initial Catalog=AspNetWebFormsCnx;Integrated Security=True";
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
