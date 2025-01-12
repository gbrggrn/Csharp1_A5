namespace C_A5_WF
{
    partial class FormManageContacts
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            customerListBox = new ListBox();
            contactDisplayRichTextBox = new RichTextBox();
            IDlabel = new Label();
            nameLabel = new Label();
            phoneLabel = new Label();
            emailLabel = new Label();
            contactDetailsLabel = new Label();
            addButton = new Button();
            editButton = new Button();
            deleteButton = new Button();
            SuspendLayout();
            // 
            // customerListBox
            // 
            customerListBox.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customerListBox.FormattingEnabled = true;
            customerListBox.ItemHeight = 15;
            customerListBox.Location = new Point(12, 34);
            customerListBox.Name = "customerListBox";
            customerListBox.Size = new Size(560, 334);
            customerListBox.TabIndex = 0;
            // 
            // contactDisplayRichTextBox
            // 
            contactDisplayRichTextBox.BackColor = SystemColors.AppWorkspace;
            contactDisplayRichTextBox.Enabled = false;
            contactDisplayRichTextBox.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contactDisplayRichTextBox.ForeColor = Color.SteelBlue;
            contactDisplayRichTextBox.Location = new Point(578, 34);
            contactDisplayRichTextBox.Name = "contactDisplayRichTextBox";
            contactDisplayRichTextBox.Size = new Size(262, 334);
            contactDisplayRichTextBox.TabIndex = 1;
            contactDisplayRichTextBox.Text = "";
            // 
            // IDlabel
            // 
            IDlabel.AutoSize = true;
            IDlabel.ForeColor = Color.ForestGreen;
            IDlabel.Location = new Point(12, 9);
            IDlabel.Name = "IDlabel";
            IDlabel.Size = new Size(18, 15);
            IDlabel.TabIndex = 2;
            IDlabel.Text = "ID";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.ForeColor = Color.ForestGreen;
            nameLabel.Location = new Point(36, 9);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(155, 15);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name (surname, first name)";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.ForeColor = Color.ForestGreen;
            phoneLabel.Location = new Point(213, 9);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(76, 15);
            phoneLabel.TabIndex = 4;
            phoneLabel.Text = "Office phone";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.ForeColor = Color.ForestGreen;
            emailLabel.Location = new Point(367, 9);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(71, 15);
            emailLabel.TabIndex = 5;
            emailLabel.Text = "Office email";
            // 
            // contactDetailsLabel
            // 
            contactDetailsLabel.AutoSize = true;
            contactDetailsLabel.ForeColor = Color.ForestGreen;
            contactDetailsLabel.Location = new Point(612, 9);
            contactDetailsLabel.Name = "contactDetailsLabel";
            contactDetailsLabel.Size = new Size(87, 15);
            contactDetailsLabel.TabIndex = 6;
            contactDetailsLabel.Text = "Contact Details";
            // 
            // addButton
            // 
            addButton.Location = new Point(12, 384);
            addButton.Name = "addButton";
            addButton.Size = new Size(153, 45);
            addButton.TabIndex = 7;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(190, 384);
            editButton.Name = "editButton";
            editButton.Size = new Size(153, 45);
            editButton.TabIndex = 8;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(367, 384);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(153, 45);
            deleteButton.TabIndex = 9;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(865, 450);
            Controls.Add(deleteButton);
            Controls.Add(editButton);
            Controls.Add(addButton);
            Controls.Add(contactDetailsLabel);
            Controls.Add(emailLabel);
            Controls.Add(phoneLabel);
            Controls.Add(nameLabel);
            Controls.Add(IDlabel);
            Controls.Add(contactDisplayRichTextBox);
            Controls.Add(customerListBox);
            Name = "mainForm";
            Text = "Customber registry by <Gustaf Berggren>";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox customerListBox;
        private RichTextBox contactDisplayRichTextBox;
        private Label IDlabel;
        private Label nameLabel;
        private Label phoneLabel;
        private Label emailLabel;
        private Label contactDetailsLabel;
        private Button addButton;
        private Button editButton;
        private Button deleteButton;
    }
}
