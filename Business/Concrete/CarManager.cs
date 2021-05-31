using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDAL _carDAL;

        public CarManager(ICarDAL carDAL)
        {
            _carDAL = carDAL;
        }


        public List<Car> GetAll()
        {
            return _carDAL.GetAll();
        }

        public Car GetById(int id)
        {
            return _carDAL.Get(c => c.CarID == id);
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            return _carDAL.GetAll(c => c.BrandID == brandId);
        }
        public List<CarDetailDTO> GetCarDetails()
        {
            return _carDAL.GetCarDetails();
        }

        public void Add(Car car)
        {
            _carDAL.Add(car);
        }

        public void Update(Car car)
        {
            _carDAL.Update(car);
        }

        public void Delete(Car car)
        {
            _carDAL.Delete(car);
        }
    }
}
