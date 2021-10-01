using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Entities
{
    public class OwnerEntity : BaseEntity
    {
        [Column(TypeName = "varchar(75)")]
        [Display(Name = "Nombre completo")]
        [Required(ErrorMessage = "El campo nombre es obligatorio")]
        public string Name { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Display(Name = "Email")]
        [Required(ErrorMessage = "El campo email es obligatorio")]
        public string Email { get; set; }

        //propiedades de navegación
        public List<CompanyEntity> Companies { get; set; }
    }
}
