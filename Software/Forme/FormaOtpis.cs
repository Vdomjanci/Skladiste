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

namespace Veronika_Domjancic.Forme {
    public partial class FormaOtpis : Form {
        private Zaposlenik prijavljen;
        public FormaOtpis(Zaposlenik zaposlenik) {
            InitializeComponent();
            prijavljen = zaposlenik;
        }

        private void Osvjezi() {
            PrikaziTipOpreme();
            PrikaziOpremu();

        }

        private void PrikaziOpremu() {
            TipOpreme item = cmbOprema.SelectedItem as TipOpreme;

            using (var context = new Entities()) {
                var svaOprema = context.Oprema.Include(op => op.TipOpreme).Where(o => o.Stanje == "Neispravno");
                string trazi = txtPretrazi.Text;

                if (item != null) {
                    svaOprema = svaOprema.Where(o => o.TipID == item.TipID);
                }

                if (!string.IsNullOrEmpty(trazi)) {
                    svaOprema = svaOprema.Where(o => o.Model.ToLower().Contains(trazi.ToLower()));
                }

                DGVOprema.DataSource = null;
                DGVOprema.DataSource = svaOprema.ToList();

                
                DGVOprema.Columns["Zaduzenje"].Visible = false;
                DGVOprema.Columns["TipID"].Visible = false;
            }

        }

        private Oprema DohvatiOpremu() {
            return DGVOprema.CurrentRow.DataBoundItem as Oprema;
        }

        private void PrikaziTipOpreme() {
            using (var context = new Entities()) {
                var query = context.TipOpreme;
                cmbOprema.DataSource = query.ToList();
                cmbOprema.SelectedIndex = -1;
            }
        }

        private void btnIzmjeni_Click(object sender, EventArgs e) {
            Oprema odabranaOprema = DohvatiOpremu();
            IzmjeniOpremuForm forma = new IzmjeniOpremuForm(odabranaOprema);

            forma.ShowDialog();
            Osvjezi();
        }

        private void FormaOtpis_Load(object sender, EventArgs e) {
            Osvjezi();
        }

        private void btnObriši_Click(object sender, EventArgs e) {
            Oprema odabranaOprema = DohvatiOpremu();
            var rezultat = MessageBox.Show("Obriši opremu?", "Obriši", MessageBoxButtons.YesNo);
            if (rezultat == DialogResult.Yes) {
                using (var context = new Entities()) {
                    context.Oprema.Attach(odabranaOprema);
                    context.Oprema.Remove(odabranaOprema);
                    context.SaveChanges();
                    Osvjezi();
                }
            }
        }

        

        private void btnDetalji_Click(object sender, EventArgs e) {
            Oprema odabranaOprema = DohvatiOpremu();
            DetaljiOpremeForm forma = new DetaljiOpremeForm(odabranaOprema);
            forma.ShowDialog();
        }

        private void btnNatrag_Click(object sender, EventArgs e) {
            this.Hide();
            IzbornikForm forma = new IzbornikForm(prijavljen);
            forma.Closed += (s, args) => this.Close();
            forma.Show();
        }

        private void cmbOprema_SelectedIndexChanged(object sender, EventArgs e) {
            PrikaziOpremu();
        }

        private void btnPonisti_Click(object sender, EventArgs e) {
            cmbOprema.SelectedIndex = -1;
        }

        private void txtPretrazi_TextChanged(object sender, EventArgs e) {
            PrikaziOpremu();
        }
    }
}
