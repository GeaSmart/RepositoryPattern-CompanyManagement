using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    public class TrademarkEntity : BaseEntity
    {
        public string Name { get; set; }
        public string Alias { get; set; }
        public int CompanyId { get; set; }

        //propiedades de navegación
        public CompanyEntity Company { get; set; }
    }
}
