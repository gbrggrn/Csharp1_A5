using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_A5_WF
{
    /// <summary>
    /// Data structure class for Phone.
    /// </summary>
    internal class Phone
    {
        private string homePhone;
        private string cellPhone;

        /// <summary>
        /// Properties for homePhone.
        /// Throws argument + message if invalid input.
        /// </summary>
        public string HomePhone
        {
            get => homePhone;
            set
            {
                if (!ValidateInput.ValidatePhone(value))
                {
                    throw new ArgumentException("Invalid private phone number.");
                }

                homePhone = value;
            }
        }

        /// <summary>
        /// Properties for cellPhone.
        /// Throws argument + message if invalid input.
        /// </summary>
        public string CellPhone
        {
            get => cellPhone;
            set
            {
                if (!ValidateInput.ValidatePhone(value))
                {
                    throw new ArgumentException("Invalid cell phone number.");
                }
                cellPhone = value;
            }
        }

        /// <summary>
        /// Constructor initializes instance variables.
        /// </summary>
        public Phone()
        {
            homePhone = string.Empty;
            cellPhone = string.Empty;
        }

        /// <summary>
        /// Explicit setter method that can be stored in an array.
        /// Inline method format is used to assign the value to the property.
        /// </summary>
        /// <param name="homePhone">The homePhone to be saved</param>
        public void SetHomePhone(string homePhone) => HomePhone = homePhone;

        /// <summary>
        /// Explicit setter method that can be stored in an array.
        /// Inline method format is used to assign the value to the property.
        /// </summary>
        /// <param name="cellPhone">The cellPhone to be saved</param>
        public void SetCellPhone(string cellPhone) => CellPhone = cellPhone;

    }
}
