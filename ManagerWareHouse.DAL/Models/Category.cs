using ManagerWareHouse.DAL.Reponsitories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerWareHouse.DAL.Models
{
    [Table("Categories")]
    public class Category : ModelConstruct
    {
        public int IDCategory { get; set; }
        public string NameCategory { get; set; }
        public string DescriptionCategory { get; set; } = String.Empty;

        public virtual IEnumerable<Product> Products { get; set; }
    }
}
