using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerWareHouse.DAL.Models
{
    [Table("Role")]
    public class Role : IdentityRole
    {
        public int IDRole { get; set; }
        public string NameRole { get; set; }
    }
}
