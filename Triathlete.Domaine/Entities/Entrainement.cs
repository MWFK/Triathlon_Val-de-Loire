using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triathlete.Domaine.Entities
{
    public class Entrainement
    {
        [Key]
        public int NumEntrainement { get; set; }
        public DateTime DateEntrainement { get; set; }
        public int NombreSeance { get; set; }

        public int DistanceAParcourir { get; set; }
        public int NumPiscine { get; set; }
        [ForeignKey("NumPiscine")]
        public virtual Piscine Piscine { get; set; }

        public virtual ICollection<PlanEntrainement> PlanEntrainements { get; set; }
    }
}
