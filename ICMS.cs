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
    public partial class ICMS : Form
    {
        public ICMS()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Registro0 reg0 = new Registro0();
            reg0.spedicms = this;
            reg0.SpedIcms();
        }

        private void RdButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
