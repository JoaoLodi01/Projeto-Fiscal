using Fiscal.Classe;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Fiscal
{
    public class Registro0
    {
        public ICMS spedicms;

        public void SpedIcms()
        {
            using (var context = new ConexaoBD())
            {
                var DadosEmitente = context.Emitente.FirstOrDefault();
                var DadosCont = context.Contabilista.FirstOrDefault();
                var DadosFornecedor = context.Fornecedores.FirstOrDefault();
                var DadosCompras = context.Compras.FirstOrDefault();
                var DadosEstoque = context.Estoque.FirstOrDefault();

                string registros;

                //Remover máscara CNPJ e Telefone

                string CPFsemMascara = DadosEmitente.CPF.Replace(".", "").Replace("-", "").Replace(" ", "");
                string TelefoneSemMascara = DadosEmitente.TELEFONE.Replace("(", "").Replace(")", "").Replace(" ", "");
                string NumeroSemMascara = DadosEmitente.NUMERO.Replace("(", "").Replace(")", "").Replace("-", "");

                //Registro 0000 

                   registros = "|0000|" + spedicms.Nlayout.Text + "0|" + "01012000|" + "01012030|" + DadosEmitente.RAZAOSOCIAL + "|";
                   registros += DadosEmitente.CNPJ + "|" + CPFsemMascara + "|" + DadosEmitente.UF + "|";
                   registros += DadosEmitente.CODCIDADEIBGE + "|" + DadosEmitente.IM + "|" + DadosEmitente.SUFRAMA + "|" + "\n";
        
                //Verifica RdButton Perfis A B C
                if (spedicms.RdPerfilA.Checked)
                {
                    registros += "|A";
                }
                else if (spedicms.RdPerfilB.Checked)
                {
                    registros += "|B";
                }
                else if (spedicms.RdPerfilC.Checked)
                {
                    registros += "|C";
                }

                //Verifica RdButton Atividade

                if (spedicms.RdOriginal.Checked)
                {
                    registros += "0";
                }
                else if (spedicms.RdSubs.Checked)
                {
                    registros += "1";
                }

                registros += "|0001|0|\n";

                //Registro 0005

                registros += "|0005|" + DadosEmitente.NOMEFANTASIA + "|" + DadosEmitente.CEP + "|" + DadosEmitente.ENDERECO + "|";
                registros += NumeroSemMascara + "|" + DadosEmitente.COMPLEMENTO + "|" + DadosEmitente.BAIRRO + "|";
                registros += TelefoneSemMascara + "|" + DadosEmitente.FAX + "|" + DadosEmitente.EMAIL + "|" + "\n";

                //Registro 0100

                registros += "|0100|" + DadosCont.NOME + "|" + DadosCont.CPF + "|" + DadosCont.CRC + "|" + DadosCont.CNPJ + "|";
                registros += DadosCont.CEP + "|" + DadosCont.ENDERECO + "|" + NumeroSemMascara + "|" + DadosCont.COMPLEMENTO + "|";
                registros += DadosCont.BAIRRO + "|" + TelefoneSemMascara + "|" + DadosCont.FAX + "|" + DadosCont.EMAIL + "|" + "\n";

                //Registro 0150

                registros += "|0150|" + DadosFornecedor.CONTROLE + "|" + DadosFornecedor.NOMEFANTASIA + "|" + DadosFornecedor.CODIGOPAIS + "|" + DadosFornecedor.CNPJ + "|";
                registros += CPFsemMascara + "|" + DadosFornecedor.IE + "|" + DadosFornecedor.CODCIDADE + "|" + DadosFornecedor.SUFRAMA + "|";
                registros += DadosFornecedor.ENDERECO + "|" + NumeroSemMascara + "|" + DadosFornecedor.COMPLEMENTO + "|" + DadosFornecedor.BAIRRO + "|" + "\n";

                //Registro 0200

                registros += "|0200|" + DadosEstoque.Controle + "|" + DadosEstoque.Produto + "|" + DadosEstoque.CodBarras + "|";
                registros += DadosEstoque.Unidade + "|" + DadosEstoque.CodAplicacaoProduto + "|" + DadosEstoque.NCM + "|" + DadosEstoque.CodEmitente + "|";
                registros += DadosEstoque.AliquotaIcmsEcf + "|" + DadosEstoque.Cest + "|" + "\n";


                SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                saveFileDialog1.Filter = "Arquivo de teste (*.txt)|.txt";
                saveFileDialog1.Title = "Salvar Arquivo SPED";
                saveFileDialog1.FileName = "SPED" + DateTime.Now.ToString("yyyyMMdd");
                saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string caminhoArquivo = saveFileDialog1.FileName;
                    try
                    {

                        using (StreamWriter sw = new StreamWriter(caminhoArquivo))
                        {
                            sw.Write(registros);
                        }

                        MessageBox.Show("SPED gerado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro ao gerar o arquivo SPED:" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
