using Microsoft.EntityFrameworkCore;
using AutoSystem.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace AutoSystem.Data
{
    public class FabricaContext : DbContext
    {
        public FabricaContext(DbContextOptions<FabricaContext> options) : base(options)
        {

        }
        public DbSet<Auto> Autos { get; set; }
    }
}
