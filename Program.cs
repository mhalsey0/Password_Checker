using System;

namespace PasswordChecker
{
  class Program
  {
    public static void Main(string[] args)
    {
      int minLength = 5;
      string lowercase = "abcdefghijklmnopqrstuvwxyz";
      string uppercase = lowercase.ToUpper();
      string digits = "0123456789";
      string specialChars = "!@#%^&*()-_=+{}|[];':,.<>?~`";

      Console.WriteLine("Please enter a password:");
      string userInput = Console.ReadLine();

      int score = 0;

      if (userInput.Length > minLength)
      {
        score++;
      }
      if (Tools.Contains(userInput,uppercase))
      {
        score++;
      }
      if (Tools.Contains(userInput,lowercase))
      {
        score++;
      }
      if (Tools.Contains(userInput, digits))
      {
        score++;
      }
      if (Tools.Contains(userInput, specialChars))
      {
        score++;
      }
      
      switch (score)
      {
        case 5:
        case 4:
          Console.WriteLine("the password is extremely strong");
          break;
        case 3:
          Console.WriteLine("the password is strong");
          break;
        case 2:
          Console.WriteLine("the password is medium");
          break;
        case 1:
          Console.WriteLine("the password is weak");
          break;
        default:
          Console.WriteLine("the password doesn't meet any of the standards");
          break;
      }

    }
  }
}
