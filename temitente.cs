using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiscal
{
    public class temitente
    {
        [DisplayName("CONTROLE")]
        public int CONTROLE { get; set; }

        [DisplayName("NOMEFANTASIA")]
        public string NOMEFANTASIA { get; set; }

        [DisplayName("RAZAOSOCIAL")]
        public string RAZAOSOCIAL { get; set; }

        [DisplayName("ENDERECO")]
        public string ENDERECO { get; set; }

        [DisplayName("COMPLEMENTO")]
        public string COMPLEMENTO { get; set; }

        [DisplayName("BAIRRO")]
        public string BAIRRO { get; set; }

        [DisplayName("CODCIDADE")]
        public int? CODCIDADE { get; set; }

        [DisplayName("CIDADE")]
        public string CIDADE { get; set; }

        [DisplayName("UF")]
        public string UF { get; set; }

        [DisplayName("CEP")]
        public string CEP { get; set; }

        [DisplayName("CNPJ")]
        public string CNPJ { get; set; }

        [DisplayName("IE")]
        public string IE { get; set; }

        [DisplayName("IM")]
        public string IM { get; set; }

        [DisplayName("DATAHORACADASTRO")]
        public DateTime? DATAHORACADASTRO { get; set; }

        [DisplayName("OBS")]
        public string OBS { get; set; }

        [DisplayName("TELEFONE")]
        public string TELEFONE { get; set; }

        [DisplayName("CELULAR")]
        public string CELULAR { get; set; }

        [DisplayName("EMAIL")]
        public string EMAIL { get; set; }

        [DisplayName("FAX")]
        public string FAX { get; set; }

        [DisplayName("ATIVIDADE")]
        public string ATIVIDADE { get; set; }

        [DisplayName("CNAE")]
        public string CNAE { get; set; }

        [DisplayName("CRT")]
        public string CRT { get; set; }

        [DisplayName("DATAFUNDACAOEMPRESA")]
        public DateTime? DATAFUNDACAOEMPRESA { get; set; }

        [DisplayName("LOGOTIPO")]
        public string LOGOTIPO { get; set; }

        [DisplayName("PAIS")]
        public string PAIS { get; set; }

        [DisplayName("NUMERO")]
        public string NUMERO { get; set; }

        [DisplayName("PERCICMS")]
        public int? PERCICMS { get; set; }

        [DisplayName("CODICMS")]
        public int? CODICMS { get; set; }

        [DisplayName("CODCIDADEIBGE")]
        public string CODCIDADEIBGE { get; set; }

        [DisplayName("DATAMOVIMENTO")]
        public DateTime? DATAMOVIMENTO { get; set; }

        [DisplayName("HORAPRIMEIRODOCUMENTOECF")]
        public DateTime? HORAPRIMEIRODOCUMENTOECF { get; set; }

        [DisplayName("SUFRAMA")]
        public string SUFRAMA { get; set; }

        [DisplayName("SERIEECF")]
        public string SERIEECF { get; set; }

        [DisplayName("MARCAECF")]
        public string MARCAECF { get; set; }

        [DisplayName("MODELOECF")]
        public string MODELOECF { get; set; }

        [DisplayName("TIPOECF")]
        public string TIPOECF { get; set; }

        [DisplayName("MD5")]
        public string MD5 { get; set; }

        [DisplayName("VERIFICADORFB")]
        public string VERIFICADORFB { get; set; }

        [DisplayName("DATAHORAVERIFICACAORFB")]
        public DateTime? DATAHORAVERIFICACAORFB { get; set; }

        [DisplayName("CAPTCHARFB")]
        public string CAPTCHARFB { get; set; }

        [DisplayName("RETORNORFB")]
        public string RETORNORFB { get; set; }

        [DisplayName("AUTORIZADOUSO")]
        public string AUTORIZADOUSO { get; set; }

        [DisplayName("MD5CNPJRAZAOUFRFB")]
        public string MD5CNPJRAZAOUFRFB { get; set; }

        [DisplayName("SERIALINSTALADO")]
        public string SERIALINSTALADO { get; set; }

        [DisplayName("ALIQUOTAISSQN")]
        public int? ALIQUOTAISSQN { get; set; }

        [DisplayName("CODIMPOSTOISS")]
        public int? CODIMPOSTOISS { get; set; }

        [DisplayName("NOTALEGALDF")]
        public string NOTALEGALDF { get; set; }

        [DisplayName("E3SERIEECF")]
        public string E3SERIEECF { get; set; }

        [DisplayName("E3TIPOECF")]
        public string E3TIPOECF { get; set; }

        [DisplayName("E3MARCAECF")]
        public string E3MARCAECF { get; set; }

        [DisplayName("E3MODELOECF")]
        public string E3MODELOECF { get; set; }

        [DisplayName("ATACADOEVAREJO")]
        public string ATACADOEVAREJO { get; set; }

        [DisplayName("MD5BOS")]
        public string MD5BOS { get; set; }

        [DisplayName("MD5P")]
        public string MD5P { get; set; }

        [DisplayName("MD5L")]
        public string MD5L { get; set; }

        [DisplayName("CPF")]
        public string CPF { get; set; }

        [DisplayName("MD5V")]
        public string MD5V { get; set; }

        [DisplayName("RNTRC")]
        public string RNTRC { get; set; }

        [DisplayName("REGIMETRIBUTARIOISSQN")]
        public string REGIMETRIBUTARIOISSQN { get; set; }

        [DisplayName("MD5B")]
        public string MD5B { get; set; }

        [DisplayName("SITE")]
        public string SITE { get; set; }

        [DisplayName("CNPJCONTADOR")]
        public string CNPJCONTADOR { get; set; }

        [DisplayName("VERSAOSERVIDOR")]
        public int? VERSAOSERVIDOR { get; set; }

        [DisplayName("RELEASESERVIDOR")]
        public int? RELEASESERVIDOR { get; set; }

        [DisplayName("CHAVEPP")]
        public string CHAVEPP { get; set; }

        [DisplayName("CONTROLESG")]
        public string CONTROLESG { get; set; }

        [DisplayName("MD5PAF")]
        public string MD5PAF { get; set; }

        [DisplayName("OC")]
        public string OC { get; set; }

        [DisplayName("DATAIE")]
        public DateTime? DATAIE { get; set; }

        [DisplayName("SITE2")]
        public string SITE2 { get; set; }

        [DisplayName("NUMEROCREDENCIAMENTO")]
        public string NUMEROCREDENCIAMENTO { get; set; }

        [DisplayName("POSSUIIESUBSTITUTO")]
        public string POSSUIIESUBSTITUTO { get; set; }

        [DisplayName("ATUALIZARESTOQUE")]
        public string ATUALIZARESTOQUE { get; set; }

        [DisplayName("COMPARANDO")]
        public string COMPARANDO { get; set; }

        [DisplayName("ESTABELECIMENTOUNICO")]
        public string ESTABELECIMENTOUNICO { get; set; }

        [DisplayName("MD5CAD")]
        public string MD5CAD { get; set; }

        [DisplayName("ATUALIZARDATAVENDACOMPRA")]
        public string ATUALIZARDATAVENDACOMPRA { get; set; }

        [DisplayName("RESERVARPRODALUGUELCONDI")]
        public string RESERVARPRODALUGUELCONDI { get; set; }

        [DisplayName("ATUALIZARESTOQUEPARCIAL")]
        public string ATUALIZARESTOQUEPARCIAL { get; set; }

        [DisplayName("UTILIZARBAIXAMP")]
        public string UTILIZARBAIXAMP { get; set; }

        [DisplayName("NUMLICENCA")]
        public string NUMLICENCA { get; set; }

        [DisplayName("NUMAUTESPECIAL")]
        public string NUMAUTESPECIAL { get; set; }

        [DisplayName("NUMAUTFUNCIONAMENTO")]
        public string NUMAUTFUNCIONAMENTO { get; set; }

        [DisplayName("MD5I")]
        public string MD5I { get; set; }

        [DisplayName("SINCRONIZADO")]
        public string SINCRONIZADO { get; set; }

        [DisplayName("CODATIVIDADE")]
        public int? CODATIVIDADE { get; set; }

        [DisplayName("EMPRESAUUIDTEF")]
        public string EMPRESAUUIDTEF { get; set; }
    }

    public class temitenteEntityTypeConfiguration : IEntityTypeConfiguration<temitente>
    {
        public void Configure(EntityTypeBuilder<temitente> builder)
        {
            builder.ToTable("TEMITENTE");

            builder.HasKey(e => e.CONTROLE);

            builder.Property(e => e.CONTROLE).HasColumnName("CONTROLE");

            builder.Property(e => e.RAZAOSOCIAL).HasColumnName("RAZAOSOCIAL");

            builder.Property(e => e.ENDERECO).HasColumnName("ENDERECO");

            builder.Property(e => e.COMPLEMENTO).HasColumnName("COMPLEMENTO");

            builder.Property(e => e.BAIRRO).HasColumnName("BAIRRO");

            builder.Property(e => e.CODCIDADE).HasColumnName("CODCIDADE");

            builder.Property(e => e.CIDADE).HasColumnName("CIDADE");

            builder.Property(e => e.UF).HasColumnName("UF");

            builder.Property(e => e.CEP).HasColumnName("CEP");

            builder.Property(e => e.CNPJ).HasColumnName("CNPJ");

            builder.Property(e => e.IE).HasColumnName("IE");

            builder.Property(e => e.IM).HasColumnName("IM");

            builder.Property(e => e.DATAHORACADASTRO).HasColumnName("DATAHORACADASTRO");

            builder.Property(e => e.OBS).HasColumnName("OBS");

            builder.Property(c => c.TELEFONE).HasColumnName("TELEFONE");

            builder.Property(c => c.CELULAR).HasColumnName("CELULAR");

            builder.Property(e => e.EMAIL).HasColumnName("EMAIL");

            builder.Property(e => e.FAX).HasColumnName("FAX");

            builder.Property(e => e.ATIVIDADE).HasColumnName("ATIVIDADE");

            builder.Property(e => e.CNAE).HasColumnName("CNAE");

            builder.Property(e => e.CRT).HasColumnName("CRT");

            builder.Property(e => e.DATAFUNDACAOEMPRESA).HasColumnName("DATAFUNDACAOEMPRESA");

            builder.Property(e => e.LOGOTIPO).HasColumnName("LOGOTIPO");

            builder.Property(e => e.PAIS).HasColumnName("PAIS");

            builder.Property(e => e.NUMERO).HasColumnName("NUMERO");

            builder.Property(e => e.PERCICMS).HasColumnName("PERCICMS");

            builder.Property(e => e.CODICMS).HasColumnName("CODICMS");

            builder.Property(e => e.CODCIDADEIBGE).HasColumnName("CODCIDADEIBGE");

            builder.Property(e => e.DATAMOVIMENTO).HasColumnName("DATAMOVIMENTO");

            builder.Property(e => e.HORAPRIMEIRODOCUMENTOECF).HasColumnName("HORAPRIMEIRODOCUMENTOECF");

            builder.Property(e => e.SUFRAMA).HasColumnName("SUFRAMA");

            builder.Property(e => e.SERIEECF).HasColumnName("SERIEECF");

            builder.Property(e => e.MARCAECF).HasColumnName("MARCAECF");

            builder.Property(e => e.MODELOECF).HasColumnName("MODELOECF");

            builder.Property(e => e.TIPOECF).HasColumnName("TIPOECF");

            builder.Property(e => e.MD5).HasColumnName("MD5");

            builder.Property(e => e.VERIFICADORFB).HasColumnName("VERIFICADORFB");

            builder.Property(e => e.DATAHORAVERIFICACAORFB).HasColumnName("DATAHORAVERIFICACAORFB");

            builder.Property(e => e.CAPTCHARFB).HasColumnName("CAPTCHARFB");

            builder.Property(e => e.RETORNORFB).HasColumnName("RETORNORFB");

            builder.Property(e => e.AUTORIZADOUSO).HasColumnName("AUTORIZADOUSO");

            builder.Property(e => e.MD5CNPJRAZAOUFRFB).HasColumnName("MD5CNPJRAZAOUFRFB");

            builder.Property(e => e.SERIALINSTALADO).HasColumnName("SERIALINSTALADO");

            builder.Property(e => e.ALIQUOTAISSQN).HasColumnName("ALIQUOTAISSQN");

            builder.Property(e => e.CODIMPOSTOISS).HasColumnName("CODIMPOSTOISS");

            builder.Property(e => e.NOTALEGALDF).HasColumnName("NOTALEGALDF");

            builder.Property(e => e.E3SERIEECF).HasColumnName("E3SERIEECF");

            builder.Property(e => e.E3TIPOECF).HasColumnName("E3TIPOECF");

            builder.Property(e => e.E3MODELOECF).HasColumnName("E3MODELOECF");

            builder.Property(e => e.ATACADOEVAREJO).HasColumnName("ATACADOEVAREJO");

            builder.Property(e => e.MD5BOS).HasColumnName("MD5BOS");

            builder.Property(e => e.MD5L).HasColumnName("MD5L");

            builder.Property(e => e.CPF).HasColumnName("CPF");

            builder.Property(e => e.MD5V).HasColumnName("MD5V");

            builder.Property(e => e.RNTRC).HasColumnName("RNTRC");

            builder.Property(e => e.REGIMETRIBUTARIOISSQN).HasColumnName("REGIMETRIBUTARIOISSQN");

            builder.Property(e => e.SITE).HasColumnName("SITE");

            builder.Property(e => e.CNPJCONTADOR).HasColumnName("CNPJCONTADOR");

            builder.Property(e => e.VERSAOSERVIDOR).HasColumnName("VERSAOSERVIDOR");

            builder.Property(e => e.RELEASESERVIDOR).HasColumnName("RELEASESERVIDOR");

            builder.Property(e => e.CHAVEPP).HasColumnName("CHAVEPP");

            builder.Property(e => e.CONTROLESG).HasColumnName("CONTROLESG");

            builder.Property(e => e.MD5PAF).HasColumnName("MD5PAF");

            builder.Property(e => e.OC).HasColumnName("OC");

            builder.Property(e => e.DATAIE).HasColumnName("DATAIE");

            builder.Property(e => e.SITE2).HasColumnName("SITE2");

            builder.Property(e => e.NUMEROCREDENCIAMENTO).HasColumnName("NUMEROCREDENCIAMENTO");

            builder.Property(e => e.POSSUIIESUBSTITUTO).HasColumnName("POSSUIIESUBSTITUTO");

            builder.Property(e => e.ATUALIZARESTOQUE).HasColumnName("ATUALIZARESTOQUE");

            builder.Property(e => e.COMPARANDO).HasColumnName("COMPARANDO");

            builder.Property(e => e.ESTABELECIMENTOUNICO).HasColumnName("ESTABELECIMENTOUNICO");

            builder.Property(e => e.MD5CAD).HasColumnName("MD5CAD");

            builder.Property(e => e.ATUALIZARDATAVENDACOMPRA).HasColumnName("ATUALIZARDATAVENDACOMPRA");

            builder.Property(e => e.RESERVARPRODALUGUELCONDI).HasColumnName("RESERVARPRODALUGUELCONDI");

            builder.Property(e => e.ATUALIZARESTOQUEPARCIAL).HasColumnName("ATUALIZARESTOQUEPARCIAL");

            builder.Property(e => e.UTILIZARBAIXAMP).HasColumnName("UTILIZARBAIXAMP");

            builder.Property(e => e.NUMLICENCA).HasColumnName("NUMLICENCA");

            builder.Property(e => e.NUMAUTESPECIAL).HasColumnName("NUMAUTESPECIAL");

            builder.Property(e => e.MD5I).HasColumnName("MD5I");

            builder.Property(e => e.SINCRONIZADO).HasColumnName("SINCRONIZADO");

            builder.Property(e => e.CODATIVIDADE).HasColumnName("CODATIVIDADE");

            builder.Property(e => e.EMPRESAUUIDTEF).HasColumnName("EMPRESAUUIDTEF");
        }
    }
}


