using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Misson1
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        int count = 0;

        
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            PictureBox pic = new PictureBox();
            pic.Height = 50;
            pic.Width = 30;
            pic.Left = rnd.Next(0, this.Width);
            pic.Top = 0;
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            pic.MouseClick += myMouseClick;
            pic.Image = Image.FromFile(Application.StartupPath + @"/../../Images/svivon.gif");
            this.Controls.Add(pic);


        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            for (int i = 0; i < this.Controls.Count; i++)
                if (this.Controls[i] is PictureBox)
                    ((PictureBox)this.Controls[i]).Top += 20;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
        }

        private void myMouseClick(object sender, MouseEventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            if (e.Button ==  MouseButtons.Left )
            {
                pic.Image = Image.FromFile(Application.StartupPath + @"/../../Images/sofgania.jpg");
                while (count > 0)
                {
                    count++;
                    label3.Text = (count);
                    
                }
                


            }
            else if (e.Button == MouseButtons.Right)
            {
                pic.Dispose();
            }
            
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        }
            }
        
   




