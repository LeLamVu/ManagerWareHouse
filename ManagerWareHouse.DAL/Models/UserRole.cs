using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerWareHouse.DAL.Models
{
    [Table("UserRole")]
    public class UserRole
    {
        public int IDUserRole { get; set; }

        public int IDUser { get; set; }
        public virtual User User { get; set; }

        public int IDRole { get; set; }
        public virtual Role Role { get; set; }
    }
}
