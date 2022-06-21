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
    public partial class DetaljiOpremeForm : Form
    {
        private Oprema odabranaOprema;

        public DetaljiOpremeForm(Oprema oprema)
        {
            InitializeComponent();
            odabranaOprema = oprema;
        }

               
        private void DetaljiOpremeForm_Load(object sender, EventArgs e)
        {
            
            DohvatiPodatke();
        }
        private void DohvatiPodatke()
        {
            txtID.Text = odabranaOprema.OpremaID.ToString();
            txtModel.Text = odabranaOprema.Model;
            txtTip.Text = odabranaOprema.TipOpreme.ToString();
            txtSN.Text = odabranaOprema.SN;
            txtStanje.Text = odabranaOprema.Stanje;
            
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
