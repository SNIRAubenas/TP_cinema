using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Application_Cinema.DataModel;

public partial class DirectorfilmactorContext : DbContext
{
    public DirectorfilmactorContext()
    {
    }

    public DirectorfilmactorContext(DbContextOptions<DirectorfilmactorContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Actor> Actors { get; set; }

    public virtual DbSet<Director> Directors { get; set; }

    public virtual DbSet<Film> Films { get; set; }

    public virtual DbSet<Filmactor> Filmactors { get; set; }

    public virtual DbSet<Filmdirector> Filmdirectors { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySQL("server=10.0.0.25;database=bdsg;uid=bdsg;password=cinema24");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Actor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("actor");

            entity.Property(e => e.Id).HasColumnType("int(11)");
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<Director>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("director");

            entity.Property(e => e.Id).HasColumnType("int(11)");
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<Film>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("film");

            entity.Property(e => e.Id).HasColumnType("int(11)");
            entity.Property(e => e.Length).HasColumnType("time");
            entity.Property(e => e.Poster).HasColumnType("mediumblob");
            entity.Property(e => e.Summary).HasColumnType("text");
            entity.Property(e => e.Title).HasMaxLength(50);
            entity.Property(e => e.Year).HasColumnType("int(11)");
        });

        modelBuilder.Entity<Filmactor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("filmactor");

            entity.HasIndex(e => e.IdActor, "IdActor");

            entity.HasIndex(e => e.IdFilm, "IdFilm");

            entity.Property(e => e.Id).HasColumnType("int(11)");
            entity.Property(e => e.IdActor).HasColumnType("int(11)");
            entity.Property(e => e.IdFilm).HasColumnType("int(11)");

            entity.HasOne(d => d.IdActorNavigation).WithMany(p => p.Filmactors)
                .HasForeignKey(d => d.IdActor)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("filmactor_ibfk_2");

            entity.HasOne(d => d.IdFilmNavigation).WithMany(p => p.Filmactors)
                .HasForeignKey(d => d.IdFilm)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("filmactor_ibfk_1");
        });

        modelBuilder.Entity<Filmdirector>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("filmdirector");

            entity.HasIndex(e => e.IdDirector, "IdDirector");

            entity.HasIndex(e => e.IdFilm, "IdFilm");

            entity.Property(e => e.Id).HasColumnType("int(11)");
            entity.Property(e => e.IdDirector).HasColumnType("int(11)");
            entity.Property(e => e.IdFilm).HasColumnType("int(11)");

            entity.HasOne(d => d.IdDirectorNavigation).WithMany(p => p.Filmdirectors)
                .HasForeignKey(d => d.IdDirector)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("filmdirector_ibfk_1");

            entity.HasOne(d => d.IdFilmNavigation).WithMany(p => p.Filmdirectors)
                .HasForeignKey(d => d.IdFilm)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("filmdirector_ibfk_2");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
