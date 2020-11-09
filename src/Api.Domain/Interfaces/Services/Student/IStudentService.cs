using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Dtos.Student;
using Api.Domain.Entities;

namespace Api.Domain.Interfaces.Services.Student
{
    public interface IStudentService
    {
        Task<StudentDto> Get(Guid id);
        Task<IEnumerable<StudentDto>> GetAll();
        Task<StudentDtoCreateResult> Post(StudentDtoCreate user);
        Task<StudentDtoUpdateResult> Put(StudentDtoUpdate user);
        Task<bool> Delete(Guid id);
    }
}
