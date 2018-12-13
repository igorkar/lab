using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_wf
{
    public partial class Form1 : Form
    {
        Bitmap image1;

        public Form1()
        {
            InitializeComponent();
        }

        private void LoadImage(string FileName)
        {
            try
            {
                // Retrieve the image.
                image1 = new Bitmap(FileName, true);

                // Set the PictureBox to display the image.
                PictureBoxOrig.Image = image1;

                // Display the pixel format in Label1.
                Label1.Text = "Pixel format: " + image1.PixelFormat.ToString();
                //DrowHistogram();

                System.Windows.Forms.DataVisualization.Charting.Series HistogramOrig = new System.Windows.Forms.DataVisualization.Charting.Series();
                HistogramOrig.ChartArea = "HistogramArea1";
                HistogramOrig.Name = "Series1";

                int[] nums = new int[256];
                int x, y;
                double Y;
                Color pixelColor;
                for (x = 0; x < image1.Width; x++)
                {
                    for (y = 0; y < image1.Height; y++)
                    {
                        pixelColor = image1.GetPixel(x, y);
                        Y = 0.299 * pixelColor.R + 0.587 * pixelColor.G + 0.114 * pixelColor.B;
                        nums[Convert.ToInt32(Y)] ++;
                    }
                }
                for(int i=0; i<=255; i++)
                {
                    HistogramOrig.Points.AddXY(i, nums[i]);
                }
                Histogram1.Series.Add(HistogramOrig);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("There was an error." +
                    "Check the path to the image file.");
            }
        }

        private void DrowHistogram()
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Displays an OpenFileDialog so the user can select a Cursor.  
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Bitmap Files|*.bmp";
            openFileDialog1.Title = "Select a Bitmap File";

            // Show the Dialog.  
            // If the user clicked OK in the dialog and  
            // a .CUR file was selected, open it.  
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                LoadImage(openFileDialog1.FileName.ToString());

            }


        }

        private void ButtonTransform_Click(object sender, EventArgs e)
        {
            try
            {
                /*
                int x, y;

                // Loop through the images pixels to reset color.
                for (x = 0; x < image1.Width; x++)
                {
                    for (y = 0; y < image1.Height; y++)
                    {
                        Color pixelColor = image1.GetPixel(x, y);
                        Color newColor = Color.FromArgb(pixelColor.R, 0, 0);
                        image1.SetPixel(x, y, newColor);
                    }
                }*/
                PictureBoxTransformed.Image = image1;
            }
            catch (Exception)
            {
                MessageBox.Show("Can't transform image");
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (image1 != null)
                {

                    // Displays a SaveFileDialog so the user can save the Image  
                    // assigned to Button2.  
                    SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                    saveFileDialog1.Filter = "Bitmap Image|*.bmp|JPeg Image|*.jpg|Gif Image|*.gif";
                    saveFileDialog1.Title = "Save an Image File";
                    saveFileDialog1.ShowDialog();

                    // If the file name is not an empty string open it for saving.  
                    if (saveFileDialog1.FileName != "")
                    {
                        // Saves the Image via a FileStream created by the OpenFile method.  
                        System.IO.FileStream fs =
                           (System.IO.FileStream)saveFileDialog1.OpenFile();
                        // Saves the Image in the appropriate ImageFormat based upon the  
                        // File type selected in the dialog box.  
                        // NOTE that the FilterIndex property is one-based.  
                        switch (saveFileDialog1.FilterIndex)
                        {
                            case 1:
                                image1.Save(fs,
                                   System.Drawing.Imaging.ImageFormat.Jpeg);
                                break;

                            case 2:
                                image1.Save(fs,
                                   System.Drawing.Imaging.ImageFormat.Bmp);
                                break;

                            case 3:
                                image1.Save(fs,
                                   System.Drawing.Imaging.ImageFormat.Gif);
                                break;
                        }

                        fs.Close();
                    }
                    Label2.Text = "Image saved";
                }
                else
                {
                    Label2.Text = "No transformed image";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("There was a problem saving the file." +
                    "Check the file permissions.");
            }
        }
    }
}
