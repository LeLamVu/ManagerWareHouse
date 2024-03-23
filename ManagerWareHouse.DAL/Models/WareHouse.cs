using ManagerWareHouse.DAL.Reponsitories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerWareHouse.DAL.Models
{
    [Table("WareHouses")]
    public class WareHouse: ModelConstruct
    {
        public int IDWareHouse { get; set; }
        public string NameWareHouse { get; set; }
        public string AdressWareHouse { get; set; }
        public string PhoneWareHouse { get; set; }
        public string DescriptionWareHouse { get; set; } = String.Empty;

        public virtual IEnumerable<Product> Products { get; set; }
    }
}
