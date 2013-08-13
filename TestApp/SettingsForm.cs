using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SkypeFx
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SaveSettingsBtn_Click(object sender, EventArgs e)
        {
            SkypeFx.Properties.Settings.Default["LogPath"] = LogPathTxt.Text;
            SkypeFx.Properties.Settings.Default.Save();

            this.Close();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            LogPathTxt.Text= SkypeFx.Properties.Settings.Default["LogPath"].ToString()  ;
        }
    }
}
