﻿using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
        List<ProductDetailDto> GetProductDetailDtos(Expression<Func<Product, bool>> filter = null);
        List<ProductDetailDto> GetProductDetailDtosByCategoryId(int categoryId);
        List<ProductDetailDto> GetProductDetailDtosById(int id);
    }
}
