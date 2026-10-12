using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace PixelResizer
{
    public partial class Form1 : Form
    {
        private Bitmap? originalImage;

        public Form1()
        {
            InitializeComponent();
            buttonLoad.Click += buttonLoad_Click;
            buttonSave.Click += buttonSave_Click;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "‰æ‘œƒtƒ@ƒCƒ‹ (*.png;*.jpg)|*.png;*.jpg"
            })
            {
                if (openFileDialog.ShowDialog() != DialogResult.OK)
                    return;

                using Bitmap original = new Bitmap(openFileDialog.FileName);
                originalImage = new Bitmap(original);
                RedrawImage();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null) return;

            using (SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "PNG‰æ‘œ|*.png"
            })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    pictureBox1.Image.Save(saveFileDialog.FileName);
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            RedrawImage();
        }

        private void RedrawImage()
        {
            if (originalImage == null)
                return;

            int scale = Math.Max(1, (int)numericUpDown1.Value);
            int width = originalImage.Width * scale;
            int height = originalImage.Height * scale;

            Bitmap resized = new Bitmap(width, height, PixelFormat.Format32bppArgb);
            using (Graphics g = Graphics.FromImage(resized))
            {
                g.InterpolationMode = InterpolationMode.NearestNeighbor;
                g.PixelOffsetMode = PixelOffsetMode.Half;
                g.Clear(Color.Transparent);
                g.DrawImage(originalImage, 0, 0, width, height);
            }

            pictureBox1.Image = resized;
        }
    }
}
