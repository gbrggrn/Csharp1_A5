namespace C_A5_WF
{
    partial class FormContactDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            nameGroupBox = new GroupBox();
            lastNameTextBox = new TextBox();
            firstNameTextBox = new TextBox();
            lastNameLabel = new Label();
            firstNameLabel = new Label();
            emailPhoneGroupBox = new GroupBox();
            emailPrivateTextBox = new TextBox();
            emailBusinessTextBox = new TextBox();
            cellPhoneTextBox = new TextBox();
            homePhoneTextBox = new TextBox();
            emailPrivateLabel = new Label();
            emailBusinessLabel = new Label();
            cellPhoneLabel = new Label();
            homePhoneLabel = new Label();
            adressGroupBox = new GroupBox();
            countryComboBox = new ComboBox();
            zipCodeTextBox = new TextBox();
            cityTextBox = new TextBox();
            streetTextBox = new TextBox();
            countryLabel = new Label();
            zipCodeLabel = new Label();
            cityLabel = new Label();
            streetLabel = new Label();
            okButton = new Button();
            cancelButton = new Button();
            nameGroupBox.SuspendLayout();
            emailPhoneGroupBox.SuspendLayout();
            adressGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // nameGroupBox
            // 
            nameGroupBox.Controls.Add(lastNameTextBox);
            nameGroupBox.Controls.Add(firstNameTextBox);
            nameGroupBox.Controls.Add(lastNameLabel);
            nameGroupBox.Controls.Add(firstNameLabel);
            nameGroupBox.Location = new Point(25, 23);
            nameGroupBox.Name = "nameGroupBox";
            nameGroupBox.Size = new Size(430, 106);
            nameGroupBox.TabIndex = 0;
            nameGroupBox.TabStop = false;
            nameGroupBox.Text = "Name";
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(128, 61);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(235, 23);
            lastNameTextBox.TabIndex = 3;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(128, 28);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(235, 23);
            firstNameTextBox.TabIndex = 2;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(61, 64);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(61, 15);
            lastNameLabel.TabIndex = 1;
            lastNameLabel.Text = "Last name";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(60, 31);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(62, 15);
            firstNameLabel.TabIndex = 0;
            firstNameLabel.Text = "First name";
            // 
            // emailPhoneGroupBox
            // 
            emailPhoneGroupBox.Controls.Add(emailPrivateTextBox);
            emailPhoneGroupBox.Controls.Add(emailBusinessTextBox);
            emailPhoneGroupBox.Controls.Add(cellPhoneTextBox);
            emailPhoneGroupBox.Controls.Add(homePhoneTextBox);
            emailPhoneGroupBox.Controls.Add(emailPrivateLabel);
            emailPhoneGroupBox.Controls.Add(emailBusinessLabel);
            emailPhoneGroupBox.Controls.Add(cellPhoneLabel);
            emailPhoneGroupBox.Controls.Add(homePhoneLabel);
            emailPhoneGroupBox.Location = new Point(25, 148);
            emailPhoneGroupBox.Name = "emailPhoneGroupBox";
            emailPhoneGroupBox.Size = new Size(430, 147);
            emailPhoneGroupBox.TabIndex = 1;
            emailPhoneGroupBox.TabStop = false;
            emailPhoneGroupBox.Text = "Email and phone";
            // 
            // emailPrivateTextBox
            // 
            emailPrivateTextBox.Location = new Point(128, 110);
            emailPrivateTextBox.Name = "emailPrivateTextBox";
            emailPrivateTextBox.Size = new Size(235, 23);
            emailPrivateTextBox.TabIndex = 8;
            // 
            // emailBusinessTextBox
            // 
            emailBusinessTextBox.Location = new Point(128, 81);
            emailBusinessTextBox.Name = "emailBusinessTextBox";
            emailBusinessTextBox.Size = new Size(235, 23);
            emailBusinessTextBox.TabIndex = 7;
            // 
            // cellPhoneTextBox
            // 
            cellPhoneTextBox.Location = new Point(128, 52);
            cellPhoneTextBox.Name = "cellPhoneTextBox";
            cellPhoneTextBox.Size = new Size(235, 23);
            cellPhoneTextBox.TabIndex = 6;
            // 
            // homePhoneTextBox
            // 
            homePhoneTextBox.Location = new Point(128, 23);
            homePhoneTextBox.Name = "homePhoneTextBox";
            homePhoneTextBox.Size = new Size(235, 23);
            homePhoneTextBox.TabIndex = 5;
            // 
            // emailPrivateLabel
            // 
            emailPrivateLabel.AutoSize = true;
            emailPrivateLabel.Location = new Point(47, 113);
            emailPrivateLabel.Name = "emailPrivateLabel";
            emailPrivateLabel.Size = new Size(75, 15);
            emailPrivateLabel.TabIndex = 4;
            emailPrivateLabel.Text = "Email private";
            // 
            // emailBusinessLabel
            // 
            emailBusinessLabel.AutoSize = true;
            emailBusinessLabel.Location = new Point(38, 84);
            emailBusinessLabel.Name = "emailBusinessLabel";
            emailBusinessLabel.Size = new Size(84, 15);
            emailBusinessLabel.TabIndex = 3;
            emailBusinessLabel.Text = "Email business";
            // 
            // cellPhoneLabel
            // 
            cellPhoneLabel.AutoSize = true;
            cellPhoneLabel.Location = new Point(58, 60);
            cellPhoneLabel.Name = "cellPhoneLabel";
            cellPhoneLabel.Size = new Size(64, 15);
            cellPhoneLabel.TabIndex = 2;
            cellPhoneLabel.Text = "Cell phone";
            // 
            // homePhoneLabel
            // 
            homePhoneLabel.AutoSize = true;
            homePhoneLabel.Location = new Point(45, 31);
            homePhoneLabel.Name = "homePhoneLabel";
            homePhoneLabel.Size = new Size(77, 15);
            homePhoneLabel.TabIndex = 1;
            homePhoneLabel.Text = "Home phone";
            // 
            // adressGroupBox
            // 
            adressGroupBox.Controls.Add(countryComboBox);
            adressGroupBox.Controls.Add(zipCodeTextBox);
            adressGroupBox.Controls.Add(cityTextBox);
            adressGroupBox.Controls.Add(streetTextBox);
            adressGroupBox.Controls.Add(countryLabel);
            adressGroupBox.Controls.Add(zipCodeLabel);
            adressGroupBox.Controls.Add(cityLabel);
            adressGroupBox.Controls.Add(streetLabel);
            adressGroupBox.Location = new Point(25, 315);
            adressGroupBox.Name = "adressGroupBox";
            adressGroupBox.Size = new Size(430, 156);
            adressGroupBox.TabIndex = 2;
            adressGroupBox.TabStop = false;
            adressGroupBox.Text = "Address";
            // 
            // countryComboBox
            // 
            countryComboBox.BackColor = SystemColors.AppWorkspace;
            countryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            countryComboBox.ForeColor = SystemColors.WindowText;
            countryComboBox.FormattingEnabled = true;
            countryComboBox.Location = new Point(128, 109);
            countryComboBox.Name = "countryComboBox";
            countryComboBox.Size = new Size(235, 23);
            countryComboBox.TabIndex = 8;
            // 
            // zipCodeTextBox
            // 
            zipCodeTextBox.Location = new Point(128, 80);
            zipCodeTextBox.Name = "zipCodeTextBox";
            zipCodeTextBox.Size = new Size(235, 23);
            zipCodeTextBox.TabIndex = 7;
            // 
            // cityTextBox
            // 
            cityTextBox.Location = new Point(128, 51);
            cityTextBox.Name = "cityTextBox";
            cityTextBox.Size = new Size(235, 23);
            cityTextBox.TabIndex = 6;
            // 
            // streetTextBox
            // 
            streetTextBox.Location = new Point(128, 22);
            streetTextBox.Name = "streetTextBox";
            streetTextBox.Size = new Size(235, 23);
            streetTextBox.TabIndex = 5;
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Location = new Point(72, 112);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new Size(50, 15);
            countryLabel.TabIndex = 4;
            countryLabel.Text = "Country";
            // 
            // zipCodeLabel
            // 
            zipCodeLabel.AutoSize = true;
            zipCodeLabel.Location = new Point(69, 83);
            zipCodeLabel.Name = "zipCodeLabel";
            zipCodeLabel.Size = new Size(53, 15);
            zipCodeLabel.TabIndex = 3;
            zipCodeLabel.Text = "Zip code";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new Point(94, 54);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new Size(28, 15);
            cityLabel.TabIndex = 2;
            cityLabel.Text = "City";
            // 
            // streetLabel
            // 
            streetLabel.AutoSize = true;
            streetLabel.Location = new Point(85, 25);
            streetLabel.Name = "streetLabel";
            streetLabel.Size = new Size(37, 15);
            streetLabel.TabIndex = 1;
            streetLabel.Text = "Street";
            // 
            // okButton
            // 
            okButton.DialogResult = DialogResult.OK;
            okButton.Location = new Point(110, 486);
            okButton.Name = "okButton";
            okButton.Size = new Size(143, 28);
            okButton.TabIndex = 4;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.DialogResult = DialogResult.Cancel;
            cancelButton.Location = new Point(273, 486);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(143, 28);
            cancelButton.TabIndex = 5;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // FormContactDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(502, 539);
            Controls.Add(cancelButton);
            Controls.Add(okButton);
            Controls.Add(adressGroupBox);
            Controls.Add(emailPhoneGroupBox);
            Controls.Add(nameGroupBox);
            Name = "FormContactDetails";
            Text = "FormContactDetails";
            nameGroupBox.ResumeLayout(false);
            nameGroupBox.PerformLayout();
            emailPhoneGroupBox.ResumeLayout(false);
            emailPhoneGroupBox.PerformLayout();
            adressGroupBox.ResumeLayout(false);
            adressGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox nameGroupBox;
        private Label lastNameLabel;
        private Label firstNameLabel;
        private GroupBox emailPhoneGroupBox;
        private Label emailPrivateLabel;
        private Label emailBusinessLabel;
        private Label cellPhoneLabel;
        private Label homePhoneLabel;
        private GroupBox adressGroupBox;
        private Label countryLabel;
        private Label zipCodeLabel;
        private Label cityLabel;
        private Label streetLabel;
        private TextBox lastNameTextBox;
        private TextBox firstNameTextBox;
        private TextBox emailPrivateTextBox;
        private TextBox emailBusinessTextBox;
        private TextBox cellPhoneTextBox;
        private TextBox homePhoneTextBox;
        private TextBox streetTextBox;
        private ComboBox countryComboBox;
        private TextBox zipCodeTextBox;
        private TextBox cityTextBox;
        private Button okButton;
        private Button cancelButton;
    }
}