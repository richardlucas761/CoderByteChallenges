using System;
using System.Text.RegularExpressions;

static class MainClass
{
    public static string CodelandUsernameValidation(string str)
    {
        const string invalid = "false";
        const string valid = "true";

        if (str.Length > 25)
        {
            return invalid;
        }

        if (str.Length < 4)
        {
            return invalid;
        }

        if (str.EndsWith('_'))
        {
            return invalid;
        }

        if (Regex.IsMatch(str, @"^[a-zA-Z0-9_]+$"))
        {
            return valid;
        }
        else
        {
            return invalid;
        }

    }

    // keep this function call here
    static void Main()
    {
        Console.WriteLine(CodelandUsernameValidation(Console.ReadLine()));
    }

}