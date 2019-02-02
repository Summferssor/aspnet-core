using System.Collections.Generic;
using ABPMPA.Demo.Roles.Dto;

namespace ABPMPA.Demo.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}