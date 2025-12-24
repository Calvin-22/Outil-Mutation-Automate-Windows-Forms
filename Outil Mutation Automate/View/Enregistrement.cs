
using System.Data;
using System.Text;
using Outil_Mutation_Automate.Model;
using Outil_Mutation_Automate.Controller;
using Outil_Mutation_Automate.Dal;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Google.Protobuf.WellKnownTypes;
using System.ComponentModel;
using System.Windows.Forms;

namespace Outil_Mutation_Automate.View

{

    public partial class Enregistrement : Form
    {

        /// <summary>
        /// Objet pour gérer la liste des mutations
        /// </summary>
        private BindingSource bdgmutation = new BindingSource();

        private FrmMutationController controller;

        private bool modeLectureSeule;

        // Variables pour stocker les valeurs passées depuis le menu principal
        private double _nombreBoitesParCommandeFromMenuPrincipal;
        private double _nombreBoitesParVenduesFromMenuPrincipal;
        private double _hauteurCanalDesireFromMenuPrincipal;
        private double _nombreCanauxNecessairesFromMenuPrincipal;
        private string _zoneFromMenuPrincipal;
        private string _codeGéoFromMenuPrincipal;
        private double _moyenneDesVentesFromMenuPrincipal;
        private double _frequencePickingFromMenuPrincipal;

        /// <summary>
        /// Constructeur de la classe Enregistrement.
        /// </summary>
        /// <param name="nbcValue"></param>
        /// <param name="nbvValue"></param>
        /// <param name="hauteurCanalDesireValue"></param>
        /// <param name="nombreCanauxNecessairesValue"></param>
        /// <param name="zoneValue"></param>
        public Enregistrement(string codegéoValue, double nbcValue, double moyenneValue, double FrequenceValue, double nbvValue, double hauteurCanalDesireValue, double nombreCanauxNecessairesValue, string zoneValue, bool lectureSeule)
        {
            InitializeComponent();

            // Abonnement à l'événement CellFormatting pour personnaliser dynamiquement
            // l'apparence des cellules (ex : couleur de fond selon la valeur).
            dgvMutation.CellFormatting += dgvMutation_CellFormatting;

            this.MaximizeBox = false;

            // Import des données depuis menu principal, si on l'utilise
            _nombreBoitesParCommandeFromMenuPrincipal = nbcValue;
            _nombreBoitesParVenduesFromMenuPrincipal = nbvValue;
            _hauteurCanalDesireFromMenuPrincipal = hauteurCanalDesireValue;
            _nombreCanauxNecessairesFromMenuPrincipal = nombreCanauxNecessairesValue;
            _zoneFromMenuPrincipal = zoneValue;
            _codeGéoFromMenuPrincipal = codegéoValue;

            _moyenneDesVentesFromMenuPrincipal = moyenneValue;
            _frequencePickingFromMenuPrincipal = FrequenceValue;

            // Variable lecture seule
            modeLectureSeule = lectureSeule;

            // Mode lecture seule 
            if (modeLectureSeule)
            {
                // Grise les champs ou les rend non modifiables
                txtCIP.ReadOnly = true;
                txtDesignation.ReadOnly = true;
                txtCIP.Enabled = false;
                txtDesignation.Enabled = false;
                this.Text = "Consultation";

                // Désactive le bouton Ajouter
                SbtnAjouter.Enabled = false;
            }
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
            // Récupération des données via le contrôleur
            List<mutation> LesMutations = controller.GetLesMutations();
            bdgmutation.DataSource = LesMutations;
            dgvMutation.DataSource = bdgmutation;

            // Boucle sur les colonnes pour appliquer les DisplayName
            foreach (DataGridViewColumn col in dgvMutation.Columns)
            {
                var prop = TypeDescriptor.GetProperties(typeof(mutation))[col.DataPropertyName];
                if (prop != null)
                {
                    var displayNameAttr = prop.Attributes[typeof(DisplayNameAttribute)] as DisplayNameAttribute;
                    if (displayNameAttr != null)
                    {
                        col.HeaderText = displayNameAttr.DisplayName;
                    }
                }
            }

            // Ajustement automatique de la taille des colonnes
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
                    string code_géo = _codeGéoFromMenuPrincipal;
                    double moyenneDesVentes = _moyenneDesVentesFromMenuPrincipal;
                    double frequencePicking = _frequencePickingFromMenuPrincipal;


                    mutation mutation = new mutation(cip, code_géo, designation, moyenneDesVentes, frequencePicking, zone, nombreBoitesParCommande, nombreBoitesVendues, hauteurCanalDesire, nombreCanauxNecessaires);
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

        /// <summary>
        /// Bouton pour importer des données depuis un fichier CSV.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SBtnImporter_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Fichiers CSV (*.csv)|*.csv";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var cheminFichier = ofd.FileName;
                ImporterCsv(cheminFichier);
            }
        }

