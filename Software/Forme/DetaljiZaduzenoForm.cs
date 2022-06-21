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
    public partial class DetaljiZaduzenoForm : Form
    {
        private Zaduzenje odabranoZaduzenje;
        public DetaljiZaduzenoForm(Zaduzenje zaduzenje)
        {
            this.odabranoZaduzenje = zaduzenje;
            InitializeComponent();
        }

        private void DetaljiZaduzenoForm_Load(object sender, EventArgs e) {
            txtOprema.Text = odabranoZaduzenje.Oprema.ToString();
            txtZaposlenik.Text = odabranoZaduzenje.Zaposlenik.ToString();
            txtZaduzivanja.Text = odabranoZaduzenje.DatumZaduzivanja.ToString();
            txtRazduzivanja.Text = odabranoZaduzenje.DatumRazduzivanja.ToString();
        }

        private void btnIzlaz_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
