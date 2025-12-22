using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Outil_Mutation_Automate.Dal;
using Outil_Mutation_Automate.Model;
using Outil_Mutation_Automate.View;

namespace Outil_Mutation_Automate.Controller
{
    public class FrmAuthentificationController
    {
        /// <summary>
        /// objet d'accès aux opérations possibles sur Responsable
        /// </summary>
        private readonly AuthentificationAccess authentificationAccess;

        /// <summary>
        /// Récupère l'accès aux données
        /// </summary>
        public FrmAuthentificationController()
        {
            authentificationAccess = new AuthentificationAccess();
        }

        /// <summary>
        /// Vérifie l'authentification
        /// </summary>
        /// <param name="authentification">objet contenant les informations de connexion</param>
        /// <returns> vrai si les informations de connexion sont correctes</returns>
        public Boolean ControleAuthentification(Authentification authentification)
        {
            return authentificationAccess.ControleAuthentification(authentification);
        }
    }
}