        /// <summary>
        /// Initialisations des variables nécessaires aux calculs
        /// </summary>
        private double _NBV; // Nombre de boîtes vendues (par jour)
        private double _NBC; // Nombre de boîtes par commande
        private double _hauteurCanalDesire; // Hauteur du canal désirée
        private double _NbGoulotte; // Nombre de canaux nécessaires
        private string _zone; // Zone du produit
        public int compteur = 0; // Compteur pour le nombre de lignes importées

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

                // Vérifie que l'ensemble des champs nécessaires sont présent
                if (champs.Length < 5) continue;

                // Récupération des champs dans des variables 
                double.TryParse(champs[0], out double cip);
                string codegéo = champs[1].Trim(); ;
                string designation = champs[2].Trim();
                double.TryParse(champs[3], out double moyenneVentes);
                double.TryParse(champs[4], out double frequencePicking);
                int.TryParse(champs[5], out int hauteurProduit);

                // Initialisation des variables de vérification et de zone au départ
                bool vérif = true;
                string zone = string.Empty;

                // Calcul des valeurs nécessaires pour la mutation
                _NBV = moyenneVentes / 25;
                double HT = hauteurProduit * _NBV;

                //_NbGoulotte = HT / _hauteurCanalDesire; : désactivation temporaire à des fins de calculs. 
                _NBC = moyenneVentes / frequencePicking;

                // Conservation de la moyenne 
                double MoyenneDesVentes = moyenneVentes;

                // Conservation de la fréquence picking
                double FrequencePicking = frequencePicking;

                // Conservation de la désignation
                string DésignationVérif = designation;

                // Détermination de la hauteur idéale (tranche en dessous de 0.81 soit 80%) 
                if (PetitCanal(HT) > 0.81)
                {
                    if (MoyenCanal(HT) > 0.81)
                    {
                        if (GrandCanal(HT) > 0.91)
                        {
                            // Fréquence beaucoup trop élevée, pas de canal possible ; incompatible avec l'automate.
                            _hauteurCanalDesire = 2200;
                            vérif = false; // Produit supérieur ou égale à 91% d'un canal de 2200 mm = ignorer le produit et le mettre en magasin. 
                        }
                        else
                        {
                            _hauteurCanalDesire = 2200; // Inférieur à 80% d'un canal de 2200mm 
                        }
                    }
                    else
                    {
                        _hauteurCanalDesire = 1200; // Inférieur à 80% d'un canal de 1200mm 
                    }
                }
                else
                {
                    _hauteurCanalDesire = 800; // Inférieur à 80% d'un canal de 800mm 
                }

                // Calcul du nombre de canaux nécessaires après attribution de la hauteur du canal
                _NbGoulotte = HT / _hauteurCanalDesire;
                _NbGoulotte = Math.Round(_NbGoulotte, 2); // Arrondi à 2 décimales pour éviter les erreurs de calcul
                _NBC = Math.Round(_NBC, 2);
                _NBV = Math.Round(_NBV, 2);

                // Définition de la zone
                if (Zone(frequencePicking, (int)_NBC, _NbGoulotte, vérif, DésignationVérif))
                {
                    _zone = "Automate"; // Zone définie comme "Automate"

                }
                else
                {
                    _zone = "Magasin"; // Zone définie comme "Magasin"
                }

