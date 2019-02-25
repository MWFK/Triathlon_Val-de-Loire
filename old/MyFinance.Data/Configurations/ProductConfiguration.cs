using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFinance.Domain.Entities;

namespace MyFinance.Data.Configurations
{
    public class ProductConfiguration : EntityTypeConfiguration<Product>
	{
    	public ProductConfiguration()
        {
            //properties configuration
            Property(e => e.Description).HasMaxLength(200).IsOptional();

            //Many to Many configuration
            HasMany(p => p.Providers)
            .WithMany(v => v.Products)
            .Map(m =>
            {
                m.ToTable("Providings");   //Table d'association
                m.MapLeftKey("Product");
                m.MapRightKey("Provider");
             });

            //Inheritance
            Map<Biological>(c =>
            {
                c.Requires("IsBiological").HasValue(1);  //isBiological is the descreminator
            });
            Map<Chemical>(c =>
            {
                c.Requires("IsBiological").HasValue(0);
            });

            //One To Many
            HasOptional(p => p.Category)   // 0,1..*   //if you need 1..* use HasRequired()
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryId)
                .WillCascadeOnDelete(false);
        }
    }

}
