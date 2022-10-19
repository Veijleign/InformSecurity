using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ShifrLab1.Data
{
    static class PasswordLimit
    {
        static Regex limitNum = new Regex("[0-9]");
        static Regex limitLetter = new Regex("[A-Za-z]");

        public static bool CheckLimit (string password)
        {
            if (limitNum.IsMatch(password) && limitLetter.IsMatch(password))
            {
                return (true);
            }
            return (false);
        }

    }
}
