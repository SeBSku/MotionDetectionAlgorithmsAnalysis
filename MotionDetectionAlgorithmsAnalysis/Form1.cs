using Emgu.CV;
using Emgu.CV.BgSegm;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MotionDetectionAlgorithmsAnalysis
{
    public partial class Form1 : Form
    {
        private bool isStopped = false;
        private double minMotionArea = 50;
        bool isCameraLiveVideo = false;
        private double motionsDetected = 0;

        private BackgroundSubtractorType backgroundSubtractorType;
        IBackgroundSubtractor backgroundSubtractor = new BackgroundSubtractorMOG2(20, 50, false);

        public Form1()
        {
            InitializeComponent();
            DisablePanels();
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            isStopped = true;
        }

        #region Validation
        private void AllowOnlyInteger(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void AllowOnlyDecimal(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        #endregion

        private void selectVideoButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Video Files (*.mp4, *.flv, *.avi) | *.mp4;*.flv;*.avi";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                selectVideoTXB.Text = ofd.SafeFileName;
            }
        }

        private void detectMotionButton_Click(object sender, EventArgs e)
        {
            try
            {
                isStopped = false;
                VideoCapture videoCapture = CreateVideoCapture();
                if (videoCapture != null)
                {
                    if (int.TryParse(minAreaTxBx.Text, out int parsedMinMotionArea))
                    {
                        minMotionArea = parsedMinMotionArea;
                    }
                    else
                    {
                        minMotionArea = 50;
                        ShowWarning("Warning", "Min motion area to detect not specified, default (50) will be used.");
                    }
                    backgroundSubtractor = CreateBackgroundSubtractor();
                    MotionDetection(videoCapture);
                }
                else
                {
                    ShowError("Error", "Cannot acquire video!");
                }
            }
            catch (Exception ex)
            {
                ShowError("Error", ex.Message);
            }
        }

        private void MotionDetection(VideoCapture videoCapture)
        {
            motionsDetected = 0;
            int timeBetweenFrames;
            if (isCameraLiveVideo)
            {
                timeBetweenFrames = 1;
            }
            else
            {
                timeBetweenFrames = (int)(1 / videoCapture.GetCaptureProperty(CapProp.Fps) * 1000);
            }
            var frame = new Mat();
            long frameCounter = 0;
            long singleFrameCounter = 0;
            bool isFirst = true;

            while (!isStopped)
            {
                try
                {
                    videoCapture.Read(frame);
                    if (frame.IsEmpty)
                    {
                        if (isFirst)
                        {
                            ShowError("Error", "Cannot acquire first frame.");
                        }
                        break;
                    }
                    else
                    {
                        frameCounter++;
                        if (isFirst)
                        {
                            isFirst = false;
                        }
                    }

                    var fg = new Mat();
                    backgroundSubtractor.Apply(frame, fg);

                    Image<Bgr, Byte> diff = fg.ToImage<Bgr, Byte>();
                    Image<Gray, Byte> grayImage = diff.Convert<Gray, Byte>();

                    var contours = new VectorOfVectorOfPoint();
                    var hierarchy = new Image<Bgr, Byte>(diff.Size.Width, diff.Size.Height);
                    CvInvoke.FindContours(grayImage, contours, hierarchy, RetrType.Ccomp, ChainApproxMethod.ChainApproxSimple);

                    if (frameCounter == 71)
                    {
                        singleFrameCounter = (long)motionsDetected;
                    }
                    for (int i = 0; i < contours.Size; i++)
                    {
                        if (CvInvoke.ContourArea(contours[i]) > minMotionArea)
                        {
                            Rectangle rect = CvInvoke.BoundingRectangle(contours[i]);
                            if (!isCameraLiveVideo && frameCounter > 70 && frameCounter < 90)
                                motionsDetected++;
                            CvInvoke.Rectangle(frame, rect, new MCvScalar(0, 0, 255), 1);
                        }
                    }
                    if (frameCounter == 71)
                    {
                        singleFrameCounter = (long)motionsDetected - singleFrameCounter;
                    }
                    CvInvoke.Imshow("SourceWithDetectedMotion", frame);
                    CvInvoke.Imshow("DetectedMotion", fg);
                    CvInvoke.WaitKey(timeBetweenFrames);
                }
                catch (Exception ex)
                {
                    ShowError("Error", ex.Message);
                    break;
                }
            }
            singleFrameDetectedTxBx.Text = singleFrameCounter.ToString();
            motionsDetectedTxBx.Text = motionsDetected.ToString();
            CvInvoke.DestroyAllWindows();
        }

        private void ShowWarning(string title, string message)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void ShowError(string title, string message)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private VideoCapture CreateVideoCapture()
        {
            if (useCameraChBx.Checked)
            {
                isCameraLiveVideo = true;
                return new VideoCapture();
            }
            else
            {
                isCameraLiveVideo = false;
                return new VideoCapture(selectVideoTXB.Text);
            }
        }

        private IBackgroundSubtractor CreateBackgroundSubtractor()
        {
            switch (backgroundSubtractorType)
            {
                case BackgroundSubtractorType.MOG:
                    return CreateMOGBackgroundSubtractor();
                case BackgroundSubtractorType.KNN:
                    return CreateKNNBackgroundSubtractor();
                case BackgroundSubtractorType.LSBP:
                    return CreateLSBPBackgroundSubtractor();
                case BackgroundSubtractorType.GMG:
                    return CreateGMGBackgroundSubtractor();
                case BackgroundSubtractorType.MOG2:
                default:
                    return CreateMOG2BackgroundSubtractor();
            }
        }

        #region MOG
        private void mogHistoryTxBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowOnlyInteger(sender, e);
        }

        private void mogNMixturesTxBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowOnlyInteger(sender, e);
        }

        private void mogBackgroundRatioTxBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowOnlyDecimal(sender, e);
        }

        private void mogNoiseSigmaTxBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowOnlyDecimal(sender, e);
        }

        private IBackgroundSubtractor CreateMOGBackgroundSubtractor()
        {
            int history = 200, nMixtures = 5;
            double backgroundRatio = 0.7, noiseSigma = 0;

            bool showWarning = false;
            string warningMessage = String.Empty;
            if (int.TryParse(mogHistoryTxBx.Text, out int parsedHistory))
            {
                history = parsedHistory;
            }
            else
            {
                showWarning = true;
                warningMessage = warningMessage + "history";
            }
            if (int.TryParse(mogNMixturesTxBx.Text, out int parsedNMixtures))
            {
                nMixtures = parsedNMixtures;
            }
            else
            {
                showWarning = true;
                if (warningMessage == String.Empty)
                {
                    warningMessage = warningMessage + "nMixtures";
                }
                else
                {
                    warningMessage = warningMessage + ", nMixtures";
                }
            }
            if (double.TryParse(mogBackgroundRatioTxBx.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double parsedBackgroundRatio))
            {
                backgroundRatio = parsedBackgroundRatio;
            }
            else
            {
                showWarning = true;
                if (warningMessage == String.Empty)
                {
                    warningMessage = warningMessage + "background ratio";
                }
                else
                {
                    warningMessage = warningMessage + ", background ratio";
                }
            }
            if (double.TryParse(mogNoiseSigmaTxBx.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double parsedNoiseSigma))
            {
                noiseSigma = parsedNoiseSigma;
            }
            else
            {
                showWarning = true;
                if (warningMessage == String.Empty)
                {
                    warningMessage = warningMessage + "noise sigma";
                }
                else
                {
                    warningMessage = warningMessage + ", noise sigma";
                }
            }
            if (showWarning)
            {
                warningMessage = "Incorrect " + warningMessage + " value. Used defaults.";
                ShowWarning("Incorrect parameters", warningMessage);
            }
            return new BackgroundSubtractorMOG(history, nMixtures, backgroundRatio, noiseSigma);
        }
        #endregion

        #region MOG2
        private void mog2HistoryTxBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowOnlyInteger(sender, e);
        }

        private void mog2ThresholdTxBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowOnlyDecimal(sender, e);
        }

        private IBackgroundSubtractor CreateMOG2BackgroundSubtractor()
        {
            int history = 500;
            float varThreshold = 16;
            bool shadowDetection = false;

            bool showWarning = false;
            string warningMessage = String.Empty;
            if (int.TryParse(mogHistoryTxBx.Text, out int parsedHistory))
            {
                history = parsedHistory;
            }
            else
            {
                showWarning = true;
                warningMessage = warningMessage + "history";
            }
            if (float.TryParse(mog2ThresholdTxBx.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out float parsedThreshold))
            {
                varThreshold = parsedThreshold;
            }
            else
            {
                showWarning = true;
                if (warningMessage == String.Empty)
                {
                    warningMessage = warningMessage + "threshold";
                }
                else
                {
                    warningMessage = warningMessage + ", threshold";
                }
            }
            shadowDetection = mog2ShadowDetectionChBx.Checked;
            if (showWarning)
            {
                warningMessage = "Incorrect " + warningMessage + " value. Used defaults.";
                ShowWarning("Incorrect parameters", warningMessage);
            }
            return new BackgroundSubtractorMOG2(history, varThreshold, shadowDetection);
        }
        #endregion

        #region KNN
        private void knnHistoryTxBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowOnlyInteger(sender, e);
        }

        private void knnDist2ThresholdTxBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowOnlyDecimal(sender, e);
        }

        private IBackgroundSubtractor CreateKNNBackgroundSubtractor()
        {
            int history = 20;
            double dist2Threshold = 100;
            bool detectShadows = false;

            bool showWarning = false;
            string warningMessage = String.Empty;
            if (int.TryParse(knnHistoryTxBx.Text, out int parsedHistory))
            {
                history = parsedHistory;
            }
            else
            {
                showWarning = true;
                warningMessage = warningMessage + "history";
            }
            if (double.TryParse(knnDist2ThresholdTxBx.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double parsedDist2Threshold))
            {
                dist2Threshold = parsedDist2Threshold;
            }
            else
            {
                showWarning = true;
                if (warningMessage == String.Empty)
                {
                    warningMessage = warningMessage + "dist to threshold";
                }
                else
                {
                    warningMessage = warningMessage + ", dist to threshold";
                }
            }
            detectShadows = knnDetectShadowsChBx.Checked;
            if (showWarning)
            {
                warningMessage = "Incorrect " + warningMessage + " value. Used defaults.";
                ShowWarning("Incorrect parameters", warningMessage);
            }
            return new BackgroundSubtractorKNN(history, dist2Threshold, detectShadows);
        }
        #endregion

        #region GMG
        private void gmgInitializationFramesTxBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowOnlyInteger(sender, e);
        }

        private void gmgDecisionThresholdTxBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowOnlyDecimal(sender, e);
        }

        private IBackgroundSubtractor CreateGMGBackgroundSubtractor()
        {
            int initializationFrames = 5;
            double decisionThreshold = 0.7;

            bool showWarning = false;
            string warningMessage = String.Empty;
            if (int.TryParse(gmgInitializationFramesTxBx.Text, out int parsedInitializationFrames))
            {
                initializationFrames = parsedInitializationFrames;
            }
            else
            {
                showWarning = true;
                warningMessage = warningMessage + "initialization frames";
            }
            if (double.TryParse(gmgDecisionThresholdTxBx.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double parsedDecisionThreshold))
            {
                decisionThreshold = parsedDecisionThreshold;
            }
            else
            {
                showWarning = true;
                if (warningMessage == String.Empty)
                {
                    warningMessage = warningMessage + "decision threshold";
                }
                else
                {
                    warningMessage = warningMessage + ", decision threshold";
                }
            }
            if (showWarning)
            {
                warningMessage = "Incorrect " + warningMessage + " value. Used defaults.";
                ShowWarning("Incorrect parameters", warningMessage);
            }
            return new BackgroundSubtractorGMG(initializationFrames, decisionThreshold);
        }
        #endregion

        #region LSBP
        private void lsbpNSamplesTxBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowOnlyInteger(sender, e);
        }

        private void lsbpRadiusTxBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowOnlyInteger(sender, e);
        }

        private void lsbpTLowerTxBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowOnlyDecimal(sender, e);
        }

        private void lsbpTUpperTxBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowOnlyDecimal(sender, e);
        }

        private void lsbpTIncTxBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowOnlyDecimal(sender, e);
        }

        private void lsbpTDecTxBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowOnlyDecimal(sender, e);
        }

        private void lsbpRScaleTxBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowOnlyDecimal(sender, e);
        }

        private void lsbpRIncDecTxBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowOnlyDecimal(sender, e);
        }

        private void lsbpNoiseRemovalThresholdFacBGTxBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowOnlyDecimal(sender, e);
        }

        private void lsbpNoiseRemovalThresholdFacFGTxBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowOnlyDecimal(sender, e);
        }

        private void lsbpThresholdTxBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowOnlyInteger(sender, e);
        }

        private void lsbpMinCountTxBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowOnlyInteger(sender, e);
        }

        private IBackgroundSubtractor CreateLSBPBackgroundSubtractor()
        {
            BackgroundSubtractorLSBP.CameraMotionCompensation cameraMotionCompensation = BackgroundSubtractorLSBP.CameraMotionCompensation.None;
            int nSamples = 5, LSBPRadius = 16, LSBPthreshold = 8, minCount = 2;
            float tlower = 2, tupper = 32, tinc = 1, tdec = 0.05F, rscale = 10, rincdec = 0.005F, noiseRemovalThresholdFacBG = 0.0004F, noiseRemovalThresholdFacFG = 0.0008F;

            bool showWarning = false;
            string warningMessage = String.Empty;
            Enum.TryParse(lsbpCameraMotionCompensationCmBx.SelectedValue.ToString(), out cameraMotionCompensation);
            if (int.TryParse(lsbpNSamplesTxBx.Text, out int parsedNSamples))
            {
                nSamples = parsedNSamples;
            }
            else
            {
                showWarning = true;
                warningMessage = warningMessage + "nSamples";
            }
            if (int.TryParse(lsbpRadiusTxBx.Text, out int parsedLSBPRadius))
            {
                LSBPRadius = parsedLSBPRadius;
            }
            else
            {
                showWarning = true;
                if (warningMessage == String.Empty)
                {
                    warningMessage = warningMessage + "LSBP Radius";
                }
                else
                {
                    warningMessage = warningMessage + ", LSBP Radius";
                }
            }
            if (float.TryParse(lsbpTLowerTxBx.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out float parsedTLower))
            {
                tlower = parsedTLower;
            }
            else
            {
                showWarning = true;
                if (warningMessage == String.Empty)
                {
                    warningMessage = warningMessage + "tlower";
                }
                else
                {
                    warningMessage = warningMessage + ", tlower";
                }
            }
            if (float.TryParse(lsbpTUpperTxBx.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out float parsedTUpper))
            {
                tupper = parsedTUpper;
            }
            else
            {
                showWarning = true;
                if (warningMessage == String.Empty)
                {
                    warningMessage = warningMessage + "tupper";
                }
                else
                {
                    warningMessage = warningMessage + ", tupper";
                }
            }
            if (float.TryParse(lsbpTIncTxBx.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out float parsedTInc))
            {
                tinc = parsedTInc;
            }
            else
            {
                showWarning = true;
                if (warningMessage == String.Empty)
                {
                    warningMessage = warningMessage + "tinc";
                }
                else
                {
                    warningMessage = warningMessage + ", tinc";
                }
            }
            if (float.TryParse(lsbpTDecTxBx.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out float parsedTDec))
            {
                tdec = parsedTDec;
            }
            else
            {
                showWarning = true;
                if (warningMessage == String.Empty)
                {
                    warningMessage = warningMessage + "tdec";
                }
                else
                {
                    warningMessage = warningMessage + ", tdec";
                }
            }
            if (float.TryParse(lsbpRScaleTxBx.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out float parsedRScale))
            {
                rscale = parsedRScale;
            }
            else
            {
                showWarning = true;
                if (warningMessage == String.Empty)
                {
                    warningMessage = warningMessage + "rscale";
                }
                else
                {
                    warningMessage = warningMessage + ", rscale";
                }
            }
            if (float.TryParse(lsbpRIncDecTxBx.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out float parsedRIncDec))
            {
                rincdec = parsedRIncDec;
            }
            else
            {
                showWarning = true;
                if (warningMessage == String.Empty)
                {
                    warningMessage = warningMessage + "rincdec";
                }
                else
                {
                    warningMessage = warningMessage + ", rincdec";
                }
            }
            if (float.TryParse(lsbpNoiseRemovalThresholdFacBGTxBx.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out float parsedNoiseRemovalThresholdFacBG))
            {
                noiseRemovalThresholdFacBG = parsedNoiseRemovalThresholdFacBG;
            }
            else
            {
                showWarning = true;
                if (warningMessage == String.Empty)
                {
                    warningMessage = warningMessage + "noiseRemovalThresholdFacBG";
                }
                else
                {
                    warningMessage = warningMessage + ", noiseRemovalThresholdFacBG";
                }
            }
            if (float.TryParse(lsbpNoiseRemovalThresholdFacFGTxBx.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out float parsedNoiseRemovalThresholdFacFG))
            {
                noiseRemovalThresholdFacFG = parsedNoiseRemovalThresholdFacFG;
            }
            else
            {
                showWarning = true;
                if (warningMessage == String.Empty)
                {
                    warningMessage = warningMessage + "noiseRemovalThresholdFacFG";
                }
                else
                {
                    warningMessage = warningMessage + ", noiseRemovalThresholdFacFG";
                }
            }
            if (int.TryParse(lsbpThresholdTxBx.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out int parsedLSBPThreshold))
            {
                LSBPthreshold = parsedLSBPRadius;
            }
            else
            {
                showWarning = true;
                if (warningMessage == String.Empty)
                {
                    warningMessage = warningMessage + "LSBP threshold";
                }
                else
                {
                    warningMessage = warningMessage + ", LSBP threshold";
                }
            }
            if (int.TryParse(lsbpMinCountTxBx.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out int parsedMinCount))
            {
                minCount = parsedMinCount;
            }
            else
            {
                showWarning = true;
                if (warningMessage == String.Empty)
                {
                    warningMessage = warningMessage + "minCount";
                }
                else
                {
                    warningMessage = warningMessage + ", minCount";
                }
            }

            if (showWarning)
            {
                warningMessage = "Incorrect " + warningMessage + " value. Used defaults.";
                ShowWarning("Incorrect parameters", warningMessage);
            }
            return new BackgroundSubtractorLSBP(cameraMotionCompensation, nSamples, LSBPRadius
                , tlower, tupper, tinc, tdec, rscale, rincdec, noiseRemovalThresholdFacBG
                , noiseRemovalThresholdFacFG, LSBPthreshold, minCount);
        }

        #endregion

        private void minAreaTxBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowOnlyInteger(sender, e);
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            isStopped = true;
        }

        private void MOG_RB_CheckedChanged(object sender, EventArgs e)
        {
            if (MOG_RB.Checked)
            {
                backgroundSubtractorType = BackgroundSubtractorType.MOG;
                ResolveActivePanels(BackgroundSubtractorType.MOG);
            }
        }

        private void MOG2_RB_CheckedChanged(object sender, EventArgs e)
        {
            if (MOG2_RB.Checked)
            {
                backgroundSubtractorType = BackgroundSubtractorType.MOG2;
                ResolveActivePanels(BackgroundSubtractorType.MOG2);
            }
        }

        private void KNN_RB_CheckedChanged(object sender, EventArgs e)
        {
            if (KNN_RB.Checked)
            {
                backgroundSubtractorType = BackgroundSubtractorType.KNN;
                ResolveActivePanels(BackgroundSubtractorType.KNN);
            }
        }

        private void LSBP_RB_CheckedChanged(object sender, EventArgs e)
        {
            if (LSBP_RB.Checked)
            {
                backgroundSubtractorType = BackgroundSubtractorType.LSBP;
                ResolveActivePanels(BackgroundSubtractorType.LSBP);
            }
        }

        private void GMG_RB_CheckedChanged(object sender, EventArgs e)
        {
            if (GMG_RB.Checked)
            {
                backgroundSubtractorType = BackgroundSubtractorType.GMG;
                ResolveActivePanels(BackgroundSubtractorType.GMG);
            }
        }

        private void DisablePanels()
        {
            mogPanel.Enabled = false;
            mog2Panel.Enabled = false;
            knnPanel.Enabled = false;
            lsbpPanel.Enabled = false;
            gmgPanel.Enabled = false;
        }

        private void ResolveActivePanels(BackgroundSubtractorType backgroundSubtractorType)
        {
            DisablePanels();
            switch(backgroundSubtractorType)
            {
                case BackgroundSubtractorType.MOG:
                    mogPanel.Enabled = true;
                    break;
                case BackgroundSubtractorType.KNN:
                    knnPanel.Enabled = true;
                    break;
                case BackgroundSubtractorType.LSBP:
                    lsbpPanel.Enabled = true;
                    break;
                case BackgroundSubtractorType.GMG:
                    gmgPanel.Enabled = true;
                    break;
                case BackgroundSubtractorType.MOG2:
                default:
                    mog2Panel.Enabled = true;
                    break;
            }
        }
    }
}
