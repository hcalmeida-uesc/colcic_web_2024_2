using System;

namespace UescColcicAPI.Core;

public class Student
{
   public int StudentId { get; set; }
   public string Name { get; set; } 
   public string Email { get; set; }
   public virtual ICollection<Skill>? Skills { get; set; } = null;
}
