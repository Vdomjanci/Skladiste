
namespace Veronika_Domjancic.Forme
{
    partial class IzbornikForm
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
            this.btnOtpis = new System.Windows.Forms.Button();
            this.btnZaduzeno = new System.Windows.Forms.Button();
            this.btnOprema = new System.Windows.Forms.Button();
            this.btnZaposlenici = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOtpis
            // 
            this.btnOtpis.Location = new System.Drawing.Point(68, 255);
            this.btnOtpis.Name = "btnOtpis";
            this.btnOtpis.Size = new System.Drawing.Size(265, 39);
            this.btnOtpis.TabIndex = 7;
            this.btnOtpis.Text = "Otpis";
            this.btnOtpis.UseVisualStyleBackColor = true;
            this.btnOtpis.Click += new System.EventHandler(this.btnOtpis_Click);
            // 
            // btnZaduzeno
            // 
            this.btnZaduzeno.Location = new System.Drawing.Point(68, 178);
            this.btnZaduzeno.Name = "btnZaduzeno";
            this.btnZaduzeno.Size = new System.Drawing.Size(265, 39);
            this.btnZaduzeno.TabIndex = 6;
            this.btnZaduzeno.Text = "Zaduzeno";
            this.btnZaduzeno.UseVisualStyleBackColor = true;
            this.btnZaduzeno.Click += new System.EventHandler(this.btnZaduzeno_Click);
            // 
            // btnOprema
            // 
            this.btnOprema.Location = new System.Drawing.Point(68, 100);
            this.btnOprema.Name = "btnOprema";
            this.btnOprema.Size = new System.Drawing.Size(265, 39);
            this.btnOprema.TabIndex = 5;
            this.btnOprema.Text = "Oprema";
            this.btnOprema.UseVisualStyleBackColor = true;
            this.btnOprema.Click += new System.EventHandler(this.btnOprema_Click);
            // 
            // btnZaposlenici
            // 
            this.btnZaposlenici.Location = new System.Drawing.Point(68, 29);
            this.btnZaposlenici.Name = "btnZaposlenici";
            this.btnZaposlenici.Size = new System.Drawing.Size(265, 39);
            this.btnZaposlenici.TabIndex = 4;
            this.btnZaposlenici.Text = "Zaposlenici";
            this.btnZaposlenici.UseVisualStyleBackColor = true;
            this.btnZaposlenici.Click += new System.EventHandler(this.btnZaposlenici_Click);
            // 
            // IzbornikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 367);
            this.Controls.Add(this.btnOtpis);
            this.Controls.Add(this.btnZaduzeno);
            this.Controls.Add(this.btnOprema);
            this.Controls.Add(this.btnZaposlenici);
            this.Name = "IzbornikForm";
            this.Text = "Izbornik";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOtpis;
        private System.Windows.Forms.Button btnZaduzeno;
        private System.Windows.Forms.Button btnOprema;
        private System.Windows.Forms.Button btnZaposlenici;
    }
}