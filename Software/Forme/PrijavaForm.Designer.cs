
namespace Veronika_Domjancic.Forme
{
    partial class PrijavaForm
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
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.txtKorIme = new System.Windows.Forms.TextBox();
            this.btnPrijavi = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtLozinka
            // 
            this.txtLozinka.Location = new System.Drawing.Point(315, 148);
            this.txtLozinka.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.PasswordChar = '*';
            this.txtLozinka.Size = new System.Drawing.Size(346, 31);
            this.txtLozinka.TabIndex = 11;
            // 
            // txtKorIme
            // 
            this.txtKorIme.Location = new System.Drawing.Point(315, 59);
            this.txtKorIme.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtKorIme.Name = "txtKorIme";
            this.txtKorIme.Size = new System.Drawing.Size(346, 31);
            this.txtKorIme.TabIndex = 10;
            // 
            // btnPrijavi
            // 
            this.btnPrijavi.Location = new System.Drawing.Point(550, 314);
            this.btnPrijavi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPrijavi.Name = "btnPrijavi";
            this.btnPrijavi.Size = new System.Drawing.Size(129, 48);
            this.btnPrijavi.TabIndex = 9;
            this.btnPrijavi.Text = "Prijavi se";
            this.btnPrijavi.UseVisualStyleBackColor = true;
            this.btnPrijavi.Click += new System.EventHandler(this.btnPrijavi_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(94, 314);
            this.btnOdustani.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(134, 48);
            this.btnOdustani.TabIndex = 8;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 153);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Lozinka:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Korisničko ime:";
            // 
            // PrijavaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 427);
            this.Controls.Add(this.txtLozinka);
            this.Controls.Add(this.txtKorIme);
            this.Controls.Add(this.btnPrijavi);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PrijavaForm";
            this.Text = "Prijava";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.TextBox txtKorIme;
        private System.Windows.Forms.Button btnPrijavi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}