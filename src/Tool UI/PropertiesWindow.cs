﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DAM
{
    public partial class PropertiesWindow : Form
    {
        public PropertiesWindow()
        {
            InitializeComponent();
        }

        private void PropertiesWindow_Load(object sender, EventArgs e)
        {
            lock (AppSettings.Default)
            {
                textBoxAccDir.Text = AppSettings.Default.setAccountDir;
                textBoxIoncrossDir.Text = AppSettings.Default.setIonCrossDir;
                textBoxFLDir.Text = AppSettings.Default.setFLDir;
                checkBoxChangedOnly.Checked = AppSettings.Default.setCheckChangedOnly;
                checkBoxWriteEncryptedFiles.Checked = AppSettings.Default.setWriteEncryptedFiles;
                textBoxFLHookPort.Value = AppSettings.Default.setFLHookPort;
                textBoxFLHookLogin.Text = AppSettings.Default.setFLHookPassword;
                checkBoxAutomaticCharClean.Checked = AppSettings.Default.setAutomaticCharClean;
                checkBoxAutomaticCharWipe.Checked = AppSettings.Default.setAutomaticCharWipe;
                numericUpDown1.Value = AppSettings.Default.setDaysToDeleteInactiveChars;
                numericUpDown2.Value = AppSettings.Default.setSecsToDeleteUninterestedChars / 60;
                checkBoxUnicode.Checked = AppSettings.Default.setFLHookUnicode;

                textBoxStatisticsDir.Text = AppSettings.Default.setStatisticsDir;
                textBoxStatsFactions.Text = AppSettings.Default.setStatsFactions;

                checkBoxAutomaticFixCharFiles.Checked = AppSettings.Default.setAutomaticFixErrors;
                checkBoxCheckDefaultEngine.Checked = AppSettings.Default.setCheckDefaultEngine;
                checkBoxCheckDefaultPowerPlant.Checked = AppSettings.Default.setCheckDefaultPowerPlant;
                checkBoxReportVisitError.Checked = AppSettings.Default.setReportVisitErrors;
                checkBoxCheckDefaultLights.Checked = AppSettings.Default.setCheckDefaultLights;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            lock (AppSettings.Default)
            {
                AppSettings.Default.setAccountDir = textBoxAccDir.Text;
                AppSettings.Default.setIonCrossDir = textBoxIoncrossDir.Text;
                AppSettings.Default.setFLDir = textBoxFLDir.Text;
                AppSettings.Default.setCheckChangedOnly = checkBoxChangedOnly.Checked;
                AppSettings.Default.setWriteEncryptedFiles = checkBoxWriteEncryptedFiles.Checked;
                AppSettings.Default.setFLHookPort = textBoxFLHookPort.Value;
                AppSettings.Default.setFLHookPassword = textBoxFLHookLogin.Text;
                AppSettings.Default.setFLHookUnicode = checkBoxUnicode.Checked;
                AppSettings.Default.setAutomaticCharClean = checkBoxAutomaticCharClean.Checked;
                AppSettings.Default.setAutomaticCharWipe = checkBoxAutomaticCharWipe.Checked;
                AppSettings.Default.setDaysToDeleteInactiveChars = numericUpDown1.Value;
                AppSettings.Default.setSecsToDeleteUninterestedChars = numericUpDown2.Value * 60;
                AppSettings.Default.setStatisticsDir = textBoxStatisticsDir.Text;
                AppSettings.Default.setStatsFactions = textBoxStatsFactions.Text;


                AppSettings.Default.setAutomaticFixErrors = checkBoxAutomaticFixCharFiles.Checked;
                AppSettings.Default.setCheckDefaultEngine = checkBoxCheckDefaultEngine.Checked;
                AppSettings.Default.setCheckDefaultPowerPlant = checkBoxCheckDefaultPowerPlant.Checked;
                AppSettings.Default.setReportVisitErrors = checkBoxReportVisitError.Checked;
                AppSettings.Default.setCheckDefaultLights = checkBoxCheckDefaultLights.Checked;
                AppSettings.Default.Save();
            } 
            this.Close();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void accountDirButton_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = textBoxAccDir.Text;
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBoxAccDir.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void ioncrossDirButton_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = textBoxIoncrossDir.Text;
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBoxIoncrossDir.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void flDirButton_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = textBoxFLDir.Text;
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBoxFLDir.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = textBoxStatisticsDir.Text;
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBoxStatisticsDir.Text = folderBrowserDialog1.SelectedPath;
            }
        }
    }
}
