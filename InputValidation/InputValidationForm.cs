﻿using System;
using System.Windows.Forms;
using SerializePeople;
using static SerializePeople.PersonSerializable;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Net.Mail;

namespace InputValidation
{
    public partial class InputValidationForm : Form
    {
        PersonSerializable personToSave = new PersonSerializable();
        private bool correctData = false;
        public InputValidationForm()
        {
            InitializeComponent();
        }

        #region Events

        private void InputValidationForm_Load(object sender, EventArgs e)
        {
            // Set ErrorProviders
            SetNameErrorProviderToTextBox(NameTextBox);
            SetPhoneErrorProviderToTextBox(PhoneTextBox);
            SetEmailErrorProviderToTextBox(EmailTextBox);
            SetDoneButtonErrorProviderToButton(DoneButton);
            SetEmailSendErrorProviderToTextBox(EmailToTextBox);

            // Set BirthDate TextBox mask and rejectEventHandler
            BirthDateMaskedTextBox.Mask = "00/00/0000";
            BirthDateMaskedTextBox.MaskInputRejected += new MaskInputRejectedEventHandler(BirthDateMaskedTextBox_MaskInputRejected);
            BirthDateMaskedTextBox.KeyDown += new KeyEventHandler(BirthDateMaskedTextBox_KeyDown);

        }

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

        private void DoneButton_Click(object sender, EventArgs e)
        {
            if (CheckInputsHasCorrectData())
            {
                SetPersonInfo();

                PreviewPersonDataListView.Items.Clear();
                PreviewPersonDataListView.Items.Add("Name: " + personToSave.Name.ToString());
                PreviewPersonDataListView.Items.Add("BirthDate: " + personToSave.BirthDate.ToString("dd/MM/yyyy"));
                PreviewPersonDataListView.Items.Add("Age: " + personToSave.GetAge().ToString());
                PreviewPersonDataListView.Items.Add("Gender: " + personToSave.Gender.ToString());
                PreviewPersonDataListView.Items.Add("Phone number: " + personToSave.PhoneNumber.ToString());
                PreviewPersonDataListView.Items.Add("Email address: " + personToSave.EmailAddress.ToString());

                correctData = true;
                doneButtonErrorProvider.SetError(DoneButton, String.Empty);
            }
            else
            {
                doneButtonErrorProvider.SetError(DoneButton, "Not all data is correct.");
                //Task.Factory.StartNew(() =>
                //{
                //    System.Threading.Thread.Sleep(3000);
                //    ClearDoneButtonErrorProvider();
                //});
            }

        }

        private void SaveObjectButton_Click(object sender, EventArgs e)
        {
            DialogResult objectDialog = SaveObjectDialog.ShowDialog();
            if (objectDialog.ToString() == "OK")
            {
                FileInfo fileInfo = new FileInfo(SaveObjectDialog.FileName);
                PersonSerializable.SerializePerson(personToSave, fileInfo.ToString());
            }
        }

