using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ADStore.Common.Dto;

namespace ADStore.Application.Services.Users.Queries.GetRoles
{
    public interface IGetRolesService
    {
        ResultDto<List<RolesDto>> Execute();
    }
}
