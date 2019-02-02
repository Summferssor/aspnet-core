using System.Collections.Generic;
using ABPMPA.Demo.Roles.Dto;
using ABPMPA.Demo.Users.Dto;

namespace ABPMPA.Demo.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
