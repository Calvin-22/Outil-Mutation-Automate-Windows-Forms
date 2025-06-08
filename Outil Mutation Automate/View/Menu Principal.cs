using System.Drawing.Text;
using System.Media;
using System.Security.Cryptography.X509Certificates;
using Outil_Mutation_Automate.View;

namespace Outil_Mutation_Automate
{
    public partial class MenuPrincipal : Form
    {
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
                    double.TryParse(hauteurCanalDesireTexte, out double hauteurCanalDesire))
                {
                    if (frequencePicking <= moyenneVentes)
                    {
                        // Logique de calcul
                        double NBV = moyenneVentes / 25;
                        double HT = hauteurProduit * NBV;
                        double NbGoulotte = HT / hauteurCanalDesire;
                        double NBC = moyenneVentes / frequencePicking;

                        // Afficher le résultat sous forme de texte
                        ligne1.Text = "• Nombre de boîtes vendues (par jour) :  " + NBV.ToString();
                        ligne2.Text = "• Hauteur totale nécessaire (par jour) : " + HT.ToString() + "mm";
                        ligne3.Text = "• Nombre de canaux de " + hauteurCanalDesire + "mm" + " nécessaire par jour : " + Math.Round(NbGoulotte, 1);
                        ligne4.Text = "• Nombre de boîtes par commande (en moyenne) : " + Math.Round(NBC, 1);

                        ligne5.Text = ""; // On efface le contenu de ligne5
                        ligne6.Text = ""; // On efface le contenu de ligne6
                        ligne7.Text = ""; // On efface le contenu de ligne7
                        ligne8.Text = ""; // On efface le contenu de ligne8

                        // Partie interprétation des résultats (conclusions)
                        if (NBC < 5 && NbGoulotte < 3.1 && Zone(frequencePicking, (int)NBC, NbGoulotte))
                        {
                            // Réponse et détermination du type de canaux (taille)
                            if (NbGoulotte > 1)
                            {
                                ligne5.Text = "Dans cette configuration, il serait souhaitable d'opter pour une hauteur de canal plus grande.";
                                ligne6.Text = $"Sinon, il faudrait mettre en place {Math.Round(NbGoulotte, 1)} canaux de {hauteurG.Text} mm.";
                                ligne7.Text = ""; // On efface le contenu de ligne7
                                ligne8.Text = ""; // On efface le contenu de ligne8
                            }
                            else
                            {
                                double pourcentage = NbGoulotte * 100;
                                ligne5.Text = "Parfait pour cette configuration en terme de hauteur de canal.";
                                ligne6.Text = $"Ce produit nécessitera précisément {Math.Round(pourcentage, 1)} % d'un canal de {hauteurG.Text} mm.";
                                ligne7.Text = ""; // On efface le contenu de ligne7
                                ligne8.Text = ""; // On efface le contenu de ligne8
                            }
                        }

                        // Définition de la zone
                        if (Zone(frequencePicking, (int)NBC, NbGoulotte))
                        {
                            ligne8.Text = "Ce produit peut aller à l'automate.";
                        }
                        else
                        {
                            ligne8.Text = "Ce produit doit aller au magasin. Il n'est pas compatible avec les exigences de l'automate.";
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
    }
}

