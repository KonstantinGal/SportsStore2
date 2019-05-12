using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportsStore2.Domain.Entities;

namespace SportsStore2.Domain.Concrete
{
    class EFDbContext : System.Data.Entity.DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
