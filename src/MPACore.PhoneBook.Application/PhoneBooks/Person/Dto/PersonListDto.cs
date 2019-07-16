using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using MPACore.PhoneBook.PhoneBooks.Persons;
using MPACore.PhoneBook.PhoneBooks.PhoneNumber.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MPACore.PhoneBook.PhoneBooks.Dto
{
    [AutoMapFrom(typeof(Person))]
    public class PersonListDto : FullAuditedEntityDto
    {
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { set; get; }
        /// <summary>
        /// 邮箱地址
        /// </summary>
        public string EmailAddress { set; get; }
        /// <summary>
        /// 地址信息
        /// </summary>
        public string Address { set; get; }

        public List<PhoneNumberListDto> PhoneNumbers { get; set; }
    }
}
