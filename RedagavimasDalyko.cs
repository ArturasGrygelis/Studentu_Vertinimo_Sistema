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
    
    public partial class RedagavimasDalyko : Form
    {
        SVS2Entities sv = new SVS2Entities();
        public RedagavimasDalyko()
        {
            InitializeComponent();
            RedDalGrupCBox.DataSource = sv.Grupe_6.ToList();
            RedDalGrupCBox.DisplayMember = "Grupes_Pavadinimas";
            DestytojasCBox.DataSource = sv.Destytojas_4.ToList();
            DestytojasCBox.DisplayMember = "ID";
        }

        private void Naujas_dalykasBtn_Click(object sender, EventArgs e)
        {
            SVS2Entities dal = new SVS2Entities();
            Dalykas7 dalykas = new Dalykas7();
            
            dalykas.Dalyko_Pavadinimas = DalykPavTxtB.Text;
            dalykas.Destytojo_ID = Convert.ToInt32(DestytojasCBox.SelectedText);
            dalykas.Grupe_6.Grupes_Pavadinimas = RedDalGrupCBox.Text;
            dal.Dalykas7.Add(dalykas);
           
            dal.SaveChanges();
        }

        private void RedDalGrupCBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PridGrupBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
