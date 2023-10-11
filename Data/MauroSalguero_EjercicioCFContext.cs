using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MauroSalguero_EjercicioCF.Models;

namespace MauroSalguero_EjercicioCF.Data
{
    public class MauroSalguero_EjercicioCFContext : DbContext
    {
        public MauroSalguero_EjercicioCFContext (DbContextOptions<MauroSalguero_EjercicioCFContext> options)
            : base(options)
        {
        }

        public DbSet<MauroSalguero_EjercicioCF.Models.Burger> Burger { get; set; } = default!;
    }
}
