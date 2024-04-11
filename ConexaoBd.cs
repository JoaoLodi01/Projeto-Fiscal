using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace Fiscal.Classe
{
    public class ConexaoBD : DbContext
    {
        public DbSet<temitente> Emitente { get; set; }
        public DbSet<tdadocontabilista> Contabilista { get; set; }
        public DbSet<tfornecedor> Fornecedores { get; set; }
        public DbSet<tcompra> Compras { get; set; }
        public DbSet<testoque> Estoque {  get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new temitenteEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new tdadocontabilistaEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new tfornecedorEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new tcompraEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new testoqueEntityTypeConfiguration());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseFirebird(new ConexaoBD().ConnectionString());
        }

        private string ConnectionString()
        {
            return "DataSource=localhost;Database=C:\\SGBR\\Master\\BD\\BASESGMASTERLODI.FDB;Port=3050;User=SYSDBA;Password=masterkey;Charset=UTF8;Dialect=3;Connection lifetime=15;PacketSize=8192;ServerType=0;Unicode=True;Max Pool Size=1000";
        }
    }
}