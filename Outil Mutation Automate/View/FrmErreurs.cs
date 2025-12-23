using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Outil_Mutation_Automate.Model;
using Outil_Mutation_Automate.Controller;

namespace Outil_Mutation_Automate.View
{
    public partial class FrmErreurs : Form
    {
        /// <summary>
        /// Objet pour gérer la liste des mutations
        /// </summary>
        private BindingSource bdgerreurs = new BindingSource();


        private FrmErreursController controller;

        /// <summary>
        /// Initialisation du formulaire
        /// </summary>
        public FrmErreurs()
        {
            InitializeComponent();
            Init();
        }

        /// <summary>
        /// Initialisations :
        /// Création du contrôleur et remplissage des listes
        /// </summary>
        private void Init()
        {
            controller = new FrmErreursController();
            RemplirListeErreurs();

        }

        /////////////
        /// <summary>
        /// Afficher les Mutations dans le DataGridView.
        /// </summary>
        private void RemplirListeErreurs()
        {
            List<Erreurs> LesErreurs = controller.GetLesErreurs();
            bdgerreurs.DataSource = LesErreurs;
            dgvErreurs.DataSource = bdgerreurs;

            dgvErreurs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SViderBDD_Click(object sender, EventArgs e)
        {

        }
    }
}
