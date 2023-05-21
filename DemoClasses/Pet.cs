namespace DemoClasses;

public abstract class Pet
{
  public abstract string? Name { get; set; }

  public override string? ToString() => Name;
}
