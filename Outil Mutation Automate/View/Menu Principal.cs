using System.Drawing.Text;
using System.Media;
using System.Security.Cryptography.X509Certificates;
using SiticoneNetCoreUI; 
using Outil_Mutation_Automate.View;
using Outil_Mutation_Automate.Dal;
using MySql.Data.MySqlClient;
using Timer = System.Windows.Forms.Timer;
using iTextSharp.text.xml;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System;


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

            this.MaximizeBox = false; // Désactivation du bouton de maximisation
            VérifierConnexion(); // Vérification de la connexion à la base de données
            this.AcceptButton = btnFakeAccept; // Permet de simuler l'appui sur le bouton d'acceptation avec la touche Entrée

            // Spécification du Timer au lancement du formulaire pour modification couleur barre de progression
            delayTimer = new Timer();
            delayTimer.Interval = 2580;  // Délai de 2580ms 
            delayTimer.Tick += delayTimer_Tick;

            // Par défaut, ne pas afficher le SmoothCircular
            SmoothCircular.Visible = false;

            // Démarrage d'un timer si la connexion est vérifié (fonction booléenne) 
            if (VérifierConnexion())
            {
                delayTimer.Start(); // Démarrage du Timer
            }
        }

        /// <summary>
        /// Limite de siticone : passer par un Winforms faux button pour simuler entrée
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFakeAccept_Click(object sender, EventArgs e)
        {
            SbtnCalculer_Click(SbtnCalculer, EventArgs.Empty);
        }

        /// <summary>
        /// A la fin du Timer, modifier la couleur de la barre de chargement
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void delayTimer_Tick(object sender, EventArgs e)
        {
            ProgressBar.GradientEndColor = Color.Green;
            ProgressBar.GradientStartColor = Color.LimeGreen;
            ProgressBar.BorderColor = Color.MediumSeaGreen;
            ProgressBar.CustomLabel = "Connexion à la base de donnée réussie.";
            delayTimer.Stop();
        }

        /// <summary>
        /// Timer responsable de l'affichage ou non du SmoothCircular
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void SmoothTimer_Tick(object sender, EventArgs e)
        {
            SmoothCircular.Visible = false;
            delayTimer.Stop();
        }

        /// <summary>
        /// Méthode pour vérifier la connexion à la base de données et influer sur la barre de progression
        /// </summary>
        /// <returns></returns>
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
                ProgressBar.CustomLabel = "Erreur de connexion à la base de données.";
                return false;
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
        private bool lectureSeule = false; // Variable pour la lecture seule, par défaut à false
        private double _moyenneVentes;
        private int _frequencePicking;

        /// <summary>
        /// Événement déclenché lors du clic sur le bouton "Calculer".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void SbtnCalculer_Click(object sender, EventArgs e)
        {
            if (!hauteur.Text.Equals("") && !frequence.Text.Equals("") && !moyenne.Text.Equals("") && !CodeGeoTxt.Text.Equals("")) //&& !hauteurG.Text.Equals("")) : désactivation temporaire pour test. 

            {
                // Récupérer le texte entré par l'utilisateur dans les TextBox.
                // 'Hauteur', 'Frequence', 'Moyenne' et 'HauteurG'
                string hauteurProduitTexte = hauteur.Text;
                string frequencePickingTexte = frequence.Text;
                string moyenneVentesTexte = moyenne.Text;

                bool vérif = true;
                // string hauteurCanalDesireTexte = hauteurG.Text; : désactivation temporaire

                // Instauration d'une animation de chargement des données 
                SmoothCircular.Visible = true;
                SmoothTimer.Start();

                // Tenter de convertir le texte récupéré en nombres (double pour les nombres décimaux, int pour les entiers).
                // 'out double hauteurProduit' signifie que si la conversion réussit, la valeur sera stockée dans la variable 'hauteurProduit'.
                if (double.TryParse(hauteurProduitTexte, out double hauteurProduit) &&
                    int.TryParse(frequencePickingTexte, out int frequencePicking) &&
                    double.TryParse(moyenneVentesTexte, out double moyenneVentes)) //&&
                                                                                   //double.TryParse(hauteurCanalDesireTexte, out _hauteurCanalDesire)) :désactivation temporaire à des fins de tests. 
                {
                    if (frequencePicking <= moyenneVentes)
                    {
                        // Logique de calcul
                        _NBV = moyenneVentes / 25;
                        double HT = hauteurProduit * _NBV;
                        //_NbGoulotte = HT / _hauteurCanalDesire; : désactivation temporaire à des fins de calculs. 
                        _NBC = moyenneVentes / frequencePicking;

                        _moyenneVentes = moyenneVentes;
                        _frequencePicking = frequencePicking;

                        // Désactiver le bouton afin d'éviter de boucler un délai de chargement
                        SbtnCalculer.Enabled = false;

                        // Attente de 2000 ms sans bloquer l'UI
                        await Task.Delay(1000);

                        // En démo : Détermination de la hauteur idéale (tranche en dessous de 0.81 soit 80%) 
                        if (PetitCanal(HT) > 0.81)
                        {
                            if (MoyenCanal(HT) > 0.81)
                            {
                                if (GrandCanal(HT) > 0.91)
                                {
                                    // Fréquence beaucoup trop élevée, pas de canal possible ; incompatible avec l'automate.
                                    _hauteurCanalDesire = 2200;
                                    vérif = false; // Produit supérieur ou égale à 91% d'un canal de 2500 mm = ignorer le produit et le mettre en magasin. 

                                }
                                else
                                {
                                    _hauteurCanalDesire = 2200; // Inférieur à 80% d'un canal de 2500mm 
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

                        // Afficher le résultat sous forme de texte
                        ligne1.Text = "• Nombre de boîtes vendues (par jour) :  " + Math.Round(_NBV, 1);
                        ligne2.Text = "• Hauteur totale nécessaire (par jour) : " + Math.Round(HT, 1) + " mm";
                        ligne3.Text = "• Nombre de canaux de " + _hauteurCanalDesire + " mm" + " nécessaire par jour : " + Math.Round(_NbGoulotte, 2);
                        ligne4.Text = "• Nombre de boîtes par commande (en moyenne) : " + Math.Round(_NBC, 1);

                        ligne5.Text = ""; // On efface le contenu de ligne5
                        ligne6.Text = ""; // On efface le contenu de ligne6
                        ligne7.Text = ""; // On efface le contenu de ligne7
                        ligne8.Text = ""; // On efface le contenu de ligne8

                        // Partie interprétation des résultats (conclusions)
                        if (_NBC < 4 && _NbGoulotte < 2.1 && Zone(frequencePicking, (int)_NBC, _NbGoulotte, vérif))
                        {
                            // Réponse et détermination du type de canaux (taille)
                            if (_NbGoulotte > 1) // Condition jamais validée car max 80%/90% 
                            {
                                double pourcentage = _NbGoulotte * 100;
                                ligne5.Text = "Ce produit nécessite plusieurs canaux.";
                                ligne6.Text = $"Il faudrait mettre en place {Math.Round(_NbGoulotte, 1)} canaux de {_hauteurCanalDesire} mm.";
                                ligne7.Text = $"Car il nécessitera précisément {Math.Round(pourcentage, 1)} % d'un canal de {_hauteurCanalDesire} mm.";
                                ligne8.Text = ""; // On efface le contenu de ligne8
                            }
                            else
                            {
                                double pourcentage = _NbGoulotte * 100;
                                ligne5.Text = "Ce produit nécessitera qu'un seul canal.";
                                ligne6.Text = $"Il nécessitera précisément {Math.Round(pourcentage, 1)} % d'un canal de {_hauteurCanalDesire} mm.";
                                ligne7.Text = ""; // On efface le contenu de ligne7
                                ligne8.Text = ""; // On efface le contenu de ligne8
                            }
                        }
                        // Définition de la zone
                        if (Zone(frequencePicking, (int)_NBC, _NbGoulotte, vérif))
                        {
                            ligne8.Text = "Ce produit peut aller à l'automate.";
                            _zone = "Automate"; // Zone définie comme "Automate"

                        }
                        else
                        {
                            // lblHauteur.Text = "Produit incompatible."; : potentielle idée
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

            // Activer le bouton afin d'éviter de boucler un délai de chargement
            SbtnCalculer.Enabled = true;
        }
        // Fonction de détermination de la zone du produit correspondant
        public bool Zone(double frequence, int NBC, double NbGoulotte, bool vérif)
        {
            // Condition fréquence minimum 60, condition picking inférieur à 5, Nombre de canaux inférieur à 3 
            if (frequence > 50 && NBC < 4 && NbGoulotte < 2.1 && vérif)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        // Trois fonctions qui retournent le pourcentage de produit vendu par rapport à la hauteur du canal.

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
        /// Fonction de calcul du pourcentage produit vendu par jour pour un canal de 2500mm.
        /// </summary>
        /// <param name="HT"></param>
        /// <returns></returns>
        public double GrandCanal(double HT)
        {
            double grand;
            grand = HT / 2200;
            return grand;
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
                // Vérifie si un formulaire nommé "Form2" est ouvert
                foreach (Form form in Application.OpenForms)
                {
                    if (form is Enregistrement)
                    {
                        form.Close();  // Ferme le formulaire
                        break;         // Stoppe la boucle une fois trouvé
                    }
                }

                // Si les lignes de résultats ne sont pas vides, on peut procéder à l'enregistrement.
                double nbcValue = Math.Round(_NBC, 1);
                double nbvValue = Math.Round(_NBV, 1); // Récupération des valeurs de nbc et nbv
                double hauteurCanalDesireValue = Math.Round(_hauteurCanalDesire, 1);
                double nombreCanauxNecessairesValue = Math.Round(_NbGoulotte, 1);
                string zoneValue = _zone; // Récupération de la zone
                string codegéoValue = CodeGeoTxt.Text; // Récupération du code géographique
                double moyenneValue = _moyenneVentes;
                double FrequenceValue = _frequencePicking;

                Enregistrement frm = new Enregistrement(codegéoValue, nbcValue, moyenneValue, FrequenceValue, nbvValue, hauteurCanalDesireValue, nombreCanauxNecessairesValue, zoneValue, lectureSeule); // génère la fenêtre
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
                !string.IsNullOrEmpty(CodeGeoTxt.Text))
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

        private void SbtnConsultation_Click(object sender, EventArgs e)
        {
            // Vérifie si un formulaire nommé "Form2" est ouvert
            foreach (Form form in Application.OpenForms)
            {
                if (form is Enregistrement)
                {
                    form.Close();  // Ferme le formulaire
                    break;         // Stoppe la boucle une fois trouvé
                }
            }
            double nbcValue = Math.Round(_NBC, 1);
            double nbvValue = Math.Round(_NBV, 1); // Récupération des valeurs de nbc et nbv
            double hauteurCanalDesireValue = Math.Round(_hauteurCanalDesire, 1);
            double nombreCanauxNecessairesValue = Math.Round(_NbGoulotte, 1);
            string zoneValue = _zone; // Récupération de la zone
            bool lectureSeule = true; // Variable lecture seule pour la consultation
            string codegéoValue = CodeGeoTxt.Text; ;
            double moyenneValue = _moyenneVentes;
            double FrequenceValue = _frequencePicking;

            Enregistrement frm = new Enregistrement(codegéoValue, nbcValue, moyenneValue, FrequenceValue, nbvValue, hauteurCanalDesireValue, nombreCanauxNecessairesValue, zoneValue, lectureSeule); // génère la fenêtre
            frm.Show(); // Affiche la fenêtre 
        }
    }
}

