
namespace Veronika_Domjancic.Forme
{
    partial class FormaOprema
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
            this.btnIzmjeni = new System.Windows.Forms.Button();
            this.btnObriši = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPretrazi = new System.Windows.Forms.TextBox();
            this.btnNatrag = new System.Windows.Forms.Button();
            this.btnDetalji = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.Filteri = new System.Windows.Forms.GroupBox();
            this.btnPonisti = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbOprema = new System.Windows.Forms.ComboBox();
            this.DGVOprema = new System.Windows.Forms.DataGridView();
            this.Filteri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVOprema)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIzmjeni
            // 
            this.btnIzmjeni.Location = new System.Drawing.Point(163, 306);
            this.btnIzmjeni.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnIzmjeni.Name = "btnIzmjeni";
            this.btnIzmjeni.Size = new System.Drawing.Size(56, 19);
            this.btnIzmjeni.TabIndex = 50;
            this.btnIzmjeni.Text = "Izmjeni";
            this.btnIzmjeni.UseVisualStyleBackColor = true;
            this.btnIzmjeni.Click += new System.EventHandler(this.btnIzmjeni_Click);
            // 
            // btnObriši
            // 
            this.btnObriši.Location = new System.Drawing.Point(236, 306);
            this.btnObriši.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnObriši.Name = "btnObriši";
            this.btnObriši.Size = new System.Drawing.Size(56, 19);
            this.btnObriši.TabIndex = 49;
            this.btnObriši.Text = "Obriši";
            this.btnObriši.UseVisualStyleBackColor = true;
            this.btnObriši.Click += new System.EventHandler(this.btnObriši_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "Pretraživanje";
            // 
            // txtPretrazi
            // 
            this.txtPretrazi.Location = new System.Drawing.Point(82, 70);
            this.txtPretrazi.Name = "txtPretrazi";
            this.txtPretrazi.Size = new System.Drawing.Size(221, 20);
            this.txtPretrazi.TabIndex = 47;
            this.txtPretrazi.TextChanged += new System.EventHandler(this.txtPretrazi_TextChanged);
            // 
            // btnNatrag
            // 
            this.btnNatrag.Location = new System.Drawing.Point(9, 11);
            this.btnNatrag.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(35, 29);
            this.btnNatrag.TabIndex = 45;
            this.btnNatrag.Text = "<";
            this.btnNatrag.UseVisualStyleBackColor = true;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // btnDetalji
            // 
            this.btnDetalji.Location = new System.Drawing.Point(421, 306);
            this.btnDetalji.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDetalji.Name = "btnDetalji";
            this.btnDetalji.Size = new System.Drawing.Size(56, 19);
            this.btnDetalji.TabIndex = 44;
            this.btnDetalji.Text = "Detalji";
            this.btnDetalji.UseVisualStyleBackColor = true;
            this.btnDetalji.Click += new System.EventHandler(this.btnDetalji_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(333, 306);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(56, 19);
            this.btnDodaj.TabIndex = 43;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // Filteri
            // 
            this.Filteri.Controls.Add(this.btnPonisti);
            this.Filteri.Controls.Add(this.label5);
            this.Filteri.Controls.Add(this.cmbOprema);
            this.Filteri.Location = new System.Drawing.Point(288, 11);
            this.Filteri.Name = "Filteri";
            this.Filteri.Size = new System.Drawing.Size(302, 53);
            this.Filteri.TabIndex = 52;
            this.Filteri.TabStop = false;
            this.Filteri.Text = "Filtriraj po tipu";
            // 
            // btnPonisti
            // 
            this.btnPonisti.Location = new System.Drawing.Point(214, 13);
            this.btnPonisti.Name = "btnPonisti";
            this.btnPonisti.Size = new System.Drawing.Size(80, 34);
            this.btnPonisti.TabIndex = 19;
            this.btnPonisti.Text = "Poništi";
            this.btnPonisti.UseVisualStyleBackColor = true;
            this.btnPonisti.Click += new System.EventHandler(this.btnPonisti_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Tip:";
            // 
            // cmbOprema
            // 
            this.cmbOprema.FormattingEnabled = true;
            this.cmbOprema.Location = new System.Drawing.Point(50, 19);
            this.cmbOprema.Name = "cmbOprema";
            this.cmbOprema.Size = new System.Drawing.Size(159, 21);
            this.cmbOprema.TabIndex = 16;
            this.cmbOprema.SelectedIndexChanged += new System.EventHandler(this.cmbOprema_SelectedIndexChanged);
            // 
            // DGVOprema
            // 
            this.DGVOprema.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVOprema.Location = new System.Drawing.Point(56, 99);
            this.DGVOprema.Name = "DGVOprema";
            this.DGVOprema.RowHeadersWidth = 51;
            this.DGVOprema.Size = new System.Drawing.Size(492, 150);
            this.DGVOprema.TabIndex = 54;
            // 
            // FormaOprema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.DGVOprema);
            this.Controls.Add(this.Filteri);
            this.Controls.Add(this.btnIzmjeni);
            this.Controls.Add(this.btnObriši);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPretrazi);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.btnDetalji);
            this.Controls.Add(this.btnDodaj);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormaOprema";
            this.Text = "FormaOprema";
            this.Load += new System.EventHandler(this.FormaOprema_Load);
            this.Filteri.ResumeLayout(false);
            this.Filteri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVOprema)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIzmjeni;
        private System.Windows.Forms.Button btnObriši;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPretrazi;
        private System.Windows.Forms.Button btnNatrag;
        private System.Windows.Forms.Button btnDetalji;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.GroupBox Filteri;
        private System.Windows.Forms.Button btnPonisti;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbOprema;
        private System.Windows.Forms.DataGridView DGVOprema;
    }
}