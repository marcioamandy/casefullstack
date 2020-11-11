using Api.Domain.Interfaces.Services.User;
using Api.Domain.Interfaces.Services.School;
using Api.Domain.Interfaces.Services.Class;
using Api.Domain.Interfaces.Services.Student;
using Api.Domain.Interfaces.Services.ClassStudent;
using Api.Service.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Api.CrossCutting.DependencyInjection
{
    public class ConfigureService
    {
        public static void ConfigureDependenciesService(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IUserService, UserService>();
            serviceCollection.AddTransient<ILoginService, LoginService>();
            serviceCollection.AddTransient<ISchoolService, SchoolService>();
            serviceCollection.AddTransient<IClassService, ClassService>();
            serviceCollection.AddTransient<IStudentService, StudentService>();
            serviceCollection.AddTransient<IClassStudentService, ClassStudentService>();
        }
    }
}
