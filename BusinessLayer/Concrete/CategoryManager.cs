﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetList()
        {
            return _categoryDal.List();
        }
        public void AddCategory(Category cat) 
        {
            if (cat.CategoryName=="" || cat.CategoryStatus==false || cat.CategoryName.Length<=2)
            {
                //hata mesajı
            }
            else
            {
                _categoryDal.Add(cat);
            }
        }

        public void CategoryAdd(Category category)
        {
            _categoryDal.Add(category);
        }
    }
}
