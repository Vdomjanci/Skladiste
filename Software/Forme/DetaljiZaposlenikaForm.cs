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
    public partial class DetaljiZaposlenikaForm : Form
    {
        private Zaposlenik odabranZaposlenik;

        public DetaljiZaposlenikaForm(Zaposlenik zaposlenik)
        {
            InitializeComponent();
            odabranZaposlenik = zaposlenik;
        }

        

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DetaljiZaposlenikaForm_Load(object sender, EventArgs e)
        {
            DohvatiPodatke();
        }
        private void DohvatiPodatke()
        {
            txtIDZaposlenika.Text = odabranZaposlenik.ZaposlenikID.ToString();
            txtImePrezime.Text = odabranZaposlenik.ImePrezime;
            txtMail.Text = odabranZaposlenik.Email;
            txtTelefon.Text = odabranZaposlenik.Telefon;
            txtKorIme.Text = odabranZaposlenik.KorisnickoIme;
            txtLozinka.Text = odabranZaposlenik.Lozinka;
            txtOdjel.Text = odabranZaposlenik.Odjel.Naziv;
            txtOpis.Text = odabranZaposlenik.Opis;
            txtUloga.Text = odabranZaposlenik.UlogaZaposlenika.Naziv;

        }
    }
}
