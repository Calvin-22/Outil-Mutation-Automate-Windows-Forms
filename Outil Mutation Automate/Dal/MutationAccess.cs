using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Outil_Mutation_Automate.Model;
using Outil_Mutation_Automate.View;
using Outil_Mutation_Automate.Bdd_Manager;

namespace Outil_Mutation_Automate.Dal
{
    class mutationAccess
    {
        /// <summary>
        /// Instance unique de l'accès aux données
        /// </summary>
        private readonly Access access = null;

        /// <summary>
        /// Constructeur pour créer l'accès aux données
        /// </summary>
        public mutationAccess()
        {
            access = Access.GetInstance();
        }

        /// <summary>
        /// Récupère et retourne les mutations
        /// </summary>
        /// <returns>liste des mutations</returns>
        public List<mutation> GetLesMutations()
        {
            List<mutation> lesMutations = new List<mutation>();
            if (access.Manager != null)
            {
                string req = "SELECT CIP, `Code Géo`, Désignation, Zone, NBC, NBV, `Hauteur Canal`, `Nombre de Canal` FROM mutation";
                try
                {
                    List<Object[]> records = access.Manager.ReqSelect(req);
                    if (records != null)
                    {
                        foreach (Object[] record in records)
                        {
                            double cip = (double)record[0];
                            string code_géo = (string)record[1];
                            string designation = (string)record[2];
                            string zone = (string)record[3];
                            double nombreBoitesParCommande = (double)record[4];
                            double nombreBoitesVendues = (double)record[5];
                            double hauteurCanalDesire = (double)record[6];
                            double nombreCanauxNecessaires = (double)record[7];
                            mutation mutation = new mutation(cip, code_géo, designation, zone, nombreBoitesParCommande, nombreBoitesVendues, hauteurCanalDesire, nombreCanauxNecessaires);

                            lesMutations.Add(mutation);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);

                }
            }
            return lesMutations;
        }

        /// <summary>
        /// Ajoute une mutation à la base de données.
        /// </summary>
        /// <param name="mutation"></param>
        public void addMutation(mutation mutation)
        {
            // Vérifie si le gestionnaire de base de données est initialisé.
            if (access.Manager != null)
            {
                // Construit la requête SQL d'insertion.
                // Les noms des colonnes dans la table 'mutation' sont supposés être les mêmes que les noms de propriétés.
                string req = "INSERT INTO mutation (CIP, `Code Géo`, Désignation, Zone, NBC, NBV, `Hauteur Canal`, `Nombre de Canal`) ";
                req += "VALUES (@CIP, @CodeGeo, @Désignation, @Zone, @NBC, @NBV, @HauteurCanal, @NombreCanauxNecessaires);";

                // Crée un dictionnaire de paramètres pour la requête SQL.
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@CIP", mutation.CIP);
                parameters.Add("@CodeGeo", mutation.CodeGéo);
                parameters.Add("@Désignation", mutation.Désignation);
                parameters.Add("@Zone", mutation.Zone);
                parameters.Add("@NBC", mutation.NBC);
                parameters.Add("@NBV", mutation.NBV);
                parameters.Add("@HauteurCanal", mutation.Hauteur_Canal);
                parameters.Add("@NombreCanauxNecessaires", mutation.Canaux);

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
                    // Dans une application réelle, vous pourriez vouloir logguer l'erreur
                    // ou afficher un message plus convivial à l'utilisateur,
                    // plutôt que de quitter l'environnement.
                    // Environment.Exit(0); // Commenté car cela peut être trop drastique pour un comportement par défaut.
                }
            }
            else
            {
                Console.WriteLine("Erreur : access.Manager est null. Le gestionnaire de base de données n'est pas initialisé.");
            }
        }

        /// <summary>
        /// Demande de suppression d'une absence
        /// </summary>
        /// <param name="mutation">objet personnel à supprimer</param>
        public void delMutation(mutation mutation)
        {
            if (access.Manager != null)
            {
                string req = "delete from mutation where Désignation = @Désignation;";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@Désignation", mutation.Désignation);
                try
                {
                    access.Manager.ReqUpdate(req, parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        /// <summary>
        /// Vider tout ce que contient la table mutation
        /// </summary>
        public void ViderMutation()
        {
            if (access.Manager != null)
            {
                string req = "DELETE FROM mutation;";
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
