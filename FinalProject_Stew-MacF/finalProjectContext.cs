using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FinalProject_Stew_MacF
{
    public partial class finalProjectContext : DbContext
    {
        public finalProjectContext()
        {
        }

        public finalProjectContext(DbContextOptions<finalProjectContext> options) : base(options)
        {
        }

        public virtual DbSet<GroupFoods> GroupFoods { get; set; }
        public virtual DbSet<GroupHobbies> GroupHobbies { get; set; }
        public virtual DbSet<GroupInformation> GroupInformation { get; set; }
        public virtual DbSet<GroupSchools> GroupSchools { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GroupFoods>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.FavoriteBreakfastFood).HasColumnType("text");

                entity.Property(e => e.FavoriteDinnerFood).HasColumnType("text");

                entity.Property(e => e.FavoriteLunchFood).HasColumnType("text");

                entity.Property(e => e.FavoriteSnackFood).HasColumnType("text");

                entity.Property(e => e.Name).HasColumnType("text");
            });

            modelBuilder.Entity<GroupHobbies>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.FavoriteClub).HasColumnType("text");

                entity.Property(e => e.FavoriteGame).HasColumnType("text");

                entity.Property(e => e.FavoriteSport).HasColumnType("text");

                entity.Property(e => e.Name).HasColumnType("text");

                entity.Property(e => e.PlayedInstrument).HasColumnType("text");
            });

            modelBuilder.Entity<GroupInformation>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.BirthDate).HasColumnType("date");

                entity.Property(e => e.CollegeProgram).HasColumnType("text");

                entity.Property(e => e.Name).HasColumnType("text");
            });

            modelBuilder.Entity<GroupSchools>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ElementarySchool).HasColumnType("text");

                entity.Property(e => e.HighSchool).HasColumnType("text");

                entity.Property(e => e.MiddleSchool).HasColumnType("text");

                entity.Property(e => e.Name).HasColumnType("text");

                entity.Property(e => e.University).HasColumnType("text");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
