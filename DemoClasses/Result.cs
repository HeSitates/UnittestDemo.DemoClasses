namespace DemoClasses;

public class Result<T>
{
  private Result()
  {
    ErrorMessage = string.Empty;
  }

  public bool Success { get; private init; }

  public T? Value { get; private init; }

  public string ErrorMessage { get; private init; }

  public static Result<T> SetSuccess(T? value = default) => new() { Success = true, Value = value };

  public static Result<T> SetErrorMessage(string errorMessage, T? value = default)
  {
    if (string.IsNullOrWhiteSpace(errorMessage))
    {
      errorMessage = "Unknown error";
    }

    return new Result<T> { Success = false, ErrorMessage = errorMessage, Value = value };
  }

  public static Result<T> SetErrorMessage(string errorMessage, Exception ex) => new() { Success = false, ErrorMessage = string.IsNullOrWhiteSpace(errorMessage) ? ex.Message : $"{errorMessage}: {ex.Message}" };
}
