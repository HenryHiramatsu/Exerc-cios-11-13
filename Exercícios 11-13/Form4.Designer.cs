
namespace Exercícios_11_13
{
    partial class frmarea
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtlarg = new System.Windows.Forms.TextBox();
            this.txtcomp = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.btncalc = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.lblatotal = new System.Windows.Forms.Label();
            this.txtatotal = new System.Windows.Forms.TextBox();
            this.lblarea = new System.Windows.Forms.Label();
            this.txtarea = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite a largura do cômodo: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digite o comprimento do cômodo: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Digite o nome do cômodo:";
            // 
            // txtlarg
            // 
            this.txtlarg.Location = new System.Drawing.Point(187, 30);
            this.txtlarg.Name = "txtlarg";
            this.txtlarg.Size = new System.Drawing.Size(143, 20);
            this.txtlarg.TabIndex = 3;
            // 
            // txtcomp
            // 
            this.txtcomp.Location = new System.Drawing.Point(205, 70);
            this.txtcomp.Name = "txtcomp";
            this.txtcomp.Size = new System.Drawing.Size(117, 20);
            this.txtcomp.TabIndex = 4;
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(200, 102);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(122, 20);
            this.txtnome.TabIndex = 5;
            // 
            // btncalc
            // 
            this.btncalc.Location = new System.Drawing.Point(389, 47);
            this.btncalc.Name = "btncalc";
            this.btncalc.Size = new System.Drawing.Size(101, 43);
            this.btncalc.TabIndex = 6;
            this.btncalc.Text = "Calcular";
            this.btncalc.UseVisualStyleBackColor = true;
            this.btncalc.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(48, 251);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(89, 43);
            this.btnclear.TabIndex = 7;
            this.btnclear.Text = "Limpar";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(143, 251);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(89, 43);
            this.btnvoltar.TabIndex = 8;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btnsair
            // 
            this.btnsair.Location = new System.Drawing.Point(238, 251);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(89, 43);
            this.btnsair.TabIndex = 9;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // lblatotal
            // 
            this.lblatotal.AutoSize = true;
            this.lblatotal.Location = new System.Drawing.Point(31, 155);
            this.lblatotal.Name = "lblatotal";
            this.lblatotal.Size = new System.Drawing.Size(58, 13);
            this.lblatotal.TabIndex = 10;
            this.lblatotal.Text = "Área total: ";
            this.lblatotal.Visible = false;
            // 
            // txtatotal
            // 
            this.txtatotal.Location = new System.Drawing.Point(200, 152);
            this.txtatotal.Name = "txtatotal";
            this.txtatotal.ReadOnly = true;
            this.txtatotal.Size = new System.Drawing.Size(122, 20);
            this.txtatotal.TabIndex = 11;
            this.txtatotal.Visible = false;
            this.txtatotal.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // lblarea
            // 
            this.lblarea.AutoSize = true;
            this.lblarea.Location = new System.Drawing.Point(31, 155);
            this.lblarea.Name = "lblarea";
            this.lblarea.Size = new System.Drawing.Size(32, 13);
            this.lblarea.TabIndex = 12;
            this.lblarea.Text = "Área:";
            this.lblarea.Visible = false;
            // 
            // txtarea
            // 
            this.txtarea.Location = new System.Drawing.Point(200, 152);
            this.txtarea.Name = "txtarea";
            this.txtarea.Size = new System.Drawing.Size(122, 20);
            this.txtarea.TabIndex = 13;
            this.txtarea.Visible = false;
            // 
            // frmarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtarea);
            this.Controls.Add(this.lblarea);
            this.Controls.Add(this.txtatotal);
            this.Controls.Add(this.lblatotal);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btncalc);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.txtcomp);
            this.Controls.Add(this.txtlarg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmarea";
            this.Text = "13 - Calculadora de área";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtlarg;
        private System.Windows.Forms.TextBox txtcomp;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Button btncalc;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Label lblatotal;
        private System.Windows.Forms.TextBox txtatotal;
        private System.Windows.Forms.Label lblarea;
        private System.Windows.Forms.TextBox txtarea;
    }
}