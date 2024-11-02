using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.DomainModel.GeneralEntity
{
    public class User:BaseEntity
    {
        [Required(ErrorMessage = "User unique Id is required.")]
        [StringLength(100, MinimumLength = 4, ErrorMessage = "User unique Id must be at least 4 characters long.")]
        public string UId { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [StringLength(256, MinimumLength = 1, ErrorMessage = "Password must be at least 1 characters long.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [StringLength(100, MinimumLength = 4, ErrorMessage = "Password must be at least 4 characters long.")]
        public string Password { get; set; }
        public string? Image { get; set; }
        public string? FirstRefUserId { get; set; }
        public string? SecondRefUserId { get; set; }
        public string? ThirdRefUserId { get; set; }
        public Int16 UserTypeId { get; set; } = 3;
        public UserType UserType { get; set; }
    }
}
