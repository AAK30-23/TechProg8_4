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
using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Drawing2D;

namespace TechProg8_4
{
    public partial class Form1 : Form
    {
        private List<string[]> origMatrix;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            origMatrix = Matrix.LoadMatrixFromFile("TextFile1.txt");
        }

        
        private FilterType selectedFilterType = FilterType.All;

        private void button1_Click(object sender, EventArgs e)
        {
            bool isUpper = radioButtonUpper.Checked;
            bool isLower = radioButtonLower.Checked;
            char filterChar1 = ' '; 
            char filterChar2 = ' ';

            if (domainUpDown1.Enabled)
            {
                if (domainUpDown1.SelectedItem != null)
                {
                    string text = domainUpDown1.SelectedItem.ToString();
                    if (text.Length > 0)
                    {
                        filterChar1 = text[0];
                        filterChar2 = char.ToLower(text[0]);
                    }
                }
                else
                {
                    MessageBox.Show("Необходимо выбрать букву!");
                }
                                
            }            
            List<string[]> filteredMatrix = Filter.ApplyFilter(origMatrix, filterChar1, filterChar2, isUpper, isLower, selectedFilterType);
            Output.DisplayFilteredMatrix(filteredMatrix, tabControl1);
            Output.CompareAndDisplay(origMatrix, filteredMatrix, tabControl1);

        }


        private void radioButtonText_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonText.Checked)
            {
                selectedFilterType = FilterType.InText;
                domainUpDown1.Enabled = true;
                radioButtonUpper.Enabled = true;
                radioButtonLower.Enabled = true;
                radioButtonNone.Enabled = true;
            }

            else
            {
                domainUpDown1.Enabled = false;
                radioButtonUpper.Enabled = false;
                radioButtonLower.Enabled = false;
                radioButtonNone.Enabled = true;
                radioButtonNone.Checked = true;
            }
        }
        private void radioButtonStart_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonStart.Checked)
            {
                selectedFilterType = FilterType.StartText;
                domainUpDown1.Enabled = true;
                radioButtonUpper.Enabled = true;
                radioButtonLower.Enabled = true;
                radioButtonNone.Enabled = true;
            }

            else
            {
                domainUpDown1.Enabled = false;
                radioButtonUpper.Enabled = false;
                radioButtonLower.Enabled = false;
                radioButtonNone.Enabled = true;
                radioButtonNone.Checked = true;
            }

        }


        private void radioButtonNumbers_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonNumbers.Checked)
            {
                selectedFilterType = FilterType.Numbers;
            }
        }

        private void radioButtonSigns_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSigns.Checked)
            {
                selectedFilterType = FilterType.Signs;
            }
        }

        private void radioButtonAll_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonAll.Checked)
            {
                selectedFilterType = FilterType.All;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
