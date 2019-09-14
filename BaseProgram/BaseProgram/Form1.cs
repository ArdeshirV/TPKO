using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseProgram
{
    public partial class Form1 : Form
    {
        private bool flag = false;

        public Form1()
        {
            InitializeComponent();
        }        

        private void writeFile_button_Click(object sender, EventArgs e)
        {
            CText cl = new CText();
            string str1 = DateTime.Now.ToString() + " || " + SystemInformation.ComputerName + " || " + textInput.Text + "\n";
            
            cl.WFile(addressFile.Text, str1);
            
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
            if (flag)
            {
                informationTable.Text += DateTime.Now.ToString() + " || " + SystemInformation.ComputerName + " || " + textInput.Text + "\n";
                flag = false;
            }            
        }
    }
}
