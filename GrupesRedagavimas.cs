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
    public partial class GrupesRedagavimas : Form
    {
        SVS2Entities grupr = new SVS2Entities();
        public GrupesRedagavimas()
        {
            InitializeComponent();
            SalinimasGrpCBx.DataSource = grupr.Grupe_6.ToList();
            SalinimasGrpCBx.DisplayMember = "Grupes_Pavadinimas";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PridetiGrpBtn_Click(object sender, EventArgs e)
        {
            SVS2Entities grupr = new SVS2Entities();
            Grupe_6 grup = new Grupe_6();
            grup.Grupes_Pavadinimas = NaujGrbtxtb.Text;
            grupr.Grupe_6.Add(grup);
            grupr.SaveChanges();
            MessageBox.Show("Nauja grupe prideta");


        }
    }
}
