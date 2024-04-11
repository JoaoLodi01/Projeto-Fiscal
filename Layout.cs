using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fiscal
{
    public partial class Layout : Form
    {
        public Layout()
        {
            InitializeComponent();
        }

        private void Sintegra_Click(object sender, EventArgs e)
        {
            Sintegra sintegra = new Sintegra();
            sintegra.Show();
        }
        private void ICMS_Click(object sender, EventArgs e)
        {
            ICMS ICMS = new ICMS();
            ICMS.Show();
        }

        private void Contri_Click(object sender, EventArgs e)
        {
            Contri contri = new Contri();
            contri.Show();
        }

        private void LCDPR_Click(object sender, EventArgs e)
        {
            LCDPR LCDPR = new LCDPR();
            LCDPR.Show();
        }

        private void Contabilista_Click(object sender, EventArgs e)
        {
            Contabil Contabilista = new Contabil();
            Contabilista.Show();
        }

        private void Config_Click(object sender, EventArgs e)
        {
            Config Configuracoes = new Config();
            Configuracoes.Show();
        }

        private void Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ICMS_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void ICMS_MouseLeave(object sender, EventArgs e)
        {
            
        }
    }
}
