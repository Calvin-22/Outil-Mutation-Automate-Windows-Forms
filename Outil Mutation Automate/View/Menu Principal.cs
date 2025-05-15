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
                // Logique de calcul en exemple
                double resultat = (hauteurProduit * frequencePicking) / (moyenneVentes + hauteurCanalDesire);

                // Afficher le résultat sous forme de texte
                ResultatsTxt.Text = "Le résultat est : " + resultat.ToString();
            }
            else
            // Si une ou plusieurs conversions ont échoué (l'utilisateur n'a pas entré de nombres valides),
            // afficher un message d'erreur dans le contrôle Label 'ResultatsTxt'.
            {
                ResultatsTxt.Text = "Erreur : Veuillez entrer des nombres valides.";
            }
        }
    }
}
