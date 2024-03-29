﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mail_Filters
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;

            if (txtMail.Text == null || txtMail.Text == "")
            {
                MessageBox.Show("Error: No data","Mail Filters Pro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                progressBar1.Maximum = txtMail.Lines.Length;
                foreach (var item in txtMail.Lines)
                {
                    if (rInclude.Checked)
                    {
                        if (item.Contains(comboBox1.Text))
                        {
                            txtResults.Invoke(new Action(() =>
                            {
                                txtResults.AppendText(item + "\r\n");
                                labelResults.Text = txtResults.Lines.Length.ToString();
                            }));
                        }

                    }
                    else
                    {
                        if (!item.Contains(comboBox1.Text))
                        {
                            txtResults.Invoke(new Action(() =>
                            {
                                txtResults.AppendText(item + "\r\n");
                                labelResults.Text = txtResults.Lines.Length.ToString();
                            }));
                        }
                    }
                    progressBar1.Value++;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Could not start filter. Error: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = null;
            comboBox1.SelectedText = "--- Select Domain ---";
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }


        private void homepageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/dokimkhanh/EmailByDomain");
        }

        private void openItemMenu_Click(object sender, EventArgs e)
        {
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open Text File";
            theDialog.Filter = "TXT files|*.txt";
            theDialog.InitialDirectory = @"C:\";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamReader sr = File.OpenText(theDialog.FileName))
                    {
                        // Read the text
                        txtMail.Text = sr.ReadToEnd();
                        labelTotal.Text = txtMail.Lines.Length.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void clearItemMenu_Click(object sender, EventArgs e)
        {
            try
            {
                txtMail.Clear();
                labelTotal.Text = "0";
                MessageBox.Show("Clear Successful!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Clear Error!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter = "Text file (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.AddExtension = true;
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.Title = "Save Results";
            saveFileDialog1.InitialDirectory = @"C:/";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("File save: " + saveFileDialog1.FileName, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                File.WriteAllText(saveFileDialog1.FileName, txtResults.Text);
            }
            else
            {
                MessageBox.Show("Save cancel!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            saveFileDialog1.Dispose();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                txtResults.Clear();
                labelResults.Text = "0";
                MessageBox.Show("Clear Successful!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Clear Error!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
