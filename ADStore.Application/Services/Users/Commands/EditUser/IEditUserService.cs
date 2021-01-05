using ADStore.Application.Interfaces.Contexts;
using ADStore.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADStore.Application.Services.Users.Commands.EditUser
{
    public interface IEditUserService
    {
        ResultDto Execute(RequestEdituserDto request);
    }
    public class EditUserService : IEditUserService
    {
        private readonly IDataBaseContext _context;

        public EditUserService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto Execute(RequestEdituserDto request)
        {
            var user = _context.Users.Find(request.UserId);
            if (user == null)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "کاربر یافت نشد"
                };
            }
            user.FullName = request.Fullname;
            user.Email = request.Email;
            user.Phone = request.Phone;
            user.Location = request.Address;
            _context.SaveChanges();

            return new ResultDto()
            {
                IsSuccess = true,
                Message = "ویرایش کاربر انجام شد"
            };

        }
    }


    public class RequestEdituserDto
    {
        public long UserId { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
    }
}
