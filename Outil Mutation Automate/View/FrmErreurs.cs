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
using Outil_Mutation_Automate.Dal;

namespace Outil_Mutation_Automate.View
{
    public partial class FrmErreurs : Form
    {
        /// <summary>
        /// Objet pour gérer la liste des mutations
        /// </summary>
        private BindingSource bdgerreurs = new BindingSource();


        private FrmErreursController controller;

        /// <summary>
        /// Initialisation du formulaire
        /// </summary>
        public FrmErreurs()
        {
            InitializeComponent();
            Init();
        }

        /// <summary>
        /// Initialisations :
        /// Création du contrôleur et remplissage des listes
        /// </summary>
        private void Init()
        {
            controller = new FrmErreursController();
            RemplirListeErreurs();

        }

        /////////////
        /// <summary>
        /// Afficher les Mutations dans le DataGridView.
        /// </summary>
        private void RemplirListeErreurs()
        {
            List<Erreurs> LesErreurs = controller.GetLesErreurs();
            bdgerreurs.DataSource = LesErreurs;
            dgvErreurs.DataSource = bdgerreurs;

            dgvErreurs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SViderBDD_Click(object sender, EventArgs e)
        {
            // Boîte de dialogue de confirmation
            DialogResult result = MessageBox.Show(
                "Voulez-vous vraiment vider la base de données ?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    // Création de l'accès à la base de données
                    ErreursAccess access = new ErreursAccess();

                    // Appel de la méthode pour vider la base
                    access.ViderErreurs();

                    // Rafraîchir la liste après suppression
                    RemplirListeErreurs();

                    MessageBox.Show("La base de données a été vidée avec succès.", "Information");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors du vidage de la base : " + ex.Message, "Erreur");
                }
            }
        }
    }
}
