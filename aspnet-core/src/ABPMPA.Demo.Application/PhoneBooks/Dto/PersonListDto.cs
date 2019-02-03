using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using ABPMPA.Demo.PhoneBooks.Persons;
using System;
using System.Collections.Generic;
using System.Text;

namespace ABPMPA.Demo.PhoneBooks.Dto
{
    [AutoMapFrom(typeof(Person))]
    public class PersonListDto : FullAuditedEntityDto
    {
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// 地址
        /// </summary>
        public string Address { get; set; }
    }
}
