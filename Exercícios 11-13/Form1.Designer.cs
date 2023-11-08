
namespace Exercícios_11_13
{
    partial class frmprincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabuadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conversorDeTemperaturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadorDeÁreaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programasToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programasToolStripMenuItem
            // 
            this.programasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tabuadaToolStripMenuItem,
            this.conversorDeTemperaturaToolStripMenuItem,
            this.calculadorDeÁreaToolStripMenuItem});
            this.programasToolStripMenuItem.Name = "programasToolStripMenuItem";
            this.programasToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.programasToolStripMenuItem.Text = "Programas";
            // 
            // tabuadaToolStripMenuItem
            // 
            this.tabuadaToolStripMenuItem.Name = "tabuadaToolStripMenuItem";
            this.tabuadaToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.tabuadaToolStripMenuItem.Text = "Tabuada ";
            this.tabuadaToolStripMenuItem.Click += new System.EventHandler(this.tabuadaToolStripMenuItem_Click);
            // 
            // conversorDeTemperaturaToolStripMenuItem
            // 
            this.conversorDeTemperaturaToolStripMenuItem.Name = "conversorDeTemperaturaToolStripMenuItem";
            this.conversorDeTemperaturaToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.conversorDeTemperaturaToolStripMenuItem.Text = "Conversor de temperatura";
            this.conversorDeTemperaturaToolStripMenuItem.Click += new System.EventHandler(this.conversorDeTemperaturaToolStripMenuItem_Click);
            // 
            // calculadorDeÁreaToolStripMenuItem
            // 
            this.calculadorDeÁreaToolStripMenuItem.Name = "calculadorDeÁreaToolStripMenuItem";
            this.calculadorDeÁreaToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.calculadorDeÁreaToolStripMenuItem.Text = "Calculador de área";
            this.calculadorDeÁreaToolStripMenuItem.Click += new System.EventHandler(this.calculadorDeÁreaToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // frmprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmprincipal";
            this.Text = "Exercícios 11-13";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabuadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conversorDeTemperaturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculadorDeÁreaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}

