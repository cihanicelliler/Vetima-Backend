using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductImagesService
    {
        IDataResult<List<ProductImages>> GetAll();
        IDataResult<ProductImages> Get(int id);
        IResult Add(IFormFile file, ProductImages productImages);
        IResult Update(IFormFile file, ProductImages productImages);
        IResult Delete(ProductImages productImages);
        IDataResult<List<ProductImages>> GetImagesByProductId(int id);
    }
}
