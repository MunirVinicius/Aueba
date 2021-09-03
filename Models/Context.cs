using Microsoft.EntityFrameworkCore;

namespace aueba.Models
{
    public partial class Context : DbContext
    {
        public Context()
        {
        }

        public Context(DbContextOptions<Context> options): base(options){
        }

        public virtual DbSet<Char> Char {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.Entity<Char>(entity =>
            {
                entity.Property(e => e.CharID).HasColumnType("int(11)");

                entity.Property(e => e.CharName)
                    .IsRequired()
                    .HasColumnName("CharName")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.CharDex)
                    .IsRequired()
                    .HasColumnName("CharDex")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CharHP)
                    .IsRequired()
                    .HasColumnName("CharHP")
                    .HasColumnType("int(11)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}