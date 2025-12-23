using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Outil_Mutation_Automate.Dal;
using Outil_Mutation_Automate.Model;

namespace Outil_Mutation_Automate.Controller
{
    public class FrmErreursController
    {
        /// <summary>
        /// Instance unique de l'accès aux données
        /// </summary>
        private readonly ErreursAccess access;

        /// <summary>
        /// Constructeur pour créer l'accès aux données
        /// </summary>
        public FrmErreursController()
        {
            access = new ErreursAccess();
        }

        /// <summary>
        /// Récupère et retourne les erreurs
        /// </summary>
        /// <returns>liste des erreurs</returns>
        public List<Erreurs> GetLesErreurs()
        {
            return access.GetLesErreurs();
        }

    }
}
