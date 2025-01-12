using C_A5_WF.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace C_A5_WF
{
    /// <summary>
    /// Manages the list of customers.
    /// </summary>
    internal class CustomerManager
    {
        private List<Customer> customers;

        //Collection of unique values to store IDs.
        private HashSet<int> usedIDs;

        private Random random;
        private int maxSize;

        /// <summary>
        /// Constructor initializes instance variables.
        /// </summary>
        /// <param name="maxSizeIn">The maximum size of the registry</param>
        public CustomerManager(int maxSizeIn)
        {
            customers = new();

            usedIDs = new();

            random = new();

            maxSize = maxSizeIn;
        }

        /// <summary>
        /// Getter for the customer-list
        /// </summary>
        public List<Customer> Customers
        {
            get { return customers; }
        }

        /// <summary>
        /// Adds the new customer to the customers-list, along with a customerID to the list.
        /// </summary>
        /// <param name="contactIn">The current instance of Contact</param>
        /// <param name ="countryIn">The user selected country</param>
        public bool AddCustomer(Contact contactIn, Countries.Country countryIn)
        {
            if (contactIn != null && customers.Count < maxSize)
            {
                string newCustomerId = GenerateId();

                Customer newCustomer;
                newCustomer = new(contactIn, newCustomerId);
                newCustomer.Contact.Address.Country = countryIn;

                customers.Add(newCustomer);
                return true;
            }

            return false;
        }

        /// <summary>
        /// Deletes the chosen customer.
        /// </summary>
        /// <param name="customerId">The ID of the customer to be deleted</param>
        public void DeleteCustomer(int customerId)
        {
            for (int i = 0; i < customers.Count; i++)
            {
                if (int.Parse(customers[i].CustomerId) == customerId)
                {
                    customers.RemoveAt(i);
                }
            }

            //ADD VALIDATION
        }

        /// <summary>
        /// Retrieves the customer that is to be edited.
        /// </summary>
        /// <param name="customerIdIn">The ID of the customer to be edited</param>
        /// <param name="customerOut">The Customer that is to be edited</param>
        /// <returns>true if found : false if not</returns>
        public bool GetCustomer(string customerIdIn, out Customer customerOut)
        {
            for (int i = 0; i < customers.Count; i++)
            {
                if (int.Parse(customers[i].CustomerId) == int.Parse(customerIdIn))
                {
                    customerOut = customers[i];
                    return true;
                }
            }

            customerOut = null!;
            return false;
        }

        /// <summary>
        /// Updates the contact information of a customer.
        /// </summary>
        /// <param name="contactIn">The current instance of Contac</param>
        /// <param name="customerId">The ID of the customer to be edited</param>
        public void UpdateCustomer(Contact contactIn, Countries.Country countryIn, int customerId)
        {
            for (int i = 0; i < customers.Count; i++)
            {
                if (int.Parse(customers[i].CustomerId) == customerId)
                {
                    customers[i].Contact = contactIn;
                    customers[i].Contact.Address.Country = countryIn;
                }
            }
        }

        /// <summary>
        /// Generates an ID for every new customer.
        /// </summary>
        /// <returns>The generated ID as a string</returns>
        private string GenerateId()
        {
            int generatedId;

            do
            {
                generatedId = random.Next(maxSize);
            } while (usedIDs.Contains(generatedId)); //Check if already in HashSet

            usedIDs.Add(generatedId); //Add to HashSet

            return generatedId.ToString();
        }
    }
}
