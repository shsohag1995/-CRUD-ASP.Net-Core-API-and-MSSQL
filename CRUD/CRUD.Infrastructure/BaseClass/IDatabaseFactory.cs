using CRUD.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Data.BaseClass
{
    public interface IDatabaseFactory : IDisposable
    {
        ApplicationDbContext Get();
    }
}
