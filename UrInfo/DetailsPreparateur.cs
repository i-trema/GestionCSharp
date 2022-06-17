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
    public partial class DetailsPreparateur : Form
    {
        private int numeroCommande;
        public DetailsPreparateur(int num)
        {
            InitializeComponent();
            AfficheDetails(num);
            numeroCommande = num;
        }


        void AfficheDetails(int num)
        {
            CommandeManager commandeManager = new CommandeManager();
            UtilisateurManager utilisateurManager = new UtilisateurManager();

            Commande uneCommande = commandeManager.GetCommande(num);
            Utilisateur unUtilisateur = utilisateurManager.FindUtilisateur(uneCommande.IdUtilisateur);

            switch (uneCommande.Etat)
            {
                case 2:
                    button2.Enabled = true;
                    button3.Enabled = false;
                    break;
                case 3:
                    button2.Enabled = false;
                    button3.Enabled = true;
                    break;
                case 4:
                    button2.Enabled = false;
                    button3.Enabled = false;
                    break;

                default:
                    button2.Enabled = true;
                    button3.Enabled = true;
                    break;

            };


            label2.Text = "Commande n°" + num + " ,état : " + uneCommande.EtatToString();
            label1.Text = "Date de la commande : " + uneCommande.DateCommande.ToString()
                + "\n Date d'expédition : " + uneCommande.DateExpedition.ToString()
                + "\n Commentaire : " + uneCommande.Commentaire.ToString()
                + "\n\n Utilisateur : " + unUtilisateur.Login
                + "\n Email : " + unUtilisateur.Email
                + "\n Adresse : " + unUtilisateur.Adresse
                + "\n Téléphone : " + unUtilisateur.Telephone;
            dataGridView1.DataSource = commandeManager.SelectProduits(uneCommande.Numero);
            
            

        }
        private void DetailsPreparateur_Load(object sender, EventArgs e)
        {
            
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            CommandeManager commandeManager = new CommandeManager();
            commandeManager.updateEtat(numeroCommande, 3);
            AfficheDetails(numeroCommande);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormPreparateur form = new FormPreparateur();
            form.Show();
            this.Close();
        }
        // clic sur Expédié , update date d'expédition et recharge les détails
        private void button3_Click(object sender, EventArgs e)
        {
            
            CommandeManager commandeManager = new CommandeManager();
            commandeManager.updateEtat(numeroCommande, 4);
            commandeManager.updateDateExpedition(numeroCommande);

            AfficheDetails(numeroCommande);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
