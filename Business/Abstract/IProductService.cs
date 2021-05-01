using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll();
        IDataResult<List<Product>> GetProductsByCategoryId(int id);
        IResult AddProduct(Product product);
        IResult DeleteProduct(Product product);
        IResult UpdateProduct(Product product);
        IDataResult<List<Product>> GetById(int productId);
        IDataResult<List<ProductDetailDto>> GetProductDetails();
    }
}
