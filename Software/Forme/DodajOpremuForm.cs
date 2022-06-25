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
    public partial class DodajOpremuForm : Form
    {
        public enum Stanje { Ispravno, Neispravno };
        private readonly Stanje stanje;
        public DodajOpremuForm(Stanje stanje)
        {
            this.stanje = stanje;
            InitializeComponent();
        }

        
        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DodajOpremuForm_Load(object sender, EventArgs e)
        {
            txtStanje.Text = stanje.ToString();
            PrikaziTipove();
        }
        private void PrikaziTipove()
        {
            List<TipOpreme> tip;
            using (var context = new Entities())
            {
                tip = context.TipOpreme.ToList();

            }
            cboxTip.DataSource = tip;
            cboxTip.Text = "Odaberite tip opreme";
        }
        private TipOpreme DohvatiTip()
        {

            return cboxTip.SelectedItem as TipOpreme;

        }
        private void btnSpremi_Click(object sender, EventArgs e)
        {
            using (var context = new Entities())
            {
                string model = txtModel.Text;
                string tip = cboxTip.SelectedItem.ToString();
                string sn = txtSN.Text;
                string stanje = txtStanje.Text;
                if (String.IsNullOrEmpty(model))
                {
                    MessageBox.Show("Unesite model!");
                    return;
                }
                
                if (String.IsNullOrEmpty(sn))
                {
                    MessageBox.Show("Unesite serijski broj!");
                    return;
                }
                
                if (context.Oprema.Where(o => o.SN == sn).Any())
                {
                    MessageBox.Show("Uneseni serijski broj već postoji!");
                    return;
                }
                
                TipOpreme odabraniTip = DohvatiTip();
                context.TipOpreme.Attach(odabraniTip);
                Oprema novaOprema = new Oprema
                {
                    Model = model,
                    
                    SN = sn,
                    Stanje = stanje,
                    
                    TipID = odabraniTip.TipID

                };
                context.Oprema.Add(novaOprema);
                context.SaveChanges();
            }
            Close();
        }
    }
}
