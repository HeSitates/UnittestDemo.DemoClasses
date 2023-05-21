using DemoClasses.Interfaces;

namespace DemoClasses;

public class PropertyManagerConsumer
{
  private readonly IPropertyManager _propertyManager;

  public PropertyManagerConsumer(IPropertyManager propertyManager)
  {
    _propertyManager = propertyManager;
  }

  public void ChangeNames(string firstName, string lastName)
  {
    _propertyManager.FirstName = firstName;
    _propertyManager.LastName = lastName;
  }

  public string GetName() => $"{_propertyManager.FirstName} {_propertyManager.LastName}";

  public void ChangeFirstName(string firstName) => _propertyManager.ChangeFirstName(firstName);
}
