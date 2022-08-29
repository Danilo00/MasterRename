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

namespace MasterRename
{
    public partial class Form1 : Form
    {
        string FolderPath = string.Empty;
        string ext = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }
        private void btnRename_Click(object sender, EventArgs e)
        {
            //Main Code            
            if (FolderPath != string.Empty)
            {
                string[] files = Directory.GetFiles(FolderPath);

                statusLabel.Text = string.Empty;
                progressBar.Value = 0;
                progressBar.Maximum = files.Length;

                for (int i = 0; i < files.Length; i++)
                {
                    FileInfo file = new FileInfo(files[i]);
                    ext = ExtSelector(file);
                    //If you want to create some new rules, put your code here or edit this row
                    string NewFileName = txtFileName.Text + i.ToString() + ext;
                    File.Move(files[i], files[i].Replace(file.Name, NewFileName));
                    progressBar.Value++;
                    statusLabel.Text = "Loading...";
                }
                statusLabel.Text = "Done.";
            }
            else MessageBox.Show("Please select a Folder.");
        }
        private void tsmiChooseFolder_Click(object sender, EventArgs e)   //Open a dialog Folder Browser and choose Folder with Files
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    FolderPath = fbd.SelectedPath;
                    tsmiFolder.Text = tsmiFolder.Text + Path.GetFileName(FolderPath);

                    //Check empty folder
                    string[] files = Directory.GetFiles(FolderPath);
                    if (files.Length == 0) MessageBox.Show("Please Choose a Folder with Files to Rename", "Folder not valid");
                }
            }            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //Pre Load Extensions
            ComboBoxExt.Items.Add(".jpg");
            ComboBoxExt.Items.Add(".jpeg");
            ComboBoxExt.Items.Add(".png");
            //ExtensionsMenu.Visible = false; //You can use this code if you want to disable the use of any custom extension
        }
        private string ExtSelector(FileInfo file)   //Select the value of the chosen extension string
        {   
            string CustomExt = ComboBoxExt.Text;
            if (!ComboBoxExt.Text.StartsWith(".")) CustomExt = Path.Combine(".", CustomExt);

            if (ChoosedefaultExt.Checked) ext = file.Extension;
            else ext = CustomExt;
            return ext;
        }

        private void ComboBoxExt_ChangeText(object sender, EventArgs e)   //Enable/disable the default extension to the change of custom extension textbox
        {
            if (ComboBoxExt.Text != string.Empty) ChoosedefaultExt.Checked = false;
            else ChoosedefaultExt.Checked = true;
        }

        private void ChoosedefaultExt_Click(object sender, EventArgs e)   //Enable Default extension on click if disabled
        {
            if (!ChoosedefaultExt.Checked) ChoosedefaultExt.Checked = true;
        }

    }
}
