using Abp.Application.Services.Dto;

namespace ABPMPA.Demo.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

