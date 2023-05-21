namespace DemoClasses;

public class Car
{
  public Person? Owner { get; private set; }

  public void AssignOwner(Person person) => Owner = person;
}
