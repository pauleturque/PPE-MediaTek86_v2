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
    public partial class frmAbsences : Form
    {
        /// <summary>
        /// Déclaration de l'objet controle
        /// </summary>
        private Controle controle;
        /// <summary>
        /// Déclaration de l'objet personnel
        /// </summary>
        public Personnel personnel;
        /// <summary>
        /// Déclaration de l'objet absences
        /// </summary>
        private List<Absences> absences;

        /// <summary>
        /// Initialisation de la source de données des absences
        /// </summary>
        BindingSource bsAbsences = new BindingSource();
        /// <summary>
        /// Initialisation de la source de données des motifs d'absences
        /// </summary>
        BindingSource bsMotifs = new BindingSource();

        /// <summary>
        /// Constructeur du formulaire absences
        /// </summary>
        /// <param name="controle"></param>
        /// <param name="personnel"></param>
        public frmAbsences(Controle controle, Personnel personnel)
        {
            InitializeComponent();
            this.controle = controle;
            this.personnel = personnel;
            bsAbsences.DataSource = controle.ListAbsences;
            dgvAbsences.DataSource = bsAbsences;
            InitDatasAbsences(personnel);
        }

        /// <summary>
        /// Fonction permettant de récupérer l'absence selectionnée dans la liste
        /// </summary>
        /// <returns>Absence selectionnée</returns>
        public Absences RecupAbsence()
        {
            Absences absence = (Absences)bsAbsences.List[bsAbsences.Position];
            return absence;
        }

        public void RefreshAbsences()
        {
            bsAbsences.ResetBindings(false);
        }
        
        /// <summary>
        /// Méthode de remplissage de la liste des absences
        /// </summary>
        /// <param name="personnel"></param>
        public void InitDatasAbsences(Personnel personnel)
        {
            absences = controle.ListAbsences;
            Absences absencee = RecupAbsence();
            List<Motif> motifs = controle.ListMotifs;
            bsMotifs.DataSource = motifs;


            var result = (from absence in absences
                          where absence.IdPersonnel == personnel.IdPersonnel
                          join motif in motifs
                          on absence.IdMotif equals motif.IdMotif
                          select new {
                          motif.Libelle, absence.DateDebut, absence.DateFin }).ToList();

            dgvAbsences.DataSource = result;
        }

        /// <summary>
        /// Personnalisation de la fenêtre avec l'identité du personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAbsences_Load(object sender, EventArgs e)
        {
            this.Text += personnel.Nom + personnel.Prenom;
        }

        /// <summary>
        /// Action permettant d'ouvrir la fenêtre absences
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjoutAbsence_Click(object sender, EventArgs e)
        {
            controle.OuvrirAjoutAbsence(personnel);
        }

        /// <summary>
        /// Action permettant la suppression d'une absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimerAbsence_Click(object sender, EventArgs e)
        {
            if (dgvAbsences.SelectedRows.Count > 0)
            {
                Absences absence = (Absences)bsAbsences.List[bsAbsences.Position];
                DialogResult dialogResult = MessageBox.Show("Souhaitez-vous vraiment supprimer l'absence de " + personnel.Nom + " " + personnel.Prenom + "?", "Confirmez la suppression", MessageBoxButtons.OKCancel);
                if (dialogResult == DialogResult.OK)
                {
                    controle.SupprimerAbsence(absence, personnel);
                }
                dgvAbsences.RefreshEdit();

            }
            else
            {
                MessageBox.Show("Vous devez selectionner un absence");
            }
        }

        /// <summary>
        /// Action permettant la modification d'une absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifierAbsence_Click(object sender, EventArgs e)
        {
            if (dgvAbsences.SelectedRows.Count > 0)
            {
                Absences absence = (Absences)bsAbsences.List[bsAbsences.Position];
                controle.OuvrirAbsenseAmodifier(absence, personnel);
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }
    }
}
