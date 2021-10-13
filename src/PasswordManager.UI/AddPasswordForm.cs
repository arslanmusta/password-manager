using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PasswordManager.Data;

namespace PasswordManager.UI
{
    public partial class AddPasswordForm : Form
    {
        private readonly string _fileName;
        private readonly string _masterPassword;
        public AddPasswordForm(string fileName, string masterPassword)
        {
            _fileName = fileName;
            _masterPassword = masterPassword;
            InitializeComponent();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            var domain = this.DomainTextBox.Text;
            var password = this.PasswordTextBox.Text;

            try
            {
                var fileRepository = new PasswordFileRepository(_fileName, new AesEncryptor(), _masterPassword);

                fileRepository.Add(new Password
                {
                    Domain = domain,
                    HashedPassword = password
                });
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }

            this.Close();
        }

        private void AnyTextBox_Change(object sender, EventArgs e)
        {
            ConfirmButton.Enabled = !(string.IsNullOrWhiteSpace(DomainTextBox.Text) ||
                                      string.IsNullOrWhiteSpace(PasswordTextBox.Text) ||
                                      string.IsNullOrWhiteSpace(ConfirmPasswordTextBox.Text)) &&
                                    PasswordTextBox.Text == ConfirmPasswordTextBox.Text;
        }
    }
}
