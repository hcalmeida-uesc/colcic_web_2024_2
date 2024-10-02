using System;

namespace UescColcicAPI.Core;

public class Skill
{
      public int SkillId { get; set; }
      public string Name { get; set; }
      public int StudentId { get; set; }
      public  Student Student { get; set; }
}

