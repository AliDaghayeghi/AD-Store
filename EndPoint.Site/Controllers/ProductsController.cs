using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ADStore.Application.Interfaces.FacadPatterns;
using ADStore.Application.Services.Products.Queries.GetProductForSite;
using Microsoft.AspNetCore.Mvc;

namespace EndPoint.Site.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductFacad _productFacad;

        public ProductsController(IProductFacad productFacad)
        {
            _productFacad = productFacad;
        }
        public IActionResult Index(Ordering ordering,string Searchkey,long? CatId=null,int page=1,int pageSize=20 )
        {
            return View(_productFacad.GetProductForSiteService.Execute(ordering, Searchkey,page,pageSize,CatId).Data);
        }


        public IActionResult Detail(long Id)
        {
            return View(_productFacad.GetProductDetailForSiteService.Execute(Id).Data);
        }
    }
}
