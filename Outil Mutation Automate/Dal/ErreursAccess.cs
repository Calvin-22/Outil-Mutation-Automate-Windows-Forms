using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Outil_Mutation_Automate.Model;
using Outil_Mutation_Automate.View;
using Outil_Mutation_Automate.Bdd_Manager;
using MySql.Data.MySqlClient;

namespace Outil_Mutation_Automate.Dal
{
    class ErreursAccess
    {
        /// <summary>
        /// Instance unique de l'accès aux données
        /// </summary>
        private readonly Access access = null;

        /// <summary>
        /// Constructeur pour créer l'accès aux données
        /// </summary>
        public ErreursAccess()
        {
            access = Access.GetInstance();
        }

        /// <summary>
        /// Récupère et retourne les erreurs
        /// </summary>
        /// <returns>liste des erreurs</returns>
        public List<Erreurs> GetLesErreurs()
        {
            List<Erreurs> lesErreurs = new List<Erreurs>();
            if (access.Manager != null)
            {
                string req = "SELECT Canal, `Code Géo`, Produit, Date, Commandé, Manque, Motif" +
                             "FROM erreurs " +
                             "ORDER BY Canal DESC";
                try
                {
                    List<Object[]> records = access.Manager.ReqSelect(req);
                    if (records != null)
                    {
                        foreach (Object[] record in records)
                        {
                            double canal = (double)record[0];
                            double codeGéo = (double)record[1];
                            double produit = (double)record[2];
                            string date = (string)record[3];
                            double commandé = (double)record[4];
                            double manque = (double)record[5];
                            string motif = (string)record[6];
                            Erreurs erreurs = new Erreurs(canal, codeGéo, produit, date, commandé, manque, motif);

                            lesErreurs.Add(erreurs);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);

                }
            }
            return lesErreurs;
        }


        /// <summary>
        /// Vider tout ce que contient la table Erreurs
        /// </summary>
        public void ViderErreurs()
        {
            if (access.Manager != null)
            {
                string req = "DELETE FROM Erreurs;";
                try
                {
                    access.Manager.ReqUpdate(req, null); // Pas de paramètres
                }
                catch (Exception e)
                {
                    Console.WriteLine("Erreur lors du vidage : " + e.Message);
                    throw; // Propage l'exception à l'appelant
                }
            }
        }
    }

}
