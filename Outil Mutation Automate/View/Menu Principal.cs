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
                // Logique de calcul en exemple
                double resultat = (hauteurProduit * frequencePicking) / (moyenneVentes + hauteurCanalDesire);

                // Afficher le r�sultat sous forme de texte
                ResultatsTxt.Text = "Le r�sultat est : " + resultat.ToString();
            }
            else
            // Si une ou plusieurs conversions ont �chou� (l'utilisateur n'a pas entr� de nombres valides),
            // afficher un message d'erreur dans le contr�le Label 'ResultatsTxt'.
            {
                ResultatsTxt.Text = "Erreur : Veuillez entrer des nombres valides.";
            }
        }
    }
}
