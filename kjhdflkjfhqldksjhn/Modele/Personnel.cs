using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kjhdflkjfhqldksjhn.Modele
{
    public class Personnel
    {
        /// <summary>
        /// propriétés correspondant aux champs de la table
        /// </summary>
        private int idpersonnel;
        private int idservice;
        private string nom;
        private string prenom;
        private string tel;
        private string mail;
        

        /// <summary>
        /// getters et setters sur les propriétés de la classe personnel
        /// </summary>
        public int IdPersonnel { get => idpersonnel; set => idpersonnel = value; }
        public int IdService { get => idservice; set => idservice = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Mail { get => mail; set => mail = value; }


        /// <summary>
        /// constructeur valorisant les propriétés
        /// </summary>
        /// <param name="idpersonnel"></param>
        /// <param name="idservice"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="tel"></param>
        /// <param name="mail"></param>
        public Personnel(int idpersonnel, int idservice, string nom, string prenom, string tel, string mail)
        {
            this.idservice = idservice;
            this.idpersonnel = idpersonnel;
            this.nom = nom;
            this.prenom = prenom;
            this.tel = tel;
            this.mail = mail;
        }

        /*public override string ToString()
        {
            return nom + " " + prenom + " " + tel + " " + mail;
        }*/
    }
}

