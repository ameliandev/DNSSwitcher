using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace DNSSwitcher.Clases
{
    class Utils
    {
        #region Variables

        private const string ValidIpAddressRegex = @"^(([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\.){3}([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])$";
        private const string ValidHostnameRegex = @"^(([a-zA-Z0-9]|[a-zA-Z0-9][a-zA-Z0-9\-]*[a-zA-Z0-9])\.)*([A-Za-z0-9]|[A-Za-z0-9][A-Za-z0-9\-]*[A-Za-z0-9])$";

        #endregion

        public static bool isValidAddress(string str)
        {
            if (str == string.Empty) { return false; }
            if (!hasNumbers(str)) { return false; }
            if (isValidIpAdress(str) || isValidHostAdress(str)) { return true; }

            return false;
        }

        #region REGEX

        public static bool hasNumbers(string str)
        {
            var match = Regex.Match(str, "\\d");

            return match.Success;
        }
        public static bool isValidIpAdress(string str)
        {
            return Regex.Match(str, ValidIpAddressRegex).Success;
        }
        public static bool isValidHostAdress(string str)
        {
            return Regex.Match(str, ValidHostnameRegex).Success;
        }

        #endregion

    }
}
