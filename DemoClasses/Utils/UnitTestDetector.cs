using System.Diagnostics.CodeAnalysis;

namespace DemoClasses.Utils;

public static class UnitTestDetector
{
  private static readonly Lazy<UnitTestDetectorRunner> _runner = new();

  public static bool IsRunningFromMicrosoftTest { get; } = _runner.Value.IsRunningMicrosoftTest;

  public static bool IsRunningFromReSharper { get; } = _runner.Value.IsRunningReSharper;

  private sealed class UnitTestDetectorRunner
  {
    [SuppressMessage("Usage", "S1144:Constructor is used", Justification = "False positive")]
    public UnitTestDetectorRunner()
    {
      static bool StartsWithIgnoreCase(string value, string valueToCheck) => value.Contains(valueToCheck, StringComparison.InvariantCultureIgnoreCase);

      foreach (var assemblyFullName in AppDomain.CurrentDomain.GetAssemblies().Select(a => a.FullName))
      {
        if (string.IsNullOrEmpty(assemblyFullName))
        {
          break;
        }

        if (StartsWithIgnoreCase(assemblyFullName, "Microsoft.TestPlatform.PlatformAbstractions"))
        {
          IsRunningMicrosoftTest = true;
          break;
        }

        if (StartsWithIgnoreCase(assemblyFullName, "ReSharperTestRunner"))
        {
          IsRunningReSharper = true;
          break;
        }
      }
    }

    public bool IsRunningMicrosoftTest { get; }

    public bool IsRunningReSharper { get; }
  }
}
