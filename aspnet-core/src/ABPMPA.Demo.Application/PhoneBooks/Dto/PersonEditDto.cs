using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using ABPMPA.Demo.Application.PhoneBooks.Phone.Dto;
using ABPMPA.Demo.PhoneBooks.Persons;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ABPMPA.Demo.PhoneBooks.Dto
{
    [AutoMapTo(typeof(Person))]
    public class PersonEditDto
    {
        public int? Id { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        [Required]
        [MaxLength(DemoConsts.MaxNameLength)]
        public string Name { get; set; }
        /// <summary>
        /// 邮箱
        /// </summary>
        [EmailAddress]
        [MaxLength(DemoConsts.MaxEmailLength)]
        public string Email { get; set; }
        /// <summary>
        /// 地址
        /// </summary>
        [MaxLength(DemoConsts.MaxAddressLength)]
        public string Address { get; set; }


        public List<PhoneEditDto> phones { get; set; }
    }
}
