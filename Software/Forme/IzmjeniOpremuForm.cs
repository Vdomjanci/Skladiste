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
    public partial class IzmjeniOpremuForm : Form
    {
         private readonly Oprema odabranaOprema;

        public IzmjeniOpremuForm(Oprema oprema)
        {
            InitializeComponent();
            odabranaOprema = oprema;
        }

        
        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void IzmjeniOpremuForm_Load(object sender, EventArgs e)
        {
            cmbStanje.DataSource = new List<string> { "Ispravno", "Neispravno" };
            DohvatiPodatke();
        }
        private void DohvatiPodatke()
        {
            txtID.Text = odabranaOprema.OpremaID.ToString();
            txtModel.Text = odabranaOprema.Model;
            
            txtSN.Text = odabranaOprema.SN;
            cmbStanje.SelectedIndex = (odabranaOprema.Stanje == "Ispravno") ? 0 : 1;
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
            for (int j = 0; j < cboxTip.Items.Count; j++)
            {
                if ((cboxTip.Items[j] as TipOpreme).TipID == odabranaOprema.TipID) 
                {
                    cboxTip.SelectedIndex = j;
                    break;
                }
            }
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            using (var context = new Entities())
            {
                int id = int.Parse(txtID.Text);
                string model = txtModel.Text;
                string sn = txtSN.Text;
                string stanje = cmbStanje.SelectedItem as string;
         
                TipOpreme tipOpreme = cboxTip.SelectedItem as TipOpreme;
                context.Oprema.Attach(odabranaOprema);
                odabranaOprema.OpremaID = id;
                odabranaOprema.Model = model;
                odabranaOprema.SN = sn;
                odabranaOprema.Stanje = stanje;
                odabranaOprema.TipID = tipOpreme.TipID;
                context.SaveChanges();
            }
            Close();
        }
    }
}
