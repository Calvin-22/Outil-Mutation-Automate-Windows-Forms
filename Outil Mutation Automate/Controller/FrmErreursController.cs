using System;
using System.Collections.Generic;
using System.Data;
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

        /// <summary>
        /// Ajoute une erreur
        /// </summary>
        /// <param name="erreur">La mutation à ajouter</param>
        public void addErreurs(Erreurs erreurs)
        {
            access.addErreurs(erreurs);
        }

        /// <summary>
        /// Retourne les statistiques des erreurs vides
        /// </summary>
        /// <returns></returns>
        public DataTable GetStatsErreursVides()
        {
            return access.GetStatsErreursVides();
        }

        /// <summary>
        /// Retourne les statistiques des erreurs vides
        /// </summary>
        /// <returns></returns>
        public DataTable GetStatsErreursManuelle()
        {
            return access.GetStatsErreursManuelle();
        }


    }
}
