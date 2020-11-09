using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Dtos.ClassStudent;
using Api.Domain.Entities;

namespace Api.Domain.Interfaces.Services.ClassStudent
{
    public interface IClassStudentService
    {
        Task<ClassStudentDto> Get(Guid id);
        Task<IEnumerable<ClassStudentDto>> GetAll();
        Task<ClassStudentDtoCreateResult> Post(ClassStudentDtoCreate user);
        Task<ClassStudentDtoUpdateResult> Put(ClassStudentDtoUpdate user);
        Task<bool> Delete(Guid id);
    }
}
