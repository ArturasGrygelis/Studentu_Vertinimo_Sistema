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
    public partial class StudentuRedagavimas : Form
         
    {
        SVS2Entities pr = new SVS2Entities();
        
        

        public StudentuRedagavimas()
        {
            InitializeComponent();
            
          AdmPridStudGrpCBox.DataSource= pr.Grupe_6.ToList();
           AdmPridStudGrpCBox.DisplayMember = "ID";
           AdmPerStudCBox.DataSource = pr.Grupe_6.ToList();
            AdmPerStudCBox.DisplayMember = "Grupes_Pavadinimas";


        }

        private void PridetiStudBtn_Click(object sender, EventArgs e)
        {
            SVS2Entities pr = new SVS2Entities();
            Studentas6 stud = new Studentas6();
            stud.Studento_Vardas = AdmPridStudVardTxtB.Text;
            stud.Studento_Pavardė = AdmPridPavTxtB.Text;
           
            stud.Studento_GrupesNr = Convert.ToInt32(AdmPridStudGrpCBox.Text);
            
            
            pr.Studentas6.Add(stud);
            pr.SaveChanges();
            MessageBox.Show("Studentas bbuvo pridetas");
        }

        private void AdmPridStudGrpCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void AdmPerziuretiStudSarBtn_Click(object sender, EventArgs e)
        {
            AdmStudSarGridV.AutoGenerateColumns = false;
            AdmStudSarGridV.DataSource = pr.Studentas6.ToList();
            var stud = pr.Studentas6.Where(x => x.Grupe_6.Grupes_Pavadinimas.Equals(AdmPerStudCBox.Text)).ToList();
            AdmStudSarGridV.DataSource = stud;
        }

        private void AdmStudSarGridV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
