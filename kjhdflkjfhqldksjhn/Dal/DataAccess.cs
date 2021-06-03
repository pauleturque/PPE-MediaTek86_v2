using kjhdflkjfhqldksjhn.ConnexionBD;
using kjhdflkjfhqldksjhn.Modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kjhdflkjfhqldksjhn.Dal
{
    class DataAccess
    {
        /// <summary>
        /// Chaîne de connexion à la base de données
        /// </summary>
        private static string connectionString = "server = localhost; user id = root; database = bdd_mediatek; port = 3308";

        /// <summary>
        /// Requête permettant l'authentification par vérification
        /// Du mot de passe et del'identifiant dans la base de données
        /// </summary>
        /// <param name="login"></param>
        /// <param name="pwd"></param>
        /// <returns>vrai si ok, faux si erroné</returns>
        public static bool AuthenticationControl(string login, string pwd)
        {

            string req = "SELECT responsable.login, responsable.pwd";
            req += " FROM responsable ";
            req += " WHERE responsable.login = SHA2(@login, 256) AND responsable.pwd = SHA2(@pwd, 256)";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@login", login);
            parameters.Add("@pwd", pwd);
            Connect curseur = Connect.Instance(connectionString);
            curseur.Open();
            curseur.ReqSelect(req, parameters);


            if (curseur.Read())
            {
                curseur.Close();
                return true;
            }
            else
            {
                curseur.Close();
                return false;
            }
        }

        /// <summary>
        /// Requête de récupération du contenu de la table personnel de la bdd
        /// </summary>
        /// <returns>Liste des personnels</returns>
        public static List<Personnel> GetPersonnels()
        {
            List<Personnel> lePersonnel = new List<Personnel>();
            string req = "SELECT * FROM Personnel ORDER BY nom, prenom";
            Connect curseur = Connect.Instance(connectionString);
            curseur.Open();
            curseur.ReqSelect(req, null);
            while (curseur.Read())
            {
                Personnel personnel = new Personnel((int)curseur.Field("idpersonnel"), (int)curseur.Field("idservice"), (string)curseur.Field("nom"), (string)curseur.Field("prenom"), (string)curseur.Field("tel"), (string)curseur.Field("mail"));
                lePersonnel.Add(personnel);
            }
            curseur.Close();
            return lePersonnel;
        }

        /// <summary>
        /// Requête de récupération de la liste des services dans la bdd
        /// </summary>
        /// <returns>Liste des services</returns>
        public static List<Services> GetServices()
        {
            List<Services> lesServices = new List<Services>();
            string req = "SELECT service.idservice, service.nom FROM Service ORDER BY Service.nom ASC";
            Connect curseur = Connect.Instance(connectionString);
            curseur.Open();
            curseur.ReqSelect(req, null);
            while (curseur.Read())
            {
                Services service = new Services((int)curseur.Field("idservice"), (string)curseur.Field("nom"));
                lesServices.Add(service);
            }
            curseur.Close();
            return lesServices;
        }



        /// <summary>
        /// Requête de récupération de la liste des absences dans la bdd
        /// </summary>
        /// <param name="personnel"></param>
        /// <returns>Liste des absences</returns>
        public static List<Absences> GetAbsences()
        {
            List<Absences> lesAbsences = new List<Absences>();
            string req = "SELECT a.idpersonnel, a.idmotif, a.datedebut, a.datefin, p.idpersonnel";
            req += " FROM Absence a JOIN Personnel p ON a.idpersonnel = p.idpersonnel ";
            req += "WHERE a.idpersonnel = p.idpersonnel";
            req += " ORDER BY a.datedebut, a.datefin DESC ";
            Connect curseur = Connect.Instance(connectionString);
            curseur.Open();
            curseur.ReqSelect(req, null);
            while (curseur.Read())
            {
                Absences absence = new Absences((int)curseur.Field("idpersonnel"), (int)curseur.Field("idmotif"), (DateTime)curseur.Field("datedebut"), (DateTime)curseur.Field("datefin"));
                lesAbsences.Add(absence);
            }
            curseur.Close();
            return lesAbsences;
        }

        /// <summary>
        /// Requête de récupération de la liste des motifs dans la bdd
        /// </summary>
        /// <returns>Liste des motifs</returns>
        public static List<Motif> GetMotifs()
        {
            List<Motif> lesMotifs = new List<Motif>();
            string req = "SELECT m.idmotif, m.libelle FROM motif m";
            Connect curseur = Connect.Instance(connectionString);
            curseur.Open();
            curseur.ReqSelect(req, null);

            while (curseur.Read())
            {
                Motif motif = new Motif((int)curseur.Field("idmotif"), (string)curseur.Field("libelle"));
                lesMotifs.Add(motif);
            }
            curseur.Close();
            return lesMotifs;
        }

        /// <summary>
        /// Requête d'ajout d'un personnel à la base de données
        /// </summary>
        /// <param name="personnel"></param>
        public static void AddPersonnel(Personnel personnel)
        {
            string req = "INSERT INTO Personnel(idpersonnel, idservice, nom, prenom, tel, mail)";
            req += " values(@idpersonnel, @idservice, @nom, @prenom, @tel, @mail)";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", personnel.IdPersonnel);
            parameters.Add("@idservice", personnel.IdService);
            parameters.Add("@nom", personnel.Nom);
            parameters.Add("@prenom", personnel.Prenom);
            parameters.Add("@tel", personnel.Tel);
            parameters.Add("@mail", personnel.Mail);
            Connect connect = Connect.Instance(connectionString);
            connect.Open();
            connect.ReqUpdate(req, parameters);
            connect.Close();
        }

        /// <summary>
        /// Requête de suppression d'un personnel dans la bdd
        /// </summary>
        /// <param name="personnel"></param>
        public static void DeletePersonnel(Personnel personnel)
        {
            string req = "DELETE FROM personnel WHERE idpersonnel = @idpersonnel ";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", personnel.IdPersonnel);
            Connect connect = Connect.Instance(connectionString);
            connect.Open();
            connect.ReqDelete(req, parameters);
            connect.Close();
        }

        /// <summary>
        /// Requête de mise à jour d'un personnel dans la bdd
        /// </summary>
        /// <param name="personnel"></param>
        public static void UpdatePersonnel(Personnel personnel)
        {
            try
            {
                Console.WriteLine(personnel);
                string req = "UPDATE personnel SET idpersonnel = @idpersonnel, idservice = @idservice, nom = @nom, prenom = @prenom, tel = @tel, mail = @mail";
                req += " WHERE idpersonnel = @idpersonnel";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@idpersonnel", personnel.IdPersonnel);
                parameters.Add("@idservice", personnel.IdService);
                parameters.Add("@nom", personnel.Nom);
                parameters.Add("@prenom", personnel.Prenom);
                parameters.Add("@tel", personnel.Tel);
                parameters.Add("@mail", personnel.Mail);
                Connect connect = Connect.Instance(connectionString);
                connect.Open();
                connect.ReqUpdate(req, parameters);
                connect.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e + "DataAccess marche ap frr");
            }
        }

        /// <summary>
        /// Requête d'ajout d'une absence dans la base de données
        /// </summary>
        /// <param name="absence"></param>
        public static void AddAbsence(Absences absence, Personnel personnel)
        {
            string req = "INSERT INTO absence(idpersonnel, idmotif, datedebut, datefin)";
            req += " VALUES (@idpersonnel, @idmotif, @datedebut, @datefin)";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            //parameters.Add("@idpersonnel", personnel.IdPersonnel);
            parameters.Add("@idpersonnel", absence.IdPersonnel);
            parameters.Add("@idmotif", absence.IdMotif);
            parameters.Add("@datedebut", absence.DateDebut);
            parameters.Add("@datefin", absence.DateFin);
            Connect connect = Connect.Instance(connectionString);
            connect.Open();
            connect.ReqUpdate(req, parameters);
            connect.Close();
        }

        /// <summary>
        /// Requête de suppression d'une absence dans la bdd
        /// </summary>
        /// <param name="absence"></param>
        public static void DeleteAbsence(Absences absence, Personnel personnel)
        {
            string req = "DELETE FROM absence WHERE";
            req += " idpersonnel = @idpersonnel AND datedebut = @datedebut AND datefin = @datefin ";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", absence.IdPersonnel);
            parameters.Add("@datedebut", absence.DateDebut);
            parameters.Add("@datefin", absence.DateFin);
            Connect connect = Connect.Instance(connectionString);
            connect.Open();
            connect.ReqDelete(req, parameters);
            connect.Close();
        }

        /// <summary>
        /// Requête de mise à jour d'une absence dans la bdd
        /// </summary>
        /// <param name="absence"></param>
        public static void UpdateAbsence(Absences absence, Personnel personnel)
        {
            string req = "UPDATE absence SET idpersonnel = @idpersonnel, idmotif = @idmotif, datedebut = @datedebut, datefin = @datefin";
            req += " WHERE idpesonnel = @idpesonnel";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", absence.IdPersonnel);
            parameters.Add("@idmotif", absence.IdMotif);
            parameters.Add("@nom", absence.DateDebut);
            parameters.Add("@prenom", absence.DateFin);
            Connect connect = Connect.Instance(connectionString);
            connect.Open();
            connect.ReqUpdate(req, parameters);
            connect.Close();
        }

        /// <summary>
        /// Encryption d'une chaîne de caractères
        /// </summary>
        /// <param name="text"></param>
        /// <returns>Chaîne cryptée</returns>
        internal static string GetStringSha256Hash(string text)
        {
            if (string.IsNullOrEmpty(text))
                return string.Empty;

            using (var sha = new System.Security.Cryptography.SHA256Managed())
            {
                byte[] textData = System.Text.Encoding.UTF8.GetBytes(text);
                byte[] hash = sha.ComputeHash(textData);
                return BitConverter.ToString(hash).Replace("-", string.Empty);
            }
        }
    }
}

