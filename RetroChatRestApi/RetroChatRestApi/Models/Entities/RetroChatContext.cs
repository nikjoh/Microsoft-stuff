using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace RetroChatRestApi.Models.Entities
{
    public partial class RetroChatContext : DbContext
    {
        public virtual DbSet<Comment> Comment { get; set; }
        public virtual DbSet<Like> Like { get; set; }
        public virtual DbSet<Post> Post { get; set; }
        public virtual DbSet<User> User { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Comment>(entity =>
            {
                entity.Property(e => e.PostId).HasColumnName("PostID");

                entity.Property(e => e.TextValue)
                    .IsRequired()
                    .IsUnicode(false);

                entity.HasOne(d => d.Post)
                    .WithMany(p => p.Comment)
                    .HasForeignKey(d => d.PostId)
                    .HasConstraintName("FK__Comment__PostID__6B24EA82");
            });

            modelBuilder.Entity<Like>(entity =>
            {
                entity.Property(e => e.LikeValue).HasDefaultValueSql("((0))");

                entity.Property(e => e.PostId).HasColumnName("PostID");

                entity.HasOne(d => d.Post)
                    .WithMany(p => p.Like)
                    .HasForeignKey(d => d.PostId)
                    .HasConstraintName("FK__Like__PostID__68487DD7");
            });

            modelBuilder.Entity<Post>(entity =>
            {
                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Post)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Post__UserID__5165187F");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Image)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Text).IsUnicode(false);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
        }
    }
}
