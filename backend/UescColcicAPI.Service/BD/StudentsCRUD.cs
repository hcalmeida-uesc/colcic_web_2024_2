using UescColcicAPI.Services.BD.Interfaces;
using UescColcicAPI.Core;

namespace UescColcicAPI.Services.BD;

public class StudentsCRUD : IStudentsCRUD
{
    private static readonly List<Student> Students = new()
   {
      new Student { Name = "Douglas", Email = "douglas.cic@uesc.br" },
      new Student { Name = "Estevão", Email = "estevao.cic@uesc.br" },
      new Student { Name = "Gabriel", Email = "gabriel.cic@uesc.br" },
      new Student { Name = "Gabriela", Email = "gabriela.cic@uesc.br" }
   };
    public void Create(Student entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(Student entity)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Student> ReadAll()
    {
        return Students;
    }

    public void Update(Student entity)
    {
        throw new NotImplementedException();
    }

}
