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

namespace BATCHTO16BITBMP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (FileInfo file in listBox1.Items)
            {
                cimage cim = new cimage();
                Bitmap bs = new Bitmap(file.FullName);
                // Bitmap bo =new Bitmap(_with, _height, PixelFormat.Format8bppIndexed)
                Bitmap bo = cim.to16bit(bs);
                // Bitmap bo= cim.to16bit(bs).Clone(new System.Drawing.Rectangle(0, 0, bs.Width, bs.Height), System.Drawing.Imaging.PixelFormat.Format16bppRgb565);

                // bo.Save(file.FullName.Replace(".bmp","o.bmp"));
                //  System.Drawing.Imaging.ImageFormat imagef = new System.Drawing.Imaging.ImageFormat();

                if (Directory.Exists(label1.Text+"\\out16bit") == false)
                {
                    Directory.CreateDirectory(label1.Text + "\\out16bit");
                }
                // dir = Directory.GetCurrentDirectory() + dir;
                //Directory.CreateDirectory(dir);



                bo.Save(file.FullName.Replace(label1.Text, label1.Text + "\\out16bit"), System.Drawing.Imaging.ImageFormat.Bmp);

                //bo.Save(file.FullName.Replace(".bmp", "o.bmp").Replace(label1.Text, label1.Text + "\\out16bit"), System.Drawing.Imaging.ImageFormat.Bmp);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                label1.Text = folderBrowserDialog1.SelectedPath;

                DirectoryInfo folder = new DirectoryInfo(folderBrowserDialog1.SelectedPath);

                foreach (FileInfo file in folder.GetFiles("*.bmp"))
                {
                    //Console.WriteLine(file.FullName);

                    bool eee = false;
                    foreach (FileInfo file1 in listBox1.Items)
                    {
                        if (file1.FullName == file.FullName)
                        { eee = true; }
                    }

                        if (eee==true){ }
                    else
                    { this.listBox1.Items.Add(file); }

                }
            }
        }


    }
}
