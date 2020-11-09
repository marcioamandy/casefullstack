using Api.Domain.Entities;
using Api.Domain.Models;
using AutoMapper;

namespace Api.CrossCutting.Mappings
{
    public class ModelToEntityProfile : Profile
    {
        public ModelToEntityProfile()
        {
            CreateMap<UserEntity, UserModel>()
                .ReverseMap();

            CreateMap<SchoolEntity, SchoolModel>()
                .ReverseMap();

            CreateMap<ClassEntity, ClassModel>()
                .ReverseMap();

            CreateMap<StudentEntity, StudentModel>()
                .ReverseMap();

            CreateMap<ClassStudentEntity, ClassStudentModel>()
                .ReverseMap();

        }
    }
}
