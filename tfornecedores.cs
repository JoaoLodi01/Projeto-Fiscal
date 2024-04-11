using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiscal
{
    public class tfornecedor
    {
        [DisplayName("CÓDIGO")]
        public int CONTROLE { get; set; }

        [DisplayName("RAZÃO SOCIAL")]
        public string RAZAOSOCIAL { get; set; }

        [DisplayName("NOME FANTASIA")]
        public string NOMEFANTASIA { get; set; }

        [DisplayName("CNPJ")]
        public string CNPJ { get; set; }

        [DisplayName("ENDEREÇO")]
        public string ENDERECO { get; set; }

        [DisplayName("BAIRRO")]
        public string BAIRRO { get; set; }

        [DisplayName("CÓD. CIDADE")]
        public int? CODCIDADE { get; set; }

        [DisplayName("CÓD. CIDADE IBGE")]
        public string CODIGOCIDADEIBGE { get; set; }

        [DisplayName("CIDADE")]
        public string CIDADE { get; set; }

        [DisplayName("CÓD. PAÍS")]
        public string CODIGOPAIS { get; set; }

        [DisplayName("UF")]
        public string UF { get; set; }

        [DisplayName("CEP")]
        public string CEP { get; set; }

        [DisplayName("RG")]
        public string RG { get; set; }

        [DisplayName("CPF")]
        public string CPF { get; set; }

        [DisplayName("IE")]
        public string IE { get; set; }

        [DisplayName("IM")]
        public string IM { get; set; }

        [DisplayName("COMPLEMENTO")]
        public string COMPLEMENTO { get; set; }

        [DisplayName("TELEFONE")]
        public string TELEFONE { get; set; }

        [DisplayName("CELULAR")]
        public string CELULAR { get; set; }

        [DisplayName("SAC")]
        public string SAC { get; set; }

        [DisplayName("E-MAIL")]
        public string EMAIL { get; set; }

        [DisplayName("SITE")]
        public string SITE { get; set; }

        [DisplayName("OBS.")]
        public string OBS { get; set; }

        [DisplayName("FORMA DE PAGAMENTO")]
        public string FORMAPAGAMENTO { get; set; }

        [DisplayName("PAÍS")]
        public string PAIS { get; set; }

        [DisplayName("NÚMERO")]
        public string NUMERO { get; set; }

        [DisplayName("CONTATO")]
        public string NOMECONTATOJURIDICA { get; set; }

        [DisplayName("CAMPO 1")]
        public string CAMPO1 { get; set; }

        [DisplayName("CAMPO 2")]
        public string CAMPO2 { get; set; }

        [DisplayName("CAMPO 3")]
        public string CAMPO3 { get; set; }

        [DisplayName("CAMPO 4")]
        public string CAMPO4 { get; set; }

        [DisplayName("CAMPO 5")]
        public string CAMPO5 { get; set; }

        [DisplayName("CAMPO 6")]
        public string CAMPO6 { get; set; }

        [DisplayName("CAMPO 7")]
        public string CAMPO7 { get; set; }

        [DisplayName("CAMPO 8")]
        public string CAMPO8 { get; set; }

        [DisplayName("CAMPO 9")]
        public string CAMPO9 { get; set; }

        [DisplayName("CAMPO 10")]
        public string CAMPO10 { get; set; }

        [DisplayName("#")]
        public string MARCADO { get; set; }

        [DisplayName("DATA HORA CADASTRO")]
        public DateTime DATAHORACADASTRO { get; set; }

        [DisplayName("ATIVO")]
        public string ATIVO { get; set; }

        [DisplayName("CÓD. EMITENTE")]
        public int? CODEMITENTE { get; set; }

        [DisplayName("CONTRIBUINTE IPI")]
        public string CONTRIBUINTEIPI { get; set; }

        [DisplayName("SUFRAMA")]
        public string SUFRAMA { get; set; }

    }

    public class tfornecedorEntityTypeConfiguration : IEntityTypeConfiguration<tfornecedor>
    {
        public void Configure(EntityTypeBuilder<tfornecedor> builder)
        {
            builder.ToTable("TFORNECEDOR");

            builder.HasKey(e => e.CONTROLE);

            builder.Property(e => e.CONTROLE).HasColumnName("CONTROLE").IsRequired();

            builder.Property(e => e.DATAHORACADASTRO).HasColumnName("DATAHORACADASTRO").IsRequired();

            builder.Property(e => e.RAZAOSOCIAL).HasColumnName("RAZAOSOCIAL").IsRequired();

            builder.Property(e => e.NOMEFANTASIA).HasColumnName("NOMEFANTASIA");

            builder.Property(e => e.ENDERECO).HasColumnName("ENDERECO");

            builder.Property(e => e.BAIRRO).HasColumnName("BAIRRO");

            builder.Property(e => e.CODCIDADE).HasColumnName("CODCIDADE");

            builder.Property(e => e.CODIGOCIDADEIBGE).HasColumnName("CODIGOCIDADEIBGE");

            builder.Property(e => e.CIDADE).HasColumnName("CIDADE");

            builder.Property(e => e.CODIGOPAIS).HasColumnName("CODIGOPAIS");

            builder.Property(e => e.UF).HasColumnName("UF");

            builder.Property(e => e.CEP).HasColumnName("CEP");

            builder.Property(e => e.RG).HasColumnName("RG");

            builder.Property(c => c.CPF).HasColumnName("CPF").HasMaxLength(20);

            builder.Property(c => c.CNPJ).HasColumnName("CNPJ").HasMaxLength(20);

            builder.Property(e => e.IE).HasColumnName("IE");

            builder.Property(e => e.IM).HasColumnName("IM");

            builder.Property(e => e.COMPLEMENTO).HasColumnName("COMPLEMENTO");

            builder.Property(e => e.TELEFONE).HasColumnName("TELEFONE");

            builder.Property(e => e.CELULAR).HasColumnName("CELULAR");

            builder.Property(e => e.SAC).HasColumnName("SAC");

            builder.Property(e => e.EMAIL).HasColumnName("EMAIL");

            builder.Property(e => e.SITE).HasColumnName("SITE");

            builder.Property(e => e.OBS).HasColumnName("OBS");

            builder.Property(e => e.FORMAPAGAMENTO).HasColumnName("FORMAPAGAMENTO");

            builder.Property(e => e.PAIS).HasColumnName("PAIS");

            builder.Property(e => e.NUMERO).HasColumnName("NUMERO");

            builder.Property(e => e.NOMECONTATOJURIDICA).HasColumnName("NOMECONTATOJURIDICA");

            builder.Property(e => e.CAMPO1).HasColumnName("CAMPO1");

            builder.Property(e => e.CAMPO2).HasColumnName("CAMPO2");

            builder.Property(e => e.CAMPO3).HasColumnName("CAMPO3");

            builder.Property(e => e.CAMPO4).HasColumnName("CAMPO4");

            builder.Property(e => e.CAMPO5).HasColumnName("CAMPO5");

            builder.Property(e => e.CAMPO6).HasColumnName("CAMPO6");

            builder.Property(e => e.CAMPO7).HasColumnName("CAMPO7");

            builder.Property(e => e.CAMPO8).HasColumnName("CAMPO8");

            builder.Property(e => e.CAMPO9).HasColumnName("CAMPO9");

            builder.Property(e => e.CAMPO10).HasColumnName("CAMPO10");

            builder.Property(e => e.MARCADO).HasColumnName("MARCADO");

            builder.Property(e => e.ATIVO).HasColumnName("ATIVO");

            builder.Property(e => e.CODEMITENTE).HasColumnName("CODEMITENTE");

            builder.Property(e => e.CONTRIBUINTEIPI).HasColumnName("CONTRIBUINTEIPI");

            builder.Property(e => e.SUFRAMA).HasColumnName("SUFRAMA");
        }
    }
}

