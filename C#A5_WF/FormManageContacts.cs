using C_A5_WF.Enums;

namespace C_A5_WF
{
    /// <summary>
    /// Responsible for manipulation of the mainForm
    /// </summary>
    public partial class FormManageContacts : Form
    {
        private const int maxSize = 100;
        private readonly CustomerManager customerManager;
        private Contact currentContact;

        /// <summary>
        /// Constructor initializes instace variables and adds a subscription
        /// </summary>
        public FormManageContacts()
        {
            InitializeComponent();

            customerManager = new(maxSize);

            currentContact = new();

            //Subscribe to event. Suppress null warning.
            customerListBox.SelectedIndexChanged += DisplayContactDetails!;
        }

        /// <summary>
        /// Reacts to click of the add-button, attempts to save contact-details
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addButton_Click(object sender, EventArgs e)
        {
            FormContactDetails formContactDetails;
            formContactDetails = new();

            formContactDetails.ShowDialog();

            if (formContactDetails.DialogResult == DialogResult.OK)
            {
                if(EvalContact(formContactDetails))
                {
                    if (customerManager.AddCustomer(currentContact, formContactDetails.UserCountry))
                    {
                        UpdateCustomerListBox();
                    }
                    else
                    {
                        MessageBox.Show("Error: Customer could not be added.",
                            "Something went wrong",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }

            currentContact = new();
        }

        /// <summary>
        /// Reacts to click of the edit-button.
        /// Checks if a customer is selected, retrieves customer data and loads it into a new instance of FormContactDetails.
        /// Evaluates new input and updates the chosen customer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editButton_Click(object sender, EventArgs e)
        {
            if (customerListBox.SelectedIndex == -1)
            {
                MessageBox.Show("No user selected for editing",
                    "Something went wrong",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            int indexToEdit = customerListBox.SelectedIndex;

            if (customerManager.GetCustomer(customerManager.Customers[indexToEdit].CustomerId, out Customer currentCustomer))
            {
                currentContact = currentCustomer.Contact;

                FormContactDetails formUpdateContact;
                formUpdateContact = new();

                formUpdateContact.LoadRecipeToUpdate(currentCustomer);

                formUpdateContact.ShowDialog();

                if (formUpdateContact.DialogResult == DialogResult.OK && EvalContact(formUpdateContact))
                {
                    Countries.Country countryIn = formUpdateContact.UserCountry;
                    customerManager.UpdateCustomer(currentContact, countryIn , int.Parse(customerManager.Customers[indexToEdit].CustomerId));
                    UpdateCustomerListBox();
                    contactDisplayRichTextBox.Clear();
                }
            }
            else
            {
                MessageBox.Show("Could not find customer",
                    "Something went wrong",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            currentContact = new();
        }

        /// <summary>
        /// If a customer is selected in the listBox: Calls DeleteCustomer from CustomerManager-Class
        /// and updates the listBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (customerListBox.SelectedIndex == -1)
            {
                MessageBox.Show("No user selected for termination.",
                    "Something went wrong",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            int indexToDelete = customerListBox.SelectedIndex;

            customerManager.DeleteCustomer(int.Parse(customerManager.Customers[indexToDelete].CustomerId));

            UpdateCustomerListBox();

            contactDisplayRichTextBox.Clear();

            //Deselect listBox if selected
            if (customerListBox.Items.Count > 0)
            {
                customerListBox.SelectedIndex = -1;
            }
        }

        /// <summary>
        /// Tries to set the properties. If exception is thrown, collects messages and displays them to the user.
        /// Resets currentContact.
        /// If no errors: calls AddCustomer from CustomerManager-Class and updates the listBox.
        /// Written this way to comply with Requirement 3.4.
        /// </summary>
        /// <param name="formContactDetails">The active instance of FormContactDetails</param>
        private bool EvalContact(FormContactDetails formContactDetails)
        {
            List<string> errorMessages = new();

            for (int i = 0; i < currentContact.Setters.Length; i++)
            {
                try
                {
                    currentContact.Setters[i](formContactDetails.InputArr[i]);
                }
                catch (ArgumentException ex)
                {
                    //Add ArgumentException message (see contact subclasses) to array of strings errorMessages
                    errorMessages.Add(ex.Message);
                }
            }

            if (errorMessages.Count > 0)
            {
                string listOfErrors = string.Join("\n", errorMessages);

                MessageBox.Show(listOfErrors,
                    "Something went wrong",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Updates the customerListBox
        /// </summary>
        private void UpdateCustomerListBox()
        {
            customerListBox.Items.Clear();

            List<Customer> customerList = customerManager.Customers;

            for (int i = 0; i < customerList.Count; i++)
            {
                string formattedString = string.Format("{0, -4}{1, -21}{2, -21}{3, -51}",
                    customerList[i].CustomerId,
                    customerList[i].Contact.Name.FirstName + " " + customerList[i].Contact.Name.LastName,
                    customerList[i].Contact.Phone.CellPhone,
                    customerList[i].Contact.Email.BusinessEmail);

                customerListBox.Items.Add(formattedString);
            }
        }

        /// <summary>
        /// Formats the contact-details string and displays it in contactDisplayRichTextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DisplayContactDetails(object sender, EventArgs e)
        {
            contactDisplayRichTextBox.Clear();

            //If no selection = return early.
            if (customerListBox.SelectedIndex == -1)
            {
                return;
            }

            int indexToDisplay = customerListBox.SelectedIndex;

            Contact contact = customerManager.Customers[indexToDisplay].Contact;

            string country = contact.Address.Country.ToString();

            if (country.Contains('_'))
            {
                country = country.Replace('_', ' ');
            }

            string formattedString =
                $"{contact.Name.FirstName}" + " " + $"{contact.Name.LastName}" + "\n" +
                $"{contact.Address.City}" + "\n" +
                $"{contact.Address.ZipCode}" + "\n" +
                $"{country}" + "\n\n" +
                $"Emails" + "\n" +
                $" Private: " + $"{contact.Email.HomeEmail}" + "\n" +
                $" Office: " + $"{contact.Email.BusinessEmail}" + "\n\n" +
                $"Phone numbers" + "\n" +
                $" Private: " + $"{contact.Phone.HomePhone}" + "\n" +
                $" Office: " + $"{contact.Phone.CellPhone}";

            contactDisplayRichTextBox.Text = formattedString;
        }
    }
}
