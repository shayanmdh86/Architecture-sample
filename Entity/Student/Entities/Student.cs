using System.Runtime.CompilerServices;

namespace App.Domain.Core.Student.Entities;
public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Family{ get; set; }
    public int? Age{ get; set;}
}
