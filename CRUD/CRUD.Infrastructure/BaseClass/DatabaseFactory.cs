using CRUD.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Data.BaseClass
{
    public class DatabaseFactory : Disposable, IDatabaseFactory
    {
        private ApplicationDbContext dataContext;
        public ApplicationDbContext Get()
        {
            return dataContext ?? (dataContext = new ApplicationDbContext());
        }
        protected override void DisposeCore()
        {
            if (dataContext != null)
                dataContext.Dispose();
        }
    }
}
