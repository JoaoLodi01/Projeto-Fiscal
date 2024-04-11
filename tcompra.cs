using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiscal
{
    public class tcompra
    {
        [DisplayName("CONTROLE")]
        public int? CONTROLE { get; set; }

        [DisplayName("NUMERONOTA")]
        public int? NUMERONOTA { get; set; }

        [DisplayName("NATUREZAOPERACAO")]
        public string NATUREZAOPERACAO { get; set; }

        [DisplayName("MODELO")]
        public string MODELO { get; set; }

        [DisplayName("SERIE")]
        public string SERIE { get; set; }

        [DisplayName("SUBSERIE")]
        public string SUBSERIE { get; set; }

        [DisplayName("DATAHORACADASTRO")]
        public DateTime? DATAHORACADASTRO { get; set; }

        [DisplayName("DATAEMISSAO")]
        public DateTime? DATAEMISSAO { get; set; }

        [DisplayName("DATARECEBIMENTO")]
        public DateTime? DATARECEBIMENTO { get; set; }

        [DisplayName("CODFORNECEDOR")]
        public int? CODFORNECEDOR { get; set; }

        [DisplayName("FORNECEDOR")]
        public string FORNECEDOR { get; set; }

        [DisplayName("CODTRANSPORTADORA")]
        public int? CODTRANSPORTADORA { get; set; }

        [DisplayName("TRANSPORTADORA")]
        public string TRANSPORTADORA { get; set; }

        [DisplayName("BASECALCICMS")]
        public int? BASECALCICMS { get; set; }

        [DisplayName("VALORICMS")]
        public int? VALORICMS { get; set; }

        [DisplayName("TOTALREDUCAOICMS")]
        public int? TOTALREDUCAOICMS { get; set; }

        [DisplayName("BASECALCICMSST")]
        public int? BASECALCICMSST { get; set; }

        [DisplayName("VALORICMSSUBSTITUICAO")]
        public int? VALORICMSSUBSTITUICAO { get; set; }

        [DisplayName("TOTALBCIPI")]
        public int? TOTALBCIPI { get; set; }

        [DisplayName("VALORTOTALIPI")]
        public int? VALORTOTALIPI { get; set; }

        [DisplayName("TOTALPIS")]
        public int? TOTALPIS { get; set; }

        [DisplayName("TOTALPISSUB")]
        public int? TOTALPISSUB { get; set; }

        [DisplayName("TOTALCOFINS")]
        public int? TOTALCOFINS { get; set; }

        [DisplayName("TOTALCOFINSSUB")]
        public int? TOTALCOFINSSUB { get; set; }

        [DisplayName("MODOFRETE")]
        public string MODOFRETE { get; set; }

        [DisplayName("TIPOFRETE")]
        public string TIPOFRETE { get; set; }

        [DisplayName("VALORICMSFRETE")]
        public int? VALORICMSFRETE { get; set; }

        [DisplayName("VALORFRETE")]
        public int? VALORFRETE { get; set; }

        [DisplayName("VALORSEGURO")]
        public int? VALORSEGURO { get; set; }

        [DisplayName("PERCDESCONTO")]
        public int? PERCDESCONTO { get; set; }

        [DisplayName("VALORDESCONTO")]
        public int? VALORDESCONTO { get; set; }

        [DisplayName("OUTRASDESPESAS")]
        public int? OUTRASDESPESAS { get; set; }

        [DisplayName("TOTALSERVICOS")]
        public int? TOTALSERVICOS { get; set; }

        [DisplayName("VALORTOTALPRODUTO")]
        public int? VALORTOTALPRODUTO { get; set; }

        [DisplayName("VALORENTRADA")]
        public int? VALORENTRADA { get; set; }

        [DisplayName("VALORTOTALNOTA")]
        public int? VALORTOTALNOTA { get; set; }

        [DisplayName("NFE")]
        public string NFE { get; set; }

        [DisplayName("PROTOCOLODANFE")]
        public string PROTOCOLODANFE { get; set; }

        [DisplayName("CHAVEACESSODANFE")]
        public string CHAVEACESSODANFE { get; set; }

        [DisplayName("INFORMACOESCOMPLEMENTARES")]
        public string INFORMACOESCOMPLEMENTARES { get; set; }

        [DisplayName("CPF")]
        public string CPF { get; set; }

        [DisplayName("CNPJ")]
        public string CNPJ { get; set; }

        [DisplayName("IE")]
        public string IE { get; set; }

        [DisplayName("IESUBSTITUTOTRIBUTARIO")]
        public string IESUBSTITUTOTRIBUTARIO { get; set; }

        [DisplayName("CODCIDADE")]
        public int? CODCIDADE { get; set; }

        [DisplayName("CIDADE")]
        public string CIDADE { get; set; }

        [DisplayName("UF")]
        public string UF { get; set; }

        [DisplayName("CEP")]
        public string CEP { get; set; }

        [DisplayName("ENDERECO")]
        public string ENDERECO { get; set; }

        [DisplayName("BAIRRO")]
        public string BAIRRO { get; set; }

        [DisplayName("TELEFONE")]
        public string TELEFONE { get; set; }

        [DisplayName("EMAIL")]
        public string EMAIL { get; set; }

        [DisplayName("SITEFORNECEDOR")]
        public string SITEFORNECEDOR { get; set; }

        [DisplayName("HORASAIDA")]
        public DateTime? HORASAIDA { get; set; }

        [DisplayName("CODIGOANTT")]
        public string CODIGOANTT { get; set; }

        [DisplayName("PLACAVAICULO")]
        public string PLACAVAICULO { get; set; }

        [DisplayName("UFTRANSPORTADORA")]
        public string UFTRANSPORTADORA { get; set; }

        [DisplayName("CNPJTRANSPORTADORA")]
        public string CNPJTRANSPORTADORA { get; set; }

        [DisplayName("CPFTRANSPORTADORA")]
        public string CPFTRANSPORTADORA { get; set; }

        [DisplayName("ENDERECOTRANSPORTADORA")]
        public string ENDERECOTRANSPORTADORA { get; set; }

        [DisplayName("CODCIDADETRANSPORTADORA")]
        public int? CODCIDADETRANSPORTADORA { get; set; }

        [DisplayName("CIDADETRANSPORTADORA")]
        public string CIDADETRANSPORTADORA { get; set; }

        [DisplayName("BAIRROTRANSPORTADORA")]
        public string BAIRROTRANSPORTADORA { get; set; }

        [DisplayName("CEPTRANSPORTADORA")]
        public string CEPTRANSPORTADORA { get; set; }

        [DisplayName("IETRANSPORTADORA")]
        public string IETRANSPORTADORA { get; set; }

        [DisplayName("QTDEVOLUME")]
        public int? QTDEVOLUME { get; set; }

        [DisplayName("ESPECIEVOLUME")]
        public string ESPECIEVOLUME { get; set; }

        [DisplayName("MARCAVOLUME")]
        public string MARCAVOLUME { get; set; }

        [DisplayName("NUMEROVOLUME")]
        public string NUMEROVOLUME { get; set; }

        [DisplayName("PESOBRUTONOTA")]
        public int? PESOBRUTONOTA { get; set; }

        [DisplayName("PESOLIQUIDONOTA")]
        public int? PESOLIQUIDONOTA { get; set; }

        [DisplayName("CODOPERACAO")]
        public int? CODOPERACAO { get; set; }

        [DisplayName("TIPOOPERACAO")]
        public string TIPOOPERACAO { get; set; }

        [DisplayName("MOVIMENTAESTOQUE")]
        public string MOVIMENTAESTOQUE { get; set; }

        [DisplayName("MOVIMENTAFINANCEIRO")]
        public string MOVIMENTAFINANCEIRO { get; set; }

        [DisplayName("AVISTA")]
        public string AVISTA { get; set; }

        [DisplayName("TOTALBCIPPI")]
        public int? TOTALBCIPPI { get; set; }

        [DisplayName("CONFIRMADA")]
        public string CONFIRMADA { get; set; }
    }

    public class tcompraEntityTypeConfiguration : IEntityTypeConfiguration<tcompra>
    {
        public void Configure(EntityTypeBuilder<tcompra> builder)
        {
            builder.ToTable("TCOMPRA");

            builder.HasKey(e => e.CONTROLE);

            builder.Property(e => e.CONTROLE).HasColumnName("CONTROLE");

            builder.Property(e => e.NUMERONOTA).HasColumnName("NUMERONOTA");

            builder.Property(e => e.NATUREZAOPERACAO).HasColumnName("NATUREZAOPERACAO");

            builder.Property(e => e.MODELO).HasColumnName("MODELO");

            builder.Property(e => e.SERIE).HasColumnName("SERIE");

            builder.Property(e => e.SUBSERIE).HasColumnName("SUBSERIE");

            builder.Property(e => e.DATAHORACADASTRO).HasColumnName("DATAHORACADASTRO");

            builder.Property(e => e.DATAEMISSAO).HasColumnName("DATAEMISSAO");

            builder.Property(e => e.DATARECEBIMENTO).HasColumnName("DATARECEBIMENTO");

            builder.Property(e => e.CODFORNECEDOR).HasColumnName("CODFORNECEDOR");

            builder.Property(e => e.FORNECEDOR).HasColumnName("FORNECEDOR");

            builder.Property(e => e.CODTRANSPORTADORA).HasColumnName("CODTRANSPORTADORA");

            builder.Property(e => e.TRANSPORTADORA).HasColumnName("TRANSPORTADORA");

            builder.Property(e => e.BASECALCICMS).HasColumnName("BASECALCICMS");

            builder.Property(e => e.VALORICMS).HasColumnName("VALORICMS");

            builder.Property(e => e.TOTALREDUCAOICMS).HasColumnName("TOTALREDUCAOICMS");

            builder.Property(e => e.BASECALCICMSST).HasColumnName("BASECALCICMSST");

            builder.Property(e => e.VALORICMSSUBSTITUICAO).HasColumnName("VALORICMSSUBSTITUICAO");

            builder.Property(e => e.TOTALBCIPI).HasColumnName("TOTALBCIPI");

            builder.Property(e => e.VALORTOTALIPI).HasColumnName("VALORTOTALIPI");

            builder.Property(e => e.TOTALPIS).HasColumnName("TOTALPIS");

            builder.Property(e => e.TOTALPISSUB).HasColumnName("TOTALPISSUB");

            builder.Property(e => e.TOTALCOFINS).HasColumnName("TOTALCOFINS");

            builder.Property(e => e.TOTALCOFINSSUB).HasColumnName("TOTALCOFINSSUB");

            builder.Property(e => e.MODOFRETE).HasColumnName("MODOFRETE");

            builder.Property(e => e.TIPOFRETE).HasColumnName("TIPOFRETE");

            builder.Property(e => e.VALORICMSFRETE).HasColumnName("VALORICMSFRETE");

            builder.Property(e => e.VALORFRETE).HasColumnName("VALORFRETE");

            builder.Property(e => e.VALORSEGURO).HasColumnName("VALORSEGURO");

            builder.Property(e => e.PERCDESCONTO).HasColumnName("PERCDESCONTO");

            builder.Property(e => e.VALORDESCONTO).HasColumnName("VALORDESCONTO");

            builder.Property(e => e.OUTRASDESPESAS).HasColumnName("OUTRASDESPESAS");

            builder.Property(e => e.TOTALSERVICOS).HasColumnName("TOTALSERVICOS");

            builder.Property(e => e.VALORTOTALPRODUTO).HasColumnName("VALORTOTALPRODUTO");

            builder.Property(e => e.VALORENTRADA).HasColumnName("VALORENTRADA");

            builder.Property(e => e.VALORTOTALNOTA).HasColumnName("VALORTOTALNOTA");

            builder.Property(e => e.NFE).HasColumnName("NFE");

            builder.Property(e => e.PROTOCOLODANFE).HasColumnName("PROTOCOLODANFE");

            builder.Property(e => e.CHAVEACESSODANFE).HasColumnName("CHAVEACESSODANFE");

            builder.Property(e => e.INFORMACOESCOMPLEMENTARES).HasColumnName("INFORMACOESCOMPLEMENTARES");

            builder.Property(e => e.CPF).HasColumnName("CPF");

            builder.Property(e => e.CNPJ).HasColumnName("CNPJ");

            builder.Property(e => e.IE).HasColumnName("IE");

            builder.Property(e => e.IESUBSTITUTOTRIBUTARIO).HasColumnName("IESUBSTITUTOTRIBUTARIO");

            builder.Property(e => e.CODCIDADE).HasColumnName("CODCIDADE");

            builder.Property(e => e.CIDADE).HasColumnName("CIDADE");

            builder.Property(e => e.UF).HasColumnName("UF");

            builder.Property(e => e.CEP).HasColumnName("CEP");

            builder.Property(e => e.ENDERECO).HasColumnName("ENDERECO");

            builder.Property(e => e.BAIRRO).HasColumnName("BAIRRO");

            builder.Property(e => e.TELEFONE).HasColumnName("TELEFONE");

            builder.Property(e => e.EMAIL).HasColumnName("EMAIL");

            builder.Property(e => e.SITEFORNECEDOR).HasColumnName("SITEFORNECEDOR");

            builder.Property(e => e.HORASAIDA).HasColumnName("HORASAIDA");

            builder.Property(e => e.CODIGOANTT).HasColumnName("CODIGOANTT");

            builder.Property(e => e.PLACAVAICULO).HasColumnName("PLACAVAICULO");

            builder.Property(e => e.UFTRANSPORTADORA).HasColumnName("UFTRANSPORTADORA");

            builder.Property(e => e.CNPJTRANSPORTADORA).HasColumnName("CNPJTRANSPORTADORA");

            builder.Property(e => e.CPFTRANSPORTADORA).HasColumnName("CPFTRANSPORTADORA");

            builder.Property(e => e.ENDERECOTRANSPORTADORA).HasColumnName("ENDERECOTRANSPORTADORA");

            builder.Property(e => e.CODCIDADETRANSPORTADORA).HasColumnName("CODCIDADETRANSPORTADORA");

            builder.Property(e => e.CIDADETRANSPORTADORA).HasColumnName("CIDADETRANSPORTADORA");

            builder.Property(e => e.BAIRROTRANSPORTADORA).HasColumnName("BAIRROTRANSPORTADORA");

            builder.Property(e => e.CEPTRANSPORTADORA).HasColumnName("CEPTRANSPORTADORA");

            builder.Property(e => e.IETRANSPORTADORA).HasColumnName("IETRANSPORTADORA");

            builder.Property(e => e.QTDEVOLUME).HasColumnName("QTDEVOLUME");

            builder.Property(e => e.ESPECIEVOLUME).HasColumnName("ESPECIEVOLUME");

            builder.Property(e => e.MARCAVOLUME).HasColumnName("MARCAVOLUME");

            builder.Property(e => e.NUMEROVOLUME).HasColumnName("NUMEROVOLUME");

            builder.Property(e => e.PESOBRUTONOTA).HasColumnName("PESOBRUTONOTA");

            builder.Property(e => e.PESOLIQUIDONOTA).HasColumnName("PESOLIQUIDONOTA");

            builder.Property(e => e.CODOPERACAO).HasColumnName("CODOPERACAO");

            builder.Property(e => e.TIPOOPERACAO).HasColumnName("TIPOOPERACAO");

            builder.Property(e => e.MOVIMENTAESTOQUE).HasColumnName("MOVIMENTAESTOQUE");

            builder.Property(e => e.MOVIMENTAFINANCEIRO).HasColumnName("MOVIMENTAFINANCEIRO");

            builder.Property(e => e.AVISTA).HasColumnName("AVISTA");

            builder.Property(e => e.TOTALBCIPPI).HasColumnName("TOTALBCIPPI");

            builder.Property(e => e.CONFIRMADA).HasColumnName("CONFIRMADA");
        }
    }
}

