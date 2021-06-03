using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kjhdflkjfhqldksjhn.Modele
{
    public class Services
    {
        /// <summary>
        /// propriétés correspondant aux champs de la table service
        /// </summary>
        private int idservice;
        private string nom;

        /// <summary>
        /// getters sur les propriétés
        /// </summary>
        public int IdService { get => idservice; }
        public string Name { get => nom; }

        /// <summary>
        /// constructeur valorisant les propriétés de la classe
        /// </summary>
        /// <param name="idservice"></param>
        /// <param name="nom"></param>
        public Services(int idservice, string nom)
        {
            this.idservice = idservice;
            this.nom = nom;
        }

        public override string ToString()
        {
            return nom;
        }
    }
}

