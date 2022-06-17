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
    public partial class FormPreparateur : Form
    {

        private List<Commande> commandeList = new List<Commande>();
        private int commandeSelectionnee;
        public FormPreparateur()
        {
            InitializeComponent();
            AfficheAllCommandes();
            button2.Enabled = false;
        }

        private void FormPreparateur_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Close();
        }

     

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //label1.Text = commandeList[int.Parse(e.RowIndex.ToString())].ToString();
            button2.Enabled = true;
            commandeSelectionnee = commandeList[int.Parse(e.RowIndex.ToString())].Numero;
            button2.Text = "Détails de la commande n°" + commandeSelectionnee.ToString();

        }

        void AfficheAllCommandes()
        {
            CommandeManager commandeManager = new CommandeManager();
            commandeList = commandeManager.SelectAllCommande2et3et4();
            dataGridView1.DataSource = commandeList;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DetailsPreparateur form = new DetailsPreparateur(commandeSelectionnee);
            form.Show();
            this.Hide();
        }
    }
}
