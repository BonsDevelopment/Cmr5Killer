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
using Cmr5Killer.Reflection;
using Cmr5Killer.TextParsing;

namespace Cmr5Killer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            

        }

        private void ofdButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Executable|*.exe";
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK && !String.IsNullOrEmpty(openFileDialog1.FileName))
            {
                FileTextBox.Text = openFileDialog1.FileName;
            }
        }

        private void decBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (FileTextBox.Text == "") { return; }

                WhitelistReflection w1 = new WhitelistReflection(FileTextBox.Text, "MyApp.whitelist");
                CookieReflection c1 = new CookieReflection(FileTextBox.Text, "MyApp.cookiework");

                var grabHwid = c1.GetFieldString("thehwidd");
                infoListBox.Items.Add(grabHwid);

                ExtractMSIL.ExtractMSILCodeAsString(FileTextBox.Text);
                var p = RetrieveEncryptedText.EncryptedStrings(ExtractMSIL.GetExecFunction());
                foreach (var item in p)
                {
                    string removeExcess = CleanStrings.CleanString(item, "\"", "\"");



                    infoListBox.Items.Add(w1.DecryptString(grabHwid, removeExcess));

                }
            }
            catch { MessageBox.Show("Not a valid cookie muncher stub"); }


            

        }
    }
}
