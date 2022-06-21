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
    public partial class IzmjeniZaduzenoForm : Form
    {
        private readonly Zaduzenje odabranoZaduzenje;
        public IzmjeniZaduzenoForm(Zaduzenje zaduzenje)
        {
            odabranoZaduzenje = zaduzenje;

            InitializeComponent();
        }

        private void IzmjeniZaduzenoForm_Load(object sender, EventArgs e) {

        }


        private void btnSpremi_Click(object sender, EventArgs e) {
            using(var context = new Entities()) {
                context.Zaduzenje.Attach(odabranoZaduzenje);
                
                odabranoZaduzenje.DatumZaduzivanja = dtpZaduzivanja.Value;
                odabranoZaduzenje.DatumRazduzivanja = dtpRazduzivanja.Value;
                context.SaveChanges();
            }

            Close();

        }

        private void btnIzlaz_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
