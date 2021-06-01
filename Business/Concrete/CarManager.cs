using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
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


        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDAL.GetAll());
        }

        public IDataResult<Car> GetById(int id)
        {
            return new SuccessDataResult<Car>(_carDAL.Get(c => c.CarID == id));
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int brandId)
        {
            return new SuccessDataResult<List<Car>>(_carDAL.GetAll(c => c.BrandID == brandId));
        }
        public IDataResult<List<CarDetailDTO>> GetCarDetails()
        {
            if (DateTime.Now.Hour == 17)
            {
                return new ErrorDataResult<List<CarDetailDTO>>(Messages.DetailErrorMsg);
            }
            return new SuccessDataResult<List<CarDetailDTO>>(_carDAL.GetCarDetails(),Messages.DetailMessage);
        }

        public IResult Add(Car car)
        {
            _carDAL.Add(car);
            return new SuccessResult();
        }

        public IResult Update(Car car)
        {
            _carDAL.Update(car);
            return new SuccessResult();
        }

        public IResult Delete(Car car)
        {
            _carDAL.Delete(car);
            return new SuccessResult();
        }
    }
}
