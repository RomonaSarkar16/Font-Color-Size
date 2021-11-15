using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Font_Paint_RunTime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FontDialog fsize = new FontDialog();
            if(fsize.ShowDialog()==DialogResult.OK)
            {
                richTextBox1.Font = fsize.Font;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog fcolor = new ColorDialog();
            fcolor.ShowDialog();
            richTextBox1.SelectionColor = fcolor.Color;
        }
    }
}
