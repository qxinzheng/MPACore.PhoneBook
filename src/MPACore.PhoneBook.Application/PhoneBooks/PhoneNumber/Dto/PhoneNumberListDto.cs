using Abp.AutoMapper;
using Phn = MPACore.PhoneBook.PhoneBooks.PhoneNumbers;
using System;
using System.Collections.Generic;
using System.Text;

namespace MPACore.PhoneBook.PhoneBooks.PhoneNumber.Dto
{
    [AutoMapFrom(typeof(Phn.PhoneNumber))]
    public class PhoneNumberListDto
    {
        /// <summary>
        /// 电话号码
        /// </summary>
        public string Number { get; set; }
        /// <summary>
        /// 类型
        /// </summary>
        public Phn.PhoneNumberType Type { get; set; }
    }
}
