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
    public class CargoCustomerManager : GenericRepositoryService<CargoCustomer>, ICargoCustomerService
    {
        private readonly ICargoCustomerDal _cargoCustomerDal;
        public CargoCustomerManager(IGenericDal<CargoCustomer> genericDal, ICargoCustomerDal cargoCustomerDal)
            : base(genericDal)
        {
            _cargoCustomerDal = cargoCustomerDal;
        }

        public CargoCustomer GetCargoCustomerById(string id)
        {
            return _cargoCustomerDal.TGetCargoCustomerById(id);
        }
    }
}
