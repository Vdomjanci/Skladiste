
namespace Veronika_Domjancic.Forme
{
    partial class FormaOtpis
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
            this.DGVOprema = new System.Windows.Forms.DataGridView();
            this.btnNatrag = new System.Windows.Forms.Button();
            this.btnDetalji = new System.Windows.Forms.Button();
            this.Filteri = new System.Windows.Forms.GroupBox();
            this.btnPonisti = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbOprema = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVOprema)).BeginInit();
            this.Filteri.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIzmjeni
            // 
            this.btnIzmjeni.Location = new System.Drawing.Point(224, 299);
            this.btnIzmjeni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIzmjeni.Name = "btnIzmjeni";
            this.btnIzmjeni.Size = new System.Drawing.Size(75, 23);
            this.btnIzmjeni.TabIndex = 50;
            this.btnIzmjeni.Text = "Izmjeni";
            this.btnIzmjeni.UseVisualStyleBackColor = true;
            this.btnIzmjeni.Click += new System.EventHandler(this.btnIzmjeni_Click);
            // 
            // btnObriši
            // 
            this.btnObriši.Location = new System.Drawing.Point(344, 299);
            this.btnObriši.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnObriši.Name = "btnObriši";
            this.btnObriši.Size = new System.Drawing.Size(75, 23);
            this.btnObriši.TabIndex = 49;
            this.btnObriši.Text = "Obriši";
            this.btnObriši.UseVisualStyleBackColor = true;
            this.btnObriši.Click += new System.EventHandler(this.btnObriši_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 75);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 48;
            this.label4.Text = "Pretraživanje";
            // 
            // txtPretrazi
            // 
            this.txtPretrazi.Location = new System.Drawing.Point(121, 71);
            this.txtPretrazi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPretrazi.Name = "txtPretrazi";
            this.txtPretrazi.Size = new System.Drawing.Size(293, 22);
            this.txtPretrazi.TabIndex = 47;
            this.txtPretrazi.TextChanged += new System.EventHandler(this.txtPretrazi_TextChanged);
            // 
            // DGVOprema
            // 
            this.DGVOprema.AllowUserToOrderColumns = true;
            this.DGVOprema.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVOprema.Location = new System.Drawing.Point(45, 102);
            this.DGVOprema.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGVOprema.Name = "DGVOprema";
            this.DGVOprema.RowHeadersWidth = 51;
            this.DGVOprema.RowTemplate.Height = 24;
            this.DGVOprema.Size = new System.Drawing.Size(620, 150);
            this.DGVOprema.TabIndex = 46;
            // 
            // btnNatrag
            // 
            this.btnNatrag.Location = new System.Drawing.Point(17, 22);
            this.btnNatrag.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(47, 36);
            this.btnNatrag.TabIndex = 45;
            this.btnNatrag.Text = "<";
            this.btnNatrag.UseVisualStyleBackColor = true;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // btnDetalji
            // 
            this.btnDetalji.Location = new System.Drawing.Point(490, 299);
            this.btnDetalji.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDetalji.Name = "btnDetalji";
            this.btnDetalji.Size = new System.Drawing.Size(75, 23);
            this.btnDetalji.TabIndex = 44;
            this.btnDetalji.Text = "Detalji";
            this.btnDetalji.UseVisualStyleBackColor = true;
            this.btnDetalji.Click += new System.EventHandler(this.btnDetalji_Click);
            // 
            // Filteri
            // 
            this.Filteri.Controls.Add(this.btnPonisti);
            this.Filteri.Controls.Add(this.label5);
            this.Filteri.Controls.Add(this.cmbOprema);
            this.Filteri.Location = new System.Drawing.Point(376, 2);
            this.Filteri.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Filteri.Name = "Filteri";
            this.Filteri.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Filteri.Size = new System.Drawing.Size(403, 65);
            this.Filteri.TabIndex = 53;
            this.Filteri.TabStop = false;
            this.Filteri.Text = "Filtriraj po tipu";
            // 
            // btnPonisti
            // 
            this.btnPonisti.Location = new System.Drawing.Point(285, 16);
            this.btnPonisti.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPonisti.Name = "btnPonisti";
            this.btnPonisti.Size = new System.Drawing.Size(107, 42);
            this.btnPonisti.TabIndex = 19;
            this.btnPonisti.Text = "Poništi";
            this.btnPonisti.UseVisualStyleBackColor = true;
            this.btnPonisti.Click += new System.EventHandler(this.btnPonisti_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 27);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Tip:";
            // 
            // cmbOprema
            // 
            this.cmbOprema.FormattingEnabled = true;
            this.cmbOprema.Location = new System.Drawing.Point(67, 23);
            this.cmbOprema.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbOprema.Name = "cmbOprema";
            this.cmbOprema.Size = new System.Drawing.Size(211, 24);
            this.cmbOprema.TabIndex = 16;
            this.cmbOprema.SelectedIndexChanged += new System.EventHandler(this.cmbOprema_SelectedIndexChanged);
            // 
            // FormaOtpis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 348);
            this.Controls.Add(this.Filteri);
            this.Controls.Add(this.btnIzmjeni);
            this.Controls.Add(this.btnObriši);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPretrazi);
            this.Controls.Add(this.DGVOprema);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.btnDetalji);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormaOtpis";
            this.Text = "FormaOtpis";
            this.Load += new System.EventHandler(this.FormaOtpis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVOprema)).EndInit();
            this.Filteri.ResumeLayout(false);
            this.Filteri.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIzmjeni;
        private System.Windows.Forms.Button btnObriši;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPretrazi;
        private System.Windows.Forms.DataGridView DGVOprema;
        private System.Windows.Forms.Button btnNatrag;
        private System.Windows.Forms.Button btnDetalji;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox Filteri;
        private System.Windows.Forms.Button btnPonisti;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbOprema;
    }
}