using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Automat
{
    public partial class einwerfen_010 : Form
    {
        public einwerfen_010()
        {
            InitializeComponent();
        }

        private void produkt_fanta_Click(object sender, EventArgs e)
        {
            double hv = Convert.ToDouble(tb_eingeworfen.Text);
            double rest;
            rest=hv-1.2;
            tb_restgeld.Text = Convert.ToString(rest);
            int produkt = 5;
            if (rest >= 0)
            {
                produkt = produkt - 1;
                //auswerfen
            }
            if (produkt == 0)
            {
                produkt_fanta.Enabled = false;
            }
        }

        private void produkt_cola_Click(object sender, EventArgs e)
        {
            double hv = Convert.ToDouble(tb_eingeworfen.Text);
            double rest;

            rest = hv - 1.2;
            tb_restgeld.Text = Convert.ToString(rest);
        }

    }
}
