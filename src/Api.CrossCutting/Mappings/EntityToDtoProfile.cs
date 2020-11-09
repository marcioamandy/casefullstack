using Api.Domain.Dtos.User;
using Api.Domain.Dtos.School;
using Api.Domain.Dtos.Class;
using Api.Domain.Dtos.Student;
using Api.Domain.Dtos.ClassStudent;
using Api.Domain.Entities;
using AutoMapper;

namespace Api.CrossCutting.Mappings
{
    public class EntityToDtoProfile : Profile
    {
        public EntityToDtoProfile()
        {
            CreateMap<UserDto, UserEntity>()
                .ReverseMap();

            CreateMap<UserDtoCreateResult, UserEntity>()
                .ReverseMap();

            CreateMap<UserDtoUpdateResult, UserEntity>()
                .ReverseMap();

            CreateMap<SchoolDto, SchoolEntity>()
                .ReverseMap();

            CreateMap<SchoolDtoCreateResult, SchoolEntity>()
                .ReverseMap();

            CreateMap<SchoolDtoUpdateResult, SchoolEntity>()
                .ReverseMap();

            CreateMap<ClassDto, ClassEntity>()
                .ReverseMap();

            CreateMap<ClassDtoCreateResult, ClassEntity>()
                .ReverseMap();

            CreateMap<ClassDtoUpdateResult, ClassEntity>()
                .ReverseMap();

            CreateMap<StudentDto, StudentEntity>()
                .ReverseMap();

            CreateMap<StudentDtoCreateResult, StudentEntity>()
                .ReverseMap();

            CreateMap<StudentDtoUpdateResult, StudentEntity>()
                .ReverseMap();

            CreateMap<ClassStudentDto, ClassStudentEntity>()
                .ReverseMap();

            CreateMap<ClassStudentDtoCreateResult, ClassStudentEntity>()
                .ReverseMap();

            CreateMap<ClassStudentDtoUpdateResult, ClassStudentEntity>()
                .ReverseMap();
        }
    }
}
