using ADStore.Application.Interfaces.Contexts;
using ADStore.Application.Interfaces.FacadPatterns;
using ADStore.Application.Services.Products.Commands.AddNewCategory;
using ADStore.Application.Services.Products.Commands.AddNewProduct;
using ADStore.Application.Services.Products.Queries.GetAllCategories;
using ADStore.Application.Services.Products.Queries.GetCategories;
using ADStore.Application.Services.Products.Queries.GetProductDetailForAdmin;
using ADStore.Application.Services.Products.Queries.GetProductDetailForSite;
using ADStore.Application.Services.Products.Queries.GetProductForAdmin;
using ADStore.Application.Services.Products.Queries.GetProductForSite;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADStore.Application.Services.Products.FacadPattern
{
    public class ProductFacad : IProductFacad
    {
        private readonly IDataBaseContext _context;
        private readonly IHostingEnvironment _environment;
        public ProductFacad(IDataBaseContext context, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            _environment = hostingEnvironment;

        }

        private AddNewCategoryService _addNewCategory;
        public AddNewCategoryService AddNewCategoryService
        {
            get
            {
                return _addNewCategory = _addNewCategory ?? new AddNewCategoryService(_context);
            }
        }


        private IGetCategoriesService _getCategoriesService;
        public IGetCategoriesService GetCategoriesService
        {
            get
            {
                return _getCategoriesService = _getCategoriesService ?? new GetCategoriesService(_context);
            }
        }

        private AddNewProductService _addNewProductService;
        public AddNewProductService AddNewProductService
        {
            get
            {
                return _addNewProductService = _addNewProductService ?? new AddNewProductService(_context, _environment);
            }
        }

        private IGetAllCategoriesService _getAllCategoriesService;
        public IGetAllCategoriesService GetAllCategoriesService
        {
            get
            {
                return _getAllCategoriesService = _getAllCategoriesService ?? new GetAllCategoriesService(_context);
            }
        }


        private IGetProductForAdminService _getProductForAdminService;
        public IGetProductForAdminService GetProductForAdminService
        {
            get
            {
                return _getProductForAdminService = _getProductForAdminService ?? new GetProductForAdminService(_context);
            }
        }


        private IGetProductDetailForAdminService _getProductDetailForAdminService;
        public IGetProductDetailForAdminService GetProductDetailForAdminService
        {
            get
            {
                return _getProductDetailForAdminService = _getProductDetailForAdminService ?? new GetProductDetailForAdminService(_context);
            }
        }    
        
        
        private IGetProductForSiteService   _getProductForSiteService;
        public IGetProductForSiteService  GetProductForSiteService
        {
            get
            {
                return _getProductForSiteService = _getProductForSiteService ?? new GetProductForSiteService(_context);
            }
        }    
        
        
        private IGetProductDetailForSiteService  _getProductDetailForSiteService;
        public IGetProductDetailForSiteService  GetProductDetailForSiteService
        {
            get
            {
                return _getProductDetailForSiteService = _getProductDetailForSiteService ?? new GetProductDetailForSiteService(_context);
            }
        }



    }
}
