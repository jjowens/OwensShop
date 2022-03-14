using System;
using System.Collections.Generic;
using System.Text;
using OwensShop.Models;

namespace OwensShop.Services
{
    public interface IShopService
    {
        ServiceResponse<CategoryModel> SaveCategory(CategoryModel obj);
        ServiceResponse<ProductModel> SaveProduct(ProductModel obj);
        ServiceResponse<ProductModel> DeleteProduct(ProductModel obj); 
        ServiceResponse<CategoryModel> DeleteCategory(CategoryModel obj);

    }
}
