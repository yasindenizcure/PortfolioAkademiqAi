using System;
using System.Collections.Generic;
using AkademiQPortfolio.Entities;
using Microsoft.EntityFrameworkCore;

namespace AkademiQPortfolio.Data;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }
    //singularize tekilleştirme tam tersi olsaydı pluralize çoğullaştırma
    public virtual DbSet<About> Abouts { get; set; }

    public virtual DbSet<Contact> Contacts { get; set; }

    public virtual DbSet<Education> Educations { get; set; }

    public virtual DbSet<Experience> Experiences { get; set; }

    public virtual DbSet<Hobby> Hobbies { get; set; }

    public virtual DbSet<Message> Messages { get; set; }

    public virtual DbSet<Skill> Skills { get; set; }

    public virtual DbSet<Work> Works { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=DESKTOP-8TRT9BV\\MSSQLSERVER01;database=AkademiQPortfolioDb;integrated security=true;trustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<About>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.AboutId).ValueGeneratedOnAdd();
            entity.Property(e => e.Address).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.ImageUrl).HasMaxLength(250);
            entity.Property(e => e.NameSurname).HasMaxLength(50);
            entity.Property(e => e.Phone).HasMaxLength(50);
            entity.Property(e => e.Title).HasMaxLength(50);
        });

        modelBuilder.Entity<Contact>(entity =>
        {
            entity.Property(e => e.Address).HasMaxLength(50);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.Phone).HasMaxLength(50);
            entity.Property(e => e.Website).HasMaxLength(50);
        });

        modelBuilder.Entity<Education>(entity =>
        {
            entity.Property(e => e.Department).HasMaxLength(50);
            entity.Property(e => e.EducationDate).HasMaxLength(50);
            entity.Property(e => e.Title).HasMaxLength(50);
        });

        modelBuilder.Entity<Experience>(entity =>
        {
            entity.Property(e => e.CompanyName).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.IconUrl).HasMaxLength(100);
            entity.Property(e => e.Title).HasMaxLength(50);
            entity.Property(e => e.WorkDate).HasMaxLength(50);
        });

        modelBuilder.Entity<Hobby>(entity =>
        {
            entity.Property(e => e.IconUrl).HasMaxLength(200);
            entity.Property(e => e.Title).HasMaxLength(50);
        });

        modelBuilder.Entity<Message>(entity =>
        {
            entity.Property(e => e.MessageText).HasMaxLength(500);
            entity.Property(e => e.SendDate).HasColumnType("datetime");
            entity.Property(e => e.SenderEmail).HasMaxLength(50);
            entity.Property(e => e.SenderName).HasMaxLength(50);
        });

        modelBuilder.Entity<Skill>(entity =>
        {
            entity.Property(e => e.SkillTitle).HasMaxLength(50);
        });

        modelBuilder.Entity<Work>(entity =>
        {
            entity.Property(e => e.Subtitle).HasMaxLength(50);
            entity.Property(e => e.Title).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
