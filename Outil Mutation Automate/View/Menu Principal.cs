using System.Drawing.Text;
using System.Media;
using System.Security.Cryptography.X509Certificates;
using SiticoneNetCoreUI; 
using Outil_Mutation_Automate.View;
using Outil_Mutation_Automate.Dal;
using MySql.Data.MySqlClient;
using Timer = System.Windows.Forms.Timer;



namespace Outil_Mutation_Automate
{
    /// <summary>
    /// Classe MenuPrincipal qui représente la fenêtre principale de l'application.
    /// </summary>
    public partial class MenuPrincipal : Form
    {
        public Timer delayTimer;  // Timer pour la mise en attente


        /// <summary>
        /// Constructeur de la classe MenuPrincipal.
        /// </summary>
        public MenuPrincipal()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            VérifierConnexion();

            // Spécification du Timer au lancement du formulaire
            delayTimer = new Timer();
            delayTimer.Interval = 2580;  // Délai de 2580ms 
            delayTimer.Tick += delayTimer_Tick;

            if (VérifierConnexion())
            {
                delayTimer.Start(); // Démarrage du Timer
            }
        }

        // A la fin du Timer, modifier la couleur de la barre de chargement
        public void delayTimer_Tick(object sender, EventArgs e)
        {
            ProgressBar.GradientEndColor = Color.Green;
            ProgressBar.GradientStartColor = Color.LimeGreen;
            ProgressBar.BorderColor = Color.MediumSeaGreen;
            ProgressBar.CustomLabel = "Connexion à la base de donnée réussie.";
            delayTimer.Stop();
        }

