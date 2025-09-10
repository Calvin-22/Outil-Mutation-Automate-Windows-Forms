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
    /// Classe MenuPrincipal qui repr�sente la fen�tre principale de l'application.
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

            this.MaximizeBox = false; // D�sactivation du bouton de maximisation
            V�rifierConnexion(); // V�rification de la connexion � la base de donn�es
            this.AcceptButton = btnFakeAccept; // Permet de simuler l'appui sur le bouton d'acceptation avec la touche Entr�e

            // Sp�cification du Timer au lancement du formulaire pour modification couleur barre de progression
            delayTimer = new Timer();
            delayTimer.Interval = 2580;  // D�lai de 2580ms 
            delayTimer.Tick += delayTimer_Tick;

            // Par d�faut, ne pas afficher le SmoothCircular
            SmoothCircular.Visible = false;

            // D�marrage d'un timer si la connexion est v�rifi� (fonction bool�enne) 
            if (V�rifierConnexion())
            {
                delayTimer.Start(); // D�marrage du Timer
            }
        }

        /// <summary>
        /// Limite de siticone : passer par un Winforms faux button pour simuler entr�e
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
            ProgressBar.CustomLabel = "Connexion � la base de donn�e r�ussie.";
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
        /// M�thode pour v�rifier la connexion � la base de donn�es et influer sur la barre de progression
        /// </summary>
        /// <returns></returns>
        public bool V�rifierConnexion()
        {
            // Remplace cette cha�ne par la cha�ne de connexion � ta base de donn�es
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
                // Si la connexion �choue, changer la couleur et la progression de la barre
                Console.WriteLine("Erreur de connexion � la base de donn�es : " + ex.Message);

                // Changer la couleur de la barre en orange et la mettre � 75%
                ProgressBar.GradientEndColor = Color.Red;
                ProgressBar.GradientStartColor = Color.Orange;
                ProgressBar.BorderColor = Color.OrangeRed;
                ProgressBar.CustomLabel = "Erreur de connexion � la base de donn�es.";
                return false;
            }
        }
        /// <summary>
        /// Initialisations des variables n�cessaires aux calculs
        /// </summary>
        private double _NBV; // Nombre de bo�tes vendues (par jour)
        private double _NBC; // Nombre de bo�tes par commande
        private double _hauteurCanalDesire; // Hauteur du canal d�sir�e
        private double _NbGoulotte; // Nombre de canaux n�cessaires
        private string _zone; // Zone du produit
        private bool lectureSeule = false; // Variable pour la lecture seule, par d�faut � false
        private double _moyenneVentes;
        private int _frequencePicking;

        /// <summary>
        /// �v�nement d�clench� lors du clic sur le bouton "Calculer".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void SbtnCalculer_Click(object sender, EventArgs e)
        {
            if (!hauteur.Text.Equals("") && !frequence.Text.Equals("") && !moyenne.Text.Equals("") && !CodeGeoTxt.Text.Equals("")) //&& !hauteurG.Text.Equals("")) : d�sactivation temporaire pour test. 

            {
                // R�cup�rer le texte entr� par l'utilisateur dans les TextBox.
                // 'Hauteur', 'Frequence', 'Moyenne' et 'HauteurG'
                string hauteurProduitTexte = hauteur.Text;
                string frequencePickingTexte = frequence.Text;
                string moyenneVentesTexte = moyenne.Text;

                bool v�rif = true;
                // string hauteurCanalDesireTexte = hauteurG.Text; : d�sactivation temporaire

                // Instauration d'une animation de chargement des donn�es 
                SmoothCircular.Visible = true;
                SmoothTimer.Start();

                // Tenter de convertir le texte r�cup�r� en nombres (double pour les nombres d�cimaux, int pour les entiers).
                // 'out double hauteurProduit' signifie que si la conversion r�ussit, la valeur sera stock�e dans la variable 'hauteurProduit'.
                if (double.TryParse(hauteurProduitTexte, out double hauteurProduit) &&
                    int.TryParse(frequencePickingTexte, out int frequencePicking) &&
                    double.TryParse(moyenneVentesTexte, out double moyenneVentes)) //&&
                                                                                   //double.TryParse(hauteurCanalDesireTexte, out _hauteurCanalDesire)) :d�sactivation temporaire � des fins de tests. 
                {
                    if (frequencePicking <= moyenneVentes)
                    {
                        // Logique de calcul
                        _NBV = moyenneVentes / 25;
                        double HT = hauteurProduit * _NBV;
                        //_NbGoulotte = HT / _hauteurCanalDesire; : d�sactivation temporaire � des fins de calculs. 
                        _NBC = moyenneVentes / frequencePicking;

                        _moyenneVentes = moyenneVentes;
                        _frequencePicking = frequencePicking;

                        // D�sactiver le bouton afin d'�viter de boucler un d�lai de chargement
                        SbtnCalculer.Enabled = false;

                        // Attente de 2000 ms sans bloquer l'UI
                        await Task.Delay(1000);

                        // En d�mo : D�termination de la hauteur id�ale (tranche en dessous de 0.81 soit 80%) 
                        if (PetitCanal(HT) > 0.81)
                        {
                            if (MoyenCanal(HT) > 0.81)
                            {
                                if (GrandCanal(HT) > 0.91)
                                {
                                    // Fr�quence beaucoup trop �lev�e, pas de canal possible ; incompatible avec l'automate.
                                    _hauteurCanalDesire = 2200;
                                    v�rif = false; // Produit sup�rieur ou �gale � 91% d'un canal de 2500 mm = ignorer le produit et le mettre en magasin. 

                                }
                                else
                                {
                                    _hauteurCanalDesire = 2200; // Inf�rieur � 80% d'un canal de 2500mm 
                                }
                            }
                            else
                            {
                                _hauteurCanalDesire = 1200; // Inf�rieur � 80% d'un canal de 1200mm 
                            }
                        }
                        else
                        {
                            _hauteurCanalDesire = 800; // Inf�rieur � 80% d'un canal de 800mm 
                        }

                        // Calcul du nombre de canaux n�cessaires apr�s attribution de la hauteur du canal
                        _NbGoulotte = HT / _hauteurCanalDesire;

                        // Afficher le r�sultat sous forme de texte
                        ligne1.Text = "� Nombre de bo�tes vendues (par jour) :  " + Math.Round(_NBV, 1);
                        ligne2.Text = "� Hauteur totale n�cessaire (par jour) : " + Math.Round(HT, 1) + " mm";
                        ligne3.Text = "� Nombre de canaux de " + _hauteurCanalDesire + " mm" + " n�cessaire par jour : " + Math.Round(_NbGoulotte, 2);
                        ligne4.Text = "� Nombre de bo�tes par commande (en moyenne) : " + Math.Round(_NBC, 1);

                        ligne5.Text = ""; // On efface le contenu de ligne5
                        ligne6.Text = ""; // On efface le contenu de ligne6
                        ligne7.Text = ""; // On efface le contenu de ligne7
                        ligne8.Text = ""; // On efface le contenu de ligne8

                        // Partie interpr�tation des r�sultats (conclusions)
                        if (_NBC < 4 && _NbGoulotte < 2.1 && Zone(frequencePicking, (int)_NBC, _NbGoulotte, v�rif))
                        {
                            // R�ponse et d�termination du type de canaux (taille)
                            if (_NbGoulotte > 1) // Condition jamais valid�e car max 80%/90% 
                            {
                                double pourcentage = _NbGoulotte * 100;
                                ligne5.Text = "Ce produit n�cessite plusieurs canaux.";
                                ligne6.Text = $"Il faudrait mettre en place {Math.Round(_NbGoulotte, 1)} canaux de {_hauteurCanalDesire} mm.";
                                ligne7.Text = $"Car il n�cessitera pr�cis�ment {Math.Round(pourcentage, 1)} % d'un canal de {_hauteurCanalDesire} mm.";
                                ligne8.Text = ""; // On efface le contenu de ligne8
                            }
                            else
                            {
                                double pourcentage = _NbGoulotte * 100;
                                ligne5.Text = "Ce produit n�cessitera qu'un seul canal.";
                                ligne6.Text = $"Il n�cessitera pr�cis�ment {Math.Round(pourcentage, 1)} % d'un canal de {_hauteurCanalDesire} mm.";
                                ligne7.Text = ""; // On efface le contenu de ligne7
                                ligne8.Text = ""; // On efface le contenu de ligne8
                            }
                        }
                        // D�finition de la zone
                        if (Zone(frequencePicking, (int)_NBC, _NbGoulotte, v�rif))
                        {
                            ligne8.Text = "Ce produit peut aller � l'automate.";
                            _zone = "Automate"; // Zone d�finie comme "Automate"

                        }
                        else
                        {
                            // lblHauteur.Text = "Produit incompatible."; : potentielle id�e
                            ligne8.Text = "Ce produit doit aller au magasin. Il n'est pas compatible avec les exigences de l'automate.";
                            _zone = "Magasin"; // Zone d�finie comme "Magasin"
                        }
                    }
                    else
                    {
                        // Si la fr�quence de picking est sup�rieure � la moyenne des ventes, afficher un message d'erreur.
                        SystemSounds.Hand.Play();
                        MessageBox.Show("Erreur : La fr�quence de picking ne peut pas �tre sup�rieure � la moyenne des ventes.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        return;
                    }
                }
                else
                // Si une ou plusieurs conversions ont �chou� (l'utilisateur n'a pas entr� de nombres valides),
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

            // Activer le bouton afin d'�viter de boucler un d�lai de chargement
            SbtnCalculer.Enabled = true;
        }
        // Fonction de d�termination de la zone du produit correspondant
        public bool Zone(double frequence, int NBC, double NbGoulotte, bool v�rif)
        {
            // Condition fr�quence minimum 60, condition picking inf�rieur � 5, Nombre de canaux inf�rieur � 3 
            if (frequence > 50 && NBC < 4 && NbGoulotte < 2.1 && v�rif)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        // Trois fonctions qui retournent le pourcentage de produit vendu par rapport � la hauteur du canal.

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

        // Fen�tre d'information du logiciel
        private void infobutton_Click(object sender, EventArgs e)
        {
            Information frm = new Information(); // g�n�re la fen�tre d'information
            frm.Show(); // Affiche la fen�tre 
        }

        /// <summary>
        /// Bouton d'enregistrement des r�sultats calcul�s dans une nouvelle fen�tre.
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
                // V�rifie si un formulaire nomm� "Form2" est ouvert
                foreach (Form form in Application.OpenForms)
                {
                    if (form is Enregistrement)
                    {
                        form.Close();  // Ferme le formulaire
                        break;         // Stoppe la boucle une fois trouv�
                    }
                }

                // Si les lignes de r�sultats ne sont pas vides, on peut proc�der � l'enregistrement.
                double nbcValue = Math.Round(_NBC, 1);
                double nbvValue = Math.Round(_NBV, 1); // R�cup�ration des valeurs de nbc et nbv
                double hauteurCanalDesireValue = Math.Round(_hauteurCanalDesire, 1);
                double nombreCanauxNecessairesValue = Math.Round(_NbGoulotte, 1);
                string zoneValue = _zone; // R�cup�ration de la zone
                string codeg�oValue = CodeGeoTxt.Text; // R�cup�ration du code g�ographique
                double moyenneValue = _moyenneVentes;
                double FrequenceValue = _frequencePicking;

                Enregistrement frm = new Enregistrement(codeg�oValue, nbcValue, moyenneValue, FrequenceValue, nbvValue, hauteurCanalDesireValue, nombreCanauxNecessairesValue, zoneValue, lectureSeule); // g�n�re la fen�tre
                frm.Show(); // Affiche la fen�tre 

            }
        }

        /// <summary>
        /// Vider int�gralement les saisies et calculs r�alis�s par l'algorithme 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnVider_Click(object sender, EventArgs e)
        {
            // V�rification que les saisies sont r�alis�es avant de tenter inutilement de supprimer
            if (!string.IsNullOrEmpty(hauteur.Text) || !string.IsNullOrEmpty(frequence.Text) || !string.IsNullOrEmpty(moyenne.Text) ||
                !string.IsNullOrEmpty(CodeGeoTxt.Text))
            {
                // Confirmation de suppression ou non
                DialogResult result = MessageBox.Show(
                    "Voulez-vous vraiment supprimer les saisies et r�sultats pr�c�demment effectu�s ?", // Affichage du message
                    "Confirmation de suppression", // Titre
                    MessageBoxButtons.YesNo, // Afficher oui ou non (instauration du choix)
                    MessageBoxIcon.Warning // Logo avertissement
                    );

                if (result == DialogResult.Yes)
                {
                    // Utilisateur a cliqu� sur oui 
                    // Suppression des �l�ments de saisies
                    hauteur.Text = string.Empty;
                    frequence.Text = string.Empty;
                    moyenne.Text = string.Empty;

                    // Suppression des �l�ments de r�sultats et de conclusions
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
            // V�rifie si un formulaire nomm� "Form2" est ouvert
            foreach (Form form in Application.OpenForms)
            {
                if (form is Enregistrement)
                {
                    form.Close();  // Ferme le formulaire
                    break;         // Stoppe la boucle une fois trouv�
                }
            }
            double nbcValue = Math.Round(_NBC, 1);
            double nbvValue = Math.Round(_NBV, 1); // R�cup�ration des valeurs de nbc et nbv
            double hauteurCanalDesireValue = Math.Round(_hauteurCanalDesire, 1);
            double nombreCanauxNecessairesValue = Math.Round(_NbGoulotte, 1);
            string zoneValue = _zone; // R�cup�ration de la zone
            bool lectureSeule = true; // Variable lecture seule pour la consultation
            string codeg�oValue = CodeGeoTxt.Text; ;
            double moyenneValue = _moyenneVentes;
            double FrequenceValue = _frequencePicking;

            Enregistrement frm = new Enregistrement(codeg�oValue, nbcValue, moyenneValue, FrequenceValue, nbvValue, hauteurCanalDesireValue, nombreCanauxNecessairesValue, zoneValue, lectureSeule); // g�n�re la fen�tre
            frm.Show(); // Affiche la fen�tre 
        }
    }
}

