using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entity_Framework
{
    public class EfCategoryDAL:GenericRepository<Category>,ICategoryDal
    {

    }
}
