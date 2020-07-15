using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            locateExistingFile.Visible = false;
        }


        private void btnGeneratePassword_Click(object sender, EventArgs e)
        {
            string account = accountNameInput.Text;
            string login = loginInput.Text;
            int length = sizeScale.Value;
            passwordDisplay.Text = generateRandomPass(length);
            

        }

        private string generateRandomPass(int length)
        {

            passwordDisplayLabel.Visible = true;
            passwordDisplay.Visible = true;
            Dictionary<int, char> validCharacters = populateCharacterDict();

            char[] preStringArray = new char[length];
            var rand = new Random();
            for (int i = 0; i < length; i++)
            {
                
                int index = rand.Next(1, validCharacters.Count() + 1);

                preStringArray[i] = validCharacters[index];
            }
            string passwordString = new string(preStringArray);
            return passwordString;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void sizeScale_Scroll(object sender, EventArgs e)
        {
            slideScaleValue.Text = sizeScale.Value.ToString();
            slideScaleValue.Text = sizeScale.Value.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sizeScaleMin.Text = sizeScale.Minimum.ToString();
            slideScaleMax.Text = sizeScale.Maximum.ToString();
            slideScaleValue.Text = sizeScaleMin.Text;
            passwordDisplay.Visible = false;
            passwordDisplayLabel.Visible = false;
        }

        private Dictionary<int, char> populateCharacterDict()
        {
            Dictionary<int, char> validCharacters = new Dictionary<int, char>();
            string alphaNumString = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            string symbols = "!@#$%^&*()";

            if (checkBoxSymbols.Checked)
            {
                alphaNumString += symbols;
            }
            char[] validCharArray = alphaNumString.ToCharArray();
            

            for (int i = 1; i <= validCharArray.Length; i++)
            {
                validCharacters.Add(i, validCharArray[i - 1]);
            }

            return validCharacters;
        }

        private void openFolderDialog_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                pathValue.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void saveFile_Click(object sender, EventArgs e)
        {
            if (pathValue.Text == "")
            {
                string message = "You must select a directory before saving.";
                string caption = "No Path Selected";

                MessageBoxButtons buttons = MessageBoxButtons.OK;

                MessageBox.Show(message, caption, buttons);

            }
            else if (accountNameInput.Text == "")
            {
                string message = "You must add an account name.";
                string caption = "No Account Supplied";

                MessageBoxButtons buttons = MessageBoxButtons.OK;

                MessageBox.Show(message, caption, buttons);
            }
            else if (loginInput.Text == "")
            {
                string message = "You must add a login name.";
                string caption = "No Login Supplied";

                MessageBoxButtons buttons = MessageBoxButtons.OK;

                MessageBox.Show(message, caption, buttons);
            }
            else if (passwordDisplay.Text == "")
            {
                string message = "You have not generated a password. Please click 'Generate' to create a password before saving.";
                string caption = "No Password Detected";

                MessageBoxButtons buttons = MessageBoxButtons.OK;

                MessageBox.Show(message, caption, buttons);

            }
            else
            {
                string fullPath = null;

                if (existingFileCheck.Checked)
                {
                    fullPath = pathValue.Text;

                    using (StreamWriter sw = new StreamWriter(fullPath, true))
                    {
                        sw.WriteLine(accountNameInput.Text);
                        sw.WriteLine("");
                        sw.WriteLine("  Login: " + loginInput.Text);
                        sw.WriteLine("  Password: " + passwordDisplay.Text);
                    }
                }
                else
                {
                    string promptValue = Prompt.ShowDialog("Name your file:", "Name");
                    fullPath = pathValue + promptValue + ".txt";

                    using (StreamWriter sw = File.CreateText(fullPath))
                    {
                        sw.WriteLine(accountNameInput.Text);
                        sw.WriteLine("");
                        sw.WriteLine("  Login: " + loginInput.Text);
                        sw.WriteLine("  Password: " + passwordDisplay.Text);
                    }
                }

               
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void existingFileCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (existingFileCheck.Checked)
            {
                locateExistingFile.Visible = true;
                openFolderDialogBtn.Visible = false;
                locateExistingFile.Location = new Point(685, 382);

            }
            else
            {
                locateExistingFile.Visible = false;
                openFolderDialogBtn.Visible = true;
            }

            pathValue.Text = "";
        }

        private void locateExistingFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pathValue.Text = openFileDialog1.FileName;

        }
    }
}
