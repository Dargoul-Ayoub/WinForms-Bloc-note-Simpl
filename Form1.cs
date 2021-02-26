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

namespace Bloc_note_Simplifié
{
    public partial class Form1 : Form
    {
        string path = "C:\\Users\\Devman\\Desktop\\Text1.txt";
        public Form1()
        {
            InitializeComponent();
        }

        // if i want to make a button in 3D format
        private void button3_Paint(object sender, PaintEventArgs e)
        {
        ControlPaint.DrawBorder(e.Graphics, button3.ClientRectangle,
        SystemColors.ControlLightLight, 3, ButtonBorderStyle.Outset,
        SystemColors.ControlLightLight, 3, ButtonBorderStyle.Outset,
        SystemColors.ControlLightLight, 3, ButtonBorderStyle.Outset,
        SystemColors.ControlLightLight, 3, ButtonBorderStyle.Outset);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // using(StreamWriter write = File.AppendText(path))  it will start writing at end of the file 

            using (StreamWriter write = File.CreateText(path)) // it will delet the previous text and write the new one 
            {
                write.Write(textBox1.Text);
                write.Close();
            }
            //StreamWriter write = new StreamWriter(path);
           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            using(StreamReader read = File.OpenText(path))
            {
                textBox1.Text = read.ReadToEnd();
                read.Close();
            }
           // StreamReader read = new StreamReader(path);
            
        }
    }
}
