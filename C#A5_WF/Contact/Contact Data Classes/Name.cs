using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_A5_WF
{
    /// <summary>
    /// /// <summary>
    /// Data structure, get, set and validation for "Name".
    /// See class: ValidateInput for validation methods.
    /// </summary>
    /// </summary>
    internal class Name
    {
        private string firstName;
        private string lastName;

        /// <summary>
        /// Properties for firstName.
        /// Throws exception + message if invalid input.
        /// </summary>
        public string FirstName
        {
            get => firstName;
            set
            {
                if (!ValidateInput.ValidateName(value))
                {
                    throw new ArgumentException("Invalid first name.");
                }

                firstName = value;
            }
        }

        /// <summary>
        /// Properties for lastName.
        /// Throws exception + message if invalid input.
        /// </summary>
        public string LastName
        {
            get => lastName;
            set
            {
                if (!ValidateInput.ValidateName(value))
                {
                    throw new ArgumentException("Invalid last name.");
                }

                lastName = value;
            }
        }

        /// <summary>
        /// Constructor initializes instance variables.
        /// </summary>
        public Name()
        {
            firstName = string.Empty;
            lastName = string.Empty;
        }

        /// <summary>
        /// Explicit setter method that can be stored in an array.
        /// Inline method format is used to assign the value to the property.
        /// </summary>
        /// <param name="firstName">The firstName to be saved</param>
        public void SetFirstName(string firstName) => FirstName = firstName;

        /// <summary>
        /// Explicit setter method that can be stored in an array.
        /// Inline method format is used to assign the value to the property.
        /// </summary>
        /// <param name="lastName">The lastName to be saved</param>
        public void SetLastName(string lastName) => LastName = lastName;
    }
}
