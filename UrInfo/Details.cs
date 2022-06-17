using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrInfo
{
    public partial class Details : Form
    {
        private int numeroCommande;
        public Details(int num)
        {
            InitializeComponent();
            AfficheDetails(num);
            numeroCommande = num;           

            
        }

        private void Details_Load(object sender, EventArgs e)
        {

        }

        void AfficheDetails(int num)
        {
            CommandeManager commandeManager = new CommandeManager();
            UtilisateurManager utilisateurManager = new UtilisateurManager();   

            //dataGridView1.DataSource = commandeManager.GetCommande(2).ToString();
            Commande uneCommande = commandeManager.GetCommande(num);
            Utilisateur unUtilisateur = utilisateurManager.FindUtilisateur(uneCommande.IdUtilisateur);

            switch (uneCommande.Etat)
            {
                case 1:
                    button2.Enabled = true;
                    button3.Enabled = false;
                    break;
                case 2:
                    button2.Enabled = false;
                    button3.Enabled = true;
                    break;
                default:
                    button2.Enabled = true;
                    button3.Enabled = true;
                    break;

            };         
                

            label2.Text = "Commande n°" + num + " ,état : "+uneCommande.EtatToString();
            label1.Text = "Date de la commande : "+uneCommande.DateCommande.ToString()
                +"\n Date d'expédition : "+ uneCommande.DateExpedition.ToString()
                +"\n Commentaire : "+ uneCommande.Commentaire.ToString()
                +"\n\n Utilisateur : "+ unUtilisateur.Login
                +"\n Email : "+unUtilisateur.Email
                +"\n Adresse : "+unUtilisateur.Adresse
                +"\n Téléphone : "+unUtilisateur.Telephone;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCommandes form = new FormCommandes();
            form.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CommandeManager commandeManager = new CommandeManager();
            commandeManager.updateEtat(numeroCommande, 2);
            AfficheDetails(numeroCommande);
            //FormCommandes form = new FormCommandes();
            //form.Show();
            //this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CommandeManager commandeManager = new CommandeManager();
            commandeManager.updateEtat(numeroCommande, 1);
            AfficheDetails(numeroCommande);
            //FormCommandes form = new FormCommandes();
            //form.Show();
            //this.Close();
        }
    }
}
