using Abp.AutoMapper;
using MPACore.PhoneBook.PhoneBooks.Dto;
using MPACore.PhoneBook.PhoneBooks.Persons;
using Phn = MPACore.PhoneBook.PhoneBooks.PhoneNumbers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MPACore.PhoneBook.PhoneBooks.PhoneNumber.Dto
{
    [AutoMapTo(typeof(Phn.PhoneNumber))]
    public class PhoneNumberEditDto
    {
        /// <summary>
        /// 电话号码
        /// </summary>
        [Required]
        [MaxLength(PhoneBookConsts.MaxPhoneNumberLength)]
        public string Number { get; set; }
        /// <summary>
        /// 类型
        /// </summary>
        public Phn.PhoneNumberType Type { get; set; }
    }
}
