using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Integra_I.Models;

namespace IntegraI.Models
{
    public class CelebracionContext : DbContext
    {
        public CelebracionContext (DbContextOptions<CelebracionContext> options)
            : base(options)
        {
        }

        public DbSet<Integra_I.Models.Celebracion> Celebracion { get; set; }
    }
}
