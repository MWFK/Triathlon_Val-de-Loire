using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Data.Infrastructure
{
    public class DatabaseFactory : Disposable, IDatabaseFactory
    {
        private MyFinanceContext dataContext;
        public MyFinanceContext DataContext { get { return dataContext; } }

        public DatabaseFactory()
        {
            dataContext = new MyFinanceContext();
        }
        protected override void DisposeCore()//libérer l'espace mémoire du contexte
        {
            if (DataContext != null)
                DataContext.Dispose();
        }
    }

}
