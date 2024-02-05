using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AnalizadorLexico.Models;

public partial class LexicoContext : DbContext
{
    public LexicoContext()
    {
    }

    public LexicoContext(DbContextOptions<LexicoContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Matriz> Matrizs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=chillywilly,49172; Database=Lexico; User Id=cheno; Password=cheno; TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Matriz>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("matriz");

            entity.Property(e => e.Ampersand).HasColumnName("ampersand");
            entity.Property(e => e.Arroba).HasColumnName("arroba");
            entity.Property(e => e.Asterisco).HasColumnName("asterisco");
            entity.Property(e => e.Backslash).HasColumnName("backslash");
            entity.Property(e => e.Diagonal).HasColumnName("diagonal");
            entity.Property(e => e.Dinero).HasColumnName("dinero");
            entity.Property(e => e.DosComillas).HasColumnName("dos_comillas");
            entity.Property(e => e.DosPuntos).HasColumnName("dos_puntos");
            entity.Property(e => e.Exclamacion).HasColumnName("exclamacion");
            entity.Property(e => e.Fdc).HasColumnName("FDC");
            entity.Property(e => e.Hash).HasColumnName("hash");
            entity.Property(e => e.Igual).HasColumnName("igual");
            entity.Property(e => e.Mas).HasColumnName("mas");
            entity.Property(e => e.MayorQue).HasColumnName("mayor_que");
            entity.Property(e => e.MenorQue).HasColumnName("menor_que");
            entity.Property(e => e.Menos).HasColumnName("menos");
            entity.Property(e => e.Porciento).HasColumnName("porciento");
            entity.Property(e => e.Punto).HasColumnName("punto");
            entity.Property(e => e.Stick).HasColumnName("stick");
            entity.Property(e => e.Token).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
