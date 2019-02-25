using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triathlete.Domaine.Entities;
using Triathlete.Service;

namespace Triathlete.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            IMyService Service = new MyService();

            Athlete athlete =new Athlete() {   //ou bien seed
                Adresse="California",
                CategoryAthlete=CategoryAthlete.Benjamin,
                DateNaissance=new DateTime(1992,01,01),
                NomAthlete = "DeBois",
                PrenomAthlete = "Jack",
                NumeroLicence = 123
            };
           
            Entrainement entrainement = new Entrainement() {
                DateEntrainement = new DateTime(2016,02,02),
                NombreSeance = 2,
                
            };

            Piscine piscine = new Piscine()
            {
                AdressePiscine="Paris",
                NomPiscine="Les champions",
                NumPiscine=123
            };
            Service.AddAthlete(athlete);
            Service.AddPiscine(piscine);
            Service.AddEntrainement(entrainement, 123);
            Service.AddPlan(athlete, new DateTime(2016,02,02),50);
            Service.Commit();
            Service.Dispose();
        }
    }
}
