﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;
using ABPMPA.Demo.Application.PhoneBooks.Dto;
using ABPMPA.Demo.PhoneBooks.Dto;
using ABPMPA.Demo.PhoneBooks.Persons;
using Microsoft.EntityFrameworkCore;

namespace ABPMPA.Demo.PhoneBooks
{
    public class PersonAppService : DemoAppServiceBase, IPersonAppService
    {
        private readonly IRepository<Person> _personRepository;
        public PersonAppService(IRepository<Person> personRepository)
        {
            _personRepository = personRepository;
        }


        public async Task CreateOrUpdatePersonAsync(CreateOrUpdatePersonInput input)
        {
            if (input.PersonEditDto.Id.HasValue)
            {
                await UpdatePersonAsync(input.PersonEditDto);
            }
            else
            {
                await CreatePersonAsync(input.PersonEditDto);
            }
        }

        public async Task DeletePersonAsync(EntityDto input)
        {
            var dbitem = await _personRepository.GetAsync(input.Id);
            if (dbitem == null)
            {
                throw new Abp.UI.UserFriendlyException("该联系人不存在");
            }
            await _personRepository.DeleteAsync(input.Id);
        }

        public async Task<PagedResultDto<PersonListDto>> GetPagedPersonAsync(GetPersonInput input)
        {
            var query = _personRepository.GetAllIncluding(a => a.phones);
            var personCount = await query.CountAsync();
            var persons = await query.OrderBy(input.Sorting).PageBy(input).ToListAsync();
            var dtos = persons.MapTo<List<PersonListDto>>();
            return new PagedResultDto<PersonListDto>(personCount, dtos);
        }

        public async Task<PersonListDto> GetPersonByIdAsync(NullableIdDto input)
        {
            var dbitem = await _personRepository.GetAllIncluding(a => a.phones).FirstOrDefaultAsync(a=>a.Id == input.Id.Value);
            return dbitem.MapTo<PersonListDto>();

        }

        protected async Task UpdatePersonAsync(PersonEditDto input)
        {
            var dbitem = await _personRepository.GetAsync(input.Id.Value);
            await _personRepository.UpdateAsync(input.MapTo(dbitem));
        }
        protected async Task CreatePersonAsync(PersonEditDto input)
        {
            var entity = input.MapTo<Person>();
            await _personRepository.InsertAsync(entity);
        }

        public async Task<GetPersonForEditOutput> GetPersonForEditAsync(NullableIdDto input)
        {
            var output = new GetPersonForEditOutput();
            PersonEditDto personEditDto;
            if (input.Id.HasValue)
            {
                var entity = await _personRepository.GetAllIncluding(a => a.phones).FirstOrDefaultAsync(a=>a.Id == input.Id.Value);
                personEditDto = entity.MapTo<PersonEditDto>();
            }
            else
            {
                personEditDto = new PersonEditDto();
            }
            output.Person = personEditDto;
            return output;
        }
    }
}
