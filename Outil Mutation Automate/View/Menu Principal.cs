using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;

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
                    // Logique de calcul en exemple à remplacer
                    double NBV = moyenneVentes / 25;
                    double HT = hauteurProduit * NBV;
                    double NbGoulotte = HT / hauteurCanalDesire;
                    double NBC = moyenneVentes / frequencePicking;

                    // Afficher le résultat sous forme de texte
                    ligne1.Text = "• Nombre de boîtes vendues (par jour) :  " + NBV.ToString();
                    ligne2.Text = "• Hauteur totale nécessaire (par jour) : " + HT.ToString() + "mm";
                    ligne3.Text = "• Nombre de canaux de " + hauteurCanalDesire + "mm" + " nécessaire par jour : " + Math.Round(NbGoulotte, 1);
                    ligne4.Text = "• Nombre de boîte par commande (en moyenne) : " + Math.Round(NBC, 1);
                }
                else
                // Si une ou plusieurs conversions ont échoué (l'utilisateur n'a pas entré de nombres valides),
                // afficher un message d'erreur 
                {
                    MessageBox.Show("Erreur : Veuillez saisir une valeur correcte.");
                    return;
                }
            }
            else
            {   // Si l'un des champs est vide, afficher un message d'erreur.
                MessageBox.Show("Erreur : Veuillez remplir tous les champs.");
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
    }
}


