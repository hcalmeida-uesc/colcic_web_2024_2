using System;
using System.Text.Json.Serialization;

namespace UescColcicAPI.Core;

public class Skill
{
      public int SkillId { get; set; }
      public string Name { get; set; }
      [JsonIgnore]
      public int StudentId { get; set; }
      [JsonIgnore]
      public virtual Student? Student { get; set; }
}

