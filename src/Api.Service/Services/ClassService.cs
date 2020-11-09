using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Dtos.Class;
using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Api.Domain.Interfaces.Services.Class
using Api.Domain.Models;
using AutoMapper;

namespace Api.Service.Services
{
    public class ClassService : IClassService
    {
        private IRepository<ClassEntity> _repository;

        private readonly IMapper _mapper;
        public ClassService(IRepository<ClassEntity> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<ClassDto> Get(Guid id)
        {
            var entity = await _repository.SelectAsync(id);
            return _mapper.Map<ClassDto>(entity) ?? new ClassDto();
        }

        public async Task<IEnumerable<ClassDto>> GetAll()
        {
            var listEntity = await _repository.SelectAsync();
            return _mapper.Map<IEnumerable<ClassDto>>(listEntity);
        }

        public async Task<ClassDtoCreateResult> Post(ClassDtoCreate class)
        {
            var model = _mapper.Map<ClassModel>(class);
            var entity = _mapper.Map<ClassEntity>(model);
            var result = await _repository.InsertAsync(entity);

            return _mapper.Map<ClassDtoCreateResult>(result);
        }

        public async Task<ClassDtoUpdateResult> Put(ClassDtoUpdate class)
        {
            var model = _mapper.Map<ClassModel>(class);
            var entity = _mapper.Map<ClassEntity>(model);
            var result = await _repository.UpdateAsync(entity);

            return _mapper.Map<ClassDtoUpdateResult>(result);
        }
    }
}
