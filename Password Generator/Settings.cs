using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Generator
{
    public partial class Settings : Form
    { 
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            PasswordLen.Value = MainForm.PasswordLength;
            Symbols.Checked = MainForm.IncludeSymbols;
            Numbers.Checked = MainForm.IncludeNumbers;
            Upload.Checked = MainForm.Upload;
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm.PasswordLength = (int)PasswordLen.Value;
            MainForm.IncludeSymbols = Symbols.Checked;
            MainForm.IncludeNumbers = Numbers.Checked;
            MainForm.Upload = Upload.Checked;

            Debug.WriteLine("SAVING: Password Length = " + MainForm.PasswordLength + " | Include Symbols = " + MainForm.IncludeSymbols + " | Include Numbers = " + MainForm.IncludeNumbers + " | Upload Password = " + MainForm.Upload);
        }

    }
}
