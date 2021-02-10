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
        IDataResult<List<Product>> GetAllByCategory(int id);
        IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max);

        IDataResult<List<ProductDetailDto>> GetProductDetails();
        IDataResult<Product> GetById(int productId); //geriye puroduct dönderiyor
        IResult Add(Product product);

        /*
         *** İLK HALİ BÖYLEYDİ***
        List<Product> GetAll(); eski hali
        List<Product> GetAllByCategory(int id);
        List<Product> GetByUnitPrice(decimal min, decimal max);

        List<ProductDetailDto> GetProductDetails();
        Product GetById(int productId); //geriye puroduct dönderiyor
        IResult Add(Product product); //void olan yer yerine IResult yazdım önceki hali void Add (Product product)

        */

    }
}
