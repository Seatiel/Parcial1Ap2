using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Parcial1Ap2.Models
{
    public class Parcial1Ap2Context : DbContext
    {
        public Parcial1Ap2Context (DbContextOptions<Parcial1Ap2Context> options)
            : base(options)
        {
        }

        public DbSet<Parcial1Ap2.Models.Clientes> Clientes { get; set; }

    }
}
