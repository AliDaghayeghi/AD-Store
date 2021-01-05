using ADStore.Application.Services.Common.Queries.GetHomePageImages;
using ADStore.Application.Services.Common.Queries.GetSlider;
using ADStore.Application.Services.Products.Queries.GetProductForSite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoint.Site.Models.ViewModels.HomePages
{
    public class HomePageViewModel
    {
        public List<SliderDto> Sliders {get;set;}
        public List<HomePageImagesDto> PageImages { get; set; }
        public List<ProductForSiteDto>  Camera { get; set; }
        public List<ProductForSiteDto>  Mobile { get; set; }
        public List<ProductForSiteDto>  Laptop { get; set; }
    }
}
