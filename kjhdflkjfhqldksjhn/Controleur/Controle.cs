using kjhdflkjfhqldksjhn.ConnexionBD;
using kjhdflkjfhqldksjhn.Dal;
using kjhdflkjfhqldksjhn.Modele;
using kjhdflkjfhqldksjhn.Vues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace kjhdflkjfhqldksjhn
{
    public class Controle
    {
        /// <summary>
        /// D�claration du formulaire de connexion
        /// </summary>
        private frmConnection frmConnection;
        /// <summary>
        /// D�claration du formulaire principal de l'appli
        /// </summary>
        private frmHome frmHome;
        /// <summary>
        /// D�claration du formulaire Absences
        /// </summary>
        private frmAbsences frmAbsences;
        /// <summary>
        /// Instanciation de la liste des absences
        /// </summary>
        public List<Absences> ListAbsences = DataAccess.GetAbsences();
        /// <summary>
        /// Instanciation de la liste du personnel
        /// </summary>
        public List<Personnel> ListPersonnel = DataAccess.GetPersonnels();
        /// <summary>
        /// Instanciation de la liste des motifs
        /// </summary>
        public List<Motif> ListMotifs = DataAccess.GetMotifs();
        /// <summary>
        /// Instanciation de la liste des services
        /// </summary>
        public List<Services> ListServices = DataAccess.GetServices();
        /// <summary>
        /// D�claration du mod�le d'absences
        /// </summary>
        private Absences absences;
        /// <summary>
        /// D�claration du formulaire d'ajout ou modification des absences
        /// </summary>
        private frmAjoutAbsence frmAjoutModifAbsence;
        /// <summary>
        /// D�claration du formulaire d'ajout d'un personnel
        /// </summary>
        private frmAddPerso frmAddPerso;
        /// <summary>
        /// D�claration du mod�le des motifs
        /// </summary>
        private Motif motif;
        /// <summary>
        /// D�claration du mod�le des personnels
        /// </summary>
        private Personnel personnel;
        /// <summary>
        /// D�claration du mod�le des services
        /// </summary>
        private Services services;

        public BindingSource bsPersonnel;
        private object frmModPerso;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            new Controle();
        }

        /// <summary>
        /// Constructeur du controleur, ouveture de la premi�re fen�tre
        /// </summary>
        public Controle()
        {
            frmConnection = new frmConnection(this);
            frmConnection.ShowDialog();
        }

        /// <summary>
        /// Contr�le de l'authentification � l'application
        /// </summary>
        /// <param name="login"></param>
        /// <param name="pwd"></param>
        /// <returns>vrai si ok, faux si errron�</returns>
        public bool AuthControl(string login, string pwd)
        {
            if (DataAccess.AuthenticationControl(login, pwd))
            {
                frmConnection.Hide();
                frmHome = new frmHome(this);
                frmHome.ShowDialog();
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// M�thode de mise � jour d'un personnel
        /// </summary>
        /// <param name="personnel"></param>
        public void UpdatePersonnel(Personnel personnel)
        {
            DataAccess.UpdatePersonnel(personnel);
        }

        /// <summary>
        /// Ouverture du formulaire permettant l'ajout d'un personnel
        /// </summary>
        public void AddPerso()
        { 
            new frmAddPerso(this, null, ListServices).ShowDialog();
        }

        public void RefreshPerso()
        {
            frmHome.RefreshPerso();
        }

        /// <summary>
        /// M�thode d'ajout d'un personnel � la BDD
        /// </summary>
        /// <param name="personnel"></param>
        public void AjoutPersonnel(Personnel personnel)
        {
            DataAccess.AddPersonnel(personnel);
            ListPersonnel.Add(personnel);
            RefreshPerso();
        }

        /// <summary>
        /// Ouverture du formulaire permettant de modifier un personnel
        /// </summary>
        /// <param name="personnel"></param>
        /// <param name="services"></param>
        /// <param name="result"></param>
        public void ModPerso(Personnel personnel, List<Services> services, List<Services> result)
        {
            services = ListServices;
            new frmModPerso(this, personnel, services, result).ShowDialog();
        }

        /// <summary>
        /// M�thode de suppression d'un personnel dans la BDD
        /// </summary>
        /// <param name="personnel"></param>
        public void SupprimerPersonnel(Personnel personnel)
        {
            DataAccess.DeletePersonnel(personnel);
        }

        /// <summary>
        /// Ouverture du formulaire d'absences d'un personnel
        /// </summary>
        /// <param name="personnel"></param>
        public void AfficherAbsences(Personnel personnel)
        {
            frmAbsences = new frmAbsences(this, personnel);
            frmAbsences.Update();
            frmAbsences.ShowDialog();
        }

        /// <summary>
        /// M�thode d'ajout d'une absence � la liste d'absence d'un personnel dans la BDD
        /// </summary>
        /// <param name="absence"></param>
        /// <param name="personnel"></param>
        public void AjouterAbsences(Absences absence, Personnel personnel)
        {
            DataAccess.AddAbsence(absence, personnel);
            ListAbsences.Add(absence);
        }

        public void RefreshAbsence()
        {
            frmAbsences.RefreshAbsences();
        }
        /// <summary>
        /// Ouvertude du formulaire d'ajout d'une absence
        /// </summary>
        /// <param name="personnel"></param>
        public void OuvrirAjoutAbsence(Personnel personnel)
        {
            new frmAjoutAbsence(this, personnel).ShowDialog();
        }

        /// <summary>
        /// M�thode de suppression d'une absence
        /// </summary>
        /// <param name="absence"></param>
        /// <param name="personnel"></param>
        public void SupprimerAbsence(Absences absence, Personnel personnel)
        {
            DataAccess.DeleteAbsence(absence, personnel);
        }

        /// <summary>
        /// Ouverture du formulaire de modification d'une absence
        /// </summary>
        /// <param name="absence"></param>
        /// <param name="personnel"></param>
        public void OuvrirAbsenseAmodifier(Absences absence, Personnel personnel)
        {
            new frmModifierAbsence(this, absence, personnel).ShowDialog();
        }

        /// <summary>
        /// M�thode de modification d'une absence
        /// </summary>
        /// <param name="absence"></param>
        /// <param name="personnel"></param>
        public void ModifierAbsence(Absences absence, Personnel personnel)
        {
            DataAccess.UpdateAbsence(absence, personnel);
        }

    }
}

