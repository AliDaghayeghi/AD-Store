using System.Collections.Generic;

namespace ADStore.Application.Services.Products.Queries.GetProductForSite
{
    public class ResultProductForSiteDto
    {

        public List<ProductForSiteDto> Products { get; set; }
        public int TotalRow { get; set; }
    }

}
