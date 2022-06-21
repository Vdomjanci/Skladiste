
namespace Veronika_Domjancic.Forme
{
    partial class IzmjeniZaduzenoForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpZaduzivanja = new System.Windows.Forms.DateTimePicker();
            this.dtpRazduzivanja = new System.Windows.Forms.DateTimePicker();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Datum zaduživanja:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 113);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Datum razduživanja:";
            // 
            // dtpZaduzivanja
            // 
            this.dtpZaduzivanja.Location = new System.Drawing.Point(202, 59);
            this.dtpZaduzivanja.Margin = new System.Windows.Forms.Padding(2);
            this.dtpZaduzivanja.Name = "dtpZaduzivanja";
            this.dtpZaduzivanja.Size = new System.Drawing.Size(151, 20);
            this.dtpZaduzivanja.TabIndex = 4;
            // 
            // dtpRazduzivanja
            // 
            this.dtpRazduzivanja.Location = new System.Drawing.Point(210, 109);
            this.dtpRazduzivanja.Margin = new System.Windows.Forms.Padding(2);
            this.dtpRazduzivanja.Name = "dtpRazduzivanja";
            this.dtpRazduzivanja.Size = new System.Drawing.Size(151, 20);
            this.dtpRazduzivanja.TabIndex = 5;
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(272, 270);
            this.btnSpremi.Margin = new System.Windows.Forms.Padding(2);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(95, 28);
            this.btnSpremi.TabIndex = 23;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Location = new System.Drawing.Point(9, 10);
            this.btnIzlaz.Margin = new System.Windows.Forms.Padding(2);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(33, 27);
            this.btnIzlaz.TabIndex = 24;
            this.btnIzlaz.Text = "<";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // IzmjeniZaduzenoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.dtpRazduzivanja);
            this.Controls.Add(this.dtpZaduzivanja);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "IzmjeniZaduzenoForm";
            this.Text = "IzmjeniZaduzenoForm";
            this.Load += new System.EventHandler(this.IzmjeniZaduzenoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpZaduzivanja;
        private System.Windows.Forms.DateTimePicker dtpRazduzivanja;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnIzlaz;
    }
}