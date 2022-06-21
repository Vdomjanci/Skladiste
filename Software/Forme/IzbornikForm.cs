using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veronika_Domjancic.Forme
{
    public partial class IzbornikForm : Form
    {
        private Zaposlenik prijavljen;
        public IzbornikForm(Zaposlenik zaposlenik)
        {
            InitializeComponent();
            prijavljen = zaposlenik;
            
            
        }

        private void btnZaposlenici_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormaZaposlenici forma = new FormaZaposlenici(prijavljen);
            forma.Closed += (s, args) => this.Close();
            forma.Show();
        }

        private void btnOprema_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormaOprema forma = new FormaOprema(prijavljen);
            forma.Closed += (s, args) => this.Close();
            forma.Show();
        }

        private void btnZaduzeno_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormaZaduzeno forma = new FormaZaduzeno(prijavljen);
            forma.Closed += (s, args) => this.Close();
            forma.Show();
        }

        private void btnOtpis_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormaOtpis forma = new FormaOtpis(prijavljen);
            forma.Closed += (s, args) => this.Close();
            forma.Show();
        }
    }
}
