using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerWareHouse.DAL.Models
{
    [Table("Role")]
    public class Role
    {
        public int IDRole { get; set; }
        public string NameRole { get; set; }
    }
}
