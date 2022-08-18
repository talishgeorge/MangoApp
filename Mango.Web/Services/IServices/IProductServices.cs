﻿using Mango.Web.Models;

namespace Mango.Web.Services.IServices
{
    public interface IProductService: IBaseService
    {
          Task<T> GetAllProductAsync<T>();

          Task<T> GetProductByIdAsync<T>(int id);
          Task<T> CreatelProductAsync<T>(ProductDto productDto);
          Task<T> UpdateProductAsync<T>(ProductDto productDto);
          Task<T> DeleteProductAsync<T>(int id);
    }
}
