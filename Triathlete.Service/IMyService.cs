
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triathlete.Domaine.Entities;

namespace Triathlete.Service
{
    public interface IMyService
    {
        //Entrainement GetEntrainement(DateTime date); private
        void AddAthlete(Athlete Athlete);
        void AddPiscine(Piscine Piscine);
        void AddEntrainement(Entrainement Entrainement,int IdPiscine);
        
        void AddPlan(Athlete athlete, DateTime date, int distance);
        void Commit();
        void Dispose();
    }
}
