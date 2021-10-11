
namespace PasswordManager.UI
{
    partial class MainForm
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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.FileLabel = new System.Windows.Forms.Label();
            this.FileTextBox = new System.Windows.Forms.TextBox();
            this.FileSelectButton = new System.Windows.Forms.Button();
            this.MasterPasswordLabel = new System.Windows.Forms.Label();
            this.MasterPasswordTextBox = new System.Windows.Forms.TextBox();
            this.LoadButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FileLabel
            // 
            this.FileLabel.AutoSize = true;
            this.FileLabel.Location = new System.Drawing.Point(13, 13);
            this.FileLabel.Name = "FileLabel";
            this.FileLabel.Size = new System.Drawing.Size(31, 15);
            this.FileLabel.TabIndex = 0;
            this.FileLabel.Text = "File: ";
            // 
            // FileTextBox
            // 
            this.FileTextBox.Enabled = false;
            this.FileTextBox.Location = new System.Drawing.Point(126, 10);
            this.FileTextBox.Name = "FileTextBox";
            this.FileTextBox.Size = new System.Drawing.Size(309, 23);
            this.FileTextBox.TabIndex = 1;
            // 
            // FileSelectButton
            // 
            this.FileSelectButton.Location = new System.Drawing.Point(454, 10);
            this.FileSelectButton.Name = "FileSelectButton";
            this.FileSelectButton.Size = new System.Drawing.Size(75, 23);
            this.FileSelectButton.TabIndex = 2;
            this.FileSelectButton.Text = "Select";
            this.FileSelectButton.UseVisualStyleBackColor = true;
            this.FileSelectButton.Click += new System.EventHandler(this.FileSelectButton_Click);
            // 
            // MasterPasswordLabel
            // 
            this.MasterPasswordLabel.AutoSize = true;
            this.MasterPasswordLabel.Location = new System.Drawing.Point(13, 42);
            this.MasterPasswordLabel.Name = "MasterPasswordLabel";
            this.MasterPasswordLabel.Size = new System.Drawing.Size(99, 15);
            this.MasterPasswordLabel.TabIndex = 3;
            this.MasterPasswordLabel.Text = "Master Password:";
            // 
            // MasterPasswordTextBox
            // 
            this.MasterPasswordTextBox.Location = new System.Drawing.Point(126, 39);
            this.MasterPasswordTextBox.Name = "MasterPasswordTextBox";
            this.MasterPasswordTextBox.Size = new System.Drawing.Size(309, 23);
            this.MasterPasswordTextBox.TabIndex = 4;
            this.MasterPasswordTextBox.TextChanged += new System.EventHandler(this.MasterPasswordTextBox_TextChanged);
            // 
            // LoadButton
            // 
            this.LoadButton.Enabled = false;
            this.LoadButton.Location = new System.Drawing.Point(454, 39);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(75, 23);
            this.LoadButton.TabIndex = 5;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.MasterPasswordTextBox);
            this.Controls.Add(this.MasterPasswordLabel);
            this.Controls.Add(this.FileSelectButton);
            this.Controls.Add(this.FileTextBox);
            this.Controls.Add(this.FileLabel);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label FileLabel;
        private System.Windows.Forms.TextBox FileTextBox;
        private System.Windows.Forms.Button FileSelectButton;
        private System.Windows.Forms.Label MasterPasswordLabel;
        private System.Windows.Forms.TextBox MasterPasswordTextBox;
        private System.Windows.Forms.Button LoadButton;
    }
}