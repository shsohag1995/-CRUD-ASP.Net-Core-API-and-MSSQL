using CRUD.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Infrastructure.BaseClass
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDatabaseFactory databaseFactory;
        private ApplicationDbContext dataContext;

        public UnitOfWork(IDatabaseFactory databaseFactory)
        {
            this.databaseFactory = databaseFactory;
        }

        protected ApplicationDbContext DataContext
        {
            get { return dataContext ?? (dataContext = databaseFactory.Get()); }
        }

        public void Commit()
        {
            try
            {
                DataContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<bool> CommitAsync()
        {
            try
            {
                await DataContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
        }


        public async Task<bool> CommitWithTransaction()
        {
            using (var trns = DataContext.Database.BeginTransaction())
            {
                try
                {
                    await DataContext.SaveChangesAsync();
                    trns.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    trns.Rollback();
                    throw ex;
                }
            }
        }

    }
}
