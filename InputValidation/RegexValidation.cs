using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace InputValidation
{
    class RegexValidation
    {
        public static bool IsNameValid(string input)
        {
            string firstNameRegex = @"^[A-Za-zÀ-ú]";
            string whiteSpaceRegex = @"+\s";
            string lastNameRegex = @"[A-Za-zÀ-ú]+$";
            string pattern = firstNameRegex + whiteSpaceRegex + lastNameRegex;

            return Regex.IsMatch(input, pattern);
        }

        public static bool IsPhoneValid(string input)
        {
            string countryCode = @"^(\+?36)?";
            string separator = @"[ -]?";
            string areaCode = @"(\d{1,2}|(\(\d{1,2}\)))?";
            string phoneNumber = @"([ -]?\d){6,7}$";
            string pattern = countryCode + separator + areaCode + phoneNumber;
            return Regex.IsMatch(input, pattern);
        }

        public static bool IsEmailValid(string input)
        {
            string localPart = @"^([0-9a-zA-Z]([!#$%&'*+-/=?^_`{|}~.\w]*[0-9a-zA-Z])*";
            char at = '@';
            string domainPart1 = @"([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)";
            char dot = '.';
            string domainPart2 = @"+[a-zA-Z]{2,9})$";
            string pattern = localPart + at + domainPart1 + dot + domainPart2;
            return Regex.IsMatch(input, pattern);
        }
    }
}
