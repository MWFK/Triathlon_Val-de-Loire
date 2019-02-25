using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triathlete.Domaine.Entities
{
    public class Piscine
    {
        [Key]
        public int NumPiscine { get; set; }
        public string NomPiscine { get; set; }
        public string AdressePiscine { get; set; }
        public virtual ICollection<Entrainement> Entrainements { get; set; }
}
}
