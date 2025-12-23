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
using System.Security.Policy;

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

        private void SBtnImporter_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Fichiers CSV (*.csv)|*.csv|Tous les fichiers (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var cheminFichier = ofd.FileName;
                ImporterCsv(cheminFichier);
            }
        }

        /// <summary>
        /// Méthode pour importer des données depuis un fichier CSV.
        /// </summary>
        /// <param name="chemin"></param>
        private void ImporterCsv(string cheminCsv)
        {
            var lignes = File.ReadAllLines(cheminCsv, Encoding.GetEncoding("Windows-1252"));

            for (int i = 0; i < lignes.Length; i++)
            {
                var champs = lignes[i].Split(';');

                // Vérifie que l'ensemble des champs nécessaires sont présent.
                if (champs.Length < 5) continue;

                // Récupération des champs dans des variables 
                double.TryParse(champs[0], out double canal);
                double.TryParse(champs[1], out double produit);
                string date = champs[2].Trim();
                double.TryParse(champs[3], out double commandé);
                double.TryParse(champs[4], out double manque);
                string motif = champs[5].Trim();

                // Création de l'objet Erreurs via appel du constructeur.
                Erreurs erreurs = new Erreurs(canal, produit, date, commandé, manque, motif);
                ;
                controller.addErreurs(erreurs);
            }
            MessageBox.Show("Import terminé !");
            RemplirListeErreurs(); // Rafraîchir la liste des mutations après l'importation.
        }

        /// <summary>
        /// Filtrer les erreurs dont le motif contient "vide"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FiltrerVide_Click(object sender, EventArgs e)
        {
            try
            {
                dgvErreurs.DataSource = controller.GetStatsErreursVides();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du filtrage : " + ex.Message);
            }


        }

        /// <summary>
        /// Filtrer les erreurs dont le motif contient "Sortie manuelle"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FiltrerManuelle_Click(object sender, EventArgs e)
        {
            try
            {
                dgvErreurs.DataSource = controller.GetStatsErreursManuelle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du filtrage : " + ex.Message);
            }
        }

        /// <summary>
        /// Annuler le filtre et afficher toutes les erreurs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnulerFiltre_Click_1(object sender, EventArgs e)
        {
            RemplirListeErreurs(); // Recharge toutes les erreurs dans le DataGridView
        }
    }
}
