// See https://aka.ms/new-console-template for more information

/* CS Enum 
https://www.w3schools.com/cs/trycs.php?filename=demo_enums */

using System;

namespace MyApplication
{
  enum Level
  {
    Low,
    Medium,
    High
  }
  class Program
  {
    static void Main(string[] args)
    {
      Level myVar = Level.Medium;
      Console.WriteLine(myVar);
    }
  }
}