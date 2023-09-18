using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebApplication2.DBContexts;

public partial class CdndbContext : DbContext
{
    public CdndbContext()
    {
    }

    public CdndbContext(DbContextOptions<CdndbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CdnUser> CdnUsers { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-4O20BOB\\SQLEXPRESS01;Initial Catalog=cdndb;TrustServerCertificate=True;User ID=sa;Password=123456");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CdnUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__cdn_user__3213E83FC123664B");

            entity.ToTable("cdn_users");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("id");
            entity.Property(e => e.Email)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Hobby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("hobby");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("phone_number");
            entity.Property(e => e.Skillsets)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("skillsets");
            entity.Property(e => e.Username)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("username");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
