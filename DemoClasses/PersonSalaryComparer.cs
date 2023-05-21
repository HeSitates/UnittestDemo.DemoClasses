namespace DemoClasses;

public class PersonSalaryComparer : IComparer<Person>
{
  public int Compare(Person? a, Person? b)
  {
    if (a != null && b != null)
    {
      return a.Salary.CompareTo(b.Salary);
    }

    return a switch
    {
      null when b == null => 0,
      null => -1,
      _ => 1,
    };
  }
}
