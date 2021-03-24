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
    public partial class Form1 : Form
    {
        SVS2Entities content = new SVS2Entities();
        public Form1()
        {
            
            InitializeComponent();
        }

        private void PrisijungtiBtn_Click(object sender, EventArgs e) 
        {
            SVS2Entities content = new SVS2Entities();
         if(PrisVardTxtB.Text != string.Empty && SlaptTxtB.Text != string.Empty)
            {
                var admin = content.SVSAdmin.Where(x => x.Prisijungimo_Vardas.Equals(PrisVardTxtB.Text)).FirstOrDefault();
                var dest = content.SVSDestytojas.Where(x => x.Destytojo_Slapyvardis.Equals(PrisVardTxtB.Text)).FirstOrDefault();
                var stud = content.SvsStudentas2.Where(x => x.Studento_Slapyvardis.Equals(PrisVardTxtB.Text)).FirstOrDefault();
                if (admin != null)
                {
                    if (admin.Slaptazodis.Equals(SlaptTxtB.Text))
                    {
                        AdminMain admin1 = new AdminMain();
                        admin1.ShowDialog();
                        this.Close();


                        MessageBox.Show("Sveiki Atyke");

                    }
                    else
                    {

                        MessageBox.Show("Nepaejo, o gal paejo?");
                    }


                }
                else if (dest != null)
                {
                    
                    if (dest.Destytojo_Slaptazodis == SlaptTxtB.Text)
                    {
                        
                        Form2 form = new Form2();
                        form.ShowDialog();



                       
                        this.Close();
                    }
                    else
                    {

                        MessageBox.Show("Nepaejo, o gal paejo?");
                    }
                }
                else if (stud != null)
                {
                    if (stud.Studento_Slaptazodis == SlaptTxtB.Text)
                    {
                        PazymioPerziurejimas stud1 = new PazymioPerziurejimas();
                        stud1.ShowDialog();
                        this.Close();
                    }
                    else
                    {

                        MessageBox.Show("Nepaejo, o gal paejo?");
                    }
                }
                else
                {

                    MessageBox.Show("Nera tokio vartotojo");
                }


            }
               

            }
        }
    }

