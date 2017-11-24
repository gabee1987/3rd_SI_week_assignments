using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace InputValidation
{
    class SendEmailDialog
    {
        public static string ResultValue;
        private static Form emailForm = new Form();
        private static Label label = new Label();
        private static TextBox textBox = new TextBox();
        private static Button buttonOk = new Button();
        private static Button buttonCancel = new Button();
        private static ErrorProvider emailErrorProvider = new ErrorProvider();
        private static DialogResult dialogResult;

        public static DialogResult SendEmailInputBox(string title, string promptText)
        {

            emailForm.Text = title;
            label.Text = promptText;
            ResultValue = "";
            emailForm.FormClosing += new System.Windows.Forms.FormClosingEventHandler(emailForm_FormClosing);

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonOk.Enabled = false;

            emailForm.ClientSize = new Size(410, 107);
            emailForm.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            emailForm.ClientSize = new Size(Math.Max(300, label.Right + 10), emailForm.ClientSize.Height);
            emailForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            emailForm.StartPosition = FormStartPosition.CenterScreen;
            emailForm.MinimizeBox = false;
            emailForm.MaximizeBox = false;
            emailForm.AcceptButton = buttonOk;
            emailForm.CancelButton = buttonCancel;

            // Set eventhandlers
            textBox.TextChanged += new EventHandler(textBox_TextChanged);
            SetEmailErrorProviderToTextBox(textBox);

            emailForm.ShowDialog();


            if (emailForm.AcceptButton.DialogResult == DialogResult.OK)
            {
                ResultValue = textBox.Text;
                //emailForm.Close();
            }
            else
            {
                //emailForm.Close();
            }
            return dialogResult;
        }

        private static void SetEmailErrorProviderToTextBox(TextBox textBoxToAdd)
        {
            emailErrorProvider.SetIconAlignment(textBoxToAdd, ErrorIconAlignment.MiddleRight);
            emailErrorProvider.SetIconPadding(textBoxToAdd, 2);
            emailErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }

        private static void textBox_TextChanged(object sender, EventArgs e)
        {
            if (RegexValidation.IsEmailValid(textBox.Text))
            {
                emailErrorProvider.SetError(textBox, String.Empty);
                buttonOk.Enabled = true;
            }
            else
            {
                buttonOk.Enabled = false;
                emailErrorProvider.SetError(textBox, "Invalid email format.");
            }
        }

        private static void emailForm_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            if (dialogResult != null) { }
            else dialogResult = DialogResult.None;
        }

        //private static Control AddControls()
        //{

        //}
    }
}
