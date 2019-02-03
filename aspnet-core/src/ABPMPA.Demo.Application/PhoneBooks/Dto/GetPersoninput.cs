using Abp.Runtime.Validation;
using ABPMPA.Demo.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace ABPMPA.Demo.PhoneBooks.Dto
{
    public class GetPersonInput : PagedAndSortedDto, IShouldNormalize
    {
        public string FilterText { get; set; }

        public void Normalize()
        {
            if (string.IsNullOrEmpty(Sorting))
            {
                Sorting = "Id";
            }
        }
    }
}
