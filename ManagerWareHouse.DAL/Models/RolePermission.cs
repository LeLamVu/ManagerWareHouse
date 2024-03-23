using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerWareHouse.DAL.Models
{
    [Table("RolePermission")]
    public class RolePermission
    {
        public int IDRolePermission { get; set; }
        
        public int IDRole { get; set; }
        public virtual Role Role { get; set; }

        public int IDPermission { get; set; }
        public virtual Permission Permission { get; set; }
    }
}
