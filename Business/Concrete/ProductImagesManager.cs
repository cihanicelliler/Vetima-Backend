using Business.Abstract;
using Core.Utilities.Business;
using Core.Utilities.FileHelper;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Business.Concrete
{
    public class ProductImagesManager:IProductImagesService
    {
        IProductImagesDal _productImagesDal;

        public ProductImagesManager(IProductImagesDal productImagesDal)
        {
            _productImagesDal = productImagesDal;
        }

        public IResult Add(IFormFile file, ProductImages productImages)
        {
            productImages.ImagePath_1 = FileHelper.Add(file);
            productImages.Date = DateTime.Now;
            _productImagesDal.Add(productImages);
            return new SuccessResult();
        }

        public IResult Delete(ProductImages productImages)
        {
            IResult result = BusinessRules.Run(ProductImageDelete(productImages));
            if (result != null)
            {
                return result;
            }
            _productImagesDal.Delete(productImages);
            return new SuccessResult();
        }

        public IDataResult<ProductImages> Get(int id)
        {
            return new SuccessDataResult<ProductImages>(_productImagesDal.Get(p => p.Id == id));
        }

        public IDataResult<List<ProductImages>> GetAll()
        {
            return new SuccessDataResult<List<ProductImages>>(_productImagesDal.GetAll());
        }

        public IDataResult<List<ProductImages>> GetImagesByProductId(int id)
        {
            return new SuccessDataResult<List<ProductImages>>(_productImagesDal.GetAll(p => p.ProductId == id));
        }

        public IResult Update(IFormFile file, ProductImages productImages)
        {
            productImages.ImagePath_1 = FileHelper.Update(_productImagesDal.Get(p => p.Id == productImages.Id).ImagePath_1, file);
            productImages.Date = DateTime.Now;
            _productImagesDal.Update(productImages);
            return new SuccessResult();
        }

        private IResult ProductImageDelete(ProductImages productImages)
        {
            try
            {
                File.Delete(productImages.ImagePath_1);
            }
            catch (Exception exception)
            {
                return new ErrorResult(exception.Message);
            }
            return new SuccessResult();
        }
    }
}
