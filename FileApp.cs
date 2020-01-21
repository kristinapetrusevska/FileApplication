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
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace FileApplication
{
    public partial class FileApp : Form
    {
        public FileApp()
        {
            InitializeComponent();
        }

        private void openFileExplorer_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();

            if (FBD.ShowDialog() == DialogResult.OK)
            {
                listOfFiles.Items.Clear();
                int numOfRepetitions = 0;
                string textFormat = ".txt";
                string searchString = textBox1.Text;
                string[] files = Directory.GetFiles(FBD.SelectedPath, "*.*", SearchOption.AllDirectories);

                foreach (string file in files)
                {
                    string textInFile = File.ReadAllText(file, Encoding.UTF8);

                    if (file.Contains(textFormat) && textInFile.Contains(searchString))
                    {
                        int countOfRepetitions = Regex.Matches(textInFile, searchString).Count;

                        listOfFiles.Items.Add(file);
                        numOfRepetitions += countOfRepetitions;
                    }

                }
                this.numOfRepetitionsLabel.Text = "Num of repetitions:" + numOfRepetitions;

            }
        }

        private void listOfFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxForSelectedFile.Text = File.ReadAllText(listOfFiles.SelectedItem.ToString(), Encoding.UTF8);
        }
        

        private void listOfFiles_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string selectedFile = listOfFiles.SelectedItem.ToString();
            Process.Start(selectedFile);
        }
    }
}
