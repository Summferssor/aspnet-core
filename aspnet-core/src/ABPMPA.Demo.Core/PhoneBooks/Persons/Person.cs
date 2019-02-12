using Abp.Domain.Entities.Auditing;
using ABPMPA.Demo.PhoneBooks.PhoneNumbers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ABPMPA.Demo.PhoneBooks.Persons
{
    /// <summary>
    /// 联系人
    /// </summary>
    public class Person : FullAuditedEntity
    {
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


        public ICollection<Phones> phones { get; set; }

    }
}
