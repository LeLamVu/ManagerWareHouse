using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerWareHouse.DAL.Models
{
    [Table("ProductAttributes")]
    public class ProductAttribute
    {
        public int IDProductAttribute { get; set; }
        public int IDProduct { get; set; }
        public int IDAttribute { get; set; }
        public string ValueAttribute { get; set; }
        public string URLAttribute { get; set; } = String.Empty;
    }
}
