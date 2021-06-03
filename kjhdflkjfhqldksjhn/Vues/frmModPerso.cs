
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

namespace kjhdflkjfhqldksjhn.Vues
{
    public partial class frmModPerso : Form
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
        private List<Services> services;
        /// <summary>
        /// Déclaration de l'objet result
        /// </summary>
        private object result;

        /// <summary>
        /// Constructeur de la fenêtre de modification d'un personnel
        /// </summary>
        /// <param name="controle"></param>
        /// <param name="personnel"></param>
        /// <param name="services"></param>
        /// <param name="result"></param>
        public frmModPerso(Controle controle, Personnel personnel, List<Services> services, List<Services> result)
        {
            InitializeComponent();
            this.controle = controle;
            this.personnel = personnel;
            this.services = services;
            this.result = result;
            InitialiseServices(result);
        }

        /// <summary>
        /// Méthode permettant l'initialisation de la liste des services
        /// </summary>
        /// <param name="result"></param>
        public void InitialiseServices(List<Services> result)
        {
            cbServices.DataSource = services;
            cbServices.SelectedItem = result.First();
            txtNom.Text = personnel.Nom;
            txtPrenom.Text = personnel.Prenom;
            txtTel.Text = personnel.Tel;
            txtMail.Text = personnel.Mail;
        }

        /// <summary>
        /// Action permettant de valider la modification d'un personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnValider_Click(object sender, EventArgs e)
        {
            if (txtNom.Text.Equals("") || txtPrenom.Text.Equals("") || txtMail.Text.Equals("") || txtTel.Text.Equals(""))
            {
                MessageBox.Show("Tous les champs doivent être remplis");
            }
            else
            {
                personnel.IdService = ((Services)cbServices.SelectedValue).IdService;
                try
                {
                    controle.UpdatePersonnel(personnel);
                    Console.WriteLine("Modification réussie");
                }
                catch (Exception i)
                {
                    Console.WriteLine(i + "échec modification");
                }
                Close();
            }
        }

        /// <summary>
        /// Action permettant l'annulation de la modification d'un personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
