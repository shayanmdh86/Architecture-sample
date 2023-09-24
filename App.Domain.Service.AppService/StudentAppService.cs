using App.Domain.Core.Student.AppServices;
using App.Domain.Core.Student.DTOs;

namespace App.Domain.Service.AppService;

public class StudentAppService : IStudentAppService
{
    public Task<List<StudentDto>> GetStudentsAsync()
    {
        throw new NotImplementedException();
    }
}
