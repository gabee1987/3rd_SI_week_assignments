using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace InputValidation
{
    public class RegexValidation
    {
        #region Validation methods

        public static bool IsNameValid(string input)
        {
            string firstNameRegex = @"^[A-Za-zÀ-ú]";
            string whiteSpaceRegex = @"+\s";
            string lastNameRegex = @"[A-Za-zÀ-ú]+$";
            string pattern = firstNameRegex + whiteSpaceRegex + lastNameRegex;

            if (input == null)
            {
                return false;
            }
            else
            {
                return Regex.IsMatch(input, pattern);
            }
        }

        public static bool IsBirthDateValid(string input)
        {
            string pattern = @"^(?:(?:31(\/|-|\.)(?:0?[13578]|1[02]))\1|(?:(?:29|30)(\/|-|\.)(?:0?[1,3-9]|1[0-2])\2))(?:(?:1[6-9]|[2-9]\d)?\d{2})$|^(?:29(\/|-|\.)0?2\3(?:(?:(?:1[6-9]|[2-9]\d)?(?:0[48]|[2468][048]|[13579][26])|(?:(?:16|[2468][048]|[3579][26])00))))$|^(?:0?[1-9]|1\d|2[0-8])(\/|-|\.)(?:(?:0?[1-9])|(?:1[0-2]))\4(?:(?:1[6-9]|[2-9]\d)?\d{2})$";
            if (input == null)
            {
                return false;
            }
            else
            {
                return Regex.IsMatch(input, pattern);
            }
        }

        public static bool IsPhoneValid(string input)
        {
            string countryCode = @"((?:\+?3|0)6)";
            string separator = @"(?:[ /-]?|\()?";
            string areaCode = @"(\d{1,2})";
            string separator2 = @"(?:-| |\/|\))?";
            string phoneNumberPart1 = @"(\d{3})";
            string separator3 = @"[ -\/]?";
            string phoneNumberPart2 = @"(\d{3,4})";
            string pattern = countryCode + separator + areaCode + separator2 + phoneNumberPart1 + separator3 + phoneNumberPart2;

            if (input == null)
            {
                return false;
            }
            else if (input.Length != Regex.Match(input, pattern).Length)
            {
                return false;
            }
            else
            {
                return Regex.IsMatch(input, pattern);
            }
        }

        public static bool IsEmailValid(string input)
        {
            string localPart = @"^([0-9a-zA-Z]([!#$%&'*+-/=?^_`{|}~.\w]*[0-9a-zA-Z])*";
            char at = '@';
            string domainPart1 = @"([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)";
            char dot = '.';
            string domainPart2 = @"+[a-zA-Z]{2,9})$";
            string pattern = localPart + at + domainPart1 + dot + domainPart2;

            if (input == null)
            {
                return false;
            }
            else
            {
                return Regex.IsMatch(input, pattern);
            }
        }

        #endregion

        #region Format methods

        public static string ReformatPhoneNumber(string input)
        {
            string countryCode = @"((?:\+?3|0)6)";
            string separator = @"(?:[ /-]?|\()?";
            string areaCode = @"(\d{1,2})";
            string separator2 = @"(?:-| |\))?";
            string phoneNumberPart1 = @"(\d{3})";
            string separator3 = @"[- ]?";
            string phoneNumberPart2 = @"(\d{3,4})";
            string pattern = countryCode + separator + areaCode + separator2 + phoneNumberPart1 + separator3 + phoneNumberPart2;
            string strippedInput = GetNumbers(input);

            Match m = Regex.Match(strippedInput, pattern);

            string formattedPhoneNumber = String.Format("+{0} {1} {2}-{3}",
                                 m.Groups[1].Value,
                                 m.Groups[2].Value,
                                 m.Groups[3].Value,
                                 m.Groups[4].Value
                                 );

            return formattedPhoneNumber;
        }

        public static string GetNumbers(string input)
        {
            return new string(input.Where(c => char.IsDigit(c)).ToArray());
        }

        #endregion
    }
}
