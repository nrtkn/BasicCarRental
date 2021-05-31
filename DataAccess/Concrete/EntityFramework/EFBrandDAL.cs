using Core.Entities.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFBrandDAL : EFEntityRepositoryBase<Brand, RecapProjectContext>, IBrandDAL
    {
    }
}
