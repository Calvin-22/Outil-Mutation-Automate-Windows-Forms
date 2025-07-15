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
using iTextSharp.text;
using iTextSharp.text.pdf;
using Outil_Mutation_Automate.View;
using System.IO;
using System.Windows.Forms;
using System.Linq;


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

        /// <summary>
        /// Constructeur de la classe Enregistrement.
        /// </summary>
        /// <param name="nbcValue"></param>
        /// <param name="nbvValue"></param>
        /// <param name="hauteurCanalDesireValue"></param>
        /// <param name="nombreCanauxNecessairesValue"></param>
        /// <param name="zoneValue"></param>
        public Enregistrement(double nbcValue, double nbvValue, double hauteurCanalDesireValue, double nombreCanauxNecessairesValue, string zoneValue)
        {
            InitializeComponent();
            this.MaximizeBox = false;
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
        /// Création du contrôleur et remplissage des listes
        /// </summary>
        private void Init()
        {
            controller = new FrmMutationController();
            RemplirListeMutation();

        }

        /////////////
        /// <summary>
        /// Afficher les Mutations dans le DataGridView.
        /// </summary>
        private void RemplirListeMutation()
        {
            List<mutation> LesMutations = controller.GetLesMutations();
            bdgmutation.DataSource = LesMutations;
            dgvMutation.DataSource = bdgmutation;
            dgvMutation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

        /// <summary>
        /// Bouton de confirmation d'ajout afin de sauvegarder les données produits..
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SbtnAjouter_Click(object sender, EventArgs e)
        {
            if (!txtCIP.Text.Equals("") && !txtDesignation.Text.Equals(""))
            {

                string designation = txtDesignation.Text;

                // Tenter de convertir le texte récupéré en nombres (double pour les nombres décimaux, int pour les entiers).
                // 'out double hauteurProduit' signifie que si la conversion réussit, la valeur sera stockée dans la variable 'hauteurProduit'.
                if (double.TryParse(txtCIP.Text, out double cip))
                {
                    double nombreBoitesParCommande = _nombreBoitesParCommandeFromMenuPrincipal;
                    double nombreBoitesVendues = _nombreBoitesParVenduesFromMenuPrincipal;
                    double hauteurCanalDesire = _hauteurCanalDesireFromMenuPrincipal;
                    double nombreCanauxNecessaires = _nombreCanauxNecessairesFromMenuPrincipal;
                    string zone = _zoneFromMenuPrincipal;


                    mutation mutation = new mutation(cip, designation, zone, nombreBoitesParCommande, nombreBoitesVendues, hauteurCanalDesire, nombreCanauxNecessaires);
                    controller.addMutation(mutation);

                    RemplirListeMutation();
                    MessageBox.Show("Données produits enregistrées avec succès !", "Information");
                    txtCIP.Clear(); // Nettoyage des champs de saisie
                    txtDesignation.Clear(); // Nettoyage des champs de saisie
                }
                else
                {
                    MessageBox.Show("Veuillez entrer un CIP valide.", "Information");
                }
            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
        }

        /// <summary>
        /// Bouton d'annulation pour fermer la fenêtre sans enregistrer les données.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SbtnAnnuler_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment annuler ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                this.Close();
            }
        }

        /// <summary>
        /// Bouton de suppression d'une mutation sélectionnée dans le DataGridView.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SbtnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvMutation.SelectedRows.Count > 0)
            {
                mutation mutation = (mutation)bdgmutation.List[bdgmutation.Position];
                if (MessageBox.Show("Voulez-vous vraiment supprimer " + mutation.Désignation + " " + "?", "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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

        /// <summary>
        /// Bouton pour imprimer le DataGridView en PDF.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrint_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Fichiers PDF (*.pdf)|*.pdf";
                sfd.Title = "Exporter en PDF";
                sfd.FileName = "Export.pdf";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ExportDataGridViewToPdf(dgvMutation, sfd.FileName);
                }
            }
        }

        /// <summary>
        /// Exporte le DataGridView vers un fichier PDF.
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="filePath"></param>
        private void ExportDataGridViewToPdf(DataGridView dgv, string filePath)
        {
            Document pdfDoc = new Document(PageSize.A4.Rotate(), 10f, 10f, 10f, 10f);

            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                PdfWriter writer = PdfWriter.GetInstance(pdfDoc, fs);
                pdfDoc.Open();

                PdfPTable table = new PdfPTable(dgv.ColumnCount);
                table.WidthPercentage = 100;

                // Ajouter en-têtes
                foreach (DataGridViewColumn col in dgv.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(col.HeaderText));
                    cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                    table.AddCell(cell);
                }

                // Ajouter données
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (row.IsNewRow) continue;

                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        table.AddCell(cell.Value?.ToString() ?? "");
                    }
                }

                pdfDoc.Add(table);
                pdfDoc.Close();
            }

            MessageBox.Show("PDF exporté avec succès !");
        }



    }
}
