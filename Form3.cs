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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void PridDestBtn_Click(object sender, EventArgs e)
        {
            SVS2Entities sv = new SVS2Entities();
            
            Destytojas_4 dest = new Destytojas_4();
           
            dest.Destytojo_Vardas = DestVardTxtB.Text;
            dest.Destytojo_Pavarde = DestPavTxtB.Text;
           sv.Destytojas_4.Add(dest);
           sv.SaveChanges();

           
            MessageBox.Show("Destytojas pridetas");
        }
    }
}
