using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Entities
{
    public class CompanyEntity : BaseEntity
    {
        [Column(TypeName ="varchar(75)")]
        [Display(Name = "Nombres")]
        [Required(ErrorMessage = "El campo nombres es obligatorio")]
        public string Name { get; set; }

        [Column(TypeName = "varchar(75)")]
        [Display(Name = "Direccion")]
        [Required(ErrorMessage = "El campo dirección es obligatorio")]
        public string Address { get; set; }

        [Column(TypeName = "varchar(6)")]
        [Display(Name = "Código postal")]
        [Required(ErrorMessage = "El campo código postal es obligatorio")]
        public string ZipCode { get; set; }

        [Column(TypeName = "varchar(25)")]
        [Display(Name = "Cuenta bancaria")]
        [Required(ErrorMessage = "El campo cuenta bancaria es obligatorio")]
        public string BankAccount { get; set; }

        //FK
        public int OwnerId { get; set; }
        public int CompanyTypeId { get; set; }

        //Navigation properties
        public List<TrademarkEntity> Trademarks { get; set; }
        public OwnerEntity Owner { get; set; }
        public CompanyTypeEntity CompanyType { get; set; }

        
    }
}
