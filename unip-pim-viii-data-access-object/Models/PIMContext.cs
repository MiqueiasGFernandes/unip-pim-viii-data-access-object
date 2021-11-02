using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace unip_pim_viii_data_access_object.Models
{
    public partial class PIMContext : DbContext
    {
        public virtual DbSet<Endereco> Enderecos { get; set; }
        public virtual DbSet<Pessoa> Pessoas { get; set; }
        public virtual DbSet<Telefone> Telefones { get; set; }
        public virtual DbSet<TipoTelefone> TipoTelefones { get; set; }

        public PIMContext()
        {
        }

        public PIMContext(DbContextOptions<PIMContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-TBRQ2Q8;Initial Catalog=PIM;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");
            modelBuilder.Entity<BaseModel>(b => {
                {
                    b.HasKey(e => e.id);
                    b.Property(e => e.id).ValueGeneratedOnAdd();
                }
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
