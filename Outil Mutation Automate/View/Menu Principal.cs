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
                    double.TryParse(hauteurCanalDesireTexte, out double hauteurCanalDesire))
                {
                    // Logique de calcul en exemple � remplacer
                    double NBV = moyenneVentes / 25;
                    double HT = hauteurProduit * NBV;
                    double NbGoulotte = HT / hauteurCanalDesire;
                    double NBC = moyenneVentes / frequencePicking;

                    // Afficher le r�sultat sous forme de texte
                    ligne1.Text = "� Nombre de bo�tes vendues (par jour) :  " + NBV.ToString();
                    ligne2.Text = "� Hauteur totale n�cessaire (par jour) : " + HT.ToString() + "mm";
                    ligne3.Text = "� Nombre de canaux de " + hauteurCanalDesire + "mm" + " n�cessaire par jour : " + Math.Round(NbGoulotte, 1);
                    ligne4.Text = "� Nombre de bo�te par commande (en moyenne) : " + Math.Round(NBC, 1);
                }
                else
                // Si une ou plusieurs conversions ont �chou� (l'utilisateur n'a pas entr� de nombres valides),
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
        // Fonction de d�termination de la zone du produit correspondant
        public bool Zone(double frequence, int NBC, double NbGoulotte)
        {
            // Condition fr�quence minimum 60 et condition picking
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


