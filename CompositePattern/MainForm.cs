using System;
using System.Drawing;
using System.Windows.Forms;
using CompositePattern.CompositeForm;
using CompositePattern.CompositeForm.Formfields;

namespace CompositePattern
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void tbnSave_Click(object sender, EventArgs e)
        {
            var isForm1Valid = ValidateForm1();
            var isForm2Valid = ValidateForm2();
            if (isForm1Valid && isForm2Valid)
            {
                MessageBox.Show("All Data is Okay, Data is ready to be saved", "Information", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
           
        }

        private bool ValidateForm2()
        {
            FormElement fatherName = new FullName("Father name",txtFatherName.Text);
            FormElement motherName = new FullName("Mother Name",txtMotherName.Text);

            FormElement parentPhoneNumber = new PhoneNumber("Parent Phone Number ", txtParentPhoneNumber.Text);
            FormElement parentEmail = new EmailAddress("Parent Email Address ",txtParentEmail.Text);

            CompositeFormElement parentsNameInfo = new CompositeFormElement("Parents Name");
            parentsNameInfo.Add(fatherName);
            parentsNameInfo.Add(motherName);

            CompositeFormElement parentsContactInfo = new CompositeFormElement("Parents Contact Info");
            parentsContactInfo.Add(parentPhoneNumber);
            parentsContactInfo.Add(parentEmail);

            CompositeFormElement form2 = new CompositeFormElement("Form2");
            form2.Add(parentsNameInfo);
            form2.Add(parentsContactInfo);

            if (form2.IsValid())
            {
                lblParentFormErrorMsg.ForeColor = Color.Green;
                lblParentFormErrorMsg.Text = "All Data in Form 2 is Okay";
            }
            else
            {
                lblParentFormErrorMsg.ForeColor = Color.Red;
                lblParentFormErrorMsg.Text = form2.ErrorMessage;
            }
            return form2.IsValid();
        }

        private bool ValidateForm1()
        {
            FormElement firstName = new FirstName(txtFirstName.Text);
            FormElement lastName = new LastName(txtLastName.Text);
            FormElement email = new EmailAddress("Email addess ",txtEmail.Text);
            FormElement webAddress = new WebAddress(txtWebSite.Text);
            FormElement mobileNo = new MobileNo(txtMobileNo.Text);
            FormElement phoneNumber = new PhoneNumber("Phone Number ",txtTelePhoneNo.Text);

            CompositeFormElement nameElements = new CompositeFormElement("Name");
            nameElements.Add(firstName);
            nameElements.Add(lastName);

            CompositeFormElement webInformation = new CompositeFormElement("WebInfo");
            webInformation.Add(email);
            webInformation.Add(webAddress);

            CompositeFormElement phoneInformation = new CompositeFormElement("Phone Numbers");
            phoneInformation.Add(mobileNo);
            phoneInformation.Add(phoneNumber);

            CompositeFormElement form1 = new CompositeFormElement("Form1");

            form1.Add(nameElements);
            form1.Add(webInformation);
            form1.Add(phoneInformation);

            if (form1.IsValid())
            {
                lblForm1ErrorMsg.ForeColor = Color.Green;
                lblForm1ErrorMsg.Text = "All Data in Form 1 is Okay";
            }
            else
            {
                lblForm1ErrorMsg.ForeColor = Color.Red;
                lblForm1ErrorMsg.Text = form1.ErrorMessage;
            }
            return form1.IsValid();
        }
    }
}
