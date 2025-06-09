using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Outil_Mutation_Automate.Model;
using Outil_Mutation_Automate.Controller;
using System.Security.Policy;
using Outil_Mutation_Automate.Dal;
using Outil_Mutation_Automate.View;

namespace Outil_Mutation_Automate.View
{
    public partial class Enregistrement : Form
    {
        /// <summary>
        /// Objet pour gérer la liste des mutations
        /// </summary>
        private BindingSource bdgmutation = new BindingSource();

        private FrmMutationController controller;

        // Variables pour stocker les valeurs passées depuis le menu principal
        private double _nombreBoitesParCommandeFromMenuPrincipal;
        private double _nombreBoitesParVenduesFromMenuPrincipal;
        private double _hauteurCanalDesireFromMenuPrincipal;
        private double _nombreCanauxNecessairesFromMenuPrincipal;
        private string _zoneFromMenuPrincipal;

        public Enregistrement(double nbcValue, double nbvValue, double hauteurCanalDesireValue, double nombreCanauxNecessairesValue, string zoneValue)
        {
            InitializeComponent();
            _nombreBoitesParCommandeFromMenuPrincipal = nbcValue;
            _nombreBoitesParVenduesFromMenuPrincipal = nbvValue;
            _hauteurCanalDesireFromMenuPrincipal = hauteurCanalDesireValue;
            _nombreCanauxNecessairesFromMenuPrincipal = nombreCanauxNecessairesValue;
            _zoneFromMenuPrincipal = zoneValue;
            // Appel de la méthode d'initialisation
            Init();
        }

        /// <summary>
        /// Initialisations :
        /// Création du controleur et remplissage des listes
        /// </summary>
        private void Init()
        {
            controller = new FrmMutationController();
            RemplirListeMutation();

        }

        /////////////
        /// <summary>
        /// Afficher les Personnels
        /// </summary>
        private void RemplirListeMutation()
        {
            List<mutation> LesMutations = controller.GetLesMutations();
            bdgmutation.DataSource = LesMutations;
            dgvMutation.DataSource = bdgmutation;
            dgvMutation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            if (!txtCIP.Text.Equals("") && !txtDesignation.Text.Equals(""))
            {
                double cip = double.Parse(txtCIP.Text);
                string designation = txtDesignation.Text;

                double nombreBoitesParCommande = _nombreBoitesParCommandeFromMenuPrincipal;
                double nombreBoitesVendues = _nombreBoitesParVenduesFromMenuPrincipal;
                double hauteurCanalDesire = _hauteurCanalDesireFromMenuPrincipal;
                double nombreCanauxNecessaires = _nombreCanauxNecessairesFromMenuPrincipal;
                string zone = _zoneFromMenuPrincipal;


                mutation mutation = new mutation(cip, designation, zone, nombreBoitesParCommande, nombreBoitesVendues, hauteurCanalDesire, nombreCanauxNecessaires);
                controller.addMutation(mutation);

                RemplirListeMutation();
                MessageBox.Show("Mutation enregistrée avec succès !", "Information");
                txtCIP.Clear(); // Nettoyage des champs de saisie
                txtDesignation.Clear(); // Nettoyage des champs de saisie
            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment annuler ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Hide();
                this.Close();
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvMutation.SelectedRows.Count > 0)
            {
                mutation mutation = (mutation)bdgmutation.List[bdgmutation.Position];
                if (MessageBox.Show("Voulez-vous vraiment supprimer " + mutation.Désignation + " " + "?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controller.delMutation(mutation);
                    RemplirListeMutation();
                }
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }
    }
}
