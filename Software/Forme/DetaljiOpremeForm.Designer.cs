
namespace Veronika_Domjancic.Forme
{
    partial class DetaljiOpremeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtTip = new System.Windows.Forms.TextBox();
            this.txtSN = new System.Windows.Forms.TextBox();
            this.txtStanje = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Location = new System.Drawing.Point(22, 17);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(44, 33);
            this.btnIzlaz.TabIndex = 0;
            this.btnIzlaz.Text = "<";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Model:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tip:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "SN:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Stanje:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(180, 53);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(176, 22);
            this.txtID.TabIndex = 6;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(180, 96);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(305, 22);
            this.txtModel.TabIndex = 7;
            // 
            // txtTip
            // 
            this.txtTip.Location = new System.Drawing.Point(180, 137);
            this.txtTip.Name = "txtTip";
            this.txtTip.Size = new System.Drawing.Size(228, 22);
            this.txtTip.TabIndex = 8;
            // 
            // txtSN
            // 
            this.txtSN.Location = new System.Drawing.Point(180, 178);
            this.txtSN.Name = "txtSN";
            this.txtSN.Size = new System.Drawing.Size(176, 22);
            this.txtSN.TabIndex = 9;
            // 
            // txtStanje
            // 
            this.txtStanje.Location = new System.Drawing.Point(180, 216);
            this.txtStanje.Name = "txtStanje";
            this.txtStanje.Size = new System.Drawing.Size(176, 22);
            this.txtStanje.TabIndex = 10;
            // 
            // DetaljiOpremeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 284);
            this.Controls.Add(this.txtStanje);
            this.Controls.Add(this.txtSN);
            this.Controls.Add(this.txtTip);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIzlaz);
            this.Name = "DetaljiOpremeForm";
            this.Text = "DetaljiOpremeForm";
            this.Load += new System.EventHandler(this.DetaljiOpremeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtTip;
        private System.Windows.Forms.TextBox txtSN;
        private System.Windows.Forms.TextBox txtStanje;
    }
}