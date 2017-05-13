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

namespace XcomPerkManager.Forms
{
    public partial class ExportManager : Form
    {
        public ExportManager()
        {
            InitializeComponent();
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bBrowse_Click(object sender, EventArgs e)
        {
            ValidationResult validFolder = new ValidationResult();
            validFolder.valid = false;

            FolderBrowserDialog dialog;

            do
            {
                dialog = new FolderBrowserDialog();
                DialogResult dialogResult = dialog.ShowDialog(this);

                if (dialogResult == DialogResult.OK)
                {
                    validFolder = validateFolderPath(dialog.SelectedPath);

                    if (!validFolder.valid)
                    {
                        MessageBox.Show(validFolder.message);
                    }
                }
                else
                {
                    return;
                }
            } while (!validFolder.valid);

            tFolder.Text = dialog.SelectedPath;
        }

        private ValidationResult validateFolderPath(string path)
        {
            ValidationResult validFolderPath = new ValidationResult();
            validFolderPath.valid = true;
            validFolderPath.message = "";

            List<string> fileNames = Directory.GetFiles(path).ToList();
            
            foreach(string fileName in fileNames)
            {
                int xComClassDataStringCompareResult = String.Compare(fileName, "XComClassData.ini", StringComparison.OrdinalIgnoreCase);
                if(xComClassDataStringCompareResult == 0)
                {
                    validFolderPath.valid = false;
                    validFolderPath.message += "This folder already contains XComClassData.init.";
                    validFolderPath.message += "\n";
                }

                int xComGameIntStringCompareResult = String.Compare(fileName, "XComGame.INT", StringComparison.OrdinalIgnoreCase);
                if (xComGameIntStringCompareResult == 0)
                {
                    validFolderPath.valid = false;
                    validFolderPath.message += "This folder already contains XComGame.INT.";
                    validFolderPath.message += "\n";
                }
            }

            if(!validFolderPath.valid)
            {
                validFolderPath.message += "\n";
                validFolderPath.message += "Please choose a new folder.";
            }

            return validFolderPath;
        }

        
    }
}
