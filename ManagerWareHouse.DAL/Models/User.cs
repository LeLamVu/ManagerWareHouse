using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerWareHouse.DAL.Models
{
    [Table("User")]
    public class User
    {
        public int IDUser { get; set; }
        public string NameUser { get; set; }
        public string AddressUser { get; set; }
        public DateTime? BirthdayUser { get; set; }
        public string PhoneUser { get; set; }
        public string Avatar { get; set; } = String.Empty;
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public int? IDWareHouse { get; set; }
        public int IDRole { get; set; }

        public virtual WareHouse WareHouse { get; set; } = null;
        public virtual Role Role { get; set; }
        
    }
}
