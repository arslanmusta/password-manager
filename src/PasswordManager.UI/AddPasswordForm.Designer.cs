
namespace PasswordManager.UI
{
    partial class AddPasswordForm
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
            this.DomainLabel = new System.Windows.Forms.Label();
            this.DomainTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.ConfirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmPasswordLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DomainLabel
            // 
            this.DomainLabel.AutoSize = true;
            this.DomainLabel.Location = new System.Drawing.Point(12, 15);
            this.DomainLabel.Name = "DomainLabel";
            this.DomainLabel.Size = new System.Drawing.Size(52, 15);
            this.DomainLabel.TabIndex = 0;
            this.DomainLabel.Text = "Domain:";
            // 
            // DomainTextBox
            // 
            this.DomainTextBox.Location = new System.Drawing.Point(125, 12);
            this.DomainTextBox.Name = "DomainTextBox";
            this.DomainTextBox.Size = new System.Drawing.Size(179, 23);
            this.DomainTextBox.TabIndex = 1;
            this.DomainTextBox.TextChanged += new System.EventHandler(this.AnyTextBox_Change);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(12, 55);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(60, 15);
            this.PasswordLabel.TabIndex = 2;
            this.PasswordLabel.Text = "Password:";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(125, 52);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(179, 23);
            this.PasswordTextBox.TabIndex = 3;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            this.PasswordTextBox.TextChanged += new System.EventHandler(this.AnyTextBox_Change);
            this.PasswordTextBox.VisibleChanged += new System.EventHandler(this.AnyTextBox_Change);
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Enabled = false;
            this.ConfirmButton.Location = new System.Drawing.Point(12, 136);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(75, 23);
            this.ConfirmButton.TabIndex = 4;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // ConfirmPasswordTextBox
            // 
            this.ConfirmPasswordTextBox.Location = new System.Drawing.Point(125, 92);
            this.ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox";
            this.ConfirmPasswordTextBox.Size = new System.Drawing.Size(179, 23);
            this.ConfirmPasswordTextBox.TabIndex = 6;
            this.ConfirmPasswordTextBox.UseSystemPasswordChar = true;
            this.ConfirmPasswordTextBox.TextChanged += new System.EventHandler(this.AnyTextBox_Change);
            this.ConfirmPasswordTextBox.VisibleChanged += new System.EventHandler(this.AnyTextBox_Change);
            // 
            // ConfirmPasswordLabel
            // 
            this.ConfirmPasswordLabel.AutoSize = true;
            this.ConfirmPasswordLabel.Location = new System.Drawing.Point(12, 95);
            this.ConfirmPasswordLabel.Name = "ConfirmPasswordLabel";
            this.ConfirmPasswordLabel.Size = new System.Drawing.Size(107, 15);
            this.ConfirmPasswordLabel.TabIndex = 5;
            this.ConfirmPasswordLabel.Text = "Confirm Password:";
            // 
            // AddPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 173);
            this.Controls.Add(this.ConfirmPasswordTextBox);
            this.Controls.Add(this.ConfirmPasswordLabel);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.DomainTextBox);
            this.Controls.Add(this.DomainLabel);
            this.Name = "AddPasswordForm";
            this.Text = "Password Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DomainLabel;
        private System.Windows.Forms.TextBox DomainTextBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.TextBox ConfirmPasswordTextBox;
        private System.Windows.Forms.Label ConfirmPasswordLabel;
    }
}