using System.ComponentModel;

namespace Outil_Mutation_Automate.Model
{
    public class Erreurs
    {

        [DisplayName("N° de Canal")]
        public double Canal { get; set; }

        [DisplayName("CIP")]
        public double Produit { get; set; }

        [DisplayName("Date de l'erreur")]
        public string Date { get; set; }

        [DisplayName("Quantité commandé")]
        public double Commandé { get; set; }
       
        [DisplayName("Quantité manquante")]
        public double Manque { get; set; }

        [DisplayName("Motif de l'erreur")]
        public string Motif { get; set; }

        /// <summary>
        /// Valorise les propriétés
        /// </summary>
        /// <param name="canal"></param>
        /// <param name="codeGéo"></param>
        /// <param name="produit"></param>
        /// <param name="date"></param>
        /// <param name="commandé"></param>
        /// <param name="manque"></param>
        /// <param name="motif"></param>
        public Erreurs(double canal, double produit, string date, double commandé, double manque, string motif)
        {
            Canal = canal;
            Produit = produit;
            Date = date;
            Commandé = commandé;
            Manque = manque;
            Motif = motif;
        }
    }
}
