using System.Runtime.InteropServices;
using System.Windows.Forms;
using System;

namespace Vokabel_Trainer
{
    partial class CConsole 
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
            this.ConsoleTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // ConsoleTextBox
            // 
            this.ConsoleTextBox.BackColor = System.Drawing.SystemColors.WindowText;
            this.ConsoleTextBox.ForeColor = System.Drawing.Color.Green;
            this.ConsoleTextBox.Location = new System.Drawing.Point(0, 0);
            this.ConsoleTextBox.Name = "ConsoleTextBox";
            this.ConsoleTextBox.Size = new System.Drawing.Size(802, 452);
            this.ConsoleTextBox.TabIndex = 0;
            this.ConsoleTextBox.Text = "";
            this.ConsoleTextBox.TextChanged += new System.EventHandler(this.ConsoleTextBox_TextChanged);
            // 
            // CConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ConsoleTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CConsole";
            this.ShowIcon = false;
            this.Text = "CConsole";
            this.Load += new System.EventHandler(this.CConsole_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox ConsoleTextBox;
    }

    public class CustomCloseButton : Form
    {
        public delegate void CloseButtonClickedHandler(object sender, EventArgs e);
        public event CloseButtonClickedHandler CloseButtonClicked;

        protected virtual void OnCloseButton(EventArgs e)
        {
            // Check if there are any subscribers to the event
            CloseButtonClickedHandler handler = CloseButtonClicked;
            if (handler != null)
            {
                // Call the event handler(s)
                handler(this, e);
            }
        }

        private const int WM_SYSCOMMAND = 0x112;
        private const int SC_CLOSE = 0xF060;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_SYSCOMMAND && (int)m.WParam == SC_CLOSE)
            {
                // Handle the close button click here or ignore to keep the default behavior
                //MessageBox.Show("Custom close button clicked!");
                // this.CloseButton();
                OnCloseButton(EventArgs.Empty);
            }
            else
            {
                base.WndProc(ref m);
            }
        }
    }
}