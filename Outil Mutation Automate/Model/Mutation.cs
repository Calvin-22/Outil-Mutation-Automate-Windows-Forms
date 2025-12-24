using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [DisplayName("CIP")]
        public double CIP { get; set; }

        [DisplayName("Code Géographique")]
        public string CodeGéo { get; set; }

        [DisplayName("Désignation")]
        public string Désignation { get; set; }

        [DisplayName("Zone")]
        public string Zone { get; set; }

        [DisplayName("Moyenne des ventes")]
        public double MoyenneDesVentes { get; set; }

        [DisplayName("Fréquence de picking")]
        public double FrequencePicking { get; set; }

        [DisplayName("Nombre de boîtes par commande")]
        public double NBC { get; set; }

        [DisplayName("Nombre de boîtes vendues/j")]
        public double NBV { get; set; }

        [DisplayName("Hauteur du canal idéal (en mm)")]
        public double Hauteur_Canal { get; set; }

        [DisplayName("Pourcentage d'utilisation d'un canal/j")]
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
        public mutation(double cip, string code_géo, string designation, double moyenneDesVentes, double frequencePicking, string zone, double nombreBoitesParCommande, double nombreBoitesVendues, double hauteurCanalDesire, double nombreCanauxNecessaires)
        {
            CIP = cip;
            CodeGéo = code_géo;
            Désignation = designation;
            Zone = zone;
            MoyenneDesVentes = moyenneDesVentes;
            FrequencePicking = frequencePicking; 
            NBC = nombreBoitesParCommande;
            NBV = nombreBoitesVendues;
            Hauteur_Canal = hauteurCanalDesire;
            Canaux = nombreCanauxNecessaires;
        }
    }
}
