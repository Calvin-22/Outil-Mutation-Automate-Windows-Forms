using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Outil_Mutation_Automate.Bdd_Manager;
using MySql.Data.MySqlClient;

namespace Outil_Mutation_Automate.Dal
{
    /// <summary>
    /// Singleton : classe d'accès à BddManager
    /// </summary>
    public class Access
    {
        /// <summary>
        /// chaine de connexion à la bdd
        /// </summary>
        private static readonly string connectionString = "server=localhost; user id=root;password=calvin22;database=bdd mutation;SslMode=none";
        /// <summary>
        /// instance unique de la classe
        /// </summary>
        private static Access instance = null;
        /// <summary>
        /// Getter sur l'objet d'accès aux données
        /// </summary>
        public BddManager Manager { get; }

        /// <summary>
        /// Création unique de l'objet de type BddManager
        /// Arrête le programme si l'accès à la BDD a échoué
        /// </summary>
        private Access()
        {
            try
            {
                Manager = BddManager.GetInstance(connectionString);
            }
            catch (Exception)
            {
                Environment.Exit(0);
            }
        }

        /// <summary>
        /// Création d'une seule instance de la classe
        /// </summary>
        /// <returns></returns>
        public static Access GetInstance()
        {
            if (instance == null)
            {
                instance = new Access();
            }
            return instance;
        }

    }
}
