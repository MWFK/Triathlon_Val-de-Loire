using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Triathlete.Domaine.Entities
{
    public enum CategoryAthlete { Benjamin, Cadet, Junior, Senior, Vétéran }
    public class Athlete
    {
        [Key]
        public int NumeroLicence { get; set; }        
        public string NomAthlete { get; set; }       
        public string PrenomAthlete { get; set; }
        public string Adresse { get; set; }       
        public DateTime DateNaissance { get; set; }
        public CategoryAthlete CategoryAthlete { get; set; }
        public virtual ICollection<PlanEntrainement> PlanEntrainements { get; set; }

    }
}