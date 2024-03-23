using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManagerWareHouse.DAL.Reponsitories;

namespace ManagerWareHouse.DAL.Models
{
    [Table("Unit")]
    public class Unit: ModelConstruct
    {
        public int IDUnit { get; set; }
        public string NameUnit { get; set; }
        public string DescriptionUnit { get; set; } = String.Empty;

        public virtual IEnumerable<Product> Products { get; set; }
    }
}
