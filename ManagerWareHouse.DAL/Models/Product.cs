using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManagerWareHouse.DAL.Reponsitories;

namespace ManagerWareHouse.DAL.Models
{
    [Table("Products")]
    public class Product : ModelConstruct
    {
        public int IDProduct { get; set; }
        public string CodeProduct { get; set; }
        public string NameProduct { get; set; }
        public string DescriptionProduct { get; set; }
        public string Avatar { get; set; } = String.Empty;
        public int? ProductPrice { get; set; } = 0;
        public int? ProductQuanlity { get; set; } = 0;
        public DateTime ProductDateOfManufacture { get; set; }
        public DateTime ProductExpirationDate { get; set; }

        public int IDCategory { get; set; }
        public int IDSupplier { get; set; }
        public int IDUnit { get; set; }
        public int IDWareHouse { get; set; }

        public virtual Category Category { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual Unit Unit { get; set; }
        public virtual WareHouse WareHouse { get; set; }

    }
}
