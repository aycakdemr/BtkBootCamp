using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public IResult Add(Product product)
        {
            _productDal.Add(product);
            return new SuccessResult();
        }

        public IDataResult<List<Product>> GetAll()
        { 
            return new SuccessDataResult<List<Product>>(_productDal.GetAll());

        }

        public IDataResult<List<Product>> GetAllByCategory(int id)
        {
             return new SuccessDataResult<List<Product>>(_productDal.GetAll(c=>c.CategoryId==id));
        }
    }
}
