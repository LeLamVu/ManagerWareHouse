using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManagerWareHouse.DAL.Reponsitories.Constracts;
using ManagerWareHouse.DAL.DataContext;
using Microsoft.EntityFrameworkCore;

namespace ManagerWareHouse.DAL.Reponsitories
{
    public class GenericReponsitory<T> : IGenericReponsitory<T> where T: class
    {
        // tạo một biến đại diện cho DbContext với private 
        private ManagerWareHouseContext _context = null;
        // tạo một biến đại diện cho một bảng dữ liệu
        private DbSet<T> _table = null;
        // constructor not parameter
        public GenericReponsitory()
        {
            this._context = new ManagerWareHouseContext();
            this._table = _context.Set<T>();
        }
        // constructor with parameter
        public GenericReponsitory(ManagerWareHouseContext context)
        {
            this._context = context;
            this._table = _context.Set<T>();
        }

        public void Create(T _object)
        {
            _table.Add(_object);
        }

        public void Update(T _object)
        {
            // gán một object mới
            _table.Attach(_object);
            _context.Entry(_object).State = EntityState.Modified;
        }

        public void Delete(T _object)
        {
            T obj = _table.Find(_object);
            _table.Remove(obj);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _table.ToListAsync();
        }
        public T GetByID(int id)
        {
            return _table.Find(id);
        }

        public void SaveToDatabase()
        {
            _context.SaveChanges();
        }
    }
}
