using UescColcicAPI.Services.BD.Interfaces;
using UescColcicAPI.Core;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;

namespace UescColcicAPI.Services.BD;

public class StudentsCRUD : IStudentsCRUD
{
    private UescColcicDBContext _context;
   public StudentsCRUD(UescColcicDBContext context){
        _context = context;
   }
    public void Create(Student entity)
    {
        _context.Students.Add(entity);
        _context.SaveChanges();
    }

    public void Delete(Student entity)
    {   
        var student = this.Find(entity.Email);
        if(student is  not null){
            _context.Students.Remove(student);

            _context.SaveChanges();
        }
    }

    public IEnumerable<Student> ReadAll()
    {
        return _context.Students.Include(s => s.Skills);
    }

    public Student? ReadById(int id)
    {
        var student = this.Find(id);
        return student;
    }

    public void Update(Student entity)
    {
        var student = this.Find(entity.StudentId);
        if(student is not null)
        {
            student.Name = entity.Name;
            student.Email = entity.Email;
            _context.SaveChanges();
        }
    }

    public Student? CreateSkill(int studentId, Skill skill)
    {
        var student = this.Find(studentId);
        if(student is not null)
        {
            if(student.Skills is null)
            {
                student.Skills = new List<Skill>();
            }
            student.Skills.Add(skill);
            _context.SaveChanges();
        }
        return student;
    }

    private Student? Find(string email)
    {
        return _context.Students.Include(s => s.Skills).FirstOrDefault(x => x.Email == email);
    }

    private Student? Find(int id)
    {
        return _context.Students.Include(s => s.Skills).FirstOrDefault(x => x.StudentId == id);
    }

}
