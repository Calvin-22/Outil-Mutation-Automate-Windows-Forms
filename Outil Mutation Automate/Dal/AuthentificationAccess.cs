using System.Text;
using Outil_Mutation_Automate.Model;
using System.Security.Cryptography;
using System.Text;

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
                // On hache le mot de passe saisi par l'utilisateur
                string hashedPwd = ComputeSha256Hash(authentification.pwd);

                string req = "select * from authentification ";
                req += "where login=@login and pwd=@pwd";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@login", authentification.login);
                parameters.Add("@pwd", hashedPwd);
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


        public string ComputeSha256Hash(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // Convertit le mot de passe en tableau d'octets
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convertit le tableau d'octets en chaîne hexadécimale
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

    }
}
