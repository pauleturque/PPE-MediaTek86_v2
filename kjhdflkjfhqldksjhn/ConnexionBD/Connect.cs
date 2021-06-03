using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kjhdflkjfhqldksjhn.ConnexionBD
{
    /// <summary>
    /// Classe permettant la connexion à la base de données
    /// Méthodes de requêtes
    /// </summary>
    public class Connect
    {


        /// <summary>
        /// instance de la classe
        /// </summary>
        private static Connect instance;

        /// <summary>
        /// objet de connexion à la base de données
        /// </summary>
        private MySqlConnection connect;

        /// <summary>
        /// objet d'exécution d'une requête
        /// </summary>
        private MySqlCommand command;

        /// <summary>
        /// curseur
        /// </summary>
        private MySqlDataReader reader;

        /// <summary>
        /// Constructeur de création de la connexion à la base de données
        /// </summary>
        /// <param name="connectionString"></param>
        private Connect(string connectionString)
        {
            try
            {
                connect = new MySqlConnection(connectionString);
                Console.WriteLine("co ok");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "la connexion a échoué :( ");
                connect.Close();
            }
        }

        /// <summary>
        /// Instanciation de la classe
        /// </summary>
        /// <param name="connectionString"></param>
        /// <returns>instance</returns>
        public static Connect Instance(string connectionString)
        {
            if (instance is null)
            {
                instance = new Connect(connectionString);
            }
            return instance;
        }

        /// <summary>
        /// Requête select sur la base de données
        /// </summary>
        /// <param name="queryString"></param>
        /// <param name="parameters"></param>
        public void ReqSelect(string queryString, Dictionary<string, object> parameters)
        {
            try
            {
                command = new MySqlCommand(queryString, connect);
                if (!(parameters is null))
                {
                    foreach (KeyValuePair<string, object> parameter in parameters)
                    {
                        command.Parameters.Add(new MySqlParameter(parameter.Key, parameter.Value));
                    }
                }
                command.Prepare();
                reader = command.ExecuteReader();
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
            }
        }

        /// <summary>
        /// Requête de modification des données ou d'insertion de données dans la base
        /// </summary>
        /// <param name="queryString"></param>
        /// <param name="parameters"></param>
        public void ReqUpdate(string queryString, Dictionary<string, object> parameters)
        {
            try
            {
                command = new MySqlCommand(queryString, connect);
                if (!(parameters is null))
                {
                    foreach (KeyValuePair<string, object> parameter in parameters)
                    {
                        command.Parameters.Add(new MySqlParameter(parameter.Key, parameter.Value));
                    }
                }
                command.Prepare();
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        /// <summary>
        /// Requête de suppression de données dans la base de données
        /// </summary>
        /// <param name="queryString"></param>
        /// <param name="parameters"></param>
        public void ReqDelete(string queryString, Dictionary<string, object> parameters)
        {
            try
            {
                command = new MySqlCommand(queryString, connect);
                if (!(parameters is null))
                {
                    foreach (KeyValuePair<string, object> parameter in parameters)
                    {
                        command.Parameters.Add(new MySqlParameter(parameter.Key, parameter.Value));
                    }
                }
                command.Prepare();
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            { 
                Console.WriteLine(e);
            }
        }

        /// <summary>
        /// Lecture de la ligne suivante si possible
        /// </summary>
        /// <returns></returns>
        public bool Read()
        {
            if (reader is null)
            {
                return false;
            }
            try
            {
                return reader.Read();
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Retourne le champ en fonction du paramètre passé
        /// </summary>
        /// <param name="nameField"></param>
        /// <returns></returns>
        public object Field(string nameField)
        {
            if (reader is null)
            {
                return null;
            }
            try
            {
                return reader[nameField];
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Ferme le curseur
        /// </summary>
        public void Close()
        {
            if (!(reader is null))
            {
                reader.Close();
            }
            connect.Close();
            }
        /// <summary>
        /// Ferme le curseur
        /// </summary>
        public void Open()
        {
            connect.Open();
        }
        
    }
}
