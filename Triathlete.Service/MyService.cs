
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triathete.Data.Infrastructure;
using System.Linq.Expressions;
using Triathlete.Domaine.Entities;

namespace Triathlete.Service
{
    public class MyService : IMyService
    {
        private static IDatabaseFactory dbf = new DatabaseFactory();
        private static IUnitOfWork ut = new UnitOfWork(dbf);
        public MyService()
        {

        }
        public void AddEntrainement(Entrainement entrainement, int IdPiscine)
        {
            entrainement.NumPiscine = IdPiscine;
            ut.getRepository<Entrainement>().Add(entrainement);
        }
        public void AddAthlete(Athlete Athlete)
        {
            ut.getRepository<Athlete>().Add(Athlete);
        }
        public void AddPiscine(Piscine Piscine)
        {
            ut.getRepository<Piscine>().Add(Piscine);
        }
        private Entrainement GetEntrainement(DateTime date)
        {
            return ut.getRepository<Entrainement>().Get(e=>e.DateEntrainement == date);
        }
        public void AddPlan(Athlete athlete, DateTime date, int distance)
        {
            Entrainement entrainement = GetEntrainement(date);

            if (entrainement != null)
            {
                PlanEntrainement plan = new PlanEntrainement()
                {
                    NumEntrainement = entrainement.NumEntrainement,
                    NumLicence = athlete.NumeroLicence,
                    DistanceAParcourir = distance
                };
                ut.getRepository<PlanEntrainement>().Add(plan);
            }
        }
        public void Commit()
        {
            ut.Commit();
        }
        public void Dispose()
        {
            ut.Dispose();
        }
        
    }
}
