using App.Domain.Core.Student.DTOs;

namespace App.Domain.Core.Student.Data.EfRepository;

public interface IStudentQueryRepo
{
    Task<List<StudentDto>> GetAllAsync(CancellationToken cancellationToken );

}
