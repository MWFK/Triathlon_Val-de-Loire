using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triathlete.Domaine.Entities;

namespace Triathete.Data.Configuration
{
    public class PlanEntrainementConfiguration: EntityTypeConfiguration<PlanEntrainement>
    {
        public PlanEntrainementConfiguration()
        {
            HasRequired(a => a.Athlete).WithMany(e => e.PlanEntrainements).WillCascadeOnDelete(true);
            HasRequired(a => a.Entrainement).WithMany(e => e.PlanEntrainements).WillCascadeOnDelete(true);
        }
        
    }
}
