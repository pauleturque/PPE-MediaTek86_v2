using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kjhdflkjfhqldksjhn.Modele
{
    public class Absences
    {

        /// <summary>
        /// Propriétés correspondant aux champs de la table absence
        /// </summary>
        private int idpersonnel;
        private int idmotif;
        private DateTime datedebut;
        private DateTime datefin;


        /// <summary>
        /// getters et setters sur les propriétés de la classe
        /// </summary>
        public int IdPersonnel { get => idpersonnel; }
        public int IdMotif { get => idmotif; set => idmotif = value; }
        public DateTime DateDebut { get => datedebut; set => datedebut = value; }
        public DateTime DateFin { get => datefin; set => datefin = value; }




        /// <summary>
        /// constructeur valorisant les propriétés de la classe
        /// </summary>
        /// <param name="idpersonnel"></param>
        /// <param name="idmotif"></param>
        /// <param name="datedebut"></param>
        /// <param name="datefin"></param>
        public Absences(int idpersonnel, int idmotif, DateTime datedebut, DateTime datefin)
        {
            this.idmotif = idmotif;
            this.idpersonnel = idpersonnel;
            this.datedebut = datedebut;
            this.datefin = datefin;
        }
    }
}

