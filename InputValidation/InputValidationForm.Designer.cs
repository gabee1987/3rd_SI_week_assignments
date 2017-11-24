namespace InputValidation
{
    partial class InputValidationForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputValidationForm));
            this.NameLabel = new System.Windows.Forms.Label();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.SaveTextButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.SimpleTextBoxTabPage = new System.Windows.Forms.TabPage();
            this.PreviewPersonDataListView = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.PreviewPersonDataLabel = new System.Windows.Forms.Label();
            this.DoneButton = new System.Windows.Forms.Button();
            this.DateTemplateLabel = new System.Windows.Forms.Label();
            this.BirthDateMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SendEmailButton = new System.Windows.Forms.Button();
            this.SaveObjectButton = new System.Windows.Forms.Button();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.FemaleRadioButton = new System.Windows.Forms.RadioButton();
            this.MaleRadioButton = new System.Windows.Forms.RadioButton();
            this.BirthDateLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.nameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.phoneErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.emailErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.doneButtonErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.SaveObjectDialog = new System.Windows.Forms.SaveFileDialog();
            this.SaveTextDialog = new System.Windows.Forms.SaveFileDialog();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.PersonDataGroupBox = new System.Windows.Forms.GroupBox();
            this.EmailSendingGroupBox = new System.Windows.Forms.GroupBox();
            this.AddEmailButton = new System.Windows.Forms.Button();
            this.EmailToTextBox = new System.Windows.Forms.TextBox();
            this.emailSendErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.TabControl.SuspendLayout();
            this.SimpleTextBoxTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doneButtonErrorProvider)).BeginInit();
            this.PersonDataGroupBox.SuspendLayout();
            this.EmailSendingGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emailSendErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(22, 24);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name";
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Location = new System.Drawing.Point(19, 104);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(38, 13);
            this.PhoneLabel.TabIndex = 2;
            this.PhoneLabel.Text = "Phone";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(26, 145);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(32, 13);
            this.EmailLabel.TabIndex = 4;
            this.EmailLabel.Text = "Email";
            // 
            // SaveTextButton
            // 
            this.SaveTextButton.Location = new System.Drawing.Point(588, 281);
            this.SaveTextButton.Name = "SaveTextButton";
            this.SaveTextButton.Size = new System.Drawing.Size(99, 23);
            this.SaveTextButton.TabIndex = 7;
            this.SaveTextButton.Text = "Save Text To File";
            this.SaveTextButton.UseVisualStyleBackColor = true;
            this.SaveTextButton.Click += new System.EventHandler(this.SaveTextButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(259, 166);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 7;
            this.SaveButton.Text = "Save to File";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.SimpleTextBoxTabPage);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(706, 346);
            this.TabControl.TabIndex = 11;
            // 
            // SimpleTextBoxTabPage
            // 
            this.SimpleTextBoxTabPage.Controls.Add(this.EmailSendingGroupBox);
            this.SimpleTextBoxTabPage.Controls.Add(this.PersonDataGroupBox);
            this.SimpleTextBoxTabPage.Controls.Add(this.PreviewPersonDataListView);
            this.SimpleTextBoxTabPage.Controls.Add(this.pictureBox1);
            this.SimpleTextBoxTabPage.Controls.Add(this.OpenFileButton);
            this.SimpleTextBoxTabPage.Controls.Add(this.PreviewPersonDataLabel);
            this.SimpleTextBoxTabPage.Controls.Add(this.SaveObjectButton);
            this.SimpleTextBoxTabPage.Controls.Add(this.SaveTextButton);
            this.SimpleTextBoxTabPage.Location = new System.Drawing.Point(4, 22);
            this.SimpleTextBoxTabPage.Name = "SimpleTextBoxTabPage";
            this.SimpleTextBoxTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.SimpleTextBoxTabPage.Size = new System.Drawing.Size(698, 320);
            this.SimpleTextBoxTabPage.TabIndex = 0;
            this.SimpleTextBoxTabPage.Text = "Simple TextBox";
            this.SimpleTextBoxTabPage.UseVisualStyleBackColor = true;
            // 
            // PreviewPersonDataListView
            // 
            this.PreviewPersonDataListView.FormattingEnabled = true;
            this.PreviewPersonDataListView.HorizontalScrollbar = true;
            this.PreviewPersonDataListView.Location = new System.Drawing.Point(459, 29);
            this.PreviewPersonDataListView.Name = "PreviewPersonDataListView";
            this.PreviewPersonDataListView.Size = new System.Drawing.Size(228, 199);
            this.PreviewPersonDataListView.TabIndex = 28;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::InputValidation.Properties.Resources.refresh_icon_png;
            this.pictureBox1.Location = new System.Drawing.Point(670, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(17, 17);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Location = new System.Drawing.Point(594, 237);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(93, 23);
            this.OpenFileButton.TabIndex = 26;
            this.OpenFileButton.Text = "Open File";
            this.OpenFileButton.UseVisualStyleBackColor = true;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // PreviewPersonDataLabel
            // 
            this.PreviewPersonDataLabel.AutoSize = true;
            this.PreviewPersonDataLabel.Location = new System.Drawing.Point(456, 13);
            this.PreviewPersonDataLabel.Name = "PreviewPersonDataLabel";
            this.PreviewPersonDataLabel.Size = new System.Drawing.Size(107, 13);
            this.PreviewPersonDataLabel.TabIndex = 25;
            this.PreviewPersonDataLabel.Text = "Preview Person Data";
            // 
            // DoneButton
            // 
            this.DoneButton.Location = new System.Drawing.Point(317, 184);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(93, 23);
            this.DoneButton.TabIndex = 23;
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = true;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // DateTemplateLabel
            // 
            this.DateTemplateLabel.AutoSize = true;
            this.DateTemplateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTemplateLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.DateTemplateLabel.Location = new System.Drawing.Point(64, 46);
            this.DateTemplateLabel.Name = "DateTemplateLabel";
            this.DateTemplateLabel.Size = new System.Drawing.Size(65, 13);
            this.DateTemplateLabel.TabIndex = 22;
            this.DateTemplateLabel.Text = "dd/mm/yyyy";
            // 
            // BirthDateMaskedTextBox
            // 
            this.BirthDateMaskedTextBox.Location = new System.Drawing.Point(63, 62);
            this.BirthDateMaskedTextBox.Name = "BirthDateMaskedTextBox";
            this.BirthDateMaskedTextBox.Size = new System.Drawing.Size(66, 20);
            this.BirthDateMaskedTextBox.TabIndex = 1;
            this.BirthDateMaskedTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BirthDateMaskedTextBox_KeyDown);
            this.BirthDateMaskedTextBox.Leave += new System.EventHandler(this.BirthDateMaskedTextBox_Leave);
            // 
            // SendEmailButton
            // 
            this.SendEmailButton.Enabled = false;
            this.SendEmailButton.Location = new System.Drawing.Point(9, 26);
            this.SendEmailButton.Name = "SendEmailButton";
            this.SendEmailButton.Size = new System.Drawing.Size(93, 23);
            this.SendEmailButton.TabIndex = 8;
            this.SendEmailButton.Text = "Send Email";
            this.SendEmailButton.UseVisualStyleBackColor = true;
            this.SendEmailButton.Click += new System.EventHandler(this.SendEmailButton_Click);
            // 
            // SaveObjectButton
            // 
            this.SaveObjectButton.Location = new System.Drawing.Point(473, 281);
            this.SaveObjectButton.Name = "SaveObjectButton";
            this.SaveObjectButton.Size = new System.Drawing.Size(109, 23);
            this.SaveObjectButton.TabIndex = 6;
            this.SaveObjectButton.Text = "Save Object To File";
            this.SaveObjectButton.UseVisualStyleBackColor = true;
            this.SaveObjectButton.Click += new System.EventHandler(this.SaveObjectButton_Click);
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.Location = new System.Drawing.Point(150, 65);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(42, 13);
            this.GenderLabel.TabIndex = 16;
            this.GenderLabel.Text = "Gender";
            // 
            // FemaleRadioButton
            // 
            this.FemaleRadioButton.AutoSize = true;
            this.FemaleRadioButton.Location = new System.Drawing.Point(252, 63);
            this.FemaleRadioButton.Name = "FemaleRadioButton";
            this.FemaleRadioButton.Size = new System.Drawing.Size(59, 17);
            this.FemaleRadioButton.TabIndex = 3;
            this.FemaleRadioButton.TabStop = true;
            this.FemaleRadioButton.Text = "Female";
            this.FemaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // MaleRadioButton
            // 
            this.MaleRadioButton.AutoSize = true;
            this.MaleRadioButton.Location = new System.Drawing.Point(198, 63);
            this.MaleRadioButton.Name = "MaleRadioButton";
            this.MaleRadioButton.Size = new System.Drawing.Size(48, 17);
            this.MaleRadioButton.TabIndex = 2;
            this.MaleRadioButton.TabStop = true;
            this.MaleRadioButton.Text = "Male";
            this.MaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // BirthDateLabel
            // 
            this.BirthDateLabel.AutoSize = true;
            this.BirthDateLabel.Location = new System.Drawing.Point(6, 65);
            this.BirthDateLabel.Name = "BirthDateLabel";
            this.BirthDateLabel.Size = new System.Drawing.Size(51, 13);
            this.BirthDateLabel.TabIndex = 12;
            this.BirthDateLabel.Text = "BirthDate";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(63, 21);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(347, 20);
            this.NameTextBox.TabIndex = 0;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Location = new System.Drawing.Point(63, 101);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(347, 20);
            this.PhoneTextBox.TabIndex = 4;
            this.PhoneTextBox.TextChanged += new System.EventHandler(this.PhoneTextBox_TextChanged);
            this.PhoneTextBox.Leave += new System.EventHandler(this.PhoneTextBox_Leave);
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(63, 142);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(347, 20);
            this.EmailTextBox.TabIndex = 5;
            this.EmailTextBox.TextChanged += new System.EventHandler(this.EmailTextBox_TextChanged);
            // 
            // nameErrorProvider
            // 
            this.nameErrorProvider.ContainerControl = this;
            // 
            // phoneErrorProvider
            // 
            this.phoneErrorProvider.ContainerControl = this;
            // 
            // emailErrorProvider
            // 
            this.emailErrorProvider.ContainerControl = this;
            // 
            // doneButtonErrorProvider
            // 
            this.doneButtonErrorProvider.ContainerControl = this;
            // 
            // SaveObjectDialog
            // 
            this.SaveObjectDialog.DefaultExt = "log";
            this.SaveObjectDialog.Filter = "SerializedObject|*.ser";
            // 
            // SaveTextDialog
            // 
            this.SaveTextDialog.DefaultExt = "txt";
            this.SaveTextDialog.Filter = "Text Files|*.txt";
            // 
            // PersonDataGroupBox
            // 
            this.PersonDataGroupBox.Controls.Add(this.NameTextBox);
            this.PersonDataGroupBox.Controls.Add(this.EmailLabel);
            this.PersonDataGroupBox.Controls.Add(this.PhoneLabel);
            this.PersonDataGroupBox.Controls.Add(this.NameLabel);
            this.PersonDataGroupBox.Controls.Add(this.EmailTextBox);
            this.PersonDataGroupBox.Controls.Add(this.DoneButton);
            this.PersonDataGroupBox.Controls.Add(this.PhoneTextBox);
            this.PersonDataGroupBox.Controls.Add(this.DateTemplateLabel);
            this.PersonDataGroupBox.Controls.Add(this.BirthDateLabel);
            this.PersonDataGroupBox.Controls.Add(this.BirthDateMaskedTextBox);
            this.PersonDataGroupBox.Controls.Add(this.MaleRadioButton);
            this.PersonDataGroupBox.Controls.Add(this.FemaleRadioButton);
            this.PersonDataGroupBox.Controls.Add(this.GenderLabel);
            this.PersonDataGroupBox.Location = new System.Drawing.Point(8, 15);
            this.PersonDataGroupBox.Name = "PersonDataGroupBox";
            this.PersonDataGroupBox.Size = new System.Drawing.Size(434, 213);
            this.PersonDataGroupBox.TabIndex = 29;
            this.PersonDataGroupBox.TabStop = false;
            this.PersonDataGroupBox.Text = "Person Data";
            // 
            // EmailSendingGroupBox
            // 
            this.EmailSendingGroupBox.Controls.Add(this.EmailToTextBox);
            this.EmailSendingGroupBox.Controls.Add(this.AddEmailButton);
            this.EmailSendingGroupBox.Controls.Add(this.SendEmailButton);
            this.EmailSendingGroupBox.Location = new System.Drawing.Point(8, 255);
            this.EmailSendingGroupBox.Name = "EmailSendingGroupBox";
            this.EmailSendingGroupBox.Size = new System.Drawing.Size(434, 55);
            this.EmailSendingGroupBox.TabIndex = 30;
            this.EmailSendingGroupBox.TabStop = false;
            this.EmailSendingGroupBox.Text = "Email Sending";
            // 
            // AddEmailButton
            // 
            this.AddEmailButton.Location = new System.Drawing.Point(330, 25);
            this.AddEmailButton.Name = "AddEmailButton";
            this.AddEmailButton.Size = new System.Drawing.Size(93, 23);
            this.AddEmailButton.TabIndex = 9;
            this.AddEmailButton.Text = "Add Email";
            this.AddEmailButton.UseVisualStyleBackColor = true;
            this.AddEmailButton.Visible = false;
            this.AddEmailButton.Click += new System.EventHandler(this.AddEmailButton_Click);
            // 
            // EmailToTextBox
            // 
            this.EmailToTextBox.Location = new System.Drawing.Point(108, 27);
            this.EmailToTextBox.Multiline = true;
            this.EmailToTextBox.Name = "EmailToTextBox";
            this.EmailToTextBox.Size = new System.Drawing.Size(216, 21);
            this.EmailToTextBox.TabIndex = 24;
            this.EmailToTextBox.TextChanged += new System.EventHandler(this.EmailToTextBox_TextChanged);
            // 
            // emailSendErrorProvider
            // 
            this.emailSendErrorProvider.ContainerControl = this;
            // 
            // InputValidationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 346);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.SaveButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InputValidationForm";
            this.Text = "Input Validation Deluxe";
            this.Load += new System.EventHandler(this.InputValidationForm_Load);
            this.TabControl.ResumeLayout(false);
            this.SimpleTextBoxTabPage.ResumeLayout(false);
            this.SimpleTextBoxTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doneButtonErrorProvider)).EndInit();
            this.PersonDataGroupBox.ResumeLayout(false);
            this.PersonDataGroupBox.PerformLayout();
            this.EmailSendingGroupBox.ResumeLayout(false);
            this.EmailSendingGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emailSendErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Button SaveTextButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage SimpleTextBoxTabPage;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.ErrorProvider nameErrorProvider;
        private System.Windows.Forms.ErrorProvider phoneErrorProvider;
        private System.Windows.Forms.ErrorProvider emailErrorProvider;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label BirthDateLabel;
        private System.Windows.Forms.Label GenderLabel;
        private System.Windows.Forms.RadioButton FemaleRadioButton;
        private System.Windows.Forms.RadioButton MaleRadioButton;
        private System.Windows.Forms.Button SendEmailButton;
        private System.Windows.Forms.Button SaveObjectButton;
        private System.Windows.Forms.MaskedTextBox BirthDateMaskedTextBox;
        private System.Windows.Forms.Label DateTemplateLabel;
        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.Label PreviewPersonDataLabel;
        private System.Windows.Forms.ErrorProvider doneButtonErrorProvider;
        private System.Windows.Forms.SaveFileDialog SaveObjectDialog;
        private System.Windows.Forms.SaveFileDialog SaveTextDialog;
        private System.Windows.Forms.Button OpenFileButton;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox PreviewPersonDataListView;
        private System.Windows.Forms.GroupBox EmailSendingGroupBox;
        private System.Windows.Forms.TextBox EmailToTextBox;
        private System.Windows.Forms.Button AddEmailButton;
        private System.Windows.Forms.GroupBox PersonDataGroupBox;
        private System.Windows.Forms.ErrorProvider emailSendErrorProvider;
    }
}

