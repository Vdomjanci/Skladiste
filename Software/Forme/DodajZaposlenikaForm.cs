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
    public partial class DodajZaposlenikaForm : Form {
        public DodajZaposlenikaForm() {
            InitializeComponent();
        }

        private void btnIzlaz_Click(object sender, EventArgs e) {
            Close();
        }

        private void DodajZaposlenikaForm_Load(object sender, EventArgs e) {
            PrikaziOdjele();
            PrikaziUloge();
        }
        private void PrikaziOdjele() {
            List<Odjel> odjel;
            using (var context = new Entities()) {
                odjel = context.Odjel.ToList();

            }
            cmbOdjel.DataSource = odjel;
            cmbOdjel.Text = "Odaberite odjel zaposlenika";
        }
        private Odjel DohvatiOdjel() {

            return cmbOdjel.SelectedItem as Odjel;

        }
        private void PrikaziUloge() {
            List<UlogaZaposlenika> uloge;
            using (var context = new Entities()) {
                uloge = context.UlogaZaposlenika.ToList();

            }
            cmbUloga.DataSource = uloge;
            cmbUloga.Text = "Odaberite ulogu zaposlenika";
        }
        private UlogaZaposlenika DohvatiUlogu() {

            return cmbUloga.SelectedItem as UlogaZaposlenika;

        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            using (var context = new Entities())
            {

                string imeprezime = txtImePrezime.Text;
                string mail = txtMail.Text;
                string tel = txtTelefon.Text;
                string korime = txtKorIme.Text;
                string lozinka = txtLozinka.Text;
                string opis = txtOpis.Text;
                if (Provjera.ProvjeraZaposlenika(mail, tel))
                {
                    if (imeprezime == null)
                    {
                        MessageBox.Show("Unesite ime i prezime!");
                    }

                    if (mail == null)
                    {
                        MessageBox.Show("Unesite E-mail!");
                    }


                    Odjel odabraniOdjel = DohvatiOdjel();
                    UlogaZaposlenika odabranaUloga = DohvatiUlogu();
                    Zaposlenik noviZaposlenik = new Zaposlenik
                    {
                        ImePrezime = imeprezime,
                        Email = mail,
                        Telefon = tel,
                        KorisnickoIme = korime,
                        Lozinka = lozinka,
                        OdjelID = odabraniOdjel.OdjelID,
                        Opis = opis,
                        UlogaID = odabranaUloga.UlogaID

                    };
                    context.Zaposlenik.Add(noviZaposlenik);
                    context.SaveChanges();
                    Close();
                }

            }
        }


    }
}
