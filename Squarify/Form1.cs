using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Squarify
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Bitmap makeSquare(Image originalImage)
        {
            // Making the image square: https://stackoverflow.com/a/2823866/8094047
            int largestDimension = Math.Max(originalImage.Height, originalImage.Width);
            Size squareSize = new Size(largestDimension, largestDimension);
            Bitmap squareImage = new Bitmap(squareSize.Width, squareSize.Height);
            using (Graphics graphics = Graphics.FromImage(squareImage))
            {
                graphics.FillRectangle(Brushes.Black, 0, 0, squareSize.Width, squareSize.Height);
                graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                graphics.DrawImage(originalImage, (squareSize.Width / 2) - (originalImage.Width / 2), (squareSize.Height / 2) - (originalImage.Height / 2), originalImage.Width, originalImage.Height);
            }
            return squareImage;
        }

        private void openImageButton_Click(object sender, EventArgs e)
        {
            if (openImageDialog.ShowDialog() == DialogResult.OK)
            {
                originalPictureBox.Load(openImageDialog.FileName);
                Image originalImage = originalPictureBox.Image;
                resultPictureBox.Image = makeSquare(originalImage);
                saveResultButton.Enabled = true;
            }
        }

        private void saveResultButton_Click(object sender, EventArgs e)
        {
            Image resultImage = resultPictureBox.Image;
            if (resultImage == null)
            {
                MessageBox.Show("Please open an image first");
            }
            else if (saveResultDialog.ShowDialog() == DialogResult.OK)
            {
                resultImage.Save(saveResultDialog.FileName);
            }
        }
    }
}
