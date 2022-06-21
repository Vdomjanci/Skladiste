
namespace Veronika_Domjancic.Forme
{
    partial class DodajZaduzenoForm
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
            this.btnSpremi = new System.Windows.Forms.Button();
            this.dtpRazduzivanja = new System.Windows.Forms.DateTimePicker();
            this.dtpZaduzivanja = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbOprema = new System.Windows.Forms.ComboBox();
            this.cmbZaposlenik = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Location = new System.Drawing.Point(32, 25);
            this.btnIzlaz.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(33, 27);
            this.btnIzlaz.TabIndex = 34;
            this.btnIzlaz.Text = "<";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(295, 285);
            this.btnSpremi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(95, 28);
            this.btnSpremi.TabIndex = 33;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // dtpRazduzivanja
            // 
            this.dtpRazduzivanja.Location = new System.Drawing.Point(231, 206);
            this.dtpRazduzivanja.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpRazduzivanja.Name = "dtpRazduzivanja";
            this.dtpRazduzivanja.Size = new System.Drawing.Size(151, 20);
            this.dtpRazduzivanja.TabIndex = 30;
            // 
            // dtpZaduzivanja
            // 
            this.dtpZaduzivanja.Location = new System.Drawing.Point(223, 155);
            this.dtpZaduzivanja.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpZaduzivanja.Name = "dtpZaduzivanja";
            this.dtpZaduzivanja.Size = new System.Drawing.Size(151, 20);
            this.dtpZaduzivanja.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 210);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Datum razduživanja:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 159);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Datum zaduživanja:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Zaposlenik:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Oprema:";
            // 
            // cmbOprema
            // 
            this.cmbOprema.FormattingEnabled = true;
            this.cmbOprema.Location = new System.Drawing.Point(223, 56);
            this.cmbOprema.Name = "cmbOprema";
            this.cmbOprema.Size = new System.Drawing.Size(151, 21);
            this.cmbOprema.TabIndex = 35;
            // 
            // cmbZaposlenik
            // 
            this.cmbZaposlenik.FormattingEnabled = true;
            this.cmbZaposlenik.Location = new System.Drawing.Point(223, 106);
            this.cmbZaposlenik.Name = "cmbZaposlenik";
            this.cmbZaposlenik.Size = new System.Drawing.Size(151, 21);
            this.cmbZaposlenik.TabIndex = 36;
            // 
            // DodajZaduzenoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.cmbZaposlenik);
            this.Controls.Add(this.cmbOprema);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.dtpRazduzivanja);
            this.Controls.Add(this.dtpZaduzivanja);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DodajZaduzenoForm";
            this.Text = "DodajZaduzenoForm";
            this.Load += new System.EventHandler(this.DodajZaduzenoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.DateTimePicker dtpRazduzivanja;
        private System.Windows.Forms.DateTimePicker dtpZaduzivanja;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbOprema;
        private System.Windows.Forms.ComboBox cmbZaposlenik;
    }
}