using System.Text.RegularExpressions;

namespace CodelandUserName
{
    internal static partial class MainClass
    {
        public static string CodelandUsernameValidation(string str)
        {
            const string invalid = "false";
            const string valid = "true";

            if (str.IsWhiteSpace())
            {
                return valid;
            }

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

            if (ValidUsername().IsMatch(str))
            {
                return valid;
            }
            else
            {
                return invalid;
            }
        }

        static void Main()
        {
            var username = Console.ReadLine();

            if (username != null)
            {
                Console.WriteLine(CodelandUsernameValidation(username));
            }
        }

        [GeneratedRegex(@"^[a-zA-Z0-9_]+$")]
        private static partial Regex ValidUsername();
    }
}