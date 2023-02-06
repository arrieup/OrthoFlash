using System;
using System.Collections.Generic;
using System.Text;

namespace OrthoFlash.classes
{
    public class Patient
    {
        private int id;
        public String nom { get; private set; }
        public String prenom { get; private set; } 
        public String nom_complet { get; private set; }
        public DateTime date_naissance { get; private set; }
        public Classe classe { get; private set; }

        public Patient() { }
        public Patient(String nom, String prenom)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.nom_complet = nom + ' ' + prenom;
        }
        public Patient(String nom, String prenom, DateTime date_naissance, Classe classe)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.nom_complet = nom + ' ' + prenom;
            this.date_naissance = date_naissance;
            this.classe = classe;
        }
     }
}
