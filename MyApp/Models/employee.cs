using System.ComponentModel.DataAnnotations;


namespace Myapp.Models
{
    public class employee
    {
        [Key]
        public decimal Nr_Personne { get; set; }
        public string Nom_Prenom { get; set; }
        public bool Activer { get; set; }
        public int Matricule { get; set; } 
        public string Nom_Groupe { get; set; } 
        public decimal Nr_Groupe { get; set; } 
        public bool Technicien { get; set; }
    }
}
