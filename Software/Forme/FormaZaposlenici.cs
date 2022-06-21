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
    public partial class FormaZaposlenici : Form
    {
        private Zaposlenik prijavljen;
        public FormaZaposlenici(Zaposlenik zaposlenik)
        {
            InitializeComponent();
            prijavljen = zaposlenik;
        }
        private void Osvjezi()
        {
            PrikaziZaposlenike();
            
        }
        
        private Zaposlenik DohvatiZaposlenika()
        {
            return DGVZaposlenici.CurrentRow.DataBoundItem as Zaposlenik;
        }
        private void PrikaziZaposlenike()
        {

            using (var context = new Entities())
            {
                var query = context.Zaposlenik.Include("Odjel").Include("UlogaZaposlenika");

                DGVZaposlenici.DataSource = query.ToList();
                DGVZaposlenici.Columns["KorisnickoIme"].Visible = false;
                DGVZaposlenici.Columns["Lozinka"].Visible = false;
                DGVZaposlenici.Columns["OdjelID"].Visible = false;
                DGVZaposlenici.Columns["UlogaID"].Visible = false;
                DGVZaposlenici.Columns["UlogaZaposlenika"].Visible = false;
                DGVZaposlenici.Columns["Zaduzenje"].Visible = false;




            }
        }
        private void btnNatrag_Click(object sender, EventArgs e)
        {
            this.Hide();
            IzbornikForm forma = new IzbornikForm(prijavljen);
            forma.Closed += (s, args) => this.Close();
            forma.Show();
        }

        
        private void txtPretrazi_TextChanged(object sender, EventArgs e)
        {
            string trazi = txtPretrazi.Text;
            using (var context = new Entities())
            {
                var query = context.Zaposlenik.Where(z => z.ImePrezime.Contains(trazi));
                DGVZaposlenici.DataSource = query.ToList();
                
            }
        }

        private void btnDetalji_Click(object sender, EventArgs e)
        {
            Zaposlenik odabranZaposlenik = DohvatiZaposlenika();
            DetaljiZaposlenikaForm forma = new DetaljiZaposlenikaForm(odabranZaposlenik);
            forma.ShowDialog();
        }

        private void btnObriši_Click(object sender, EventArgs e)
        {
            Zaposlenik odabranZaposlenik = DohvatiZaposlenika();
            var rezultat = MessageBox.Show("Obriši zaposlenika?", "Obriši", MessageBoxButtons.YesNo);
            if (rezultat == DialogResult.Yes)
            {
                using (var context = new Entities())
                {
                    context.Zaposlenik.Attach(odabranZaposlenik);
                    context.Zaposlenik.Remove(odabranZaposlenik);
                    context.SaveChanges();
                    Osvjezi();
                }
            }
        }

        private void btnIzmjeni_Click(object sender, EventArgs e)
        {
            Zaposlenik odabranZaposlenik = DohvatiZaposlenika();
            IzmjeniZaposlenikaForm forma = new IzmjeniZaposlenikaForm(odabranZaposlenik);
            forma.ShowDialog();
            Osvjezi();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DodajZaposlenikaForm forma = new DodajZaposlenikaForm();
            forma.ShowDialog();
            Osvjezi();
        }

        private void FormaZaposlenici_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
