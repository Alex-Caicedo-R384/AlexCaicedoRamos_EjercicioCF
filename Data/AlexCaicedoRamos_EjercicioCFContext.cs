using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AlexCaicedoRamos_EjercicioCF.Models;

namespace AlexCaicedoRamos_EjercicioCF.Data
{
    public class AlexCaicedoRamos_EjercicioCFContext : DbContext
    {
        public AlexCaicedoRamos_EjercicioCFContext (DbContextOptions<AlexCaicedoRamos_EjercicioCFContext> options)
            : base(options)
        {
        }

        public DbSet<AlexCaicedoRamos_EjercicioCF.Models.Burger> Burger { get; set; } = default!;
    }
}
