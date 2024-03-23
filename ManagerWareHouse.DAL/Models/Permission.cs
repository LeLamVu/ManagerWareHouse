using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerWareHouse.DAL.Models
{
    [Table("Permission")]
    public class Permission
    {
        public int IDPermission { get; set; }
        public string NamePermission { get; set; }
    }
}
