﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Veronika_Domjancic.Forme;

namespace Veronika_Domjancic
{
    public partial class Pocetna : Form
    {
        public Pocetna()
        {
            InitializeComponent();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            this.Hide();
            PrijavaForm form = new PrijavaForm();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

    }
}
