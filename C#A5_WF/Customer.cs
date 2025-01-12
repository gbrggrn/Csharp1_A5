using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_A5_WF
{
    /// <summary>
    /// Data structure class for Customer.
    /// </summary>
    internal class Customer
    {
        private Contact contact;
        private string customerId;

        /// <summary>
        /// Constructor initializes instance variables.
        /// </summary>
        /// <param name="contactIn">The Contact associated with this instance of Customer</param>
        /// <param name="customerIdIn">The ID associated with this instance of Customer</param>
        public Customer(Contact contactIn, string customerIdIn)
        {
            contact = contactIn;
            customerId = customerIdIn;
        }

        /// <summary>
        /// Properties for contact.
        /// </summary>
        internal Contact Contact
        {
            get { return contact; }
            set { contact = value; }
        }

        /// <summary>
        /// Properties for customerID.
        /// </summary>
        public string CustomerId
        {
            get { return customerId; }
            set { customerId = value; }
        }
    }
}
