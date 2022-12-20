using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Tkus.Core.Entities;

namespace Tkus.Infrastructure.Data;

public partial class TkosContext : DbContext
{
    public TkosContext()
    {
    }

    public TkosContext(DbContextOptions<TkosContext> options)
        : base(options)
    {
    }

    public virtual DbSet<City> Cities { get; set; }

    public virtual DbSet<Form> Forms { get; set; }

    public virtual DbSet<Security> Securities { get; set; }

    public virtual DbSet<Service> Services { get; set; }

    public virtual DbSet<Supplier> Suppliers { get; set; }

    public virtual DbSet<Typeform> Typeforms { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<City>(entity =>
        {
            entity.HasKey(e => e.IdCities).HasName("PK__Cities__F7E7D84B88532F9C");

            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Form>(entity =>
        {
            entity.HasKey(e => e.IdForm).HasName("PK__form__007D03D9865F63AC");

            entity.ToTable("form");

            entity.Property(e => e.Name)
                .HasMaxLength(75)
                .IsUnicode(false);


        });

        modelBuilder.Entity<Security>(entity =>
        {
            entity.HasKey(e => e.IdSecurity).HasName("PK__security__77863C70AA8E446E");

            entity.ToTable("security");

            entity.Property(e => e.NameUser)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Users)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Service>(entity =>
        {
            entity.HasKey(e => e.IdServices).HasName("PK__services__2D329E13A4FD5E16");

            entity.ToTable("services");

            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nit)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Price).HasColumnType("smallmoney");


        });

        modelBuilder.Entity<Supplier>(entity =>
        {
            entity.HasKey(e => e.IdSupplier).HasName("PK__supplier__F2C105E84C0E5022");

            entity.ToTable("suppliers");

            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nit)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<Typeform>(entity =>
        {
            entity.HasKey(e => e.Idtypeform).HasName("PK__typeform__6DF0402B72C70670");

            entity.ToTable("typeform");

            entity.Property(e => e.String)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("string");
        });
    }
}
