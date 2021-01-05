using ADStore.Application.Interfaces.Contexts;
using ADStore.Common.Dto;
using ADStore.Domain.Entities.HomePages;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADStore.Application.Services.Common.Queries.GetHomePageImages
{
    public interface IGetHomePageImagesService
    {
        ResultDto<List<HomePageImagesDto>> Execute();
    }

    public class GetHomePageImagesService : IGetHomePageImagesService
    {
        private readonly IDataBaseContext _context;
        public GetHomePageImagesService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto<List<HomePageImagesDto>> Execute()
        {
            var images = _context.HomePageImages.OrderByDescending(p => p.Id)
                .Select(p => new HomePageImagesDto
                {
                    Id = p.Id,
                    ImageLocation = p.ImageLocation,
                    Link = p.link,
                    Src = p.Src,
                }).ToList();
            return new ResultDto<List<HomePageImagesDto>>()
            {
                Data = images,
                IsSuccess = true,
            };
        }
    }
    public class HomePageImagesDto
    {
        public long Id { get; set; }
        public string Src { get; set; }
        public string Link { get; set; }
        public ImageLocation ImageLocation { get; set; }
    }
}
