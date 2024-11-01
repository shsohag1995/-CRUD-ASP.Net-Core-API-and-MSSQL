using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.DomainModel.GeneralEntity
{
    public class UserAccount
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public string UserAccountId { get; set; }
        public int Currency { get; set; }
    }
}
