namespace Outil_Mutation_Automate.Model
{
    public class Erreurs
    {
        public double Canal { get; set; }

        public double CodeGéo { get; set; }

        public double Produit { get; set; }
        public string Date { get; set; }

        public double Commandé { get; set; }

        public double Manque { get; set; }

        public string Motif { get; set; }
        public string ChampsLibre { get; set; }

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
