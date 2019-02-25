using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triathlete.Domaine.Entities;

namespace Triathete.Data.Configuration
{
    public class EntrainementConfiguration : EntityTypeConfiguration<Entrainement>
    {
        public EntrainementConfiguration()
        {
            //one to many
            HasRequired(p => p.Piscine)   // 0,1..*   //if you need 1..* use HasRequired()
               .WithMany(c => c.Entrainements)
               .HasForeignKey(p => p.NumPiscine)
               .WillCascadeOnDelete(false);
        }
       
    }
}
