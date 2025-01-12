using C_A5_WF.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_A5_WF
{
    /// <summary>
    /// Manages the contact details form.
    /// </summary>
    public partial class FormContactDetails : Form
    {
        private string[] inputArr;
        private TextBox[] textBoxArr;
        private Countries.Country userCountry;

        /// <summary>
        /// Constructor responsible for initializations
        /// </summary>
        public FormContactDetails()
        {
            InitializeComponent();

            FormContactDetails_Load();

            InitArrays();

            userCountry = Countries.Country.Unknown;
        }

        /// <summary>
        /// Property getter for ValidInputArr
        /// </summary>
        public string[] InputArr
        {
            get { return inputArr; }
        }

        /// <summary>
        /// Property getter for Enum Country
        /// </summary>
        public Countries.Country UserCountry
        {
            get { return userCountry; }
        }

        /// <summary>
        /// Loads the country names stored as an enum in the "Countries" class into the countryComboBox
        /// </summary>
        private void FormContactDetails_Load()
        {
            countryComboBox.DataSource = Enum.GetNames(typeof(Countries.Country));

            countryComboBox.SelectedItem = 1;
        }

        /// <summary>
        /// Calls methods to populate the arrays.
        /// </summary>
        private void InitArrays()
        {
            InitTextBoxArr();
            InitInputArr();
        }

        /// <summary>
        /// Overrides the DialogResult "Cancel" that is set in the form to instead prompt the user for y/n.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult quitOrNot = MessageBox.Show("Are you sure? Changes will be lost",
                "Cancel?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (quitOrNot == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        /// <summary>
        /// Calls SaveInput() to store input, then closes the form (preset DialogResult == OK)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void okButton_Click(object sender, EventArgs e)
        {
            SaveInput();

            //Parse selected item from comboBox and assign to userCountry. Suppress null warning because selected is always true.
            userCountry = (Countries.Country)Enum.Parse(typeof(Countries.Country), countryComboBox.SelectedItem!.ToString()!);


            this.Close();
        }

        /// <summary>
        /// Entry point when editing a contact.
        /// Gets the previous input-values and displays them in the corresponding field.
        /// </summary>
        /// <param name="contactGettersIn">Array of Contact getters</param>
        internal void LoadRecipeToUpdate(Customer customerIn)
        {
            for (int i = 0; i < customerIn.Contact.Getters.Length; i++)
            {
                textBoxArr[i].Text = customerIn.Contact.Getters[i].Invoke();
            }

            //Adds the country
            countryComboBox.SelectedItem = customerIn.Contact.Address.Country.ToString();
        }

        /// <summary>
        /// Adds the input from textBoxes to ínputArr.
        /// </summary>
        private void SaveInput()
        {
            for (int i = 0; i < textBoxArr.Length; i++)
            {
                //Retrieves input from textBoxes
                InputArr[i] = textBoxArr[i].Text;
            }
        }

        /// <summary>
        /// Initializes inputArr with empty strings
        /// </summary>
        private void InitInputArr()
        {
            inputArr = new string[9];

            for (int i = 0; i < InputArr.Length; i++)
            {
                InputArr[i] = string.Empty;
            }
        }

        /// <summary>
        /// Initializes textBoxArr with references to each textbox
        /// </summary>
        private void InitTextBoxArr()
        {
            textBoxArr = new TextBox[] {
                firstNameTextBox,
                lastNameTextBox,
                homePhoneTextBox,
                cellPhoneTextBox,
                emailBusinessTextBox,
                emailPrivateTextBox,
                streetTextBox,
                cityTextBox,
                zipCodeTextBox};
        }
    }
}
