using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flood_it_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            System.Drawing.Bitmap bmp = new Bitmap(64, 64);

            Color c = Color.FromArgb(255, 0, 0);

            for (int i = 0; i < 64; i++){

                for (int j = 0; j < 64; j++){



                    bmp.SetPixel(i, j, c);


                }

            }

            PictureBox p1 = new PictureBox();
            
            p1.Left = 0;
            p1.Top = 0;
            p1.Width = 64;
            p1.Height = 64;
            p1.Image = bmp;

            this.Controls.Add(p1);
        }
    }
}
