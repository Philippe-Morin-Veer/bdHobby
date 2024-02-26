using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfa_hobby
{
    internal class Etudiants
    {
        private int no_etudiants;
        private string prenom;
        private string nom;
        private string cellulaire;
        private int humour;
        private int no_provenance;
        

        public int No_etudiants { get => no_etudiants; set => no_etudiants = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Cellulaire { get => cellulaire; set => cellulaire = value; }
        public int Humour { get => humour; set => humour = value; }
        public int No_provenance { get => no_provenance; set => no_provenance = value; }
    }
}
