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
            this.MaximizeBox = false;
            V�rifierConnexion();

            // Sp�cification du Timer au lancement du formulaire
            delayTimer = new Timer();
            delayTimer.Interval = 2580;  // D�lai de 2580ms 
            delayTimer.Tick += delayTimer_Tick;

            if (V�rifierConnexion())
            {
                delayTimer.Start(); // D�marrage du Timer
            }
        }

        // A la fin du Timer, modifier la couleur de la barre de chargement
        public void delayTimer_Tick(object sender, EventArgs e)
        {
            ProgressBar.GradientEndColor = Color.Green;
            ProgressBar.GradientStartColor = Color.LimeGreen;
            ProgressBar.BorderColor = Color.MediumSeaGreen;
            ProgressBar.CustomLabel = "Connexion � la base de donn�e r�ussie.";
            delayTimer.Stop();
        }

        // M�thode pour v�rifier la connexion � la base de donn�es et influer sur la barre de progression
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
                ProgressBar.CustomLabel = "Erreur de connexion � la base de donn�e.";
                return false;
            }
        }

        private double _NBV; // Nombre de bo�tes vendues (par jour)
        private double _NBC; // Nombre de bo�tes par commande
        private double _hauteurCanalDesire; // Hauteur du canal d�sir�e
        private double _NbGoulotte; // Nombre de canaux n�cessaires
        private string _zone; // Zone du produit

        /// <summary>
        /// �v�nement d�clench� lors du clic sur le bouton "Calculer".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SbtnCalculer_Click(object sender, EventArgs e)
        {
            if (!hauteur.Text.Equals("") && !frequence.Text.Equals("") && !moyenne.Text.Equals("") && !hauteurG.Text.Equals(""))
            {
                // R�cup�rer le texte entr� par l'utilisateur dans les TextBox.
                // 'Hauteur', 'Frequence', 'Moyenne' et 'HauteurG'
                string hauteurProduitTexte = hauteur.Text;
                string frequencePickingTexte = frequence.Text;
                string moyenneVentesTexte = moyenne.Text;
                string hauteurCanalDesireTexte = hauteurG.Text;

                // Tenter de convertir le texte r�cup�r� en nombres (double pour les nombres d�cimaux, int pour les entiers).
                // 'out double hauteurProduit' signifie que si la conversion r�ussit, la valeur sera stock�e dans la variable 'hauteurProduit'.
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

                        // Afficher le r�sultat sous forme de texte
                        ligne1.Text = "� Nombre de bo�tes vendues (par jour) :  " + _NBV.ToString();
                        ligne2.Text = "� Hauteur totale n�cessaire (par jour) : " + Math.Round(HT, 1) + "mm";
                        ligne3.Text = "� Nombre de canaux de " + _hauteurCanalDesire + "mm" + " n�cessaire par jour : " + Math.Round(_NbGoulotte, 1);
                        ligne4.Text = "� Nombre de bo�tes par commande (en moyenne) : " + Math.Round(_NBC, 1);

                        ligne5.Text = ""; // On efface le contenu de ligne5
                        ligne6.Text = ""; // On efface le contenu de ligne6
                        ligne7.Text = ""; // On efface le contenu de ligne7
                        ligne8.Text = ""; // On efface le contenu de ligne8

                        // Partie interpr�tation des r�sultats (conclusions)
                        if (_NBC < 5 && _NbGoulotte < 3.1 && Zone(frequencePicking, (int)_NBC, _NbGoulotte))
                        {
                            // R�ponse et d�termination du type de canaux (taille)
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
                                ligne6.Text = $"Ce produit n�cessitera pr�cis�ment {Math.Round(pourcentage, 1)} % d'un canal de {hauteurG.Text} mm.";
                                ligne7.Text = ""; // On efface le contenu de ligne7
                                ligne8.Text = ""; // On efface le contenu de ligne8
                            }
                        }

                        // D�finition de la zone
                        if (Zone(frequencePicking, (int)_NBC, _NbGoulotte))
                        {
                            ligne8.Text = "Ce produit peut aller � l'automate.";
                            _zone = "Automate"; // Zone d�finie comme "Automate"

                        }
                        else
                        {
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
        }
        // Fonction de d�termination de la zone du produit correspondant
        public bool Zone(double frequence, int NBC, double NbGoulotte)
        {
            // Condition fr�quence minimum 60, condition picking inf�rieur � 5, Nombre de canaux inf�rieur � 3 
            if (frequence > 60 && NBC < 5 && NbGoulotte < 3.1)
            {
                return true;
            }
            else
            {
                return false;
            }

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
                // Si les lignes de r�sultats ne sont pas vides, on peut proc�der � l'enregistrement.
                double nbcValue = Math.Round(_NBC, 1);
                double nbvValue = Math.Round(_NBV, 1); // R�cup�ration des valeurs de nbc et nbv
                double hauteurCanalDesireValue = Math.Round(_hauteurCanalDesire, 1);
                double nombreCanauxNecessairesValue = Math.Round(_NbGoulotte, 1);
                string zoneValue = _zone; // R�cup�ration de la zone

                Enregistrement frm = new Enregistrement(nbcValue, nbvValue, hauteurCanalDesireValue, nombreCanauxNecessairesValue, zoneValue); // g�n�re la fen�tre
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
                !string.IsNullOrEmpty(hauteurG.Text))
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
                    hauteurG.Text = string.Empty;

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
    }
}

