namespace DemoClasses
{
  public static class SomeCalculator
  {
    public static CalculationResult DoCalculation() => new()
    {
      // Hard-coded for demo
      RealPart = 5.2,
      ImaginaryPart = 3.9,
    };

    public class CalculationResult
    {
      public double RealPart { get; set; }

      public double ImaginaryPart { get; set; }
    }
  }
}
