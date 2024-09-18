using UescColcicAPI.Services.BD.Interfaces;
using UescColcicAPI.Core;

namespace UescColcicAPI.Services.BD;

public class StudentsCRUD : IStudentsCRUD
{
    private static readonly List<Student> Students = new()
   {
      new Student { StudentId = 1, Name = "Douglas", Email = "douglas.cic@uesc.br" },
      new Student { StudentId = 2, Name = "Estevão", Email = "estevao.cic@uesc.br" },
      new Student { StudentId = 3, Name = "Gabriel", Email = "gabriel.cic@uesc.br" },
      new Student { StudentId = 4, Name = "Gabriela", Email = "gabriela.cic@uesc.br" }
   };
    public void Create(Student entity)
    {
        Students.Add(entity);
    }

    public void Delete(Student entity)
    {   
        var student = this.Find(entity.Email);
        if(student is  not null)
            Students.Remove(student);
    }

    public IEnumerable<Student> ReadAll()
    {
        return Students;
    }

    public Student? ReadById(int id)
    {
        var student = this.Find(id);
        return student;
    }

    public void Update(Student entity)
    {
        var student = this.Find(entity.Email);
        if(student is not null) student.Name = entity.Name;
    }

    private Student? Find(string email)
    {
        return Students.FirstOrDefault(x => x.Email == email);
    }

    private Student? Find(int id)
    {
        return Students.FirstOrDefault(x => x.StudentId == id);
    }

}
