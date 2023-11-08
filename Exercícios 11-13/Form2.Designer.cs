
namespace Exercícios_11_13
{
    partial class frmtabuada
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
            this.lblnumero = new System.Windows.Forms.Label();
            this.lblresult = new System.Windows.Forms.Label();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnenquanto = new System.Windows.Forms.Button();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.btnrepita = new System.Windows.Forms.Button();
            this.btnate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblnumero
            // 
            this.lblnumero.AutoSize = true;
            this.lblnumero.Location = new System.Drawing.Point(42, 51);
            this.lblnumero.Name = "lblnumero";
            this.lblnumero.Size = new System.Drawing.Size(107, 13);
            this.lblnumero.TabIndex = 0;
            this.lblnumero.Text = "Escreva um número: ";
            this.lblnumero.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Location = new System.Drawing.Point(45, 82);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(61, 13);
            this.lblresult.TabIndex = 1;
            this.lblresult.Text = "Resultado: ";
            this.lblresult.Visible = false;
            this.lblresult.Click += new System.EventHandler(this.txtresult_Click);
            // 
            // txtnum
            // 
            this.txtnum.Location = new System.Drawing.Point(155, 48);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(64, 20);
            this.txtnum.TabIndex = 2;
            this.txtnum.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(45, 270);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(104, 30);
            this.btnlimpar.TabIndex = 7;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnsair
            // 
            this.btnsair.Location = new System.Drawing.Point(292, 270);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(104, 30);
            this.btnsair.TabIndex = 8;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(170, 270);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(104, 30);
            this.btnvoltar.TabIndex = 9;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnenquanto
            // 
            this.btnenquanto.Location = new System.Drawing.Point(45, 225);
            this.btnenquanto.Name = "btnenquanto";
            this.btnenquanto.Size = new System.Drawing.Size(117, 39);
            this.btnenquanto.TabIndex = 10;
            this.btnenquanto.Text = "Calcular (Enquanto)";
            this.btnenquanto.UseVisualStyleBackColor = true;
            this.btnenquanto.Click += new System.EventHandler(this.btncalc_Click);
            // 
            // txtresultado
            // 
            this.txtresultado.Location = new System.Drawing.Point(155, 82);
            this.txtresultado.Multiline = true;
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtresultado.Size = new System.Drawing.Size(285, 70);
            this.txtresultado.TabIndex = 12;
            this.txtresultado.Visible = false;
            this.txtresultado.TextChanged += new System.EventHandler(this.txtresultado_TextChanged);
            // 
            // btnrepita
            // 
            this.btnrepita.Location = new System.Drawing.Point(190, 225);
            this.btnrepita.Name = "btnrepita";
            this.btnrepita.Size = new System.Drawing.Size(117, 39);
            this.btnrepita.TabIndex = 13;
            this.btnrepita.Text = "Calcular (Repita)";
            this.btnrepita.UseVisualStyleBackColor = true;
            this.btnrepita.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // btnate
            // 
            this.btnate.Location = new System.Drawing.Point(334, 225);
            this.btnate.Name = "btnate";
            this.btnate.Size = new System.Drawing.Size(117, 39);
            this.btnate.TabIndex = 14;
            this.btnate.Text = "Calcular (Até)";
            this.btnate.UseVisualStyleBackColor = true;
            this.btnate.Click += new System.EventHandler(this.btnate_Click);
            // 
            // frmtabuada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnate);
            this.Controls.Add(this.btnrepita);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.btnenquanto);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.lblnumero);
            this.Name = "frmtabuada";
            this.Text = "11 - Tabuada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnumero;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnenquanto;
        private System.Windows.Forms.TextBox txtresultado;
        private System.Windows.Forms.Button btnrepita;
        private System.Windows.Forms.Button btnate;
    }
}