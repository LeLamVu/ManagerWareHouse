using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManagerWareHouse.DAL.Reponsitories;

namespace ManagerWareHouse.DAL.Models
{
    [Table("Supplier")]
    public class Supplier : ModelConstruct
    {
        public int IDSupplier { get; set; }
        public string NameSupplier { get; set; }
        public string AddressSupplier { get; set; }
        public string PhoneSupplier { get; set; }
        public string ImageSupplier { get; set; } = String.Empty;

        public virtual IEnumerable<Product> Products { get; set; }
    }
}