                mutation mutation = new mutation(cip, codegéo, designation, MoyenneDesVentes, FrequencePicking, _zone, _NBC, _NBV, _hauteurCanalDesire, _NbGoulotte);
                controller.addMutation(mutation);

            }
            MessageBox.Show("Import terminé !");
            RemplirListeMutation(); // Rafraîchir la liste des mutations après l'importation
        }

        // Fonction de détermination de la zone du produit correspondant
        public bool Zone(double frequence, int NBC, double NbGoulotte, bool vérif, string Désignation)
        {
            // Si le produit est Frésubin ou Clinutren, il est automatiquement en magasin
            if (Désignation.IndexOf("Frésubin", StringComparison.OrdinalIgnoreCase) >= 0 ||
                Désignation.IndexOf("CLINUTREN", StringComparison.OrdinalIgnoreCase) >= 0 ||
                Désignation.IndexOf("FRESUBIN", StringComparison.OrdinalIgnoreCase) >= 0 ||
                Désignation.IndexOf("MEPILEX", StringComparison.OrdinalIgnoreCase) >= 0 ||
                Désignation.IndexOf("SOD BICARB", StringComparison.OrdinalIgnoreCase) >= 0)
            {
                return false;
            }

            // Condition fréquence minimum 60, condition picking inférieur à 4, Nombre de canaux inférieur à 2.1
            if (frequence > 50 && NBC < 4 && NbGoulotte < 2.1 && vérif)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        /// <summary>
        /// Fonction de calcul du pourcentage produit vendu par jour pour un canal de 800mm.
        /// </summary>
        /// <param name="HT"></param>
        /// <returns></returns>
        public double PetitCanal(double HT)
        {
            double petit;
            petit = HT / 800;
            return petit;
        }

        /// <summary>
        /// Fonction de calcul du pourcentage produit vendu par jour pour un canal de 1200mm.
        /// </summary>
        /// <param name="HT"></param>
        /// <returns></returns>
        public double MoyenCanal(double HT)
        {
            double moyen;
            moyen = HT / 1200;
            return moyen;
        }

        /// <summary>
        /// Fonction de calcul du pourcentage produit vendu par jour pour un canal de 2200mm.
        /// </summary>
        /// <param name="HT"></param>
        /// <returns></returns>
        public double GrandCanal(double HT)
        {
            double grand;
            grand = HT / 2200;
            return grand;
        }

        private void FiltrerMagasin_Click(object sender, EventArgs e)
        {
            var mutationsFiltrées = ((List<mutation>)bdgmutation.DataSource)
        .Where(m => m.Zone != null && m.Zone.ToLower().Contains("magasin"))
        .ToList();

            dgvMutation.DataSource = mutationsFiltrées;
        }


        private void FiltrerAutomate_Click(object sender, EventArgs e)
        {
            var mutationsFiltrées = ((List<mutation>)bdgmutation.DataSource)
        .Where(m => m.Zone != null && m.Zone.ToLower().Contains("automate"))
        .ToList();

            dgvMutation.DataSource = mutationsFiltrées;
        }

        /// <summary>
        /// Bouton pour vider entièrement la bdd. 
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
                    mutationAccess access = new mutationAccess();

                    // Appel de la méthode pour vider la base
                    access.ViderMutation();

                    // Rafraîchir la liste après suppression
                    RemplirListeMutation();

                    MessageBox.Show("La base de données a été vidée avec succès.", "Information");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors du vidage de la base : " + ex.Message, "Erreur");
                }
            }
        }

        private void btnAnnulerFiltre_Click(object sender, EventArgs e)
        {
            RemplirListeMutation(); // Recharge toutes les mutations dans le DataGridView
        }

        private void btnRechercherCodeGeo_Click(object sender, EventArgs e)
        {
            string codeRecherche = txtRechercheCodeGeo.Text.Trim().ToLower() + "'";

            if (string.IsNullOrWhiteSpace(codeRecherche))
            {
                MessageBox.Show("Veuillez entrer un code géographique.", "Recherche", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            bool trouvé = false;

            foreach (DataGridViewRow row in dgvMutation.Rows)
            {
                if (row.Cells["CodeGéo"].Value != null &&
                    row.Cells["CodeGéo"].Value.ToString().ToLower() == codeRecherche)
                {
                    // Sélectionne la ligne
                    row.Selected = true;

                    // Fait défiler vers la ligne
                    dgvMutation.FirstDisplayedScrollingRowIndex = row.Index;

                    trouvé = true;
                    txtRechercheCodeGeo.Text = "";
                    break;

                }
            }

            if (!trouvé)
            {
                MessageBox.Show("Aucun produit trouvé avec ce code géographique.", "Résultat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Vérifie si une ligne est non conforme selon les règles de code géographique et hauteur de canal.
        /// </summary>
        /// <param name="codeGeo"></param>
        /// <param name="hauteurStr"></param>
        /// <returns></returns>
        private bool LigneEstNonConforme(string codeGeo, string hauteurStr)
        {
            if (string.IsNullOrEmpty(codeGeo)) return false;

            codeGeo = codeGeo.Trim();
            hauteurStr = hauteurStr?.Trim();

            // 90/91 => 800
            if (codeGeo.Length >= 2)
            {
                string codePrefix = codeGeo.Substring(0, 2);
                if ((codePrefix == "90" || codePrefix == "91") && hauteurStr != "800")
                    return true;
            }

            if (codeGeo.Length >= 3)
            {
                string codePrefix3 = codeGeo.Substring(0, 3);

                // 92N à 92Y => 2200
                if (new[] { "92N", "92P", "92Q", "92R", "92S", "92T", "92V", "92W", "92X", "92Y" }.Contains(codePrefix3)
                    && hauteurStr != "2200")
                    return true;

                // 92M, 92K, 92H, 92F => 1200
                if (new[] { "92M", "92K", "92H", "92F" }.Contains(codePrefix3)
                    && hauteurStr != "1200")
                    return true;

                // 92E, 92G, 92J, 92L => 800
                if (new[] { "92E", "92G", "92J", "92L" }.Contains(codePrefix3)
                    && hauteurStr != "800")
                    return true;
            }

            if (codeGeo.Length >= 4)
            {
                string codePrefix4 = codeGeo.Substring(0, 4);

                // 92C1 à 92C4 / 92D1 à 92D4 => 1200
                if (new[] { "92C1", "92C2", "92C3", "92C4", "92D1", "92D2", "92D3", "92D4" }.Contains(codePrefix4)
                    && hauteurStr != "1200")
                    return true;

                // 92C5 à 92C8 / 92D5 à 92D8 => 800
                if (new[] { "92C5", "92C6", "92C7", "92C8", "92D5", "92D6", "92D7", "92D8" }.Contains(codePrefix4)
                    && hauteurStr != "800")
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Événement de formatage des cellules pour changer la couleur de fond
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvMutation_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var row = dgvMutation.Rows[e.RowIndex];

            string codeGeo = row.Cells["CodeGéo"].Value?.ToString();
            string hauteurStr = row.Cells["Hauteur_Canal"].Value?.ToString();

            if (LigneEstNonConforme(codeGeo, hauteurStr))
            {
                e.CellStyle.BackColor = Color.DarkRed;
                e.CellStyle.ForeColor = Color.White;
            }
        }

        /// <summary>
        /// Bouton pour filtrer les lignes non conformes selon les règles de code géographique et hauteur de canal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void filtrebutton_Click(object sender, EventArgs e)
        {
            var mutations = (List<mutation>)bdgmutation.DataSource;

            var mutationsFiltrees = mutations
                .Where(m => LigneEstNonConforme(m.CodeGéo, m.Hauteur_Canal.ToString()))
                .ToList();

            dgvMutation.DataSource = mutationsFiltrees;
        }

        /// <summary>
        /// Ouvrir le formulaire dédié spécifiquement aux erreurs automate.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SBtnErreursAutomate_Click(object sender, EventArgs e)
        {
            // Vérifie si un formulaire nommé "Form2" est ouvert
            foreach (Form form in Application.OpenForms)
            {
                if (form is FrmErreurs)
                {
                    form.Close();  // Ferme le formulaire
                    break;         // Stoppe la boucle une fois trouvé
                }
            }
            FrmErreurs frm = new FrmErreurs();
            frm.Show(); // Affiche la fenêtre 
        }
    }
}
