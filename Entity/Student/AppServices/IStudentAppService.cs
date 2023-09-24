using App.Domain.Core.Student.DTOs;

namespace App.Domain.Core.Student.AppServices;

public interface IStudentAppService
{
    Task<List<StudentDto>> GetStudentsAsync();


}
