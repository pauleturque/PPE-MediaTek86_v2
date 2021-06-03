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
    public partial class frmHome : Form
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
        /// Déclaration et initialisation de la source de données de la liste des personnels
        /// </summary>
        BindingSource bsPersonnel = new BindingSource();
        /// <summary>
        /// Déclaration et initialisation de la source de données de la liste des services
        /// </summary>
        BindingSource bsServices = new BindingSource();
        /// <summary>
        /// Déclaration et initialisation de la source de données de la liste des absences
        /// </summary>
        BindingSource bsAbsences = new BindingSource();

        private Button btnModPerso;
        
        /// <summary>
        /// Constructeur de la fenêtre principale
        /// </summary>
        /// <param name="controle"></param>
        public frmHome(Controle controle)
        {
            InitializeComponent();
            this.controle = controle;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmHome_Load(object sender, EventArgs e)
        {
            bsPersonnel.DataSource = controle.ListPersonnel;
            dgvPersonnel.DataSource = bsPersonnel;
            dgvPersonnel.Columns["idPersonnel"].Visible = false;
            dgvPersonnel.Columns["idservice"].Visible = false;
            
        }

        public void RefreshPerso()
        {
            bsPersonnel.ResetBindings(false);
        }

        /// <summary>
        /// Ajout d'un personnel à la liste
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddPerso_Click(object sender, EventArgs e)
        {
            controle.AddPerso();
        }

        /// <summary>
        /// Affichage des absences du personnel après selection dans la liste
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAbsPerso_Click(object sender, EventArgs e)
        {
            if (dgvPersonnel.SelectedRows.Count > 0)
            {
                Personnel personnel = (Personnel)bsPersonnel.List[bsPersonnel.Position];
                controle.AfficherAbsences(personnel);
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }
        /// <summary>
        /// Après selection d'un personnel dans la liste : Modification
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifierPerso_Click(object sender, EventArgs e)
        {
            if (dgvPersonnel.SelectedRows.Count > 0)
            {
                Personnel personnel = (Personnel)bsPersonnel.List[bsPersonnel.Position];
                List<Services> lesServices = controle.ListServices;
                bsServices.DataSource = lesServices;
                var result = (from service in lesServices
                                             where service.IdService == personnel.IdService
                                             select service).ToList();

                controle.ModPerso(personnel, lesServices, result);
                dgvPersonnel.RefreshEdit();
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }

        /// <summary>
        /// Après sélection d'une ligne et confirmation, Suppression du personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelPerso_Click(object sender, EventArgs e)
        {
            if (dgvPersonnel.SelectedRows.Count > 0)
            {
                Personnel personnel = (Personnel)bsPersonnel.List[bsPersonnel.Position];
                DialogResult dialogResult = MessageBox.Show("Souhaitez-vous vraiment supprimer " + personnel.Nom + " " + personnel.Prenom + "?", "Confirmez la suppression", MessageBoxButtons.OKCancel);
                if (dialogResult == DialogResult.OK)
                {
                    controle.SupprimerPersonnel(personnel);
                    foreach (DataGridViewRow item in dgvPersonnel.SelectedRows)
                    {
                        dgvPersonnel.Rows.Remove(item);
                    }
                    dgvPersonnel.RefreshEdit();
                }
            }
            else
            {
                MessageBox.Show("Vous devez selectionner un personnel");
            }
        }

    }
}
