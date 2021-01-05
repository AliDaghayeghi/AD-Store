using ADStore.Application.Interfaces.Contexts;
using ADStore.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADStore.Application.Services.Users.Commands.UserStatusChange
{
    public interface IUserStatusChangeService
    {
        ResultDto Execute(long UserId);
    }

    public class UserStatusChangeService : IUserStatusChangeService
    {
        private readonly IDataBaseContext _context;


        public UserStatusChangeService(IDataBaseContext context)
        {
            _context = context;
        }

        public ResultDto Execute(long UserId)
        {
            var user = _context.Users.Find(UserId);
            if (user == null)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "کاربر یافت نشد"
                };
            }

            user.IsActive = !user.IsActive;
            _context.SaveChanges();
            string userstate = user.IsActive == true ? "فعال" : "غیر فعال";
            return new ResultDto()
            {
                IsSuccess = true,
                Message = $"کاربر با موفقیت {userstate} شد!",
            };
        }
    }
}
