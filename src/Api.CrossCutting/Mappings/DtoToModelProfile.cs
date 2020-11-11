using Api.Domain.Dtos.Class;
using Api.Domain.Dtos.School;
using Api.Domain.Dtos.Student;
using Api.Domain.Dtos.ClassStudent;
using Api.Domain.Dtos.User;
using Api.Domain.Models;
using AutoMapper;

namespace Api.CrossCutting.Mappings
{
    public class DtoToModelProfile : Profile
    {
        public DtoToModelProfile()
        {
            CreateMap<UserModel, UserDto>()
                .ReverseMap();

            CreateMap<UserModel, UserDtoCreate>()
                .ReverseMap();

            CreateMap<UserModel, UserDtoUpdate>()
                .ReverseMap();

            CreateMap<SchoolModel, SchoolDto>()
                .ReverseMap();

            CreateMap<SchoolModel, SchoolDtoCreate>()
                .ReverseMap();

            CreateMap<SchoolModel, SchoolDtoUpdate>()
                .ReverseMap();

            CreateMap<ClassModel, ClassDto>()
                .ReverseMap();

            CreateMap<ClassModel, ClassDtoCreate>()
                .ReverseMap();

            CreateMap<ClassModel, ClassDtoUpdate>()
                .ReverseMap();

            CreateMap<StudentModel, StudentDto>()
                .ReverseMap();

            CreateMap<StudentModel, StudentDtoCreate>()
                .ReverseMap();

            CreateMap<StudentModel, StudentDtoUpdate>()
                .ReverseMap();

            CreateMap<ClassStudentModel, ClassStudentDto>()
                .ReverseMap();

            CreateMap<ClassStudentModel, ClassStudentDtoCreate>()
                .ReverseMap();

            CreateMap<ClassStudentModel, ClassStudentDtoUpdate>()
                .ReverseMap();
        }
    }
}
