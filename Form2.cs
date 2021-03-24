using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SVSistema
{
    public partial class Form2 : Form
    {
        SVS2Entities ivp = new SVS2Entities();
        public Form2()
        {
            InitializeComponent();

            //DestPazymiaiDataGrid.DataSource = ivp.Dalykas7.ToList();
            DestPazPerCbox.DataSource = ivp.Dalykas7.ToList();
            DestPazPerCbox.DisplayMember = "Dalyko_Pavadinimas";
            PasirinktiDalykaCBox.DataSource = ivp.Dalykas7.ToList();
            PasirinktiDalykaCBox.DisplayMember = "Dalyko_Pavadinimas";


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void IvestiPazBtn_Click(object sender, EventArgs e)
        {
            SVS2Entities ivp = new SVS2Entities();
            Pazimys6 pazimys = new Pazimys6();
            
            pazimys.Studento_ID = Convert.ToInt32(IvStudIDTxtB.Text);
            pazimys.Dalyko_ID = Convert.ToInt32(PasirinktiDalykaCBox.Text);
            pazimys.Ivertinimas = Convert.ToInt32(IvertinimasTxtB.Text);
            pazimys.Komentaras = KomentarastxtB.Text;
            ivp.Pazimys6.Add(pazimys);
            MessageBox.Show("Pazimys ivestas");
            
            ivp.SaveChanges();
            

        }

        private void DestPerStudBtn_Click(object sender, EventArgs e)
        {
            
           

        }

        private void PasirinktiDalykaCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DestPazymiaiDataGrid.AutoGenerateColumns = false;
            DestPazymiaiDataGrid.DataSource = ivp.Pazimys6.ToList();
            var stud = ivp.Pazimys6.Where(x => x.Dalykas7.Dalyko_Pavadinimas.Equals(DestPazPerCbox.Text)).ToList();
            DestPazymiaiDataGrid.DataSource = stud;
        }
    }
}
