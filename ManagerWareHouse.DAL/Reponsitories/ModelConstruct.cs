using ManagerWareHouse.DAL.Reponsitories.Constracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerWareHouse.DAL.Reponsitories
{
    public class ModelConstruct : IModelConstruct
    {
        public DateTime CreateAt { get; set; }
        public DateTime? UpdateAt { get; set; }
    }
}
