using System.Text.RegularExpressions;

namespace CodelandUsername
{
    public static partial class MainClass
    {
        /// <summary>
        /// Return a string indicating whether a username is valid or not.
        /// </summary>
        /// <param name="str">A username to validate.</param>
        /// <returns>true if the username is valid, false otherwise.</returns>
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

            // Must start with a character
            if (!CharactersOnly().IsMatch(str[0].ToString()))
            {
                return invalid;
            }

            if (!ValidUsername().IsMatch(str))
            {
                return invalid;
            }
            else
            {
                return valid;
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

        /// <summary>
        /// a-z A-Z 0-9 and underscore are the only valid characters.
        /// </summary>
        [GeneratedRegex(@"^[a-zA-Z0-9_]+$")]
        private static partial Regex ValidUsername();

        /// <summary>
        /// a-z A-Z only.
        /// </summary>
        [GeneratedRegex(@"^[a-zA-Z]+$")]
        private static partial Regex CharactersOnly();
    }
}