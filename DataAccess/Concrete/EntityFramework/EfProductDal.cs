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
                                 CategoryId= c.CategoryId,
                                 ProductName = p.ProductName,
                                 ProductName_EN = p.ProductName_EN,
                                 CategoryName = c.CategoryName,
                                 CategoryName_EN = c.CategoryName_EN,
                                 DescriptionProduct = p.DescriptionProduct,
                                 DescriptionProduct2 = p.DescriptionProduct2,
                                 DescriptionProduct_EN = p.DescriptionProduct_EN,
                                 DescriptionProduct2_EN = p.DescriptionProduct2_EN,
                                 ImagePath_1 = img.ImagePath_1,
                                 ImagePath_2 = img.ImagePath_2,
                                 ImagePath_3 = img.ImagePath_3,
                                 ImagePath_4 = img.ImagePath_4,
                                 ImagePath_5 = img.ImagePath_5,
                                 ImagePath_6 = img.ImagePath_6,
                                 ImagePath_7 = img.ImagePath_7,
                                 ImagePath_8 = img.ImagePath_8,
                                 ImagePath_9 = img.ImagePath_9,
                                 ImagePath_10 = img.ImagePath_10
                             };
                return result.ToList();
            }
        }
        public List<ProductDetailDto> GetProductDetailDtosByCategoryId(int categoryId)
        {
            using (ProductDbContext context = new ProductDbContext())
            {
                var result = from p in context.Products.Where(p=>p.CategoryId==categoryId)
                             join c in context.Categories
                             on p.CategoryId equals c.CategoryId
                             join img in context.ProductImages
                             on p.Id equals img.ProductId
                             select new ProductDetailDto
                             {
                                 Id = p.Id,
                                 CategoryId = c.CategoryId,
                                 ProductName = p.ProductName,
                                 ProductName_EN = p.ProductName_EN,
                                 CategoryName = c.CategoryName,
                                 CategoryName_EN = c.CategoryName_EN,
                                 DescriptionProduct = p.DescriptionProduct,
                                 DescriptionProduct2 = p.DescriptionProduct2,
                                 DescriptionProduct_EN = p.DescriptionProduct_EN,
                                 DescriptionProduct2_EN = p.DescriptionProduct2_EN,
                                 ImagePath_1 = img.ImagePath_1,
                                 ImagePath_2 = img.ImagePath_2,
                                 ImagePath_3 = img.ImagePath_3,
                                 ImagePath_4 = img.ImagePath_4,
                                 ImagePath_5 = img.ImagePath_5,
                                 ImagePath_6 = img.ImagePath_6,
                                 ImagePath_7 = img.ImagePath_7,
                                 ImagePath_8 = img.ImagePath_8,
                                 ImagePath_9 = img.ImagePath_9,
                                 ImagePath_10 = img.ImagePath_10
                             };
                return result.ToList();
            }
        }

        public List<ProductDetailDto> GetProductDetailDtosById(int id)
        {
            using (ProductDbContext context = new ProductDbContext())
            {
                var result = from p in context.Products.Where(p => p.Id == id)
                             join c in context.Categories
                             on p.CategoryId equals c.CategoryId
                             join img in context.ProductImages
                             on p.Id equals img.ProductId
                             select new ProductDetailDto
                             {
                                 Id = p.Id,
                                 CategoryId = c.CategoryId,
                                 ProductName = p.ProductName,
                                 ProductName_EN = p.ProductName_EN,
                                 CategoryName = c.CategoryName,
                                 CategoryName_EN = c.CategoryName_EN,
                                 DescriptionProduct = p.DescriptionProduct,
                                 DescriptionProduct2 = p.DescriptionProduct2,
                                 DescriptionProduct_EN = p.DescriptionProduct_EN,
                                 DescriptionProduct2_EN = p.DescriptionProduct2_EN,
                                 ImagePath_1 = img.ImagePath_1,
                                 ImagePath_2 = img.ImagePath_2,
                                 ImagePath_3 = img.ImagePath_3,
                                 ImagePath_4 = img.ImagePath_4,
                                 ImagePath_5 = img.ImagePath_5,
                                 ImagePath_6 = img.ImagePath_6,
                                 ImagePath_7 = img.ImagePath_7,
                                 ImagePath_8 = img.ImagePath_8,
                                 ImagePath_9 = img.ImagePath_9,
                                 ImagePath_10 = img.ImagePath_10
                             };
                return result.ToList();
            }
        }
    }
}

