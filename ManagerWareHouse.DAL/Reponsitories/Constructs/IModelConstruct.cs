using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerWareHouse.DAL.Reponsitories.Constracts
{
    public interface IModelConstruct
    {
        DateTime CreateAt { get; set; }
        DateTime? UpdateAt { get; set; }
    }
}
