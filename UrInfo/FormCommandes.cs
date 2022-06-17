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
    public partial class FormCommandes : Form
    {
        private List<Commande> commandeList = new List<Commande>();
        private int commandeSelectionnee;
        public FormCommandes()
        {
            InitializeComponent();
            AfficheAllCommandes();
            button1.Enabled = false;
        }

        private void FormCommandes_Load(object sender, EventArgs e)
        {

        }

        void AfficheAllCommandes()
        {
            CommandeManager commandeManager = new CommandeManager();
            commandeList = commandeManager.SelectAllCommande1et2();
            dataGridView1.DataSource = commandeList;
        }

        

        private void button5_Click(object sender, EventArgs e)
        {
            
            Form2 form = new Form2();
            form.Show();
            this.Close();
        }

        

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            button1.Enabled = true;
            commandeSelectionnee = commandeList[int.Parse(e.RowIndex.ToString())].Numero;
            button1.Text = "Détails de la commande n°"+commandeSelectionnee.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Details form = new Details(commandeSelectionnee);
            form.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
