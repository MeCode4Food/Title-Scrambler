using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using Title_Scrambler_v0._2.Properties;

namespace Title_Scrambler_v0._2
{
    public partial class Form1 : Form
    {
        string folderPath = "";
        public Form1()
        {
            InitializeComponent();
            textBox_directory.Text = Properties.Settings.Default.temp_path;
            textBox_extension.Text = Properties.Settings.Default.temp_extension;
            folderPath = Properties.Settings.Default.temp_path;
            this.FormClosing += Form1_FormClosing1;
        }

        private void Form1_FormClosing1(object sender, FormClosingEventArgs e)
        {
            
            Properties.Settings.Default.temp_path = folderPath;
            Properties.Settings.Default.temp_extension = textBox_extension.Text;
            Properties.Settings.Default.Save();
            
        }

        private void button_browse_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog FBD1 = new FolderBrowserDialog();
            if (FBD1.ShowDialog() == DialogResult.OK)
            {
                folderPath = FBD1.SelectedPath;
            }
            textBox_directory.Text = folderPath;
            Properties.Settings.Default.temp_path = folderPath;
            Properties.Settings.Default.Save();

        }

        private void button_execute_Click(object sender, EventArgs e)
        {
            if (folderPath == "")
            {
                MessageBox.Show("Please select your directory.");
            }
            else if(textBox_extension.Text == "")
            {
                MessageBox.Show("Please select the extension to be used.");
            }
            else
            {
                //collect array(list) of titles
                string[] Directories = Directory.GetFiles(folderPath, "*" + textBox_extension.Text);

                //Directory dump

                System.Console.WriteLine("Directory List:");
                foreach (string element in Directories)
                {
                    System.Console.WriteLine(element);
                }
                System.Console.WriteLine();

                int Length = Directories.Length;
                ArrayList TitleList = new ArrayList();
                ArrayList TempTitleList = new ArrayList();
                ArrayList ScrambledList = new ArrayList();

                for (int i = 0; i < Length; i++)
                {
                    TitleList.Add(Directories[i]);
                    TempTitleList.Add(Directories[i]);
                }

                //TitleList and TempTitleList dump

                System.Console.WriteLine("Title List:");
                foreach (string element in TitleList)
                {
                    System.Console.WriteLine(element);
                }
                System.Console.WriteLine();

                //Random seed for scrambling
                Random r = new Random();

                //Scramble
                for (int i = 0; i < Length; i++)
                {
                    int rInt = r.Next(0, TempTitleList.Count);
                    ScrambledList.Add(TempTitleList[rInt]);
                    TempTitleList.RemoveAt(rInt);
                }

                //TitleList and TempTitleList dump
                System.Console.WriteLine("Original Title List:");
                foreach (string element in TempTitleList)
                {
                    System.Console.WriteLine(element);
                }
                System.Console.WriteLine();

                //Scrambled Title List dump
                System.Console.WriteLine("Scrambled Title List:");
                foreach (string element in ScrambledList)
                {
                    System.Console.WriteLine(element);
                }
                System.Console.WriteLine();

                //Rename
                
                for(int i = 0; i < Length; i++)
                {
                    if (File.Exists((string)TitleList[i]) && (TitleList[i] != ScrambledList[i]))
                    {
                        //copy original to temp
                        try
                        {
                            File.Copy((string)TitleList[i], folderPath + "\\temp", true);
                        }catch
                        {
                            MessageBox.Show("Can't copy from " +(string)TitleList[i] + " to " + folderPath + "\\temp");
                        }
                        
                        System.Console.WriteLine("Copying from "+ (string)TitleList[i] + " to " + folderPath + "\\temp");

                        //copy scrambled to original, overwriting
                        try
                        {
                            File.Copy((string)ScrambledList[i], (string)TitleList[i], true);
                        }
                        catch
                        {
                            MessageBox.Show("Can't copy from " + (string)ScrambledList[i] + " to " + (string)TitleList[i]);
                        }
                        System.Console.WriteLine("Copying from " + (string)ScrambledList[i] + " to " + (string)TitleList[i]);

                        //copy temp to scrambled
                        try
                        {
                            File.Copy(folderPath + "\\temp", (string)ScrambledList[i], true);
                        }
                        catch
                        {
                            MessageBox.Show("Can't copy from " + folderPath + "\\temp" + " to " + (string)ScrambledList[i]);
                        }
                        System.Console.WriteLine("Copying from " + folderPath + "\\temp" + " to " +  (string)ScrambledList[i]);

                        //delete temp
                        try
                        {
                            File.Delete(folderPath + "\\temp");
                        }
                        catch
                        {
                            MessageBox.Show("Can't delete from " + folderPath + "\\temp");
                        }
                        System.Console.WriteLine("Deleting from " + folderPath + "\\temp");

                    }
                    System.Console.WriteLine(folderPath + "\\temp");

                }
                MessageBox.Show("Mischief Managed.");


            }

        }
    }
}
