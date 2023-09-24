using App.Domain.Core.Student.Entities;
using Microsoft.EntityFrameworkCore;

namespace App.Infru.Data.Db.SqlServer.Ef.DbCtx;

public class AppDbContext : DbContext
{
    private const string ConnactionString = @"server=DESCTOP\SQLEXPRESS;database=Architecture sample;Trusted_Connection=True;TrustServerCertificate=True;Integrated Security = true;";

    public DbSet<Student> students { get; set; }




}
