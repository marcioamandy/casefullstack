using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Dtos.School;
using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Api.Domain.Interfaces.Services.School;
using Api.Domain.Models;
using AutoMapper;

namespace Api.Service.Services
{
    public class SchoolService : ISchoolService
    {
        private IRepository<SchoolEntity> _repository;

        private readonly IMapper _mapper;
        public SchoolService(IRepository<SchoolEntity> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<SchoolDto> Get(Guid id)
        {
            var entity = await _repository.SelectAsync(id);
            return _mapper.Map<SchoolDto>(entity) ?? new SchoolDto();
        }

        public async Task<IEnumerable<SchoolDto>> GetAll()
        {
            var listEntity = await _repository.SelectAsync();
            return _mapper.Map<IEnumerable<SchoolDto>>(listEntity);
        }

        public async Task<SchoolDtoCreateResult> Post(SchoolDtoCreate school)
        {
            var model = _mapper.Map<SchoolModel>(school);
            var entity = _mapper.Map<SchoolEntity>(model);
            var result = await _repository.InsertAsync(entity);

            return _mapper.Map<SchoolDtoCreateResult>(result);
        }

        public async Task<SchoolDtoUpdateResult> Put(SchoolDtoUpdate school)
        {
            var model = _mapper.Map<SchoolModel>(school);
            var entity = _mapper.Map<SchoolEntity>(model);
            var result = await _repository.UpdateAsync(entity);

            return _mapper.Map<SchoolDtoUpdateResult>(result);
        }
    }
}
