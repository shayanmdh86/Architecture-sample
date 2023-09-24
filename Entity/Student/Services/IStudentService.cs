using App.Domain.Core.Student.DTOs;

namespace App.Domain.Core.Student.Services;

public interface IStudentService
{
    Task<List<StudentDto>> GetStudents(CancellationToken cancellationToken);
}
