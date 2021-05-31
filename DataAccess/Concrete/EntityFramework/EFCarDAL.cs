using Core.Entities.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFCarDAL : EFEntityRepositoryBase<Car, RecapProjectContext>, ICarDAL
    {
        public List<CarDetailDTO> GetCarDetails()
        {
            using (RecapProjectContext context = new RecapProjectContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandID equals b.BrandID
                             join cl in context.Color
                             on c.ColorID equals cl.ColorID
                             select new CarDetailDTO
                             {
                                 BrandName = b.BrandName,
                                 ColorName = cl.ColorName,
                                 DailyPrice = c.DailyPrice,
                                 ModelYear = c.ModelYear
                             };

                return result.ToList();
            }
        }
    }
}
