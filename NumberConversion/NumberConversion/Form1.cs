﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberConversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                int converted;

                converted = RomanToArabic.RomtoAra(textBox1.Text);
                arabicLabel.Text = converted.ToString();

              try
            {  string rome;

                rome = ArabicToRoman.AratoRom(int.Parse(textBox2.Text));
                romanLabel.Text = rome.ToString();
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
