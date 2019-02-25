
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triathete.Data.Configuration;
using Triathlete.Domaine.Entities;

namespace Triathete.Data
{
    public class MyContext : DbContext
    {
        public MyContext() : base("Name=TriathlonDB")
        {
           Database.SetInitializer<MyContext>(new MyContextInitializer());
        }

        public DbSet<Entrainement> Entrainements { get; set; }
        public DbSet<Athlete> Athlete { get; set; }
        public DbSet<Piscine> Piscines { get; set; }
        //
        //public DbSet<PlanEntrainement> PlanEntrainement { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //If you want to remove all Convetions and work only with configuration :
            //  modelBuilder.Conventions.Remove<IncludeMetadataConvention>();
            modelBuilder.Configurations.Add(new EntrainementConfiguration());
            //modelBuilder.Configurations.Add(new Configuration());
            //modelBuilder.Configurations.Add(new AddressConfiguration());
            //modelBuilder.Conventions.Add(new DateTime2Convention());
        }

    }

    public class MyContextInitializer : DropCreateDatabaseIfModelChanges<MyContext>
    {
        protected override void Seed(MyContext context)
        {
            var listPiscine = new List<Piscine>{
            	new Piscine{NomPiscine="KIKI CARON" },
            	new Piscine{NomPiscine="LE CHAMPION" },
            	new Piscine{NomPiscine="LES SPORTIFS" },                   	
        	};

            context.Piscines.AddRange(listPiscine);
            context.SaveChanges();
        }
    }


}
