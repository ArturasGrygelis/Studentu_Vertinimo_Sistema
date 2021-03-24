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
    public partial class PazymioPerziurejimas : Form
    {
        SVS2Entities sv = new SVS2Entities();
        public PazymioPerziurejimas()
        {
            InitializeComponent();
            DalPazPerzCBox.DataSource = sv.Dalykas7.ToList();
            DalPazPerzCBox.DisplayMember = "Dalyko_Pavadinimas";
        }

        private void StudPazPerzBtn_Click(object sender, EventArgs e)
        {
            PazymiaiDataGrid.AutoGenerateColumns = false;
            PazymiaiDataGrid.DataSource = sv.Pazimys6.ToList();
            var stud = sv.Pazimys6.Where(x => x.Dalykas7.Dalyko_Pavadinimas.Equals(DalPazPerzCBox.Text)).ToList();
            PazymiaiDataGrid.DataSource = stud;
        }

        private void PazymiaiDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

      

      
    }

