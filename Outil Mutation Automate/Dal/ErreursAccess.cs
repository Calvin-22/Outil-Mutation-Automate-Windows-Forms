using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Outil_Mutation_Automate.Model;
using Outil_Mutation_Automate.View;
using Outil_Mutation_Automate.Bdd_Manager;
using MySql.Data.MySqlClient;
using System.Data;

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
                string req = "SELECT Canal, Produit, Date, Commandé, Manque, Motif " +
                             "FROM erreurs " +
                             "ORDER BY Canal";
                try
                {
                    List<Object[]> records = access.Manager.ReqSelect(req);
                    if (records != null)
                    {
                        foreach (Object[] record in records)
                        {
                            double canal = (double)record[0];
                            double produit = (double)record[1];
                            string date = (string)record[2];
                            double commandé = (double)record[3];
                            double manque = (double)record[4];
                            string motif = (string)record[5];
                            Erreurs erreurs = new Erreurs(canal, produit, date, commandé, manque, motif);

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

        /// <summary>
        /// Ajoute une erreur à la base de données.
        /// </summary>
        /// <param name="erreur"></param>
        public void addErreurs(Erreurs erreurs)
        {
            // Vérifie si le gestionnaire de base de données est initialisé.
            if (access.Manager != null)
            {
                // Construit la requête SQL d'insertion.
                // Les noms des colonnes dans la table 'erreurs' sont supposés être les mêmes que les noms de propriétés.
                string req = "INSERT INTO erreurs (Canal, Produit, Date, Commandé, Manque, Motif) ";
                req += "VALUES (@Canal, @Produit, @Date, @Commandé, @Manque, @Motif);";

                // Crée un dictionnaire de paramètres pour la requête SQL.
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@Canal", erreurs.Canal);
                parameters.Add("@Produit", erreurs.Produit);
                parameters.Add("@Date", erreurs.Date);
                parameters.Add("@Commandé", erreurs.Commandé);
                parameters.Add("@Manque", erreurs.Manque);
                parameters.Add("@Motif", erreurs.Motif);

                try
                {
                    // Exécute la requête de mise à jour.
                    access.Manager.ReqUpdate(req, parameters);
                    Console.WriteLine("Mutation ajoutée avec succès.");
                }
                catch (Exception e)
                {
                    // Affiche le message d'erreur en cas d'exception.
                    Console.WriteLine($"Une erreur est survenue lors de l'ajout de la mutation : {e.Message}");
                }
            }
            else
            {
                Console.WriteLine("Erreur : access.Manager est null. Le gestionnaire de base de données n'est pas initialisé.");
            }
        }

        /// <summary>
        /// Récupère les statistiques des erreurs vides groupées par canal.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public DataTable GetStatsErreursVides()
        {
            if (access.Manager == null)
                throw new Exception("Le gestionnaire de base de données n'est pas initialisé.");

            string query = @"
        SELECT Canal, COUNT(*) AS Nombre_Occurrences
        FROM erreurs
        WHERE Motif = 'vide'
        GROUP BY Canal
        ORDER BY Nombre_Occurrences DESC;
    ";

            try
            {
                List<object[]> records = access.Manager.ReqSelect(query);

                DataTable dt = new DataTable();
                dt.Columns.Add("Canal", typeof(double));
                dt.Columns.Add("Nombre_Occurrences", typeof(int));

                foreach (var record in records)
                {
                    DataRow row = dt.NewRow();
                    row["Canal"] = record[0];
                    row["Nombre_Occurrences"] = record[1];
                    dt.Rows.Add(row);
                }

                return dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur GetStatsErreursVides : " + ex.Message);
                throw;
            }
        }




    }

}
