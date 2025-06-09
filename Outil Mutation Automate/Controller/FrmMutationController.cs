using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Outil_Mutation_Automate.Dal;
using Outil_Mutation_Automate.Model;

namespace Outil_Mutation_Automate.Controller
{

    public class FrmMutationController
    {
        /// <summary>
        /// Instance unique de l'accès aux données
        /// </summary>
        private readonly mutationAccess access;

        /// <summary>
        /// Constructeur pour créer l'accès aux données
        /// </summary>
        public FrmMutationController()
        {
            access = new mutationAccess();
        }

        /// <summary>
        /// Récupère et retourne les mutations
        /// </summary>
        /// <returns>liste des mutations</returns>
        public List<mutation> GetLesMutations()
        {
            return access.GetLesMutations();
        }

        /// <summary>
        /// Ajoute une mutation
        /// </summary>
        /// <param name="mutation">La mutation à ajouter</param>
        public void addMutation(mutation mutation)
        {
            access.addMutation(mutation); 
        }

        /// <summary>
        /// Demande de suppression d'une ligne mutation
        /// </summary>
        /// <param name="absence">objet absence à supprimer</param>
        public void delMutation(mutation mutation)
        {
            access.delMutation(mutation);
        }
    }
}
