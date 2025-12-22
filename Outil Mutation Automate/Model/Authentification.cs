

namespace Outil_Mutation_Automate.Model
{
    public class Authentification
    {
        /// <summary>
        /// class identifiant
        /// </summary>
        public string login { get; }

        /// <summary>
        /// class pwd, mot de passe
        /// </summary>
        public string pwd { get; }

        /// <summary>
        /// Valorise les propriétés
        /// </summary>
        /// <param name="login"></param>
        /// <param name="pwd"></param>
        public Authentification(string login, string pwd)
        {
            this.login = login;
            this.pwd = pwd;
        }
    }
}
