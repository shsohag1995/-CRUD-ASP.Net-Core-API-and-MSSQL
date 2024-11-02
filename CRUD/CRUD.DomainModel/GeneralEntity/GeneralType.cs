using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.DomainModel.GeneralEntity
{
    public class GeneralType
    {
        [Key]
        public Int16 Id { get; set; }
        [Required(ErrorMessage = "General Type is required.")]
        public string Name { get; set; }
    }
}
