using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarCRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace CarCRUD.DbContexts
{
    public class CarPartsDbContext : DbContext
    {
        public CarPartsDbContext(DbContextOptions<CarPartsDbContext> options) : base(options) { }
        public DbSet<CarPart> CarParts { get; set; }

    }
}
