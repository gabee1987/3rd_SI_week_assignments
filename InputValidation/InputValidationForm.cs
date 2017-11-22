using System;
using System.Windows.Forms;

namespace InputValidation
{
    public partial class InputValidationForm : Form
    {
        public InputValidationForm()
        {
            InitializeComponent();
            SetNameErrorProviderToTextBox(NameTextBox);
            SetPhoneErrorProviderToTextBox(PhoneTextBox);
            SetEmailErrorProviderToTextBox(EmailTextBox);
        }

        #region Events

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (RegexValidation.IsNameValid(NameTextBox.Text))
            {
                nameErrorProvider.SetError(NameTextBox, String.Empty);
            }
            else
            {
                nameErrorProvider.SetError(NameTextBox, "Invalid name format.");
            }
        }

        private void PhoneTextBox_TextChanged(object sender, EventArgs e)
        {
            if (RegexValidation.IsPhoneValid(PhoneTextBox.Text))
            {
                nameErrorProvider.SetError(PhoneTextBox, String.Empty);
            }
            else
            {
                nameErrorProvider.SetError(PhoneTextBox, "Invalid phone number format.");
            }
        }

        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {
            if (RegexValidation.IsEmailValid(EmailTextBox.Text))
            {
                nameErrorProvider.SetError(EmailTextBox, String.Empty);
            }
            else
            {
                nameErrorProvider.SetError(EmailTextBox, "Invalid email format.");
            }
        }

        private void PhoneTextBox_Leave(object sender, EventArgs e)
        {
            string originalPhoneTextBoxText = PhoneTextBox.Text;
            PhoneTextBox.Text = RegexValidation.ReformatPhoneNumber(originalPhoneTextBoxText);
        }

        #endregion

        #region ErrorProviders

        // Create and set the nameErrorProvider for a textbox to it's right side
        private void SetNameErrorProviderToTextBox(TextBox textBoxToAdd)
        {
            nameErrorProvider = new ErrorProvider();
            nameErrorProvider.SetIconAlignment(textBoxToAdd, ErrorIconAlignment.MiddleRight);
            nameErrorProvider.SetIconPadding(textBoxToAdd, 2);
            nameErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }

        private void SetPhoneErrorProviderToTextBox(TextBox textBoxToAdd)
        {
            phoneErrorProvider = new ErrorProvider();
            phoneErrorProvider.SetIconAlignment(textBoxToAdd, ErrorIconAlignment.MiddleRight);
            phoneErrorProvider.SetIconPadding(textBoxToAdd, 2);
            phoneErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }

        private void SetEmailErrorProviderToTextBox(TextBox textBoxToAdd)
        {
            emailErrorProvider = new ErrorProvider();
            emailErrorProvider.SetIconAlignment(textBoxToAdd, ErrorIconAlignment.MiddleRight);
            emailErrorProvider.SetIconPadding(textBoxToAdd, 2);
            emailErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }

        #endregion

    }
}
