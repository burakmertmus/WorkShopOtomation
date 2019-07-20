using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace $safeprojectname$
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblDurum_Click(object sender, EventArgs e)
        {

        }

        private void btnSorgula_Click(object sender, EventArgs e)
        {
            string plaka = txtPlaka.Text;
            int bolum = comboBolum.SelectedIndex;
            Tamirhane tm = new Tamirhane(plaka,bolum);
            lblModel.Text = tm.getModel();
            lblMarka.Text = tm.getMarka();
            lblYil.Text = Convert.ToString(tm.getYil());
            
            foreach (Parca prime in tm.getDegisenList()) // Loop through List with foreach
            {
                listBoxDegisen.Items.Add("Degisen Parca="+prime.getIsim());
                listBoxDegisen.Items.Add("Parca Fiyatı="+Convert.ToString(prime.getFiyat()));
                listBoxDegisen.Items.Add("Iscilik Parasi"+prime.getIscilik());

            }
            
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtPlaka_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
