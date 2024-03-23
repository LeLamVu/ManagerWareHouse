using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManagerWareHouse.DAL.Reponsitories;

namespace ManagerWareHouse.DAL.Models
{
    [Table("Attributes")]
    public class Attributes : ModelConstruct
    {
        public int IDAttribute { get; set; }
        public string NameAttribute { get; set; }
        public string DescriptionAttribute { get; set; } = String.Empty;
    }
}
