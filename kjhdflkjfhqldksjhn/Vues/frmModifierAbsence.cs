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
    public partial class frmModifierAbsence : Form
    {
        /// <summary>
        /// Déclaration de l'objet controle
        /// </summary>
        private Controle controle;
        /// <summary>
        /// Déclaration de l'objet absence
        /// </summary>
        private Absences absences;
        /// <summary>
        /// Déclaration de l'objet personnel
        /// </summary>
        private Personnel personnel;
        /// <summary>
        /// Initialisation de la source de données des motifs d'absences
        /// </summary>
        BindingSource bsMotifs = new BindingSource();

        /// <summary>
        /// Constructeur de la fenêtre de modification des absences
        /// </summary>
        /// <param name="controle"></param>
        /// <param name="absences"></param>
        /// <param name="personnel"></param>
        public frmModifierAbsence(Controle controle, Absences absences, Personnel personnel)
        {
            InitializeComponent();
            this.controle = controle;
            this.absences = absences;
            this.personnel = personnel;
            InitialiseAbsenceAmodifier(personnel, absences);
        }

        /// <summary>
        /// Méthode permettant de récupérer l'absence à modifier et de remplir les champs selon l'objet
        /// </summary>
        /// <param name="personnel"></param>
        /// <param name="absences"></param>
        public void InitialiseAbsenceAmodifier(Personnel personnel, Absences absences)
        {
            dateDebut.Value = absences.DateDebut;
            dateFin.Value = absences.DateFin;

            List<Motif> motifs = controle.ListMotifs;
            bsMotifs.DataSource = motifs;

            List<Absences> lesAbsences = controle.ListAbsences;


            var result = (from absence in lesAbsences
                          where absence.IdPersonnel == personnel.IdPersonnel
                          join motif in motifs
                          on absence.IdMotif equals motif.IdMotif
                          select new
                          {
                              motif.Libelle,
                          }).ToList();

            cbMotif.DataSource = result;
            cbMotif.SelectedItem = result.First();
        }

        /// <summary>
        /// Action permettant de valider la modification d'une absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnValider_Click(object sender, EventArgs e)
        {
            controle.ModifierAbsence(absences, personnel);
            Close();
        }

        /// <summary>
        /// Actcion permettant d'annuler la modification d'une absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
