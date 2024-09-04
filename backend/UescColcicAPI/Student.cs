using System;

namespace UescColcicAPI;

public class Student
{
   private string _name;
   public string Name { get => _name.ToUpper(); set => _name = value; } 

   public string Email { get; set; }
}
