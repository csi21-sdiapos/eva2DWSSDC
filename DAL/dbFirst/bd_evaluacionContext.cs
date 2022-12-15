using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DAL.dbFirst
{
    public partial class bd_evaluacionContext : DbContext
    {
        public bd_evaluacionContext()
        {
        }

        public bd_evaluacionContext(DbContextOptions<bd_evaluacionContext> options)
            : base(options)
        {
        }

        public virtual DbSet<EvaCatEvaluacion> EvaCatEvaluacions { get; set; } = null!;
        public virtual DbSet<EvaTchNotasEvaluacion> EvaTchNotasEvaluacions { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Pooling=true;Database=bd_evaluacion;UserId=postgres;Password=12345;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EvaCatEvaluacion>(entity =>
            {
                entity.HasKey(e => e.CodEvaluacion)
                    .HasName("eva_cat_evaluacion_pkey");

                entity.ToTable("eva_cat_evaluacion", "sc_evaluacion");

                entity.Property(e => e.CodEvaluacion)
                    .HasColumnType("character varying")
                    .HasColumnName("cod_evaluacion");

                entity.Property(e => e.DescEvaluacion)
                    .HasColumnType("character varying")
                    .HasColumnName("desc_evaluacion");
            });

            modelBuilder.Entity<EvaTchNotasEvaluacion>(entity =>
            {
                entity.HasKey(e => e.IdNotaEvaluacion)
                    .HasName("eva_tch_notas_evaluacion_pkey");

                entity.ToTable("eva_tch_notas_evaluacion", "sc_evaluacion");

                entity.Property(e => e.IdNotaEvaluacion).HasColumnName("id_nota_evaluacion");

                entity.Property(e => e.CodAlumno)
                    .HasColumnType("character varying")
                    .HasColumnName("cod_alumno");

                entity.Property(e => e.CodEvaluacion)
                    .HasColumnType("character varying")
                    .HasColumnName("cod_evaluacion");

                entity.Property(e => e.MdFch).HasColumnName("md_fch");

                entity.Property(e => e.MdUuid)
                    .HasColumnType("character varying")
                    .HasColumnName("md_uuid");

                entity.Property(e => e.NotaEvaluacion).HasColumnName("nota_evaluacion");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
