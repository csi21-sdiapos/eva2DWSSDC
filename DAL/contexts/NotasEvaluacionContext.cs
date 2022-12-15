using DAL.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.contexts
{
    public class NotasEvaluacionContext : DbContext
    {
        public NotasEvaluacionContext(DbContextOptions<NotasEvaluacionContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseSerialColumns();
        }

        public DbSet<Notas> SetNotas { get; set; }
        public DbSet<Evaluacion> SetEvaluaciones { get; set; }
    }
}
