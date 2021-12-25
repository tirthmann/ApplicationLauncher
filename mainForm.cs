using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Microsoft.Win32;

namespace ApplicationLauncher
{
    public partial class mainForm : Form
    {
        string FileName = Path.Combine(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Application Launcher"),"Info.bin");
        List<programInfo> programs = new List<programInfo>();

        public mainForm()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var box = new AboutBox();
            box.ShowDialog();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            if (File.Exists(FileName)) //Load a file with existing information
            {
                Console.WriteLine("Reading saved file");
                Stream openFileStream = File.OpenRead(FileName);
                BinaryFormatter deserializer = new BinaryFormatter();
                programs = (List<programInfo>)deserializer.Deserialize(openFileStream);
                openFileStream.Close();
            }
            if (Properties.Settings.Default.FirstStartup == true)
            {
                MessageBox.Show("Welcome to Application Launcher!\nTo setup the application, add the programs you wish to launch under file->add", "Welcome!");
                Properties.Settings.Default.FirstStartup = false;
            }
            loadForm(programs);
        }

        private void buttonLaunch_Click(object sender, EventArgs e)
        {
            foreach (int item in CheckListPrograms.CheckedIndices)
            {
                try
                {
                    System.Diagnostics.Process.Start(programs[item].fileLocation);
                }
                catch (Exception) { }
            }
        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save(); //Save user settings

            for (int i = 0; i < programs.Count(); i++)
            {
                programs[i].lastRun = CheckListPrograms.GetItemChecked(i);
            }
            //Stream TestFilesStream = File.Open(FileName,FileMode.Open);
            Stream TestFilesStream = File.Create(FileName); //save object information to a file for reuse
            BinaryFormatter serializer = new BinaryFormatter();
            serializer.Serialize(TestFilesStream, programs); //The serialized file is binary
            TestFilesStream.Close();

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addProgram = new AddProgramForm();
            addProgram.ShowDialog(); //Opens AddProgramInfo form to add a new entry to the programs class
            if (addProgram.ValidInfo)
            {
                programs.Add(new programInfo(addProgram.ProgramName, addProgram.ProgramFileLocation, false));
            }
            loadForm(programs);
        }

        private void loadForm(List<programInfo> programList)
        {
            CheckListPrograms.Items.Clear();
            toolStripComboBox1.Items.Clear();
            for (int i = 0; i < programList.Count; i++) //iterate through the arrays and add the entries to the checklistbox
            {
                if (programList[i].lastRun == true)
                {
                    CheckListPrograms.Items.Add(programList[i].name, true);
                    toolStripComboBox1.Items.Add(programList[i].name);
                }
                else
                {
                    CheckListPrograms.Items.Add(programList[i].name, false);
                    toolStripComboBox1.Items.Add(programList[i].name);
                }
            }
            
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            programs.Clear();
            loadForm(programs);
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Are you sure you want to remove " + (programs[toolStripComboBox1.SelectedIndex].Name), "!!!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show(programs[toolStripComboBox1.SelectedIndex].Name + " sucessfully removed", "Sucess");
                programs.RemoveAt(toolStripComboBox1.SelectedIndex);
            }
            loadForm(programs);
        }

        private void buttonLaunchAndClose_Click(object sender, EventArgs e)
        {
            {
                foreach (int item in CheckListPrograms.CheckedIndices)
                {
                    try
                    {
                        System.Diagnostics.Process.Start(programs[item].fileLocation);
                    }
                    catch (Exception) { }
                }
            }
            Close();
        }

        private void startWithWindowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var temp = MessageBox.Show("Do you want Application Launcher to run on startup?", "Windows Startup", MessageBoxButtons.YesNo);
            if (temp == DialogResult.Yes)
            {
                var path = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run";
                RegistryKey key = Registry.CurrentUser.OpenSubKey(path, true);
                key.SetValue("Application Launcher", Application.ExecutablePath);
                MessageBox.Show("Check \"Startup Apps\" in Windows settings for Application Launcher and make sure it is enabled", "Sucess!");
            }
            else if (temp == DialogResult.No)
            {
                var path = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run";
                RegistryKey key = Registry.CurrentUser.OpenSubKey(path, true);
                key.DeleteValue("Application Launcher", false);
                MessageBox.Show("Application Launcher has been removed from startup", "Sucess!");
            }
        }
    }
}
