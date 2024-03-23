using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerWareHouse.DAL.Reponsitories.Constracts
{
    public interface IGenericReponsitory<T> where T: class
    {
        void Create(T _object);
        void Update(T _object);
        void Delete(T _object);
        Task<IEnumerable<T>> GetAll();
        T GetByID(int id);
        void SaveToDatabase();
    }
}
