using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace ADStore.Application.Services.Users.Queries.GetUsers
{
    public interface IGetUsersService
    {
        ReslutGetUserDto Execute(RequestGetUserDto request);
    }
}
