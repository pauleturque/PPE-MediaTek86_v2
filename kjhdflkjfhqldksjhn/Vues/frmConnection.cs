
using System;
using System.Windows.Forms;

namespace kjhdflkjfhqldksjhn
{
    public partial class frmConnection : Form
    {
        /// <summary>
        /// Déclaration de l'objet controle
        /// </summary>
        private Controle controle;

        /// <summary>
        /// Constructeur de la fenêtre de connexion
        /// </summary>
        /// <param name="controle"></param>
        public frmConnection(Controle controle)
        {
            InitializeComponent();
            this.controle = controle;
        }

        /// <summary>
        /// Remplacement des caratères du mot de passe par des étoiles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmConnection_Load(object sender, EventArgs e)
        {
            txtPwd.PasswordChar = '*';
        }

        /// <summary>
        /// Action permettant de valider la connexion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!txtLogin.Text.Equals("") && !txtPwd.Text.Equals(""))
            {
                if (!controle.AuthControl(txtLogin.Text, txtPwd.Text))
                {
                    MessageBox.Show("L'identifiant ou le mot de passe sont incorrects !");
                }
            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis !");
            }
        }
    }
}
