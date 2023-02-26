using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Be.Models;

namespace Be.Data
{
    public class BancoDados : DbContext
    {
        public BancoDados (DbContextOptions<BancoDados> options)
            : base(options)
        {
        }

        public DbSet<Be.Models.Filme> Filme { get; set; } = default!;
    }
}
