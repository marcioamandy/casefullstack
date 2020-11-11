using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Dtos.Student;
using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Api.Domain.Interfaces.Services.Student;
using Api.Domain.Models;
using AutoMapper;

namespace Api.Service.Services
{
    public class StudentService : IStudentService
    {
        private IRepository<StudentEntity> _repository;

        private readonly IMapper _mapper;
        public StudentService(IRepository<StudentEntity> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<StudentDto> Get(Guid id)
        {
            var entity = await _repository.SelectAsync(id);
            return _mapper.Map<StudentDto>(entity) ?? new StudentDto();
        }

        public async Task<IEnumerable<StudentDto>> GetAll()
        {
            var listEntity = await _repository.SelectAsync();
            return _mapper.Map<IEnumerable<StudentDto>>(listEntity);
        }

        public async Task<StudentDtoCreateResult> Post(StudentDtoCreate student)
        {
            var model = _mapper.Map<StudentModel>(student);
            var entity = _mapper.Map<StudentEntity>(model);
            var result = await _repository.InsertAsync(entity);

            return _mapper.Map<StudentDtoCreateResult>(result);
        }

        public async Task<StudentDtoUpdateResult> Put(StudentDtoUpdate student)
        {
            var model = _mapper.Map<StudentModel>(student);
            var entity = _mapper.Map<StudentEntity>(model);
            var result = await _repository.UpdateAsync(entity);

            return _mapper.Map<StudentDtoUpdateResult>(result);
        }
    }
}
