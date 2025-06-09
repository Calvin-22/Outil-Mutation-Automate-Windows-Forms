using System.Drawing.Text;
using System.Media;
using System.Security.Cryptography.X509Certificates;
using Outil_Mutation_Automate.View;

namespace Outil_Mutation_Automate
{
    public partial class MenuPrincipal : Form
    {
        private double _NBV; 
        private double _NBC; // Nombre de boîtes par commande
        private double _hauteurCanalDesire; // Hauteur du canal désirée
        private double _NbGoulotte; // Nombre de canaux nécessaires
        private string _zone; // Zone du produit

        public MenuPrincipal()
        {
            InitializeComponent();

        }

        private void BtnCalculer_Click(object sender, EventArgs e)
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
                        ligne2.Text = "• Hauteur totale nécessaire (par jour) : " + HT.ToString() + "mm";
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
            // Condition fréquence minimum 60 et condition picking
            if (frequence > 60 && NBC < 5 && NbGoulotte < 3.2)
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

        // Fenêtre d'enregistrement du logiciel
        private void enregistrement_Click(object sender, EventArgs e)
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
                double nbcValue = Math.Round(_NBC,1);
                double nbvValue = Math.Round(_NBV,1); // Récupération des valeurs de nbc et nbv
                double hauteurCanalDesireValue = Math.Round(_hauteurCanalDesire,1);
                double nombreCanauxNecessairesValue = Math.Round(_NbGoulotte, 1);
                string zoneValue = _zone; // Récupération de la zone

                Enregistrement frm = new Enregistrement(nbcValue, nbvValue, hauteurCanalDesireValue, nombreCanauxNecessairesValue, zoneValue); // génère la fenêtre
                frm.Show(); // Affiche la fenêtre 

            }
                
        }
    }
}

