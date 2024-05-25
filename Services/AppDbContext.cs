using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using AngelHack.Models;

namespace AngelHack.Services
{
    public partial class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AppUser> AppUser { get; set; } = null!;
        public virtual DbSet<Posts> Posts { get; set; } = null!;
        public virtual DbSet<UserEvent> UserEvent { get; set; } = null!;
        public virtual DbSet<VEvents> VEvents { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppUser>(entity =>
            {
                entity.Property(e => e.DisplayName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Organisation)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserPass).HasMaxLength(50);

                entity.Property(e => e.UserRole)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Posts>(entity =>
            {
                entity.HasKey(e => e.PostId)
                    .HasName("PK__Posts__AA126018CBE56FD3");

                entity.Property(e => e.DatePosted).HasColumnType("datetime");

                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ImageURL");

                entity.Property(e => e.Organiser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PostTitle)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Posts)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Posts__UserId__08B54D69");
            });

            modelBuilder.Entity<UserEvent>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.UeventId })
                    .HasName("PK__UserEven__65714747A402F162");

                entity.Property(e => e.UeventId).HasColumnName("UEvent_Id");

                entity.Property(e => e.Roles)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.UserEvent)
                    .HasForeignKey(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__UserEvent__Id__04E4BC85");

                entity.HasOne(d => d.Uevent)
                    .WithMany(p => p.UserEvent)
                    .HasForeignKey(d => d.UeventId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__UserEvent__UEven__05D8E0BE");
            });

            modelBuilder.Entity<VEvents>(entity =>
            {
                entity.HasKey(e => e.EventId)
                    .HasName("PK__vEvents__FD6BEF84BEC0B285");

                entity.ToTable("vEvents");

                entity.Property(e => e.EventId).HasColumnName("Event_Id");

                entity.Property(e => e.DatePosted).HasColumnType("datetime");

                entity.Property(e => e.EventDate).HasColumnType("datetime");

                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ImageURL");

                entity.Property(e => e.Locations)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Organiser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Points)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
