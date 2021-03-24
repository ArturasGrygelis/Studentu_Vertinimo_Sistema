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
    public partial class AdminMain : Form
    {
        public AdminMain()
        {
            InitializeComponent();
        }

        private void StudRedagavimoBtn_Click(object sender, EventArgs e)
        {
            StudentuRedagavimas sr = new StudentuRedagavimas();
            sr.ShowDialog();
           
        }

        private void GrupesRedagavimoBtn_Click(object sender, EventArgs e)
        {
            GrupesRedagavimas gr = new GrupesRedagavimas();
            gr.ShowDialog();


        }

        private void DalykoRedagavimoBtn_Click(object sender, EventArgs e)
        {
            RedagavimasDalyko rd = new RedagavimasDalyko();
            rd.Show();
        }

        private void DestytojoRedagavimasBtn_Click(object sender, EventArgs e)
        {
            Form3 rd = new Form3();
            rd.Show();

        }
    }
}
