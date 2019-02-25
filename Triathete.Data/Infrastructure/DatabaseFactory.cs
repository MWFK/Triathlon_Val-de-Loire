using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triathete.Data.Infrastructure
{
    public class DatabaseFactory : Disposable, IDatabaseFactory
    {
        private MyContext dataContext;
        public MyContext DataContext { get { return dataContext; } }

        public DatabaseFactory()
        {
            dataContext = new MyContext();
        }
        protected override void DisposeCore()//libérer l'espace mémoire du contexte
        {
            if (DataContext != null)
                DataContext.Dispose();
        }
    }

}
