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
    public partial class Form1 : Form
    {
        private bool flag = false;
        private string date = null;
        private string addres = null;

        public Form1()
        {
            InitializeComponent();
        }        

        private void writeFile_button_Click(object sender, EventArgs e)
        {
            CText cl = new CText();
            string str1 = textInput.Text + "\r\n";
            date = DateTime.Now.Hour + ":" + DateTime.Now.Minute;

            if (addres == null && addres != addressFile.Text)
                addres = addressFile.Text;

            cl.WFile(addres, str1);
            
            MessageBox.Show("Успешно записано!", "Сообщение", MessageBoxButtons.OK);

            flag = true;
        }

        private void AddressFile_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog pfg = new OpenFileDialog();
            pfg.ShowDialog();
            addressFile.Text = pfg.FileName;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            CText cl = new CText();
            if(addres != null)
            {
                if (flag)
                {
                    informationTable.Text += DateTime.Now.ToString() + " || " + SystemInformation.ComputerName + " || " + cl.RFile(addressFile.Text) + "\n";
                    flag = false;
                }
                else if (date != cl.WhenWriteFile(addressFile.Text))
                {
                    informationTable.Text += DateTime.Now.ToString() + " || " + SystemInformation.ComputerName + " || " + cl.RFile(addressFile.Text) + "\n";
                    date = cl.WhenWriteFile(addressFile.Text);
                }
            }            
        }
    }
}
