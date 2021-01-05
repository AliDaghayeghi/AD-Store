using ADStore.Application.Services.Products.Commands.AddNewCategory;
using ADStore.Application.Services.Products.Commands.AddNewProduct;
using ADStore.Application.Services.Products.Queries.GetAllCategories;
using ADStore.Application.Services.Products.Queries.GetCategories;
using ADStore.Application.Services.Products.Queries.GetProductDetailForAdmin;
using ADStore.Application.Services.Products.Queries.GetProductDetailForSite;
using ADStore.Application.Services.Products.Queries.GetProductForAdmin;
using ADStore.Application.Services.Products.Queries.GetProductForSite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADStore.Application.Interfaces.FacadPatterns
{
    public interface IProductFacad
    {
        AddNewCategoryService AddNewCategoryService { get; }
        IGetCategoriesService GetCategoriesService { get; }
        AddNewProductService AddNewProductService { get; }
        IGetAllCategoriesService GetAllCategoriesService { get; }
        /// <summary>
        /// دریافت لیست محصولات
        /// </summary>
        IGetProductForAdminService GetProductForAdminService { get; }
        IGetProductDetailForAdminService GetProductDetailForAdminService { get; }
        IGetProductForSiteService GetProductForSiteService { get; }
        IGetProductDetailForSiteService GetProductDetailForSiteService { get; }
    }
}
