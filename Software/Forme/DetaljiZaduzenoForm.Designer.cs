
namespace Veronika_Domjancic.Forme
{
    partial class DetaljiZaduzenoForm
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
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtZaposlenik = new System.Windows.Forms.TextBox();
            this.txtOprema = new System.Windows.Forms.TextBox();
            this.txtZaduzivanja = new System.Windows.Forms.TextBox();
            this.txtRazduzivanja = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Location = new System.Drawing.Point(19, 16);
            this.btnIzlaz.Margin = new System.Windows.Forms.Padding(2);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(33, 27);
            this.btnIzlaz.TabIndex = 34;
            this.btnIzlaz.Text = "<";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 201);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Datum razduživanja:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Datum zaduživanja:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Zaposlenik:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Oprema:";
            // 
            // txtZaposlenik
            // 
            this.txtZaposlenik.Location = new System.Drawing.Point(150, 98);
            this.txtZaposlenik.Margin = new System.Windows.Forms.Padding(2);
            this.txtZaposlenik.Name = "txtZaposlenik";
            this.txtZaposlenik.Size = new System.Drawing.Size(218, 20);
            this.txtZaposlenik.TabIndex = 32;
            // 
            // txtOprema
            // 
            this.txtOprema.Location = new System.Drawing.Point(150, 48);
            this.txtOprema.Margin = new System.Windows.Forms.Padding(2);
            this.txtOprema.Name = "txtOprema";
            this.txtOprema.Size = new System.Drawing.Size(218, 20);
            this.txtOprema.TabIndex = 31;
            // 
            // txtZaduzivanja
            // 
            this.txtZaduzivanja.Location = new System.Drawing.Point(174, 147);
            this.txtZaduzivanja.Name = "txtZaduzivanja";
            this.txtZaduzivanja.Size = new System.Drawing.Size(194, 20);
            this.txtZaduzivanja.TabIndex = 35;
            // 
            // txtRazduzivanja
            // 
            this.txtRazduzivanja.Location = new System.Drawing.Point(178, 201);
            this.txtRazduzivanja.Name = "txtRazduzivanja";
            this.txtRazduzivanja.Size = new System.Drawing.Size(190, 20);
            this.txtRazduzivanja.TabIndex = 36;
            // 
            // DetaljiZaduzenoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.txtRazduzivanja);
            this.Controls.Add(this.txtZaduzivanja);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.txtZaposlenik);
            this.Controls.Add(this.txtOprema);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DetaljiZaduzenoForm";
            this.Text = "DetaljiZaduzenoForm";
            this.Load += new System.EventHandler(this.DetaljiZaduzenoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtZaposlenik;
        private System.Windows.Forms.TextBox txtOprema;
        private System.Windows.Forms.TextBox txtZaduzivanja;
        private System.Windows.Forms.TextBox txtRazduzivanja;
    }
}