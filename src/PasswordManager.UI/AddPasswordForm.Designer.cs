
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
            this.DomainTextBox.Location = new System.Drawing.Point(78, 12);
            this.DomainTextBox.Name = "DomainTextBox";
            this.DomainTextBox.Size = new System.Drawing.Size(226, 23);
            this.DomainTextBox.TabIndex = 1;
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
            this.PasswordTextBox.Location = new System.Drawing.Point(78, 52);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(226, 23);
            this.PasswordTextBox.TabIndex = 3;
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(13, 96);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(75, 23);
            this.ConfirmButton.TabIndex = 4;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            // 
            // AddPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 131);
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
    }
}