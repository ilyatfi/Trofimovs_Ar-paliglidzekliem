using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Trofimovs_Ar_paliglidzekliem.Models;

namespace Trofimovs_Ar_paliglidzekliem.Data
{
    public class Trofimovs_Ar_paliglidzekliemContext : DbContext
    {
        public Trofimovs_Ar_paliglidzekliemContext (DbContextOptions<Trofimovs_Ar_paliglidzekliemContext> options)
            : base(options)
        {
        }

        public DbSet<Trofimovs_Ar_paliglidzekliem.Models.Product> Product { get; set; } = default!;
    }
}
