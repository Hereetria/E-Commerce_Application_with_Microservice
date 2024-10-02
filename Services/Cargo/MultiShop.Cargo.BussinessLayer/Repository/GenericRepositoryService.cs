using MultiShop.Cargo.BussinessLayer.Abstract;
using MultiShop.Cargo.DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Cargo.BussinessLayer.Repository
{
    public class GenericRepositoryService<T> : IGenericService<T> where T : class
    {
        private readonly IGenericDal<T> _genericDal;

        public GenericRepositoryService(IGenericDal<T> genericDal)
        {
            _genericDal = genericDal;
        }

        public void Delete(int id)
        {
            _genericDal.TDelete(id);
        }

        public List<T> GetAll()
        {
            return _genericDal.TGetAll();
        }

        public T GetById(int id)
        {
            return _genericDal.TGetById(id);
        }

        public void Insert(T entity)
        {
            _genericDal.TInsert(entity);
        }

        public void Update(T entity)
        {
            _genericDal.TUpdate(entity);
        }
    }
}
