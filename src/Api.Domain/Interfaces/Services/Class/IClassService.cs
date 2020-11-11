using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Dtos.Class;
using Api.Domain.Entities;

namespace Api.Domain.Interfaces.Services.Class
{
    public interface IClassService
    {
        Task<ClassDto> Get(Guid id);
        Task<IEnumerable<ClassDto>> GetAll();
        Task<ClassDtoCreateResult> Post(ClassDtoCreate _class);
        Task<ClassDtoUpdateResult> Put(ClassDtoUpdate _class);
        Task<bool> Delete(Guid id);
    }
}
