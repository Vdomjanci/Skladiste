using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace Veronika_Domjancic.Forme
{
    public partial class FormaZaduzeno : Form
    {
        private Zaposlenik prijavljen; 
        public FormaZaduzeno(Zaposlenik zaposlenik)
        {
            InitializeComponent();
            prijavljen = zaposlenik; 
        }

        private void FormaZaduzeno_Load(object sender, EventArgs e) {
            Osvjezi();
        }

        private void Osvjezi() {
            PrikaziZaduzenja();
        }

        private void PrikaziZaduzenja() {
            string trazi = txtPretrazi.Text;
            using (var context = new Entities()) {
                var query = context.Zaduzenje
                    .Include(z => z.Zaposlenik)
                    .Include(z => z.Oprema);

                if(!string.IsNullOrEmpty(trazi)) {
                    query = query.Where(zaduzenje => 
                        zaduzenje.Oprema.Model.ToLower().Contains(trazi.ToLower()) || 
                        zaduzenje.Zaposlenik.ImePrezime.ToLower().Contains(trazi.ToLower())
                    );
                }




                DGVZaduzeno.DataSource = null;
                DGVZaduzeno.DataSource = query.ToList();
                DGVZaduzeno.Columns["ZaposlenikID"].Visible = false;
                DGVZaduzeno.Columns["OpremaID"].Visible = false;

            }
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            this.Hide();
            IzbornikForm forma = new IzbornikForm(prijavljen);
            forma.Closed += (s, args) => this.Close();
            forma.Show();
        }

        private Zaduzenje DohvatiOdabranoZaduzenje() {
            var zaduzenje = DGVZaduzeno.CurrentRow.DataBoundItem as Zaduzenje;
            return zaduzenje;
        }

        private void btnIzmjeni_Click(object sender, EventArgs e) {
            
            IzmjeniZaduzenoForm forma = new IzmjeniZaduzenoForm(DohvatiOdabranoZaduzenje());
            forma.Show();
            Osvjezi();
        }

        private void btnObriši_Click(object sender, EventArgs e) {
            Zaduzenje odabrano = DohvatiOdabranoZaduzenje();
            using(var context = new Entities()) {
                context.Zaduzenje.Attach(odabrano);
                context.Zaduzenje.Remove(odabrano);
                context.SaveChanges();
            }
            Osvjezi();
        }

        private void btnDodaj_Click(object sender, EventArgs e) {
            DodajZaduzenoForm forma = new DodajZaduzenoForm();
            forma.Show();
            Osvjezi();
        }

        private void btnDetalji_Click(object sender, EventArgs e) {
            DetaljiZaduzenoForm forma = new DetaljiZaduzenoForm(DohvatiOdabranoZaduzenje());
            forma.Show();
        }

        private void txtPretrazi_TextChanged(object sender, EventArgs e) {
            PrikaziZaduzenja();
        }
    }
}
