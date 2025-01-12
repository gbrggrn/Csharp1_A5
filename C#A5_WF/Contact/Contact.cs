using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_A5_WF
{
    /// <summary>
    /// Data structure class for Contacts.
    /// </summary>
    internal class Contact
    {
        private Name name;
        private Phone phone;
        private Email email;
        private Address address;

        private Action<String>[] setters; //Array of setters

        private Func<string>[] getters; //Array of getters

        /// <summary>
        /// Constructor initializes instance variables.
        /// </summary>
        public Contact()
        {
            name = new();
            phone = new();
            email = new();
            address = new();

            InitSetters();

            InitGetters();
        }

        /// <summary>
        /// Get/set propery for name.
        /// </summary>
        public Name Name
        {
            get => name;
            set { name = value; }
        }

        /// <summary>
        /// Get/set property for phone.
        /// </summary>
        public Phone Phone
        {
            get => phone;
            set { phone = value; }
        }

        /// <summary>
        /// Get/set propery for email.
        /// </summary>
        public Email Email
        {
            get => email;
            set { email = value; }
        }

        /// <summary>
        /// Get/set property for address.
        /// </summary>
        public Address Address
        {
            get => address;
            set { address = value; }
        }

        /// <summary>
        /// Returns the array of setters.
        /// </summary>
        public Action<string>[] Setters
        {
            get => setters;
        }

        /// <summary>
        /// Returns the array of getters.
        /// </summary>
        public Func<string>[] Getters
        {
            get => getters;
        }

        /// <summary>
        /// Initializes the setters array with all setters for this class.
        /// Takes one string as argument and "Action" always returns void.
        /// </summary>
        private void InitSetters()
        {
            setters = new Action<string>[]
            {
                (Name.SetFirstName),
                (Name.SetLastName),
                (Phone.SetHomePhone),
                (Phone.SetCellPhone),
                (Email.SetBusinessEmail),
                (Email.SetHomeEmail),
                (Address.SetStreet),
                (Address.SetCity),
                (Address.SetZipCode)
            };
        }

        /// <summary>
        /// Initializes the array of getters with all getters for this class.
        /// () = takes no argument.
        /// <string>Returns a string</string>
        /// </summary>
        private void InitGetters()
        {
            getters = new Func<string>[]
            {
                () => Name.FirstName,
                () => Name.LastName,
                () => Phone.HomePhone,
                () => Phone.CellPhone,
                () => Email.BusinessEmail,
                () => Email.HomeEmail,
                () => Address.Street,
                () => Address.City,
                () => Address.ZipCode
            };
        }
    }
}
