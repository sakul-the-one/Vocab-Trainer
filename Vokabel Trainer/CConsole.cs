using System;
using System.Windows.Forms;

namespace Vokabel_Trainer
{
    public partial class CConsole : CustomCloseButton
    {
        public CConsole()
        {
            InitializeComponent();
            WriteLine("Console Started");
            ConsoleTextBox.KeyPress += RichTextBox_KeyPress;
            this.CloseButtonClicked += OnCloseButtonPressed;
        }
        private void RichTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Enter key pressed, read the input
                int start = ConsoleTextBox.SelectionStart;
                int length = ConsoleTextBox.Text.Length - start;

                if (length > 0)
                {
                    string userInput = ConsoleTextBox.Text.Substring(start, length);
                    MessageBox.Show($"User Input: {userInput}");

                    // Optionally, clear or process the input
                    ConsoleTextBox.SelectionStart = ConsoleTextBox.TextLength;
                    ConsoleTextBox.SelectionLength = 0;
                    ConsoleTextBox.SelectedText = string.Empty;
                }

                // Cancel the Enter key press to prevent a new line
                e.Handled = true;
            }
        }

        private void ConsoleTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        public void WriteLine(string input)
        {
            ConsoleTextBox.Text += DateTime.Now + ": " + input + "\n";
        }
        public void Write(string input)
        {
            ConsoleTextBox.Text += DateTime.Now + ": " + input;
        }
        public string ReadLine(string Prefix)
        {
            Write(Prefix);
            string Input = "";
            return Input;
        }

        private void CConsole_Load(object sender, EventArgs e)
        {

        }
        public void OnCloseButtonPressed(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
