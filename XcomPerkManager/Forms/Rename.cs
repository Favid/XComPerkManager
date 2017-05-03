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
    public partial class Rename : Form
    {
        private string originalInternalName;
        private string newInternalName;

        public Rename(string originalInternalName)
        {
            InitializeComponent();

            this.originalInternalName = originalInternalName;
            laCurrentName.Text = this.originalInternalName;

            newInternalName = this.originalInternalName;
            tNewName.Text = newInternalName;
        }

        private void bOk_Click(object sender, EventArgs e)
        {
            // TODO validate name

            newInternalName = tNewName.Text;

            Close();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        public string getNewName()
        {
            return newInternalName;
        }
    }
}
