using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Cargo.BussinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        void Insert(T entity);

        void Update(T entity);

        void Delete(int id);

        T GetById(int id);
        List<T> GetAll();
    }
}
