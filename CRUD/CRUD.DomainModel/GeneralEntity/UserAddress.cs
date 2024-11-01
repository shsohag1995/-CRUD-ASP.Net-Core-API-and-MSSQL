using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.DomainModel.GeneralEntity
{
    public class UserAddress : BaseEntity
    {
        [Required(ErrorMessage = "Email is required.")]
        [StringLength(256, ErrorMessage = "User Address must be less than 256 characters.")]
        public string Name { get; set; }
    }
}
