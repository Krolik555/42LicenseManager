﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _42LicenseManager
{
    public partial class CreateDatabaseForm : Form
    {
        ConfigClass ConfigOutput = new ConfigClass();

        public CreateDatabaseForm()
        {
            InitializeComponent();
            aTextBoxNewDBDir.Text = $@"C:\42LicenseManagerDB";
            aTextBoxDatabaseName.Text = "MyDatabase";
            aTextBoxTimeToRenew.Text = "21";
        }

        private void AButtonBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog BrowseFolder = new FolderBrowserDialog();
            if (BrowseFolder.ShowDialog() == DialogResult.OK)
            {
                aTextBoxNewDBDir.Text = BrowseFolder.SelectedPath;
            }
        }

        private void AButtonCreateNewDatabase_Click(object sender, EventArgs e)
        {
            try
            {
                string newdbdir = $@"{aTextBoxNewDBDir.Text}\{aTextBoxDatabaseName.Text}.mdf";
                if (File.Exists($@"{aTextBoxNewDBDir.Text}\{aTextBoxDatabaseName.Text}.mdf"))
                {
                    throw new System.IO.IOException();
                }
                // CREATE CONFIG FILE FOR NEW DATABASE
                TextWriter tw = new StreamWriter($@"{Environment.CurrentDirectory}\Config.txt");
                tw.WriteLine($@"DBDIR={aTextBoxNewDBDir.Text}\{aTextBoxDatabaseName.Text}.mdf");
                tw.WriteLine($"TimeToRenew={aTextBoxTimeToRenew.Text}");
                tw.WriteLine($"InstalledDirectory={Environment.CurrentDirectory}");
                tw.WriteLine($"AllowDuplicateMachines={aCheckBoxAllowDupeMachines}");
                tw.Close();

                // GET DATA FOR CREATING NEW DATABASE
                ConfigOutput.DBDir_Name = $@"{aTextBoxNewDBDir.Text}\{aTextBoxDatabaseName.Text}.mdf";
                ConfigOutput.TimeToRenew = aTextBoxTimeToRenew.Text;
                ConfigOutput.InstalledDirectory = Environment.CurrentDirectory;

                // CREATE NEW DATABASE
                Utilities.CreateNewDatabase(ConfigOutput);

                DialogResult = DialogResult.OK;
                this.Close();
                Application.Restart();
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("A database in this location already exists. \nTo create a new Database please use a database name that doesn't already exist.", "Already exists!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        private void ATextBoxNewDBDir_Leave(object sender, EventArgs e)
        {
            if (aTextBoxNewDBDir.Text.EndsWith(@"\"))
            {
                aTextBoxNewDBDir.Text = aTextBoxNewDBDir.Text.Remove(aTextBoxNewDBDir.Text.Length - 1);
                ATextBoxNewDBDir_Leave(this, e);
            }
            try
            {
                DirectoryInfo CheckDir = new DirectoryInfo(aTextBoxNewDBDir.Text);
            }
            catch(Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }

        private void ATextBoxDatabaseName_Leave(object sender, EventArgs e)
        {
            if (aTextBoxDatabaseName.Text.EndsWith(".mdf"))
            {
                aTextBoxDatabaseName.Text = aTextBoxDatabaseName.Text.Remove(aTextBoxDatabaseName.Text.Length - 4);
            }
        }
    }
}
