namespace DemoClasses;

public abstract class MyAbstractClass
{
  public void Do()
  {
    MyAbstractMethod();
  }

  public abstract void MyAbstractMethod();

  internal string CallingMethod(Baz baz)
  {
    return ProtectedMethod(baz.Name);
  }

  protected virtual string ProtectedMethod(string? value)
  {
    if (string.IsNullOrWhiteSpace(value))
    {
      return string.Empty;
    }

    switch (value.ToUpper())
    {
      case "ABC":
      case "XYZ":
        return string.Empty;
      default:
        return value;
    }
  }
}
