using ADStore.Application.Interfaces.Contexts;
using ADStore.Common;
using ADStore.Common.Dto;
using ADStore.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADStore.Application.Services.Users.Commands.UserLogin
{
    public interface IUserLoginService
    {
        ResultDto<ResultUserloginDto> Execute(string Username, string Password);
    }

    public class UserLoginService : IUserLoginService
    {
        private readonly IDataBaseContext _context;
        public UserLoginService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto<ResultUserloginDto> Execute(string Username, string Password)
        {

            if (string.IsNullOrWhiteSpace(Username) || string.IsNullOrWhiteSpace(Password))
            {
                return new ResultDto<ResultUserloginDto>()
                {
                    Data = new ResultUserloginDto()
                    {

                    },
                    IsSuccess = false,
                    Message = "نام کاربری و رمز عبور را وارد نمایید",
                };
            }



            var user = _context.Users
                .Include(p => p.UserInRoles)
                .ThenInclude(p=>p.Role)
                .Where(p => p.Email.Equals(Username)
            && p.IsActive == true)
            .FirstOrDefault();

            if (user == null)
            {
                return new ResultDto<ResultUserloginDto>()
                {
                    Data = new ResultUserloginDto()
                    {

                    },
                    IsSuccess = false,
                    Message = "کاربری با این ایمیل در فروشگاه ثبت نام نکرده است",
                };
            }

            var passwordHasher = new PasswordHasher();
            bool resultVerifyPassword = passwordHasher.VerifyPassword(user.Password, Password);
            if (resultVerifyPassword == false)
            {
                return new ResultDto<ResultUserloginDto>()
                {
                    Data = new ResultUserloginDto()
                    {

                    },
                    IsSuccess = false,
                    Message = "رمز وارد شده اشتباه است!",
                };
            }


            List<string> roles = new List<string>();
            foreach (var item in user.UserInRoles)
            {
                roles.Add(item.Role.Name);
            }


            return new ResultDto<ResultUserloginDto>()
            {
                Data = new ResultUserloginDto()
                {
                    Roles = roles,
                    UserId = user.Id,
                    Name = user.FullName
                },
                IsSuccess = true,
                Message = "ورود به سایت با موفقیت انجام شد",
            };


        }
    }

    public class ResultUserloginDto
    {
        public long UserId { get; set; }
        public List<string> Roles { get; set; }
        public  string   Name { get; set; }
    }
}
