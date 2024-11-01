using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.DomainModel.GeneralEntity
{
    public class UserInfo
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public string? Image { get; set; }
        public string? RefUserId { get; set; }
        public string? ParentUserId { get; set; }
        public string? GParentUserId { get; set; }
        public int UserTypeId { get; set; }
        public UserType UserType { get; set; }
       
    }
}
