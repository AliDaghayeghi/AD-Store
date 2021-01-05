using ADStore.Application.Interfaces.Contexts;
using ADStore.Common.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADStore.Application.Services.Fainances.Queries.GetRequestPayForAdmin
{
    public interface IGetRequestPayForAdminService
    {
        ResultDto<List<RequestPayDto>> Execute();
    }

    public class GetRequestPayForAdminService : IGetRequestPayForAdminService
    {
        private readonly IDataBaseContext _context;
        public GetRequestPayForAdminService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto<List<RequestPayDto>> Execute()
        {
            var requestPay = _context.RequestPays
                .Include(p=>p.User)
                .ToList()
                 .Select(p => new RequestPayDto
                 {
                     Id=p.Id,
                     Amount = p.Amount,
                     Authority = p.Authority,
                     Guid = p.Guid,
                     IsPay = p.IsPay,
                     PayDate = p.PayDate,
                     RefId = p.RefId,
                     UserId = p.UserId,
                     UserName = p.User.FullName
                 }).ToList();

            return new ResultDto<List<RequestPayDto>>()
            {
                Data = requestPay,
                IsSuccess = true,
            };
        }
    }
    public class RequestPayDto
    {
        public long Id { get; set; }
        public Guid Guid { get; set; }
         public string UserName { get; set; }
         public long UserId { get; set; }
        public int Amount { get; set; }
        public bool IsPay { get; set; }
        public DateTime? PayDate { get; set; }
        public string Authority { get; set; }
        public long RefId { get; set; } = 0;
    }
}
