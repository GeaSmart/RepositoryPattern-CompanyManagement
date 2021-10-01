using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Entities
{
    public class CompanyTypeEntity : BaseEntity
    {
        [Column(TypeName = "varchar(50)")]
        [Display(Name = "Tipo de compañía")]
        [Required(ErrorMessage = "El campo tipo de compañía es obligatorio")]
        public string Name { get; set; }

        //Navigation properties
        public List<CompanyEntity> Companies { get; set; }
    }
}
