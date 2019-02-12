using System;
using Abp.AutoMapper;
using ABPMPA.Demo.PhoneBooks.Persons;
using ABPMPA.Demo.PhoneBooks.PhoneNumbers;

namespace ABPMPA.Demo.Application.PhoneBooks.Phone.Dto
{
    [AutoMapFrom(typeof(Phones))]
    public class PhoneListDto
    {
        /// <summary>
        /// 电话
        /// </summary>
        public string Number { get; set; }
        
        /// <summary>
        /// 电话类型
        /// </summary>
        public PhoneType Type { get; set; }

    }
}