using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.DomainModel.GeneralEntity
{
    public class UserEmail:BaseEntity
    {
        [Required(ErrorMessage = "User is required.")]
        public int UserId { get; set; }
        public User User { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        [StringLength(150, ErrorMessage = "Email must be less than 150 characters.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "GeneralType is required.")]
        public Int16 GeneralTypeId { get; set; }
        public GeneralType GeneralType { get; set; }



    }
}
