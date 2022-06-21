
namespace Veronika_Domjancic.Forme
{
    partial class FormaZaposlenici
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
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnDetalji = new System.Windows.Forms.Button();
            this.btnNatrag = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPretrazi = new System.Windows.Forms.TextBox();
            this.btnObriši = new System.Windows.Forms.Button();
            this.btnIzmjeni = new System.Windows.Forms.Button();
            this.DGVZaposlenici = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVZaposlenici)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(449, 383);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 0;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnDetalji
            // 
            this.btnDetalji.Location = new System.Drawing.Point(566, 383);
            this.btnDetalji.Name = "btnDetalji";
            this.btnDetalji.Size = new System.Drawing.Size(75, 23);
            this.btnDetalji.TabIndex = 1;
            this.btnDetalji.Text = "Detalji";
            this.btnDetalji.UseVisualStyleBackColor = true;
            this.btnDetalji.Click += new System.EventHandler(this.btnDetalji_Click);
            // 
            // btnNatrag
            // 
            this.btnNatrag.Location = new System.Drawing.Point(17, 21);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(47, 36);
            this.btnNatrag.TabIndex = 2;
            this.btnNatrag.Text = "<";
            this.btnNatrag.UseVisualStyleBackColor = true;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(238, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 40;
            this.label4.Text = "Pretraživanje";
            // 
            // txtPretrazi
            // 
            this.txtPretrazi.Location = new System.Drawing.Point(337, 28);
            this.txtPretrazi.Margin = new System.Windows.Forms.Padding(4);
            this.txtPretrazi.Name = "txtPretrazi";
            this.txtPretrazi.Size = new System.Drawing.Size(293, 22);
            this.txtPretrazi.TabIndex = 39;
            this.txtPretrazi.Text = "Traži";
            this.txtPretrazi.TextChanged += new System.EventHandler(this.txtPretrazi_TextChanged);
            // 
            // btnObriši
            // 
            this.btnObriši.Location = new System.Drawing.Point(320, 383);
            this.btnObriši.Name = "btnObriši";
            this.btnObriši.Size = new System.Drawing.Size(75, 23);
            this.btnObriši.TabIndex = 41;
            this.btnObriši.Text = "Obriši";
            this.btnObriši.UseVisualStyleBackColor = true;
            this.btnObriši.Click += new System.EventHandler(this.btnObriši_Click);
            // 
            // btnIzmjeni
            // 
            this.btnIzmjeni.Location = new System.Drawing.Point(222, 383);
            this.btnIzmjeni.Name = "btnIzmjeni";
            this.btnIzmjeni.Size = new System.Drawing.Size(75, 23);
            this.btnIzmjeni.TabIndex = 42;
            this.btnIzmjeni.Text = "Izmjeni";
            this.btnIzmjeni.UseVisualStyleBackColor = true;
            this.btnIzmjeni.Click += new System.EventHandler(this.btnIzmjeni_Click);
            // 
            // DGVZaposlenici
            // 
            this.DGVZaposlenici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVZaposlenici.Location = new System.Drawing.Point(89, 96);
            this.DGVZaposlenici.Name = "DGVZaposlenici";
            this.DGVZaposlenici.RowHeadersWidth = 51;
            this.DGVZaposlenici.RowTemplate.Height = 24;
            this.DGVZaposlenici.Size = new System.Drawing.Size(613, 179);
            this.DGVZaposlenici.TabIndex = 43;
            this.DGVZaposlenici.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FormaZaposlenici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DGVZaposlenici);
            this.Controls.Add(this.btnIzmjeni);
            this.Controls.Add(this.btnObriši);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPretrazi);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.btnDetalji);
            this.Controls.Add(this.btnDodaj);
            this.Name = "FormaZaposlenici";
            this.Text = "Zaposlenici";
            this.Load += new System.EventHandler(this.FormaZaposlenici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVZaposlenici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnDetalji;
        private System.Windows.Forms.Button btnNatrag;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPretrazi;
        private System.Windows.Forms.Button btnObriši;
        private System.Windows.Forms.Button btnIzmjeni;
        private System.Windows.Forms.DataGridView DGVZaposlenici;
    }
}