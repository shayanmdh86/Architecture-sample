using App.Domain.Core.Student.Data.EfRepository;
using App.Domain.Core.Student.DTOs;
using App.Infru.Data.Db.SqlServer.Ef.DbCtx;

namespace App.Infra.Data.Repos.Ef.Student;

internal class StudentQueryRepo : IStudentQueryRepo
{
    private readonly AppDbContext _context;

    public StudentQueryRepo(AppDbContext context)
    {
        _context = context;
    }
    public Task<List<StudentDto>> GetAllAsync(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
