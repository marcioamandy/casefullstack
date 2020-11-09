using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Dtos.School;
using Api.Domain.Entities;

namespace Api.Domain.Interfaces.Services.School
{
    public interface ISchoolService
    {
        Task<SchoolDto> Get(Guid id);
        Task<IEnumerable<SchoolDto>> GetAll();
        Task<SchoolDtoCreateResult> Post(SchoolDtoCreate user);
        Task<SchoolDtoUpdateResult> Put(SchoolDtoUpdate user);
        Task<bool> Delete(Guid id);
    }
}
