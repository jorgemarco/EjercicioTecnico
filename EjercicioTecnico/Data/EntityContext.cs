using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EjercicioTecnico.Models;

namespace EjercicioTecnico.Data
{
    public class EntityContext : DbContext
    {
        public EntityContext (DbContextOptions<EntityContext> options)
            : base(options)
        {
        }

        public DbSet<EjercicioTecnico.Models.Cliente> Cliente { get; set; }

        public DbSet<EjercicioTecnico.Models.Pais> Pais { get; set; }

        public DbSet<EjercicioTecnico.Models.Tipo> Tipo { get; set; }
    }
}
