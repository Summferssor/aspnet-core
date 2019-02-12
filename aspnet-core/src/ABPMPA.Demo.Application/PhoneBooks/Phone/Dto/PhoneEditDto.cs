using System;
using System.ComponentModel.DataAnnotations;
using Abp.AutoMapper;
using ABPMPA.Demo.PhoneBooks.Persons;
using ABPMPA.Demo.PhoneBooks.PhoneNumbers;

namespace ABPMPA.Demo.Application.PhoneBooks.Phone.Dto
{
    [AutoMapTo(typeof(Phones))]
    public class PhoneEditDto
    {
        /// <summary>
        /// 电话
        /// </summary>
        [Required]
        [MaxLength(DemoConsts.MaxPhoneLength)]
        public string Number { get; set; }
        
        /// <summary>
        /// 电话类型
        /// </summary>
        public PhoneType Type { get; set; }
    }
}