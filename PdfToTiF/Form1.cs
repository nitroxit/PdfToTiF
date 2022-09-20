using ImageMagick;
using System;

namespace PdfToTiF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fileselect_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            openFileDialog1.ShowDialog();
            foreach (string file in openFileDialog1.SafeFileNames)
            {
                listBox1.Items.Add(file);
            }
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            foreach (string file in openFileDialog1.FileNames)
            {
                using (MagickImage magi = new MagickImage(file))
                {
                    magi.Format = MagickFormat.Tif;
                    magi.Write(file + ".Tif");
                }
            }
        }
    }
} 