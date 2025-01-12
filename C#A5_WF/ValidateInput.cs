using C_A5_WF.Enums;
using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_A5_WF
{
    /// <summary>
    /// Validation methods for input.
    /// </summary>
    public class ValidateInput
    {
        /// <summary>
        /// Checks null/whitespace and length of name-input.
        /// </summary>
        /// <param name="name">The name to be validated</param>
        /// <returns>true if valid : false if not</returns>
        public static bool ValidateName(string name)
        {
            return !string.IsNullOrWhiteSpace(name) 
                && name.Length <= 21;
        }

        /// <summary>
        /// Checks address input for null/whitespace and length.
        /// </summary>
        /// <param name="streetOrCityOrZipCode">The street/city/zipcode to be validated</param>
        /// <returns>true if valid : false if not</returns>
        public static bool ValidateAddressInput(string streetOrCityOrZipCode)
        {
            return !string.IsNullOrWhiteSpace(streetOrCityOrZipCode)
                && streetOrCityOrZipCode.Length <= 51;
        }

        /// <summary>
        /// Checks phone input for null/whitespace and length.
        /// </summary>
        /// <param name="phone">The phone number to be validated</param>
        /// <returns>true if valid : false if not</returns>
        public static bool ValidatePhone(string phone)
        {
            return !string.IsNullOrWhiteSpace(phone) 
                && phone.Length <= 21;
        }

        /// <summary>
        /// Checks email input for null/whitespace, special email characters and length.
        /// </summary>
        /// <param name="email">The email address to be validated</param>
        /// <returns>true if valid : false if not</returns>
        public static bool ValidateEmail(string email)
        {
            return !string.IsNullOrWhiteSpace(email)
                && email.Contains("@")
                && email.Contains(".")
                && email.Length <= 51;
        }
    }
}
