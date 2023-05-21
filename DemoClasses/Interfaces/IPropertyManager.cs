namespace DemoClasses.Interfaces;

public interface IPropertyManager
{
  string FirstName { get; set; }

  string LastName { get; set; }

  void ChangeFirstName(string firstName);
}
