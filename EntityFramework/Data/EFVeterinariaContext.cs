using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EntityFramework.Models;

namespace EntityFramework.Data
{
    public class EFVeterinariaContext : DbContext
    {
        public EFVeterinariaContext (DbContextOptions<EFVeterinariaContext> options)
            : base(options)
        {
        }

        public DbSet<EntityFramework.Models.Propietario> Propietario { get; set; } = default!;
    }
}
