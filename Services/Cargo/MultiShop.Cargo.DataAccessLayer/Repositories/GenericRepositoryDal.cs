using MultiShop.Cargo.DataAccessLayer.Abstract;
using MultiShop.DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Cargo.DataAccessLayer.Repositories
{
    public class GenericRepositoryDal<T> : IGenericDal<T> where T : class
    {
        private readonly CargoContext _context;
        public GenericRepositoryDal(CargoContext context)
        {
            _context = context;
        }
        public void TDelete(int id)
        {
            var values = _context.Set<T>().Find(id);
            _context.Set<T>().Remove(values);
            _context.SaveChanges();
        }
        public List<T> TGetAll()
        {
            var values = _context.Set<T>().ToList();
            return values;
        }
        public T TGetById(int id)
        {
            var value = _context.Set<T>().Find(id);
            return value;
        }
        public void TInsert(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }
        public void TUpdate(T entity)
        {
            _context.Set<T>().Update(entity);
            _context.SaveChanges();
        }
    }
}
