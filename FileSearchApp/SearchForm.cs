using System;
using System.IO;
using System.Windows.Forms;

namespace FileSearchApp
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            DialogResult result = folderBrowserDialog.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
            {
                string[] files = Directory.GetFiles(folderBrowserDialog.SelectedPath, searchMaskTextBox.Text);
                fileListBox.Items.Clear();
                fileListBox.Items.AddRange(files);
            }
        }
    }
}