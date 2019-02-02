using System.Collections.Generic;
using ABPMPA.Demo.Roles.Dto;

namespace ABPMPA.Demo.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<RoleListDto> Roles { get; set; }

        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
