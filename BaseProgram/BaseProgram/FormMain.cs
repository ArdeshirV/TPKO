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


namespace BaseProgram
{
    public partial class FormMain : Form
    {
        private bool flag = false;
        private string date = null;
        // private string stringFileAddress = null;

        public FormMain()
        {
            InitializeComponent();

            // Set the Form startup position to the center of screen
            StartPosition = FormStartPosition.CenterScreen;

            // Now if you change the form size everything must looks good!
            TextBoxFileAddress.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            TextBoxInput.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            ButtonFileBrowse.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ButtonWriteFile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TextBoxOutputInfo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom |
                AnchorStyles.Left | AnchorStyles.Right;
            MinimumSize = new Size(320, 200);

            // Whenever user didn't choose a file should be disabled
            ButtonWriteFile.Enabled = false;

            TextBoxFileAddress.Text = string.Empty;
            timer.Start();
        }

        private void ButtonWriteFile_Click(object sender, EventArgs e)
        {
            CText cl = new CText();
            string str1 = TextBoxInput.Text + "\r\n";
            date = DateTime.Now.Hour + ":" + DateTime.Now.Minute;

            // We don't need below code anymore
            //if (stringFileAddress == null && stringFileAddress != TextBoxFileAddress.Text)
            //stringFileAddress = TextBoxFileAddress.Text;

            //cl.WFile(stringFileAddress, str1);
            File.AppendAllText(TextBoxFileAddress.Text, str1);

            MessageBox.Show("Успешно записано!", "Сообщение", MessageBoxButtons.OK);

            flag = true;
        }

        private void TextBoxFileAddress_Click(object sender, EventArgs e)
        {
            var ofdDialog = new OpenFileDialog
            {
                CheckFileExists = true,
                Title = "Browse text file"
            };

            // Accept file-name only if user choose a real file
            if (ofdDialog.ShowDialog() == DialogResult.OK)
            {
                TextBoxFileAddress.Text = ofdDialog.FileName;
                ButtonWriteFile.Enabled = true;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            CText cl = new CText();
            if(TextBoxFileAddress.Text != string.Empty)
            {
                if (flag)
                {
                    TextBoxOutputInfo.Text += DateTime.Now.ToString() +
                        " || " + SystemInformation.ComputerName + " || " +
                        //cl.RFile(TextBoxFileAddress.Text)
                        File.ReadAllText(TextBoxFileAddress.Text) + "\n";
                    flag = false;
                }
                else if (date != cl.WhenWriteFile(TextBoxFileAddress.Text))
                {
                    TextBoxOutputInfo.Text += DateTime.Now.ToString() + " || " +
                        SystemInformation.ComputerName + " || " +
                        //cl.RFile(TextBoxFileAddress.Text)
                        File.ReadAllText(TextBoxFileAddress.Text) + "\n";
                    date = cl.WhenWriteFile(TextBoxFileAddress.Text);
                }
            }            
        }
    }
}
