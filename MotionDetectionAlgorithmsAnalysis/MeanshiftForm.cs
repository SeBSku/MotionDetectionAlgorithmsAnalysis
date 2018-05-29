using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotionDetectionAlgorithmsAnalysis
{
    public partial class MeanshiftForm : Form
    {
        private VideoCapture video;
        private CancellationTokenSource tokenSource = new CancellationTokenSource();
        private int LeftTopCornerX;
        private int LeftTopCornerY;
        private int RightBottomCornerX;
        private int RightBottomCornerY;
        bool wasScaled;
        bool isMeanshiftRunning;
        double scale;

        Rectangle roi;
        public MeanshiftForm(VideoCapture video)
        {
            InitializeComponent();
            isMeanshiftRunning = false;
            this.video = video;
        }


        private void originalVideoFramePlaceholder_MouseDown(object sender, MouseEventArgs e)
        {
            tokenSource.Cancel();
            LeftTopCornerX = e.Location.X;
            LeftTopCornerY = e.Location.Y;
        }
        private void originalVideoFramePlaceholder_MouseUp(object sender, MouseEventArgs e)
        {
            if (!isMeanshiftRunning)
            {
                isMeanshiftRunning = true;
                RightBottomCornerX = e.Location.X;
                RightBottomCornerY = e.Location.Y;
                roi = new Rectangle(LeftTopCornerX, LeftTopCornerY, RightBottomCornerX - LeftTopCornerX, RightBottomCornerY - LeftTopCornerY);
                if (wasScaled)
                {
                    double backScale = 1.0 / scale;
                    MeanshiftDemo.Meanshift.RunMeanshiftDemo(video,
                        (int)(backScale * LeftTopCornerX),
                        (int)(backScale * LeftTopCornerY),
                        (int)(backScale * (RightBottomCornerX - LeftTopCornerX)),
                        (int)(backScale * (RightBottomCornerY - LeftTopCornerY))
                    );
                }
                else
                {
                    MeanshiftDemo.Meanshift.RunMeanshiftDemo(video, LeftTopCornerX, LeftTopCornerY, RightBottomCornerX - LeftTopCornerX, RightBottomCornerY - LeftTopCornerY);
                }
                MessageBox.Show("Koniec");
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            getRoi();
        }
        private async void getRoi()
        {
            var frame = new Mat();
            var i = 0;
            video.Read(frame);
            var frameImg = frame.ToImage<Bgr, byte>().Bitmap;
            Size? newSize = null;
            wasScaled = originalVideoFramePlaceholder.Width < frameImg.Width;
            if (wasScaled)
            {
                int newWidth = Math.Min(originalVideoFramePlaceholder.Width, frameImg.Width);
                scale = (double)originalVideoFramePlaceholder.Width / frameImg.Width;
                int newHeight = (int)(scale * frameImg.Size.Height);
                newSize = new Size(newWidth, newHeight);
            }

            while (true)
            {
                if (frame.IsEmpty)
                {
                    return;
                }
                i++;
                frameImg = frame.ToImage<Bgr, byte>().Bitmap;
                if (newSize != null)
                {
                    frameImg = new Bitmap(frameImg, newSize.Value);
                }
                originalVideoFramePlaceholder.Image = frameImg;
                video.Read(frame);
                try
                {
                    await PutTaskDelay();
                }
                catch (Exception e)
                {
                    return;
                }
            }
        }

        async Task PutTaskDelay()
        {
            await Task.Delay(50, tokenSource.Token);
        }

    }
}
