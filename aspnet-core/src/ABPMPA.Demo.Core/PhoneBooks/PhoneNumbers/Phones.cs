using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using ABPMPA.Demo.PhoneBooks.Persons;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ABPMPA.Demo.PhoneBooks.PhoneNumbers
{
    public class Phones :Entity<long>, IHasCreationTime
    {
        /// <summary>
        /// 电话
        /// </summary>
        [Required]
        [MaxLength(11)]
        public string Number { get; set; }
        
        /// <summary>
        /// 电话类型
        /// </summary>
        public PhoneType Type { get; set; }

        public int PersonId { get; set; }
        public Person Person { get; set; }
        public DateTime CreationTime { get; set; }
    }
}
