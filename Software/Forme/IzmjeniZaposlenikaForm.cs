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
    public partial class IzmjeniZaposlenikaForm : Form
    {
        private Zaposlenik odabranZaposlenik;

        public IzmjeniZaposlenikaForm(Zaposlenik zaposlenik)
        {
            InitializeComponent();
            odabranZaposlenik = zaposlenik;
        }

        

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void IzmjeniZaposlenikaForm_Load(object sender, EventArgs e)
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
            
            txtOpis.Text = odabranZaposlenik.Opis;
            
            PrikaziOdjele();
            PrikaziUloge();

        }
        private void PrikaziOdjele()
        {
            List<Odjel> odjel;
            using(var context = new Entities())
            {
                odjel = context.Odjel.ToList();
            }
            cmbOdjel.DataSource = odjel;
            for (int j = 0; j < cmbOdjel.Items.Count; j++)
            {
                if((cmbOdjel.Items[j] as Odjel).OdjelID == odabranZaposlenik.OdjelID)
                {
                    cmbOdjel.SelectedIndex = j;
                    break;
                }
            }
        }
        private void PrikaziUloge()
        {
            List<UlogaZaposlenika> uloga;
            using (var context = new Entities())
            {
                uloga = context.UlogaZaposlenika.ToList();
            }
            cmbUloga.DataSource = uloga;
            for (int j = 0; j < cmbUloga.Items.Count; j++)
            {
                if ((cmbUloga.Items[j] as UlogaZaposlenika).UlogaID == odabranZaposlenik.UlogaID)
                {
                    cmbUloga.SelectedIndex = j;
                    break;
                }
            }
        }
        private void btnSpremi_Click(object sender, EventArgs e)
        {
            using (var context = new Entities())
            {
                int id = int.Parse(txtIDZaposlenika.Text);
                string imeprez = txtImePrezime.Text;
                string mail = txtMail.Text;
                string tel = txtTelefon.Text;
                string korime = txtKorIme.Text;
                string lozinka = txtLozinka.Text;

                string opis = txtOpis.Text;
                context.Zaposlenik.Attach(odabranZaposlenik);
                Odjel odjel = cmbOdjel.SelectedItem as Odjel;
                
                odabranZaposlenik.OdjelID = odjel.OdjelID;
                odabranZaposlenik.KorisnickoIme = korime;
                odabranZaposlenik.ImePrezime = imeprez;
                odabranZaposlenik.Lozinka = lozinka;
                odabranZaposlenik.Opis = opis;
                odabranZaposlenik.Telefon = tel;
                odabranZaposlenik.Email = mail;

                
                UlogaZaposlenika uloga = cmbUloga.SelectedItem as UlogaZaposlenika;

                odabranZaposlenik.UlogaID = uloga.UlogaID;
                context.SaveChanges();
            }
            Close();
        }
    }
}
