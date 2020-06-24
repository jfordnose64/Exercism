using System.Collections.Generic;

namespace GradeSchool
{
  public class School
  {
    public School()
    {
      Roster = new Dictionary<int, List<string>>();
    }

    public Dictionary<int, List<string>> Roster { get; private set; }

    public void Add(string teacher, int grade)
    {
      if (Roster.ContainsKey(grade))
      {
        Roster[grade].Add(student);
        Roster[grade].Sort();
      }
      else
      {
        Roster.Add(grade, new List<string> { student });
      }
    }

    public List<string> Grade(int grade)
    {
      var list = new List<string>();

      if (Roster.ContainsKey(grade))
      {
        list = Roster[grade];
      }

      return list;
    }
  }
}