        // Méthode pour vérifier la connexion à la base de données et influer sur la barre de progression
        public bool VérifierConnexion()
        {
            // Remplace cette chaîne par la chaîne de connexion à ta base de données
            string connectionString = "server=localhost; user id=root; password=calvin22; database=bdd_mutation; SslMode=none";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();  // Tente d'ouvrir la connexion
                    return true;

                }
            }
            catch (Exception ex)
            {
                // Si la connexion échoue, changer la couleur et la progression de la barre
                Console.WriteLine("Erreur de connexion à la base de données : " + ex.Message);

                // Changer la couleur de la barre en orange et la mettre à 75%
                ProgressBar.GradientEndColor = Color.Red;
                ProgressBar.GradientStartColor = Color.Orange;
                ProgressBar.BorderColor = Color.OrangeRed;
                ProgressBar.CustomLabel = "Erreur de connexion à la base de donnée.";
                return false;
            }
        }

        private double _NBV; // Nombre de boîtes vendues (par jour)
        private double _NBC; // Nombre de boîtes par commande
        private double _hauteurCanalDesire; // Hauteur du canal désirée
        private double _NbGoulotte; // Nombre de canaux nécessaires
        private string _zone; // Zone du produit

        /// <summary>
        /// Événement déclenché lors du clic sur le bouton "Calculer".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SbtnCalculer_Click(object sender, EventArgs e)
        {
            if (!hauteur.Text.Equals("") && !frequence.Text.Equals("") && !moyenne.Text.Equals("") && !hauteurG.Text.Equals(""))
            {
                // Récupérer le texte entré par l'utilisateur dans les TextBox.
                // 'Hauteur', 'Frequence', 'Moyenne' et 'HauteurG'
                string hauteurProduitTexte = hauteur.Text;
                string frequencePickingTexte = frequence.Text;
                string moyenneVentesTexte = moyenne.Text;
                string hauteurCanalDesireTexte = hauteurG.Text;

                // Tenter de convertir le texte récupéré en nombres (double pour les nombres décimaux, int pour les entiers).
                // 'out double hauteurProduit' signifie que si la conversion réussit, la valeur sera stockée dans la variable 'hauteurProduit'.
                if (double.TryParse(hauteurProduitTexte, out double hauteurProduit) &&
                    int.TryParse(frequencePickingTexte, out int frequencePicking) &&
                    double.TryParse(moyenneVentesTexte, out double moyenneVentes) &&
                    double.TryParse(hauteurCanalDesireTexte, out _hauteurCanalDesire))
                {
                    if (frequencePicking <= moyenneVentes)
                    {
                        // Logique de calcul
                        _NBV = moyenneVentes / 25;
                        double HT = hauteurProduit * _NBV;
                        _NbGoulotte = HT / _hauteurCanalDesire;
                        _NBC = moyenneVentes / frequencePicking;

                        // Afficher le résultat sous forme de texte
                        ligne1.Text = "• Nombre de boîtes vendues (par jour) :  " + _NBV.ToString();
                        ligne2.Text = "• Hauteur totale nécessaire (par jour) : " + Math.Round(HT, 1) + "mm";
                        ligne3.Text = "• Nombre de canaux de " + _hauteurCanalDesire + "mm" + " nécessaire par jour : " + Math.Round(_NbGoulotte, 1);
                        ligne4.Text = "• Nombre de boîtes par commande (en moyenne) : " + Math.Round(_NBC, 1);

                        ligne5.Text = ""; // On efface le contenu de ligne5
                        ligne6.Text = ""; // On efface le contenu de ligne6
                        ligne7.Text = ""; // On efface le contenu de ligne7
                        ligne8.Text = ""; // On efface le contenu de ligne8

                        // Partie interprétation des résultats (conclusions)
                        if (_NBC < 5 && _NbGoulotte < 3.1 && Zone(frequencePicking, (int)_NBC, _NbGoulotte))
                        {
                            // Réponse et détermination du type de canaux (taille)
                            if (_NbGoulotte > 1)
                            {
                                ligne5.Text = "Dans cette configuration, il serait souhaitable d'opter pour une hauteur de canal plus grande.";
                                ligne6.Text = $"Sinon, il faudrait mettre en place {Math.Round(_NbGoulotte, 1)} canaux de {hauteurG.Text} mm.";
                                ligne7.Text = ""; // On efface le contenu de ligne7
                                ligne8.Text = ""; // On efface le contenu de ligne8
                            }
                            else
                            {
                                double pourcentage = _NbGoulotte * 100;
                                ligne5.Text = "Parfait pour cette configuration en terme de hauteur de canal.";
                                ligne6.Text = $"Ce produit nécessitera précisément {Math.Round(pourcentage, 1)} % d'un canal de {hauteurG.Text} mm.";
                                ligne7.Text = ""; // On efface le contenu de ligne7
                                ligne8.Text = ""; // On efface le contenu de ligne8
                            }
                        }

                        // Définition de la zone
                        if (Zone(frequencePicking, (int)_NBC, _NbGoulotte))
                        {
                            ligne8.Text = "Ce produit peut aller à l'automate.";
                            _zone = "Automate"; // Zone définie comme "Automate"

                        }
                        else
                        {
                            ligne8.Text = "Ce produit doit aller au magasin. Il n'est pas compatible avec les exigences de l'automate.";
                            _zone = "Magasin"; // Zone définie comme "Magasin"
                        }
                    }
                    else
                    {
                        // Si la fréquence de picking est supérieure à la moyenne des ventes, afficher un message d'erreur.
                        SystemSounds.Hand.Play();
                        MessageBox.Show("Erreur : La fréquence de picking ne peut pas être supérieure à la moyenne des ventes.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        return;
                    }

                }
                else
                // Si une ou plusieurs conversions ont échoué (l'utilisateur n'a pas entré de nombres valides),
                // afficher un message d'erreur 
                {
                    SystemSounds.Hand.Play();
                    MessageBox.Show("Erreur : Veuillez saisir une valeur correcte.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {   // Si l'un des champs est vide, afficher un message d'erreur.
                SystemSounds.Hand.Play();
                MessageBox.Show("Erreur : Veuillez remplir tous les champs.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        // Fonction de détermination de la zone du produit correspondant
        public bool Zone(double frequence, int NBC, double NbGoulotte)
        {
            // Condition fréquence minimum 60, condition picking inférieur à 5, Nombre de canaux inférieur à 3 
            if (frequence > 60 && NBC < 5 && NbGoulotte < 3.1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        // Fenêtre d'information du logiciel
        private void infobutton_Click(object sender, EventArgs e)
        {
            Information frm = new Information(); // génère la fenêtre d'information
            frm.Show(); // Affiche la fenêtre 
        }

        /// <summary>
        /// Bouton d'enregistrement des résultats calculés dans une nouvelle fenêtre.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void SbtnEnregistrer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ligne1.Text) || string.IsNullOrEmpty(ligne2.Text) || string.IsNullOrEmpty(ligne3.Text) ||
                string.IsNullOrEmpty(ligne4.Text))

            {
                SystemSounds.Hand.Play();
                MessageBox.Show("Erreur : Veuillez d'abord effectuer un calcul avant d'enregistrer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                // Si les lignes de résultats ne sont pas vides, on peut procéder à l'enregistrement.
                double nbcValue = Math.Round(_NBC, 1);
                double nbvValue = Math.Round(_NBV, 1); // Récupération des valeurs de nbc et nbv
                double hauteurCanalDesireValue = Math.Round(_hauteurCanalDesire, 1);
                double nombreCanauxNecessairesValue = Math.Round(_NbGoulotte, 1);
                string zoneValue = _zone; // Récupération de la zone

                Enregistrement frm = new Enregistrement(nbcValue, nbvValue, hauteurCanalDesireValue, nombreCanauxNecessairesValue, zoneValue); // génère la fenêtre
                frm.Show(); // Affiche la fenêtre 

            }

        }
        /// <summary>
        /// Vider intégralement les saisies et calculs réalisés par l'algorithme 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnVider_Click(object sender, EventArgs e)
        {
            // Vérification que les saisies sont réalisées avant de tenter inutilement de supprimer
            if (!string.IsNullOrEmpty(hauteur.Text) || !string.IsNullOrEmpty(frequence.Text) || !string.IsNullOrEmpty(moyenne.Text) ||
                !string.IsNullOrEmpty(hauteurG.Text))
            {
                // Confirmation de suppression ou non
                DialogResult result = MessageBox.Show(
                    "Voulez-vous vraiment supprimer les saisies et résultats précédemment effectués ?", // Affichage du message
                    "Confirmation de suppression", // Titre
                    MessageBoxButtons.YesNo, // Afficher oui ou non (instauration du choix)
                    MessageBoxIcon.Warning // Logo avertissement
                    );

                if (result == DialogResult.Yes)
                {
                    // Utilisateur a cliqué sur oui 
                    // Suppression des éléments de saisies
                    hauteur.Text = string.Empty;
                    frequence.Text = string.Empty;
                    moyenne.Text = string.Empty;
                    hauteurG.Text = string.Empty;

                    // Suppression des éléments de résultats et de conclusions
                    ligne1.Text = string.Empty;
                    ligne2.Text = string.Empty;
                    ligne3.Text = string.Empty;
                    ligne4.Text = string.Empty;
                    ligne5.Text = string.Empty;
                    ligne6.Text = string.Empty;
                    ligne7.Text = string.Empty;
                    ligne8.Text = string.Empty;
                }
                else
                {
                    // Ne rien faire
                }
            }
            else
            {
                SystemSounds.Hand.Play();
                MessageBox.Show("Erreur : Veuillez d'abord effectuer une saisie.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
        }
    }
}

