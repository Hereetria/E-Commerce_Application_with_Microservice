using MultiShop.Cargo.BussinessLayer.Abstract;
using MultiShop.Cargo.BussinessLayer.Repository;
using MultiShop.Cargo.DataAccessLayer.Abstract;
using MultiShop.Cargo.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Cargo.BussinessLayer.Concrete
{
    public class CargoOperationManager : GenericRepositoryService<CargoOperation>, ICargoOperationService
    {
        public CargoOperationManager(IGenericDal<CargoOperation> genericDal) 
            : base(genericDal)
        {
        }
    }
}
