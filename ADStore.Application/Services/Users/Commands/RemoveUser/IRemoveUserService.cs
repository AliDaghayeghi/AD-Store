using ADStore.Common.Dto;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADStore.Application.Services.Users.Commands.RemoveUser
{
    public interface IRemoveUserService
    {
        ResultDto Execute(long UserId);
    }
}
