using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Entities
{
    public class TrademarkEntity : BaseEntity
    {
        [Column(TypeName = "varchar(75)")]
        [Display(Name = "Marca")]
        [Required(ErrorMessage = "El campo marca es obligatorio")]
        public string Name { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Display(Name = "Alias")]
        [Required(ErrorMessage = "El campo alias es obligatorio")]
        public string Alias { get; set; }

        public int CompanyId { get; set; }

        //propiedades de navegación
        public CompanyEntity Company { get; set; }
    }
}