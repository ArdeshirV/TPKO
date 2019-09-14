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
        public Form1()
        {
            InitializeComponent();
        }

        private bool flag = false;

        private void writeFile_button_Click(object sender, EventArgs e)
        {
            flag = true;
            string str1 = DateTime.Now.ToString() + "    ||    " + SystemInformation.ComputerName + "    ||    " + textInput.Text + "\n";
            CText cl = new CText();
            cl.WFile(addressFile.Text, str1);
            MessageBox.Show("Успешно записано!", "Сообщение", MessageBoxButtons.OK);
        }

        private void AddressFile_button_Click(object sender, EventArgs e)
        {

        }
    }
}
