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
    public partial class frmAjoutAbsence : Form
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
        /// Initialisation de la source de données de la liste des motifs
        /// </summary>
        BindingSource bsMotifs = new BindingSource();
        /// <summary>
        /// Déclaration de l'objet absences
        /// </summary>
        private Absences absence;

        /// <summary>
        /// Constructeur du formulaire d'ajout d'une absence
        /// </summary>
        /// <param name="controle"></param>
        /// <param name="personnel"></param>
        public frmAjoutAbsence(Controle controle, Personnel personnel)
        {
            InitializeComponent();
            this.controle = controle;
            this.personnel = personnel;
            InitialiseMotifs();
        }

        /// <summary>
        /// Méthode permettant de récupérer et d'afficher la liste de motifs d'absences
        /// </summary>
        public void InitialiseMotifs()
        {
            List<Motif> motifs = controle.ListMotifs;
            bsMotifs.DataSource = motifs;

            var result = (from motif in motifs
                          select new
                          {
                              motif.Libelle,
                          }).ToList();

            cbMotif.DataSource = result;
            cbMotif.SelectedItem = result.First();
        }

        /// <summary>
        /// Personnalisation de la fenêtre avec l'identité du personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAjoutModifAbsence_Load(object sender, EventArgs e)
        {
            this.Text += personnel.Nom + " " + personnel.Prenom;

        }

        /// <summary>
        /// Action permettant de valider l'ajout d'une absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnValiderAbsence_Click(object sender, EventArgs e)
        {
            if (dateDebut.Value.Date > dateFin.Value.Date)
            {
                MessageBox.Show("La date de début d'absence doit être supérieure à celle de fin");
            }
            else
            {
                try
                {
                    absence = new Absences(personnel.IdPersonnel, cbMotif.SelectedIndex, dateDebut.Value, dateFin.Value);
                    controle.AjouterAbsences(absence, personnel);
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
        /// Action permettant l'annulation de l'ajout d'une absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnulerAbsence_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
