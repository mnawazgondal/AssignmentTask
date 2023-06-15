using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace AN_CRM.Model
{
    public partial class crm_databaseContext : DbContext
    {
        //public crm_databaseContext()
        //{
        //}

        public crm_databaseContext(DbContextOptions<crm_databaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UsersBalance> UsersBalances { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseMySql("server=localhost;port=3306;user=root;password=123456;database=crm_database", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.33-mysql"));
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_0900_ai_ci");

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("users");

                entity.HasIndex(e => e.Id, "id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Browser)
                    .IsRequired()
                    .HasMaxLength(45)
                    .HasColumnName("browser");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("createdAt");

                entity.Property(e => e.Device)
                    .IsRequired()
                    .HasMaxLength(45)
                    .HasColumnName("device");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("email");

                entity.Property(e => e.FristName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("fristName");

                entity.Property(e => e.IpAddress)
                    .IsRequired()
                    .HasMaxLength(45)
                    .HasColumnName("ipAddress");

                entity.Property(e => e.IsFristTimeLogin).HasColumnName("isFristTimeLogin");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("lastName");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("password");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.UpdateAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updateAt");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("userName");
            });

            modelBuilder.Entity<UsersBalance>(entity =>
            {
                entity.ToTable("users_balance");

                entity.HasIndex(e => e.Id, "id_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.UserId, "users_balancecol_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Balance)
                    .HasColumnName("balance")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.UsersBalance)
                    .HasForeignKey<UsersBalance>(d => d.UserId)
                    .HasConstraintName("user_id");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
