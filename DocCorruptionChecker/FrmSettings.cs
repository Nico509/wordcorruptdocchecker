﻿using System.Reflection;
using System.Windows.Forms;

namespace DocCorruptionChecker
{
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();

            ckRemoveFallback.Checked = Properties.Settings.Default.RemoveFallback == "true";
            ckOpenInWord.Checked = Properties.Settings.Default.OpenInWord == "true";
            lblDisplayVersion.Text = GetRunningVersion();
        }

        private void BtnOk_Click(object sender, System.EventArgs e)
        {
            Properties.Settings.Default.RemoveFallback = ckRemoveFallback.Checked ? "true" : "false";
            Properties.Settings.Default.OpenInWord = ckOpenInWord.Checked ? "true" : "false";
            Properties.Settings.Default.Save();
            Close();
        }

        private void BtnCancel_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private string GetRunningVersion()
        {
            return Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }
    }
}