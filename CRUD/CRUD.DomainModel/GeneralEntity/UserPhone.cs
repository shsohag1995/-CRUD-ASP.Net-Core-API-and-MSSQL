using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.DomainModel.GeneralEntity
{
    public class UserPhone : BaseEntity
    {
        [Required(ErrorMessage = "Email is required.")]
        [StringLength(20, ErrorMessage = "User phone must be less than 20 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "GeneralType is required.")]
        public Int16 GeneralTypeId { get; set; }
        public GeneralType GeneralType { get; set; }
    }
}