        private void SaveTextButton_Click(object sender, EventArgs e)
        {
            DialogResult textDialog = SaveTextDialog.ShowDialog();
            if (textDialog.ToString() == "OK")
            {
                FileInfo fileInfo = new FileInfo(SaveTextDialog.FileName);
                StreamWriter streamWriter = fileInfo.CreateText();
                foreach (string sItem in PreviewPersonDataListView.Items)
                {
                    streamWriter.WriteLine(sItem);
                }
                streamWriter.Close();
            }
        }

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            DialogResult openDialog = OpenFileDialog.ShowDialog();
            if (openDialog.ToString() == "OK")
            {
                string openedFileInfoString = OpenFileDialog.FileName;
                FileInfo openedFileInfo = new FileInfo(OpenFileDialog.FileName);
                if (openedFileInfo.Extension == ".ser")
                {
                    PersonSerializable personToShow = PersonSerializable.DeserializePerson(openedFileInfoString);

                    PreviewPersonDataListView.Items.Clear();
                    PreviewPersonDataListView.Items.Add("Name: " + personToShow.Name.ToString());
                    PreviewPersonDataListView.Items.Add("BirthDate: " + personToShow.BirthDate.ToString("dd/MM/yyyy"));
                    PreviewPersonDataListView.Items.Add("Age: " + personToShow.GetAge().ToString());
                    PreviewPersonDataListView.Items.Add("Gender: " + personToShow.Gender.ToString());
                    PreviewPersonDataListView.Items.Add("Phone number: " + personToShow.PhoneNumber.ToString());
                    PreviewPersonDataListView.Items.Add("Email address: " + personToShow.EmailAddress.ToString());
                }
                else if (openedFileInfo.Extension == ".txt")
                {
                    string item;
                    StreamReader streamReader = new StreamReader(openedFileInfoString);
                    PreviewPersonDataListView.Items.Clear();
                    while ((item = streamReader.ReadLine()) != null)
                    {
                        PreviewPersonDataListView.Items.Add(item);
                    }
                    streamReader.Close();
                }
                else
                {
                    MessageBox.Show("Could not open file.", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PreviewPersonDataListView.Items.Clear();
        }

        private void EmailToTextBox_TextChanged(object sender, EventArgs e)
        {
            if (RegexValidation.IsEmailValid(EmailToTextBox.Text))
            {
                nameErrorProvider.SetError(EmailToTextBox, String.Empty);
                SendEmailButton.Enabled = true;
            }
            else
            {
                nameErrorProvider.SetError(EmailToTextBox, "Invalid email format.");
            }
        }

        private void AddEmailButton_Click(object sender, EventArgs e)
        {
            DialogResult emailResult = SendEmailDialog.SendEmailInputBox("Send Person Data to Email", "Enter an email address to send");
            //Check InputBox result
            if (emailResult == System.Windows.Forms.DialogResult.OK)
            {
                EmailToTextBox.Text = SendEmailDialog.ResultValue;
                EmailToTextBox.Visible = true;
            }
        }

        private void SendEmailButton_Click(object sender, EventArgs e)
        {
            string fromEmailAddressString = "gabee1987@gmail.com";
            string toEmailAddressString = EmailToTextBox.Text;
            string emailSubject = "Person Data";
            string emailBody = PreviewPersonDataListView.Text;
            string username = "gabee1987@gmail.com";
            string password = "KonGabee198701Ab";
            if (PreviewPersonDataListView.Items.Count > 0)
            {
                EmailSending.SendEmail(fromEmailAddressString, toEmailAddressString, emailSubject, emailBody, username, password);
            }
            else
            {
                MessageBox.Show("Cannot send email. Person Data is not complete.", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
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

        private void SetDoneButtonErrorProviderToButton(Button buttonToAdd)
        {
            doneButtonErrorProvider = new ErrorProvider();
            doneButtonErrorProvider.SetIconAlignment(buttonToAdd, ErrorIconAlignment.MiddleLeft);
            doneButtonErrorProvider.SetIconPadding(buttonToAdd, 2);
            doneButtonErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }

        private void SetEmailSendErrorProviderToTextBox(TextBox textBoxToAdd)
        {
            emailSendErrorProvider = new ErrorProvider();
            emailSendErrorProvider.SetIconAlignment(textBoxToAdd, ErrorIconAlignment.MiddleRight);
            emailSendErrorProvider.SetIconPadding(textBoxToAdd, 2);
            emailSendErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }

        #endregion

        #region Masked Textbox Events

        private void BirthDateMaskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (BirthDateMaskedTextBox.MaskFull)
            {
                toolTip1.ToolTipTitle = "Input Rejected - Too Much Data";
                toolTip1.Show("You cannot enter any more data into the date field. Delete some characters in order to insert more data.", BirthDateMaskedTextBox, 0, -20, 5000);
            }
            else if (e.Position == BirthDateMaskedTextBox.Mask.Length)
            {
                toolTip1.ToolTipTitle = "Input Rejected - End of Field";
                toolTip1.Show("You cannot add extra characters to the end of this date field.", BirthDateMaskedTextBox, 0, -20, 5000);
            }
            else
            {
                toolTip1.ToolTipTitle = "Input Rejected";
                toolTip1.Show("You can only add numeric characters (0-9) into this date field.", BirthDateMaskedTextBox, 0, -20, 5000);
            }
        }

        private void BirthDateMaskedTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            // The balloon tip is visible for five seconds; if the user types any data before it disappears, collapse it ourselves.
            toolTip1.Hide(BirthDateMaskedTextBox);
        }

        private void BirthDateMaskedTextBox_Leave(object sender, EventArgs e)
        {

        }

        #endregion

        #region Basic Methods

        private bool CheckInputsHasCorrectData()
        {
            if (RegexValidation.IsNameValid(NameTextBox.Text) &&
                RegexValidation.IsPhoneValid(PhoneTextBox.Text) &&
                RegexValidation.IsEmailValid(EmailTextBox.Text) &&
                RegexValidation.IsBirthDateValid(BirthDateMaskedTextBox.Text) &&
                (MaleRadioButton.Checked || FemaleRadioButton.Checked))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void SetPersonInfo()
        {
            string name = NameTextBox.Text;
            DateTime birthDate;
            if (!DateTime.TryParseExact(BirthDateMaskedTextBox.Text, "dd/MM/yyyy", null, DateTimeStyles.None, out birthDate))
            {
                birthDate = new DateTime(0000, 00, 00);
                Console.WriteLine("There was an error during date parse.");
            }
            Genders gender = Genders.Unknown;
            if (MaleRadioButton.Checked)
            {
                gender = Genders.Male;
            }
            else if (FemaleRadioButton.Checked)
            {
                gender = Genders.Female;
            }
            string phoneNumber = PhoneTextBox.Text;
            string email = EmailTextBox.Text;

            personToSave.Name = name;
            personToSave.BirthDate = birthDate;
            personToSave.Gender = gender;
            personToSave.PhoneNumber = phoneNumber;
            personToSave.EmailAddress = email;
            personToSave.SetAge();
        }

        //private void ClearDoneButtonErrorProvider()
        //{
        //    doneButtonErrorProvider.SetError(DoneButton, String.Empty);
        //}

        #endregion

    }
}
