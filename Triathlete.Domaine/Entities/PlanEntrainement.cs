using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triathlete.Domaine.Entities
{
    public class PlanEntrainement
    { 
        [Key, Column(Order = 1)]
        public int NumEntrainement { get; set; } //#
        [Key, Column(Order = 2)]
        public int NumLicence { get; set; }//#
        [Required]
        public int DistanceAParcourir { get; set; }
        public int DistanceParcourue { get; set; }
        public virtual Entrainement Entrainement { get; set; }
        public virtual Athlete Athlete{ get; set; }

    }
}
