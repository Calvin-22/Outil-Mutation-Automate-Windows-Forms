using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outil_Mutation_Automate.Model
{
    /// <summary>
    /// Classe métier interne pour mémoriser les informations des mutations
    /// </summary>
    public class mutation
    {
        public double CIP { get; set; }
        public string Désignation { get; set; }
        public string Zone { get; set; } 
        public double NBC { get; set; }
        public double NBV { get; set; }
        public double Hauteur_Canal { get; set; }
        public double Canaux { get; set; }

        /// <summary>
        /// Valorise les propriétés
        /// </summary>
        /// <param name="cip"></param>
        /// <param name="designation"></param>
        /// <param name="nombreBoitesParCommande"></param>
        /// <param name="nombreBoitesVendues"></param>
        /// <param name="hauteurCanalDesire"></param>
        /// <param name="nombreCanauxNecessaires"></param>
        public mutation(double cip, string designation, string zone, double nombreBoitesParCommande, double nombreBoitesVendues, double hauteurCanalDesire, double nombreCanauxNecessaires)
        {
            CIP = cip;
            Désignation = designation;
            Zone = zone;
            NBC = nombreBoitesParCommande;
            NBV = nombreBoitesVendues;
            Hauteur_Canal = hauteurCanalDesire;
            Canaux = nombreCanauxNecessaires;
        }
    }
}
