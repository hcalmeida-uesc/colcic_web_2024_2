using System;
using UescColcicAPI.Core;

namespace UescColcicAPI.Services.BD.Interfaces;

public interface IStudentsCRUD : IBaseCRUD<Student>
{
      public Student? CreateSkill(int studentId, Skill skill);
}
