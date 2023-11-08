
namespace Exercícios_11_13
{
    partial class frmtemperatura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtcelcius = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnenquanto = new System.Windows.Forms.Button();
            this.btnrepita = new System.Windows.Forms.Button();
            this.btnate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite uma temperatura em Cº: ";
            // 
            // txtcelcius
            // 
            this.txtcelcius.Location = new System.Drawing.Point(206, 45);
            this.txtcelcius.Name = "txtcelcius";
            this.txtcelcius.Size = new System.Drawing.Size(78, 20);
            this.txtcelcius.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Resultado: ";
            // 
            // txtresultado
            // 
            this.txtresultado.Location = new System.Drawing.Point(126, 95);
            this.txtresultado.Multiline = true;
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtresultado.Size = new System.Drawing.Size(138, 63);
            this.txtresultado.TabIndex = 3;
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(180, 234);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(104, 30);
            this.btnvoltar.TabIndex = 12;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btnsair
            // 
            this.btnsair.Location = new System.Drawing.Point(302, 234);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(104, 30);
            this.btnsair.TabIndex = 11;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(55, 234);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(104, 30);
            this.btnlimpar.TabIndex = 10;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnenquanto
            // 
            this.btnenquanto.Location = new System.Drawing.Point(359, 111);
            this.btnenquanto.Name = "btnenquanto";
            this.btnenquanto.Size = new System.Drawing.Size(108, 36);
            this.btnenquanto.TabIndex = 13;
            this.btnenquanto.Text = "Calcular (Enquanto)";
            this.btnenquanto.UseVisualStyleBackColor = true;
            this.btnenquanto.Click += new System.EventHandler(this.btncalc_Click);
            // 
            // btnrepita
            // 
            this.btnrepita.Location = new System.Drawing.Point(487, 111);
            this.btnrepita.Name = "btnrepita";
            this.btnrepita.Size = new System.Drawing.Size(113, 36);
            this.btnrepita.TabIndex = 14;
            this.btnrepita.Text = "Calcular (Repita)";
            this.btnrepita.UseVisualStyleBackColor = true;
            this.btnrepita.Click += new System.EventHandler(this.btnrepita_Click);
            // 
            // btnate
            // 
            this.btnate.Location = new System.Drawing.Point(606, 111);
            this.btnate.Name = "btnate";
            this.btnate.Size = new System.Drawing.Size(113, 36);
            this.btnate.TabIndex = 16;
            this.btnate.Text = "Calcular (Até)";
            this.btnate.UseVisualStyleBackColor = true;
            this.btnate.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmtemperatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnate);
            this.Controls.Add(this.btnrepita);
            this.Controls.Add(this.btnenquanto);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcelcius);
            this.Controls.Add(this.label1);
            this.Name = "frmtemperatura";
            this.Text = "12 - Conversor de temperatura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcelcius;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtresultado;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnenquanto;
        private System.Windows.Forms.Button btnrepita;
        private System.Windows.Forms.Button btnate;
    }
}