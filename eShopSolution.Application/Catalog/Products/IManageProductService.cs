
using eShopSolution.ViewModel.Catalog.ProductImages;
using eShopSolution.ViewModel.Catalog.Products;
using eShopSolution.ViewModel.Common;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Application.Catalog.Products
{
    public interface IManageProductService
    {
        Task<int> Create(ProductCreateRequest request);
        Task<int> Update(ProductUpdateRequest request);
        Task<int> Delete(int productId);
        Task<ProductViewModel> GetById(int productId,string LanguageId);
        Task<bool> UpdatePrice(int productId, decimal newprice);
        Task AddViewCount(int productId);
        Task<bool> UpdateStock(int productId, int addedQuantity);
  
        Task<PageResult<ProductViewModel>> GetAllPaging(GetManageProductPagingRequest request);
        Task<int> AddImage(int productId, ProductImageCreateRequest request);
        Task<int> RemoveImage(int imageId);
        Task<int> UpdateImage( int imageId,ProductImageUpdateRequest request);
        Task<ProductImageViewModel> GetImageById(int imageId);
        Task<List<ProductImageViewModel>> GetListImages(int productId);
    }
}
