using C_A5_WF.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_A5_WF
{
    /// <summary>
    /// Data structure class for Address.
    /// </summary>
    internal class Address
    {
        private string street;
        private string city;
        private string zipCode;
        private Countries.Country country;

        /// <summary>
        /// Properties for street.
        /// Throws exception + message if invalid input.
        /// </summary>
        public string Street
        {
            get => street;
            set
            {
                if (!ValidateInput.ValidateAddressInput(value))
                {
                    throw new ArgumentException("Invalid street");
                }
                street = value;
            }
        }

        /// <summary>
        /// Properties for city.
        /// Throws exception + message if invalid input.
        /// </summary>
        public string City
        {
            get => city;
            set
            {
                if (!ValidateInput.ValidateAddressInput(value))
                {
                    throw new ArgumentException("Invalid city");
                }
                city = value;
            }
        }

        /// <summary>
        /// Properties for zipCode.
        /// Throws exception + message if invalid input.
        /// </summary>
        public string ZipCode
        {
            get => zipCode;
            set
            {
                if (!ValidateInput.ValidateAddressInput(value))
                {
                    throw new ArgumentException("Invalid zipcode");
                }
                zipCode = value;
            }
        }

        /// <summary>
        /// Properties for country.
        /// No validation since it has a default value.
        /// </summary>
        public Countries.Country Country
        {
            get => country;
            set
            {
                country = value;
            }
        }

        /// <summary>
        /// First constructor calls second constructor.
        /// </summary>
        public Address()
            : this(Countries.Country.Unknown)
        {
            //Chain calling constructors to comply with requirement 4.2.4
        }

        /// <summary>
        /// Second constructor calls third constructor.
        /// </summary>
        /// <param name="country">The default initialization value for country</param>
        public Address(Countries.Country country)
            : this(string.Empty, string.Empty, string.Empty)
        {
            Country = country;
        }

        /// <summary>
        /// Third constructor finalizes initialization.
        /// </summary>
        /// <param name="street">The default value for street</param>
        /// <param name="city">The default value for city</param>
        /// <param name="zipCode">The default value for zipCode</param>
        public Address(string street, string city, string zipCode)
        {
            this.street = street;
            this.city = city;
            this.zipCode = zipCode;
        }

        /// <summary>
        /// Explicit setter method that can be stored in an array.
        /// Inline method format is used to assign the value to the property.
        /// </summary>
        /// <param name="street">The name to be saved</param>
        public void SetStreet(string street) => Street = street;

        /// <summary>
        /// Explicit setter method that can be stored in an array.
        /// Inline method format is used to assign the value to the property.
        /// </summary>
        /// <param name="city">The city to be saved</param>
        public void SetCity(string city) => City = city;

        /// <summary>
        /// Explicit setter method that can be stored in an array.
        /// Inline method format is used to assign the value to the property.
        /// </summary>
        /// <param name="zipCode">The zipCode to be saved</param>
        public void SetZipCode(string zipCode) => ZipCode = zipCode;
    }
}
