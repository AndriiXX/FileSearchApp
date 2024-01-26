namespace FileSearchApp
{
    partial class SearchForm
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
            browseButton = new Button();
            fileListBox = new ListBox();
            searchMaskTextBox = new TextBox();
            SuspendLayout();
            // 
            // browseButton
            // 
            browseButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            browseButton.Location = new Point(329, 321);
            browseButton.Name = "browseButton";
            browseButton.Size = new Size(135, 46);
            browseButton.TabIndex = 0;
            browseButton.Text = "Знайти";
            browseButton.UseVisualStyleBackColor = true;
            browseButton.Click += browseButton_Click;
            // 
            // fileListBox
            // 
            fileListBox.FormattingEnabled = true;
            fileListBox.ItemHeight = 15;
            fileListBox.Location = new Point(139, 12);
            fileListBox.Name = "fileListBox";
            fileListBox.Size = new Size(501, 214);
            fileListBox.TabIndex = 1;
            // 
            // searchMaskTextBox
            // 
            searchMaskTextBox.Location = new Point(221, 292);
            searchMaskTextBox.Name = "searchMaskTextBox";
            searchMaskTextBox.Size = new Size(354, 23);
            searchMaskTextBox.TabIndex = 2;
            // 
            // SearchForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(searchMaskTextBox);
            Controls.Add(fileListBox);
            Controls.Add(browseButton);
            Name = "SearchForm";
            Text = "SearchForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button browseButton;
        private ListBox fileListBox;
        private TextBox searchMaskTextBox;
    }
}