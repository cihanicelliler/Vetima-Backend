using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, ProductDbContext>, IProductDal
    {
        public List<ProductDetailDto> GetProductDetailDtos(Expression<Func<Product, bool>> filter = null)
        {
            using (ProductDbContext context = new ProductDbContext())
            {
                var result = from p in filter == null ? context.Products : context.Products.Where(filter)
                             join c in context.Categories
                             on p.CategoryId equals c.CategoryId
                             join img in context.ProductImages
                             on p.Id equals img.ProductId
                             select new ProductDetailDto
                             {
                                 Id = p.Id,
                                 ProductName = p.ProductName,
                                 CategoryName = c.CategoryName,
                                 DescriptionProduct = p.DescriptionProduct,
                                 DescriptionProduct2 = p.DescriptionProduct2,
                                 ImagePath = img.ImagePath
                             };
                return result.ToList();
            }
        }
    }
}

