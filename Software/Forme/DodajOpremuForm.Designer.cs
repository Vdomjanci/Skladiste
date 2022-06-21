
namespace Veronika_Domjancic.Forme
{
    partial class DodajOpremuForm
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
            this.txtStanje = new System.Windows.Forms.TextBox();
            this.txtSN = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.cboxTip = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtStanje
            // 
            this.txtStanje.Location = new System.Drawing.Point(134, 181);
            this.txtStanje.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtStanje.Name = "txtStanje";
            this.txtStanje.ReadOnly = true;
            this.txtStanje.Size = new System.Drawing.Size(133, 20);
            this.txtStanje.TabIndex = 21;
            // 
            // txtSN
            // 
            this.txtSN.Location = new System.Drawing.Point(134, 150);
            this.txtSN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSN.Name = "txtSN";
            this.txtSN.Size = new System.Drawing.Size(133, 20);
            this.txtSN.TabIndex = 20;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(134, 84);
            this.txtModel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(230, 20);
            this.txtModel.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 184);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Stanje:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 153);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "SN:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 119);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tip:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Model:";
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Location = new System.Drawing.Point(16, 20);
            this.btnIzlaz.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(33, 27);
            this.btnIzlaz.TabIndex = 11;
            this.btnIzlaz.Text = "<";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(183, 231);
            this.btnSpremi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(95, 28);
            this.btnSpremi.TabIndex = 22;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // cboxTip
            // 
            this.cboxTip.FormattingEnabled = true;
            this.cboxTip.Location = new System.Drawing.Point(134, 117);
            this.cboxTip.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboxTip.Name = "cboxTip";
            this.cboxTip.Size = new System.Drawing.Size(186, 21);
            this.cboxTip.TabIndex = 23;
            // 
            // DodajOpremuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 288);
            this.Controls.Add(this.cboxTip);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.txtStanje);
            this.Controls.Add(this.txtSN);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnIzlaz);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DodajOpremuForm";
            this.Text = "DodajOpremuForm";
            this.Load += new System.EventHandler(this.DodajOpremuForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStanje;
        private System.Windows.Forms.TextBox txtSN;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.ComboBox cboxTip;
    }
}