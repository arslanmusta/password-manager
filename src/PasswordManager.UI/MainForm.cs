﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PasswordManager.Data;
using PasswordManager.UI.Controls;

namespace PasswordManager.UI
{
    public partial class MainForm : Form
    {
        private readonly Action<string> _fileNameChanged;

        public MainForm()
        {
            InitializeComponent();

            _fileNameChanged += _ => LoadButton.Enabled = !string.IsNullOrEmpty(MasterPasswordTextBox.Text);
            _fileNameChanged += fileName => FileTextBox.Text = fileName;
            _fileNameChanged += _ => AddPasswordButton.Enabled = !string.IsNullOrEmpty(MasterPasswordTextBox.Text);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void FileSelectButton_Click(object sender, EventArgs e)
        {
            var result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                _fileNameChanged(openFileDialog.FileName);
            }
        }

        private void MasterPasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            LoadButton.Enabled = !string.IsNullOrEmpty(MasterPasswordTextBox.Text) &&
                                 !string.IsNullOrEmpty(FileTextBox.Text);
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            LoadFile();
        }

        private void LoadFile()
        {
            try
            {
                var fileRepository = new PasswordFileRepository(openFileDialog.FileName, new AesEncryptor(), MasterPasswordTextBox.Text);
                var passwords = fileRepository.GetAll();
                PasswordDataGridView.DataSource = passwords;
                SetLoad(true);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }

        private void SetLoad(bool isLoad)
        {
            FileSelectButton.Enabled = !isLoad;
            LoadButton.Enabled = !isLoad;
            AddPasswordButton.Enabled = isLoad;
            MasterPasswordTextBox.Enabled = !isLoad;
        }

        private void MasterPasswordTextBox_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Enter)
            {
                LoadFile();
            }
        }

        private void PasswordDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var column = PasswordDataGridView.Columns[e.ColumnIndex];
            if (column is DataGridViewPasswordColumn && e.RowIndex >= 0 && PasswordDataGridView.CurrentCell.Value is string value)
            {
                Clipboard.SetText(value);
            }
        }

        private void AddPasswordButton_Click(object sender, EventArgs e)
        {
            var addPasswordForm = new AddPasswordForm(openFileDialog.FileName, MasterPasswordTextBox.Text);
            addPasswordForm.StartPosition = FormStartPosition.CenterParent;
            addPasswordForm.Closed += (_, _) => LoadFile();
            addPasswordForm.ShowDialog();
        }
    }
}
