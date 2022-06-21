
namespace Veronika_Domjancic.Forme
{
    partial class FormaZaduzeno
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
            this.DGVZaduzeno = new System.Windows.Forms.DataGridView();
            this.btnNatrag = new System.Windows.Forms.Button();
            this.btnDetalji = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVZaduzeno)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIzmjeni
            // 
            this.btnIzmjeni.Location = new System.Drawing.Point(166, 311);
            this.btnIzmjeni.Margin = new System.Windows.Forms.Padding(2);
            this.btnIzmjeni.Name = "btnIzmjeni";
            this.btnIzmjeni.Size = new System.Drawing.Size(56, 19);
            this.btnIzmjeni.TabIndex = 50;
            this.btnIzmjeni.Text = "Izmjeni";
            this.btnIzmjeni.UseVisualStyleBackColor = true;
            this.btnIzmjeni.Click += new System.EventHandler(this.btnIzmjeni_Click);
            // 
            // btnObriši
            // 
            this.btnObriši.Location = new System.Drawing.Point(240, 311);
            this.btnObriši.Margin = new System.Windows.Forms.Padding(2);
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
            this.label4.Location = new System.Drawing.Point(178, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "Pretraživanje";
            // 
            // txtPretrazi
            // 
            this.txtPretrazi.Location = new System.Drawing.Point(253, 23);
            this.txtPretrazi.Name = "txtPretrazi";
            this.txtPretrazi.Size = new System.Drawing.Size(221, 20);
            this.txtPretrazi.TabIndex = 47;
            this.txtPretrazi.TextChanged += new System.EventHandler(this.txtPretrazi_TextChanged);
            // 
            // DGVZaduzeno
            // 
            this.DGVZaduzeno.AllowUserToOrderColumns = true;
            this.DGVZaduzeno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVZaduzeno.Location = new System.Drawing.Point(34, 82);
            this.DGVZaduzeno.Margin = new System.Windows.Forms.Padding(2);
            this.DGVZaduzeno.Name = "DGVZaduzeno";
            this.DGVZaduzeno.RowHeadersWidth = 51;
            this.DGVZaduzeno.RowTemplate.Height = 24;
            this.DGVZaduzeno.Size = new System.Drawing.Size(465, 122);
            this.DGVZaduzeno.TabIndex = 46;
            // 
            // btnNatrag
            // 
            this.btnNatrag.Location = new System.Drawing.Point(13, 17);
            this.btnNatrag.Margin = new System.Windows.Forms.Padding(2);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(35, 29);
            this.btnNatrag.TabIndex = 45;
            this.btnNatrag.Text = "<";
            this.btnNatrag.UseVisualStyleBackColor = true;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // btnDetalji
            // 
            this.btnDetalji.Location = new System.Drawing.Point(424, 311);
            this.btnDetalji.Margin = new System.Windows.Forms.Padding(2);
            this.btnDetalji.Name = "btnDetalji";
            this.btnDetalji.Size = new System.Drawing.Size(56, 19);
            this.btnDetalji.TabIndex = 44;
            this.btnDetalji.Text = "Detalji";
            this.btnDetalji.UseVisualStyleBackColor = true;
            this.btnDetalji.Click += new System.EventHandler(this.btnDetalji_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(337, 311);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(2);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(56, 19);
            this.btnDodaj.TabIndex = 43;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // FormaZaduzeno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnIzmjeni);
            this.Controls.Add(this.btnObriši);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPretrazi);
            this.Controls.Add(this.DGVZaduzeno);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.btnDetalji);
            this.Controls.Add(this.btnDodaj);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormaZaduzeno";
            this.Text = "FormaZaduzeno";
            this.Load += new System.EventHandler(this.FormaZaduzeno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVZaduzeno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIzmjeni;
        private System.Windows.Forms.Button btnObriši;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPretrazi;
        private System.Windows.Forms.DataGridView DGVZaduzeno;
        private System.Windows.Forms.Button btnNatrag;
        private System.Windows.Forms.Button btnDetalji;
        private System.Windows.Forms.Button btnDodaj;
    }
}