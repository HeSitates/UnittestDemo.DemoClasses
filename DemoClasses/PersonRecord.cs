﻿namespace DemoClasses;

public record PersonRecord
{
  public PersonRecord()
  {
  }

  public PersonRecord(string name)
  {
    LastName = name ?? throw new ArgumentNullException(nameof(name));
  }

  public string? FirstName { get; set; }

  public string? LastName { get; set; }

  public int Salary { get; set; }

  public DateTime DateOfBirth { get; set; }

  public Pet[] Pets { get; set; } = Array.Empty<Pet>();

  public void RaiseSalary(int raise) => Salary += raise;
}
