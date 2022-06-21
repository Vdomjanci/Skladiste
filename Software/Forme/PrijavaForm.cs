using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veronika_Domjancic.Forme {
    public partial class PrijavaForm : Form {
        public PrijavaForm() {
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e) {
            this.Hide();
            Pocetna form = new Pocetna();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void btnPrijavi_Click(object sender, EventArgs e) {
            PrijaviAdministratora();
        }
        private void PrijaviAdministratora() {
            Zaposlenik Prijavljen = DohvatiPrijavljenog();

            if (Prijavljen == null || Prijavljen.UlogaID != 2) {
                MessageBox.Show("Pogrešno uneseni podatci");
                txtKorIme.Clear();
                txtLozinka.Clear();
            } else if (Prijavljen.UlogaID == 2) {
                this.Hide();
                IzbornikForm formZaposlenik = new IzbornikForm(Prijavljen);
                formZaposlenik.Closed += (s, args) => this.Close();
                formZaposlenik.Show();


            }

        }
        private Zaposlenik DohvatiPrijavljenog() {
            string kIme = txtKorIme.Text.ToLower();
            string loz = txtLozinka.Text;

            using (var contex = new Entities()) {
                return contex.Zaposlenik.FirstOrDefault(k => k.KorisnickoIme == kIme && k.Lozinka == loz);
            }

        }
    }
}
