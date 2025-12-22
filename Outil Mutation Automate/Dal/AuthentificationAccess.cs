using Outil_Mutation_Automate.Model;

namespace Outil_Mutation_Automate.Dal
{
    public class AuthentificationAccess
    {
        /// <summary>
        /// Instance unique de l'accès aux données
        /// </summary>
        private readonly Access access = null;

        /// <summary>
        /// Constructeur pour créer l'accès aux données
        /// </summary>
        public AuthentificationAccess()
        {
            access = Access.GetInstance();
        }

        /// <summary>
        /// Controle si l'utilisateur a le droit de se connecter (identifiant, pwd)
        /// </summary>
        /// <param name="responsable"></param>

        /// <returns>vrai si l'utilisateur a le profil "responsable"</returns>
        public Boolean ControleAuthentification(Authentification authentification)
        {
            if (access.Manager != null)
            {
                string req = "select * from authentification";
                req += " where login=@login and pwd=@pwd";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@login", authentification.login);
                parameters.Add("@pwd", authentification.pwd);
                try
                {
                    List<Object[]> records = access.Manager.ReqSelect(req, parameters);
                    if (records != null)
                    {
                        return (records.Count > 0);
                    }
                }
                catch (Exception e)
                {
                    //Message d'erreur en console pour débogage
                    Console.WriteLine(e.Message);
                }
            }
            return false;
        }

    }
}
