using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static UrInfo.EmployeManager;

namespace UrInfo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            AfficheAllEmploye();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string password = textBox2.Text;    
            
            

            Employe newEmploye = FindEmploye(login);
            if (newEmploye.Login == null)
            {
                label2.Text = "Ce compte n'existe pas.";
            }
            else if(newEmploye.Mdp != password){
                label2.Text = "Mot de passe incorrect.";

            }
            else
            {
                //label2.Text = newEmploye.Login + " " + newEmploye.Mdp;
                if(newEmploye.Type == "comptable")
                {
                    FormCommandes form = new FormCommandes();
                    form.Show();
                    this.Hide();
                }else if(newEmploye.Type == "preparateurs"){
                    FormPreparateur formP = new FormPreparateur();
                    formP.Show();
                    this.Hide();
                }
            }

            //FormCommandes form = new FormCommandes();
            //        form.Show();
            //        this.Hide();


        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        void AfficheAllEmploye()
        {
            EmployeManager employeManager = new EmployeManager();
            List<Employe> employeList = employeManager.SelectAllEmploye();
            dataGridView1.DataSource = employeList;

        }

        Employe FindEmploye(string login)
        {
            EmployeManager employeManager = new EmployeManager();
            Employe unEmploye = employeManager.FindEmploye(login);
            return unEmploye;
        }
    }
}
