using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace ApplicationLauncher
{
    public partial class AddProgramForm : Form
    {
        public AddProgramForm()
        {
            InitializeComponent();
        }

        private void FileDialog_FileOk(object sender, CancelEventArgs e)
        {
            labelLocationFile.Text = FileDialog.FileName;
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            FileDialog.ShowDialog();
        }

        //values and the properties that are used to pass values from one form to another
        private string programName;
        private string programFileLocation;
        private bool validInfo;

        public string ProgramName
        {
            get => programName;
        }

        public string ProgramFileLocation
        {
            get => programFileLocation;
        }

        public bool ValidInfo
        {
            get => validInfo;
        }
        static public bool IsValidPath(string path)
        {
            return (!Directory.Exists(path));
        }

        private void buttonAddProgram_Click(object sender, EventArgs e)
        {
            if (IsValidPath(labelLocationFile.Text) && labelLocationFile.Text != "Not selected")
            {
                if (textBoxName.Text.Length > 0)
                {
                    validInfo = true;
                    programFileLocation = labelLocationFile.Text;
                    programName = textBoxName.Text;
                    MessageBox.Show("The program was added to the list!", "Success");
                }
                else
                {
                    MessageBox.Show("Invalid name!", "Error");
                }
            }
            else
            {
                MessageBox.Show("Invalid file location!", "Error");
            }
            Close();
        }
    }
}
