using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C_A5_WF
{
    /// <summary>
    /// Data structure class for Email.
    /// </summary>
    internal class Email
    {
        private string homeEmail;
        private string businessEmail;

        /// <summary>
        /// Properties for homeEmail.
        /// Throws exception + message if invalid input.
        /// </summary>
        public string HomeEmail
        {
            get => homeEmail;
            set
            {
                if (!ValidateInput.ValidateEmail(value))
                {
                    throw new ArgumentException("Invalid private email address.");
                }

                homeEmail = value;
            }
        }

        /// <summary>
        /// Properties for businessEmail.
        /// Throws exception + message if invalid input.
        /// </summary>
        public string BusinessEmail
        {
            get => businessEmail;
            set
            {
                if (!ValidateInput.ValidateEmail(value))
                {
                    throw new ArgumentException("Invalid business email address");
                }

                businessEmail = value;
            }
        }

        /// <summary>
        /// Constructor initializes instance variables.
        /// </summary>
        public Email()
        {
            homeEmail = string.Empty;
            businessEmail = string.Empty;
        }

        /// <summary>
        /// Explicit setter method that can be stored in an array.
        /// Inline method format is used to assign the value to the property.
        /// </summary>
        /// <param name="homeEmail">The homeEmail to be saved</param>
        public void SetHomeEmail(string homeEmail) => HomeEmail = homeEmail;

        /// <summary>
        /// Explicit setter method that can be stored in an array.
        /// Inline method format is used to assign the value to the property.
        /// </summary>
        /// <param name="businessEmail">The businessEmail to be saved</param>
        public void SetBusinessEmail(string businessEmail) => BusinessEmail = businessEmail;
    }
}
