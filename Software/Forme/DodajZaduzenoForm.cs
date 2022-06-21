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
    public partial class DodajZaduzenoForm : Form
    {
        public DodajZaduzenoForm()
        {
            InitializeComponent();
        }

        private void DodajZaduzenoForm_Load(object sender, EventArgs e) {
            using(var context = new Entities()) {
                UcitajOpremu(context);
                UcitajZaposlenike(context);
            }
        }

        private void UcitajOpremu(Entities context) {
            List<Oprema> listaOpreme = context.Oprema.Where(o=>o.Stanje!="Neispravno").ToList();
            cmbOprema.DataSource = listaOpreme;
            cmbOprema.SelectedIndex = -1;
        }

        private void UcitajZaposlenike(Entities context) {
            List<Zaposlenik> listaZaposlenika = context.Zaposlenik.ToList();
            cmbZaposlenik.DataSource = listaZaposlenika;
            cmbZaposlenik.SelectedIndex = -1;
        }

        private void btnSpremi_Click(object sender, EventArgs e) {
            using (var context = new Entities()) {
                Zaduzenje novo = new Zaduzenje {
                    OpremaID = (cmbOprema.SelectedItem as Oprema).OpremaID,
                    ZaposlenikID = (cmbZaposlenik.SelectedItem as Zaposlenik).ZaposlenikID,
                    DatumZaduzivanja = dtpZaduzivanja.Value,
                    DatumRazduzivanja = dtpRazduzivanja.Value
                };
                context.Zaduzenje.Add(novo);
                context.SaveChanges();
                Close();
            }
        }

        private void btnIzlaz_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
