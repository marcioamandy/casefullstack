using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Dtos.ClassStudent;
using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Api.Domain.Interfaces.Services.ClassStudent
using Api.Domain.Models;
using AutoMapper;

namespace Api.Service.Services
{
    public class ClassStudentService : IClassStudentService
    {
        private IRepository<ClassStudentEntity> _repository;

        private readonly IMapper _mapper;
        public ClassStudentService(IRepository<ClassStudentEntity> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<ClassStudentDto> Get(Guid id)
        {
            var entity = await _repository.SelectAsync(id);
            return _mapper.Map<ClassStudentDto>(entity) ?? new ClassStudentDto();
        }

        public async Task<IEnumerable<ClassStudentDto>> GetAll()
        {
            var listEntity = await _repository.SelectAsync();
            return _mapper.Map<IEnumerable<ClassStudentDto>>(listEntity);
        }

        public async Task<ClassStudentDtoCreateResult> Post(ClassStudentDtoCreate classstudent)
        {
            var model = _mapper.Map<ClassStudentModel>(classstudent);
            var entity = _mapper.Map<ClassStudentEntity>(model);
            var result = await _repository.InsertAsync(entity);

            return _mapper.Map<ClassStudentDtoCreateResult>(result);
        }

        public async Task<ClassStudentDtoUpdateResult> Put(ClassStudentDtoUpdate classstudent)
        {
            var model = _mapper.Map<ClassStudentModel>(classstudent);
            var entity = _mapper.Map<ClassStudentEntity>(model);
            var result = await _repository.UpdateAsync(entity);

            return _mapper.Map<ClassStudentDtoUpdateResult>(result);
        }
    }
}
