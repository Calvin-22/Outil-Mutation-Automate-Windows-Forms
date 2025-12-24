
using System.Media;
using Outil_Mutation_Automate.Controller;
using Outil_Mutation_Automate.Model;

namespace Outil_Mutation_Automate.View
{
    public partial class FrmAuthentification : Form
    {
        /// <summary>
        /// Contrôleur de la fenêtre
        /// </summary>
        private FrmAuthentificationController controller;

        /// <summary>
        /// Initialisation du formulaire 
        /// </summary>
        public FrmAuthentification()
        {
            InitializeComponent();
            Init();
        }

        /// <summary>
        /// Initialisations : 
        /// Création du contrôleur
        /// </summary>
        private void Init()
        {
            controller = new FrmAuthentificationController();
        }

        private void SbtnConnexion_Click(object sender, EventArgs e)
        {
            String login = txtIdentifiant.Text;
            String pwd = txtMdp.Text;
            if (String.IsNullOrEmpty(login) || String.IsNullOrEmpty(pwd))
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
            else
            {
                Authentification authentification = new Authentification(login, pwd);
                if (controller.ControleAuthentification(authentification))
                {
                    this.Hide(); // cacher le formulaire précédent 
                    MenuPrincipal frm = new MenuPrincipal(); // ouvrir nouveau formulaire
                    frm.ShowDialog(); // ouverture 
                    this.Close(); // fermeture du formulaire caché 
                }
                else
                {
                    SystemSounds.Hand.Play();
                    MessageBox.Show("Identifiant ou mot de passe incorrect. Veuillez réessayer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMdp.Clear();
                }
            }
        }

        /// <summary>
        /// Faux bouton afin de contourner les limitations du framework Siticone avec Winforms.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FakeAcceptButton_Click(object sender, EventArgs e)
        {
            SbtnConnexion_Click(SbtnConnexion, EventArgs.Empty);
        }
    }
}
