using Ini;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XcomPerkManager.Forms
{
    public partial class ImportClasses : Form
    {
        public ImportClasses()
        {
            InitializeComponent();
        }

        private void bBrowse_Click(object sender, EventArgs e)
        {
            ValidationResult validFolder = new ValidationResult();
            validFolder.valid = false;

            OpenFileDialog dialog;

            do
            {
                dialog = new OpenFileDialog();
                DialogResult dialogResult = dialog.ShowDialog(this);

                if (dialogResult == DialogResult.OK)
                {
                    validFolder = validateIniFile(dialog.FileName);

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

            tFile.Text = dialog.FileName;
        }

        private ValidationResult validateIniFile(string fileName)
        {
            ValidationResult validFile = new ValidationResult();
            validFile.valid = true;
            validFile.message = "";

            if (!fileName.EndsWith("XComClassData.ini", StringComparison.OrdinalIgnoreCase))
            {
                validFile.valid = false;
                validFile.message += "Must select XComClassData.ini file.";
                validFile.message += "\n";
            }

            if (!validFile.valid)
            {
                validFile.message += "Please choose a new file.";
            }

            return validFile;
        }

        private void bImport_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tFile.Text))
            {
                return;
            }

            // TODO Going to have to write own parser for XCom 2's ini files because the library does not support:
            // - Values that span multiple lines
            // - Having multiple values for a single key
            IniFile iniFile = new IniFile(tFile.Text);
            string a = iniFile.IniReadValue("LWS_Technical X2SoldierClassTemplate", "				aStatProgression");
        }
    }
}
