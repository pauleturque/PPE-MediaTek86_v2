using kjhdflkjfhqldksjhn.Modele;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kjhdflkjfhqldksjhn
{
    public partial class frmAddPerso : Form
    {
        /// <summary>
        /// Déclaration de l'objet controle
        /// </summary>
        private Controle controle;
        /// <summary>
        /// Déclaration de l'objet personnel
        /// </summary>
        private Personnel personnel;
        /// <summary>
        /// Déclaration de l'objet service
        /// </summary>
        private Services service;
        /// <summary>
        /// Déclaration de la liste des services
        /// </summary>
        private List<Services> ListeService;
        /// <summary>
        /// Initialisation de la source de données pour la liste des services
        /// </summary>
        BindingSource bsServices = new BindingSource();

        /// <summary>
        /// Constructeur du formulaire d'ajout d'un personnel
        /// </summary>
        /// <param name="controle"></param>
        /// <param name="personnel"></param>
        /// <param name="ListeService"></param>
        public frmAddPerso(Controle controle, Personnel personnel, List<Services> ListeService)
        {
            InitializeComponent();
            this.controle = controle;
            this.personnel = personnel;
            this.ListeService = controle.ListServices;
            InitialiseServices();
        }

        /// <summary>
        /// Méthode de liaison de la liste de services avec la source de données
        /// </summary>
        public void InitialiseServices()
        {
            List<Services> lesServices = controle.ListServices;
            bsServices.DataSource = lesServices;
            cbServices.DataSource = bsServices;
        }

        /// <summary>
        /// Action permettant de valider l'ajout d'un personnel à la liste
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnValider_Click(object sender, EventArgs e)
        {
            if (txtNom.Text.Equals("") || txtPrenom.Text.Equals("") || txtTel.Text.Equals("") || txtMail.Text.Equals("") || cbServices.SelectedItem == null)
            {
                MessageBox.Show("Tous les champs doivent être remplis");
            }
            else
            {
                int idservice = cbServices.SelectedIndex;
                int idpersonnel = 0;
                Personnel personnel = new Personnel(idpersonnel, idservice, txtNom.Text, txtPrenom.Text, txtTel.Text, txtMail.Text);
                try
                {
                    controle.AjoutPersonnel(personnel);

                }
                catch (Exception i)
                {

                    Console.WriteLine(i + "échec ajout");
                }

            }
            Close();
        }

        /// <summary>
        /// Action permettant d'annuler l'ajout d'un personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
