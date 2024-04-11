namespace Fiscal
{
    partial class Layout
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Layout));
            this.Selecao = new System.Windows.Forms.GroupBox();
            this.Contri = new System.Windows.Forms.Button();
            this.LCDPR = new System.Windows.Forms.Button();
            this.ICMS = new System.Windows.Forms.Button();
            this.Sintegra = new System.Windows.Forms.Button();
            this.Status = new System.Windows.Forms.GroupBox();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Config = new System.Windows.Forms.Button();
            this.Sair = new System.Windows.Forms.Button();
            this.Contabilista = new System.Windows.Forms.Button();
            this.Selecao.SuspendLayout();
            this.Status.SuspendLayout();
            this.SuspendLayout();
            // 
            // Selecao
            // 
            this.Selecao.BackColor = System.Drawing.Color.Transparent;
            this.Selecao.Controls.Add(this.Contri);
            this.Selecao.Controls.Add(this.LCDPR);
            this.Selecao.Controls.Add(this.ICMS);
            this.Selecao.Controls.Add(this.Sintegra);
            this.Selecao.Controls.Add(this.Status);
            this.Selecao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Selecao.Location = new System.Drawing.Point(12, 12);
            this.Selecao.Name = "Selecao";
            this.Selecao.Size = new System.Drawing.Size(590, 295);
            this.Selecao.TabIndex = 0;
            this.Selecao.TabStop = false;
            this.Selecao.Text = "Seleção do arquivo a ser gerado:";
            // 
            // Contri
            // 
            this.Contri.BackgroundImage = global::Fiscal.Properties.Resources.contri;
            this.Contri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Contri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Contri.FlatAppearance.BorderSize = 0;
            this.Contri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Contri.Location = new System.Drawing.Point(321, 55);
            this.Contri.Name = "Contri";
            this.Contri.Size = new System.Drawing.Size(100, 100);
            this.Contri.TabIndex = 9;
            this.Contri.UseVisualStyleBackColor = true;
            this.Contri.Click += new System.EventHandler(this.Contri_Click);
            // 
            // LCDPR
            // 
            this.LCDPR.BackgroundImage = global::Fiscal.Properties.Resources.lcdpr;
            this.LCDPR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LCDPR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LCDPR.FlatAppearance.BorderSize = 0;
            this.LCDPR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LCDPR.Location = new System.Drawing.Point(462, 55);
            this.LCDPR.Name = "LCDPR";
            this.LCDPR.Size = new System.Drawing.Size(100, 100);
            this.LCDPR.TabIndex = 8;
            this.LCDPR.UseVisualStyleBackColor = true;
            this.LCDPR.Click += new System.EventHandler(this.LCDPR_Click);
            // 
            // ICMS
            // 
            this.ICMS.BackgroundImage = global::Fiscal.Properties.Resources.sped;
            this.ICMS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ICMS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ICMS.FlatAppearance.BorderSize = 0;
            this.ICMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ICMS.Location = new System.Drawing.Point(171, 55);
            this.ICMS.Name = "ICMS";
            this.ICMS.Size = new System.Drawing.Size(100, 100);
            this.ICMS.TabIndex = 7;
            this.ICMS.UseVisualStyleBackColor = true;
            this.ICMS.Click += new System.EventHandler(this.ICMS_Click);
            this.ICMS.MouseEnter += new System.EventHandler(this.ICMS_MouseEnter);
            this.ICMS.MouseLeave += new System.EventHandler(this.ICMS_MouseLeave);
            // 
            // Sintegra
            // 
            this.Sintegra.BackgroundImage = global::Fiscal.Properties.Resources.sintegra;
            this.Sintegra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Sintegra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sintegra.FlatAppearance.BorderSize = 0;
            this.Sintegra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sintegra.ForeColor = System.Drawing.Color.Transparent;
            this.Sintegra.Location = new System.Drawing.Point(26, 55);
            this.Sintegra.Name = "Sintegra";
            this.Sintegra.Size = new System.Drawing.Size(100, 100);
            this.Sintegra.TabIndex = 6;
            this.Sintegra.UseVisualStyleBackColor = true;
            this.Sintegra.Click += new System.EventHandler(this.Sintegra_Click);
            // 
            // Status
            // 
            this.Status.Controls.Add(this.progressBar2);
            this.Status.Controls.Add(this.progressBar1);
            this.Status.Location = new System.Drawing.Point(6, 173);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(578, 96);
            this.Status.TabIndex = 6;
            this.Status.TabStop = false;
            this.Status.Text = "Status da geração";
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(20, 57);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(536, 20);
            this.progressBar2.TabIndex = 5;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(20, 31);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(536, 20);
            this.progressBar1.TabIndex = 4;
            // 
            // Config
            // 
            this.Config.BackColor = System.Drawing.Color.Blue;
            this.Config.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Config.ForeColor = System.Drawing.Color.White;
            this.Config.Image = ((System.Drawing.Image)(resources.GetObject("Config.Image")));
            this.Config.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Config.Location = new System.Drawing.Point(194, 322);
            this.Config.Name = "Config";
            this.Config.Size = new System.Drawing.Size(176, 32);
            this.Config.TabIndex = 4;
            this.Config.Text = "Configurações  - F11";
            this.Config.UseVisualStyleBackColor = false;
            this.Config.Click += new System.EventHandler(this.Config_Click);
            // 
            // Sair
            // 
            this.Sair.BackColor = System.Drawing.Color.Blue;
            this.Sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sair.ForeColor = System.Drawing.Color.White;
            this.Sair.Image = ((System.Drawing.Image)(resources.GetObject("Sair.Image")));
            this.Sair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Sair.Location = new System.Drawing.Point(488, 322);
            this.Sair.Name = "Sair";
            this.Sair.Size = new System.Drawing.Size(114, 32);
            this.Sair.TabIndex = 3;
            this.Sair.Text = "Sair - F10";
            this.Sair.UseVisualStyleBackColor = false;
            this.Sair.Click += new System.EventHandler(this.Sair_Click);
            // 
            // Contabilista
            // 
            this.Contabilista.BackColor = System.Drawing.Color.Blue;
            this.Contabilista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Contabilista.ForeColor = System.Drawing.Color.White;
            this.Contabilista.Image = ((System.Drawing.Image)(resources.GetObject("Contabilista.Image")));
            this.Contabilista.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Contabilista.Location = new System.Drawing.Point(12, 322);
            this.Contabilista.Name = "Contabilista";
            this.Contabilista.Size = new System.Drawing.Size(176, 32);
            this.Contabilista.TabIndex = 1;
            this.Contabilista.Text = "Contabilista - F12";
            this.Contabilista.UseVisualStyleBackColor = false;
            this.Contabilista.Click += new System.EventHandler(this.Contabilista_Click);
            // 
            // Layout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(614, 366);
            this.Controls.Add(this.Config);
            this.Controls.Add(this.Sair);
            this.Controls.Add(this.Contabilista);
            this.Controls.Add(this.Selecao);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Layout";
            this.Text = "Fiscal SG Master || SGBr Sistemas";
            this.Selecao.ResumeLayout(false);
            this.Status.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Selecao;
        private System.Windows.Forms.GroupBox Status;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button Contri;
        private System.Windows.Forms.Button LCDPR;
        private System.Windows.Forms.Button ICMS;
        private System.Windows.Forms.Button Sintegra;
        private System.Windows.Forms.Button Contabilista;
        private System.Windows.Forms.Button Sair;
        private System.Windows.Forms.Button Config;
        private System.Windows.Forms.ProgressBar progressBar2;
    }
}

