using Emgu.CV.BgSegm;
using System;

namespace MotionDetectionAlgorithmsAnalysis
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.selectVideoButton = new System.Windows.Forms.Button();
            this.selectVideoTXB = new System.Windows.Forms.TextBox();
            this.detectMotionButton = new System.Windows.Forms.Button();
            this.MOGParamsLabel = new System.Windows.Forms.Label();
            this.bgSubtractorTypePanel = new System.Windows.Forms.Panel();
            this.GMG_RB = new System.Windows.Forms.RadioButton();
            this.LSBP_RB = new System.Windows.Forms.RadioButton();
            this.KNN_RB = new System.Windows.Forms.RadioButton();
            this.MOG2_RB = new System.Windows.Forms.RadioButton();
            this.MOG_RB = new System.Windows.Forms.RadioButton();
            this.selectSourceLabel = new System.Windows.Forms.Label();
            this.useCameraChBx = new System.Windows.Forms.CheckBox();
            this.selectBGSubtractorTypeLabel = new System.Windows.Forms.Label();
            this.mogHistoryLabel = new System.Windows.Forms.Label();
            this.mogPanel = new System.Windows.Forms.Panel();
            this.mogDefaultNoiseSigmaValue = new System.Windows.Forms.Label();
            this.mogDefaultsLabel = new System.Windows.Forms.Label();
            this.mogDefaultBgRatioValue = new System.Windows.Forms.Label();
            this.mogDefaultNMixturesValue = new System.Windows.Forms.Label();
            this.mogDefaultHistoryValue = new System.Windows.Forms.Label();
            this.mogNoiseSigmaTxBx = new System.Windows.Forms.TextBox();
            this.mogNoiseSigmaLabel = new System.Windows.Forms.Label();
            this.mogBackgroundRatioTxBx = new System.Windows.Forms.TextBox();
            this.mogBackgroundRatioLabel = new System.Windows.Forms.Label();
            this.mogNMixturesTxBx = new System.Windows.Forms.TextBox();
            this.mogNMixturesLabel = new System.Windows.Forms.Label();
            this.mogHistoryTxBx = new System.Windows.Forms.TextBox();
            this.mog2Panel = new System.Windows.Forms.Panel();
            this.mog2DefaultThresholdValue = new System.Windows.Forms.Label();
            this.mog2DefaultHistoryValue = new System.Windows.Forms.Label();
            this.mog2DefaultsLabel = new System.Windows.Forms.Label();
            this.mog2ShadowDetectionChBx = new System.Windows.Forms.CheckBox();
            this.mog2ThresholdTxBx = new System.Windows.Forms.TextBox();
            this.mog2ThresholdLabel = new System.Windows.Forms.Label();
            this.mog2HistoryTxBx = new System.Windows.Forms.TextBox();
            this.mog2HisotryLabel = new System.Windows.Forms.Label();
            this.MOG2ParamsLabel = new System.Windows.Forms.Label();
            this.lsbpPanel = new System.Windows.Forms.Panel();
            this.lsbpDefaultMinCountValue = new System.Windows.Forms.Label();
            this.lsbpDefaultThresholdValue = new System.Windows.Forms.Label();
            this.lsbpDefaultNRTFFGValue = new System.Windows.Forms.Label();
            this.lsbpDefaultNRTFBGValue = new System.Windows.Forms.Label();
            this.lsbpDefaultRIncDecValue = new System.Windows.Forms.Label();
            this.lsbpDefaultRScaleValue = new System.Windows.Forms.Label();
            this.lsbpDefaultTDecValue = new System.Windows.Forms.Label();
            this.lsbpDefaultTIncValue = new System.Windows.Forms.Label();
            this.lsbpDefaultTUpperValue = new System.Windows.Forms.Label();
            this.lsbpDefaultTLowerValue = new System.Windows.Forms.Label();
            this.lsbpDefaultRadiusValue = new System.Windows.Forms.Label();
            this.lsbpDefaultNSamplesValue = new System.Windows.Forms.Label();
            this.lsbpDefaultsLabel = new System.Windows.Forms.Label();
            this.lsbpMinCountTxBx = new System.Windows.Forms.TextBox();
            this.lsbpMinCountLabel = new System.Windows.Forms.Label();
            this.lsbpThresholdTxBx = new System.Windows.Forms.TextBox();
            this.lsbpThresholdLabel = new System.Windows.Forms.Label();
            this.lsbpNoiseRemovalThresholdFacFGTxBx = new System.Windows.Forms.TextBox();
            this.lsbpNoiseRemovalThresholdFacFGLabel = new System.Windows.Forms.Label();
            this.lsbpNoiseRemovalThresholdFacBGTxBx = new System.Windows.Forms.TextBox();
            this.lsbpNoiseRemovalThresholdFacBGLabel = new System.Windows.Forms.Label();
            this.lsbpRIncDecTxBx = new System.Windows.Forms.TextBox();
            this.lsbpRIncDecLabel = new System.Windows.Forms.Label();
            this.lsbpRScaleTxBx = new System.Windows.Forms.TextBox();
            this.lsbpRScaleLabel = new System.Windows.Forms.Label();
            this.lsbpTDecTxBx = new System.Windows.Forms.TextBox();
            this.lsbpTDecLabel = new System.Windows.Forms.Label();
            this.lsbpTIncTxBx = new System.Windows.Forms.TextBox();
            this.lsbpTIncLabel = new System.Windows.Forms.Label();
            this.lsbpTUpperTxBx = new System.Windows.Forms.TextBox();
            this.lsbpTUpperLabel = new System.Windows.Forms.Label();
            this.lsbpTLowerTxBx = new System.Windows.Forms.TextBox();
            this.lsbpTLowerLabel = new System.Windows.Forms.Label();
            this.lsbpRadiusTxBx = new System.Windows.Forms.TextBox();
            this.lsbpRadiusLabel = new System.Windows.Forms.Label();
            this.lsbpNSamplesTxBx = new System.Windows.Forms.TextBox();
            this.lsbpNSamplesLabel = new System.Windows.Forms.Label();
            this.lsbpCameraMotionCompensationLabel = new System.Windows.Forms.Label();
            this.lsbpCameraMotionCompensationCmBx = new System.Windows.Forms.ComboBox();
            this.LSBPParamsLabel = new System.Windows.Forms.Label();
            this.knnPanel = new System.Windows.Forms.Panel();
            this.knnDefaultDist2ThresholdValue = new System.Windows.Forms.Label();
            this.knnDefaultHistoryValue = new System.Windows.Forms.Label();
            this.knnDefaultsLabel = new System.Windows.Forms.Label();
            this.knnDetectShadowsChBx = new System.Windows.Forms.CheckBox();
            this.knnDist2ThresholdTxBx = new System.Windows.Forms.TextBox();
            this.knnDist2ThresholdLabel = new System.Windows.Forms.Label();
            this.knnHistoryTxBx = new System.Windows.Forms.TextBox();
            this.knnHistoryLabel = new System.Windows.Forms.Label();
            this.KNNParamsLabel = new System.Windows.Forms.Label();
            this.gmgPanel = new System.Windows.Forms.Panel();
            this.gmgDefaultDecisionThresholdValue = new System.Windows.Forms.Label();
            this.gmgDefaultInitializationFramesValue = new System.Windows.Forms.Label();
            this.gmgDefaultsLabel = new System.Windows.Forms.Label();
            this.gmgDecisionThresholdTxBx = new System.Windows.Forms.TextBox();
            this.gmgDecisionThresholdLabel = new System.Windows.Forms.Label();
            this.gmgInitializationFramesTxBx = new System.Windows.Forms.TextBox();
            this.gmgInitializationFramesLabel = new System.Windows.Forms.Label();
            this.GMGParamsLabel = new System.Windows.Forms.Label();
            this.minAreaLabel = new System.Windows.Forms.Label();
            this.minAreaTxBx = new System.Windows.Forms.TextBox();
            this.motionsDetectedLabel = new System.Windows.Forms.Label();
            this.motionsDetectedTxBx = new System.Windows.Forms.TextBox();
            this.stopButton = new System.Windows.Forms.Button();
            this.singleFrameDetectedTxBx = new System.Windows.Forms.TextBox();
            this.singleFrameDetectedLabel = new System.Windows.Forms.Label();
            this.bgSubtractorTypePanel.SuspendLayout();
            this.mogPanel.SuspendLayout();
            this.mog2Panel.SuspendLayout();
            this.lsbpPanel.SuspendLayout();
            this.knnPanel.SuspendLayout();
            this.gmgPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectVideoButton
            // 
            this.selectVideoButton.Location = new System.Drawing.Point(15, 28);
            this.selectVideoButton.Name = "selectVideoButton";
            this.selectVideoButton.Size = new System.Drawing.Size(89, 23);
            this.selectVideoButton.TabIndex = 0;
            this.selectVideoButton.Text = "Select video";
            this.selectVideoButton.UseVisualStyleBackColor = false;
            this.selectVideoButton.Click += new System.EventHandler(this.selectVideoButton_Click);
            // 
            // selectVideoTXB
            // 
            this.selectVideoTXB.Location = new System.Drawing.Point(110, 31);
            this.selectVideoTXB.Name = "selectVideoTXB";
            this.selectVideoTXB.ReadOnly = true;
            this.selectVideoTXB.Size = new System.Drawing.Size(205, 20);
            this.selectVideoTXB.TabIndex = 1;
            // 
            // detectMotionButton
            // 
            this.detectMotionButton.Location = new System.Drawing.Point(780, 498);
            this.detectMotionButton.Name = "detectMotionButton";
            this.detectMotionButton.Size = new System.Drawing.Size(98, 23);
            this.detectMotionButton.TabIndex = 2;
            this.detectMotionButton.Text = "Detect motion";
            this.detectMotionButton.UseVisualStyleBackColor = true;
            this.detectMotionButton.Click += new System.EventHandler(this.detectMotionButton_Click);
            // 
            // MOGParamsLabel
            // 
            this.MOGParamsLabel.AutoSize = true;
            this.MOGParamsLabel.Location = new System.Drawing.Point(3, 0);
            this.MOGParamsLabel.Name = "MOGParamsLabel";
            this.MOGParamsLabel.Size = new System.Drawing.Size(90, 13);
            this.MOGParamsLabel.TabIndex = 3;
            this.MOGParamsLabel.Text = "MOG parameters:";
            // 
            // bgSubtractorTypePanel
            // 
            this.bgSubtractorTypePanel.Controls.Add(this.GMG_RB);
            this.bgSubtractorTypePanel.Controls.Add(this.LSBP_RB);
            this.bgSubtractorTypePanel.Controls.Add(this.KNN_RB);
            this.bgSubtractorTypePanel.Controls.Add(this.MOG2_RB);
            this.bgSubtractorTypePanel.Controls.Add(this.MOG_RB);
            this.bgSubtractorTypePanel.Location = new System.Drawing.Point(15, 122);
            this.bgSubtractorTypePanel.Name = "bgSubtractorTypePanel";
            this.bgSubtractorTypePanel.Size = new System.Drawing.Size(81, 124);
            this.bgSubtractorTypePanel.TabIndex = 4;
            // 
            // GMG_RB
            // 
            this.GMG_RB.AutoSize = true;
            this.GMG_RB.Location = new System.Drawing.Point(3, 95);
            this.GMG_RB.Name = "GMG_RB";
            this.GMG_RB.Size = new System.Drawing.Size(50, 17);
            this.GMG_RB.TabIndex = 4;
            this.GMG_RB.TabStop = true;
            this.GMG_RB.Text = "GMG";
            this.GMG_RB.UseVisualStyleBackColor = true;
            this.GMG_RB.CheckedChanged += new System.EventHandler(this.GMG_RB_CheckedChanged);
            // 
            // LSBP_RB
            // 
            this.LSBP_RB.AutoSize = true;
            this.LSBP_RB.Location = new System.Drawing.Point(3, 72);
            this.LSBP_RB.Name = "LSBP_RB";
            this.LSBP_RB.Size = new System.Drawing.Size(52, 17);
            this.LSBP_RB.TabIndex = 3;
            this.LSBP_RB.TabStop = true;
            this.LSBP_RB.Text = "LSBP";
            this.LSBP_RB.UseVisualStyleBackColor = true;
            this.LSBP_RB.CheckedChanged += new System.EventHandler(this.LSBP_RB_CheckedChanged);
            // 
            // KNN_RB
            // 
            this.KNN_RB.AutoSize = true;
            this.KNN_RB.Location = new System.Drawing.Point(3, 49);
            this.KNN_RB.Name = "KNN_RB";
            this.KNN_RB.Size = new System.Drawing.Size(48, 17);
            this.KNN_RB.TabIndex = 2;
            this.KNN_RB.TabStop = true;
            this.KNN_RB.Text = "KNN";
            this.KNN_RB.UseVisualStyleBackColor = true;
            this.KNN_RB.CheckedChanged += new System.EventHandler(this.KNN_RB_CheckedChanged);
            // 
            // MOG2_RB
            // 
            this.MOG2_RB.AutoSize = true;
            this.MOG2_RB.Location = new System.Drawing.Point(3, 26);
            this.MOG2_RB.Name = "MOG2_RB";
            this.MOG2_RB.Size = new System.Drawing.Size(56, 17);
            this.MOG2_RB.TabIndex = 1;
            this.MOG2_RB.TabStop = true;
            this.MOG2_RB.Text = "MOG2";
            this.MOG2_RB.UseVisualStyleBackColor = true;
            this.MOG2_RB.CheckedChanged += new System.EventHandler(this.MOG2_RB_CheckedChanged);
            // 
            // MOG_RB
            // 
            this.MOG_RB.AutoSize = true;
            this.MOG_RB.Location = new System.Drawing.Point(3, 3);
            this.MOG_RB.Name = "MOG_RB";
            this.MOG_RB.Size = new System.Drawing.Size(50, 17);
            this.MOG_RB.TabIndex = 0;
            this.MOG_RB.TabStop = true;
            this.MOG_RB.Text = "MOG";
            this.MOG_RB.UseVisualStyleBackColor = true;
            this.MOG_RB.CheckedChanged += new System.EventHandler(this.MOG_RB_CheckedChanged);
            // 
            // selectSourceLabel
            // 
            this.selectSourceLabel.AutoSize = true;
            this.selectSourceLabel.Location = new System.Drawing.Point(12, 9);
            this.selectSourceLabel.Name = "selectSourceLabel";
            this.selectSourceLabel.Size = new System.Drawing.Size(75, 13);
            this.selectSourceLabel.TabIndex = 5;
            this.selectSourceLabel.Text = "Select source:";
            // 
            // useCameraChBx
            // 
            this.useCameraChBx.AutoSize = true;
            this.useCameraChBx.Location = new System.Drawing.Point(87, 69);
            this.useCameraChBx.Name = "useCameraChBx";
            this.useCameraChBx.Size = new System.Drawing.Size(118, 17);
            this.useCameraChBx.TabIndex = 7;
            this.useCameraChBx.Text = "Use default camera";
            this.useCameraChBx.UseVisualStyleBackColor = true;
            // 
            // selectBGSubtractorTypeLabel
            // 
            this.selectBGSubtractorTypeLabel.AutoSize = true;
            this.selectBGSubtractorTypeLabel.Location = new System.Drawing.Point(12, 106);
            this.selectBGSubtractorTypeLabel.Name = "selectBGSubtractorTypeLabel";
            this.selectBGSubtractorTypeLabel.Size = new System.Drawing.Size(173, 13);
            this.selectBGSubtractorTypeLabel.TabIndex = 8;
            this.selectBGSubtractorTypeLabel.Text = "Select background subtractor type:";
            // 
            // mogHistoryLabel
            // 
            this.mogHistoryLabel.AutoSize = true;
            this.mogHistoryLabel.Location = new System.Drawing.Point(3, 22);
            this.mogHistoryLabel.Name = "mogHistoryLabel";
            this.mogHistoryLabel.Size = new System.Drawing.Size(42, 13);
            this.mogHistoryLabel.TabIndex = 9;
            this.mogHistoryLabel.Text = "History:";
            // 
            // mogPanel
            // 
            this.mogPanel.Controls.Add(this.mogDefaultNoiseSigmaValue);
            this.mogPanel.Controls.Add(this.mogDefaultsLabel);
            this.mogPanel.Controls.Add(this.mogDefaultBgRatioValue);
            this.mogPanel.Controls.Add(this.mogDefaultNMixturesValue);
            this.mogPanel.Controls.Add(this.mogDefaultHistoryValue);
            this.mogPanel.Controls.Add(this.mogNoiseSigmaTxBx);
            this.mogPanel.Controls.Add(this.mogNoiseSigmaLabel);
            this.mogPanel.Controls.Add(this.mogBackgroundRatioTxBx);
            this.mogPanel.Controls.Add(this.mogBackgroundRatioLabel);
            this.mogPanel.Controls.Add(this.mogNMixturesTxBx);
            this.mogPanel.Controls.Add(this.mogNMixturesLabel);
            this.mogPanel.Controls.Add(this.mogHistoryTxBx);
            this.mogPanel.Controls.Add(this.MOGParamsLabel);
            this.mogPanel.Controls.Add(this.mogHistoryLabel);
            this.mogPanel.Location = new System.Drawing.Point(15, 252);
            this.mogPanel.Name = "mogPanel";
            this.mogPanel.Size = new System.Drawing.Size(265, 144);
            this.mogPanel.TabIndex = 10;
            // 
            // mogDefaultNoiseSigmaValue
            // 
            this.mogDefaultNoiseSigmaValue.AutoSize = true;
            this.mogDefaultNoiseSigmaValue.Location = new System.Drawing.Point(211, 115);
            this.mogDefaultNoiseSigmaValue.Name = "mogDefaultNoiseSigmaValue";
            this.mogDefaultNoiseSigmaValue.Size = new System.Drawing.Size(13, 13);
            this.mogDefaultNoiseSigmaValue.TabIndex = 20;
            this.mogDefaultNoiseSigmaValue.Text = "0";
            // 
            // mogDefaultsLabel
            // 
            this.mogDefaultsLabel.AutoSize = true;
            this.mogDefaultsLabel.Location = new System.Drawing.Point(211, 0);
            this.mogDefaultsLabel.Name = "mogDefaultsLabel";
            this.mogDefaultsLabel.Size = new System.Drawing.Size(49, 13);
            this.mogDefaultsLabel.TabIndex = 13;
            this.mogDefaultsLabel.Text = "Defaults:";
            // 
            // mogDefaultBgRatioValue
            // 
            this.mogDefaultBgRatioValue.AutoSize = true;
            this.mogDefaultBgRatioValue.Location = new System.Drawing.Point(211, 84);
            this.mogDefaultBgRatioValue.Name = "mogDefaultBgRatioValue";
            this.mogDefaultBgRatioValue.Size = new System.Drawing.Size(22, 13);
            this.mogDefaultBgRatioValue.TabIndex = 19;
            this.mogDefaultBgRatioValue.Text = "0.7";
            // 
            // mogDefaultNMixturesValue
            // 
            this.mogDefaultNMixturesValue.AutoSize = true;
            this.mogDefaultNMixturesValue.Location = new System.Drawing.Point(211, 54);
            this.mogDefaultNMixturesValue.Name = "mogDefaultNMixturesValue";
            this.mogDefaultNMixturesValue.Size = new System.Drawing.Size(13, 13);
            this.mogDefaultNMixturesValue.TabIndex = 18;
            this.mogDefaultNMixturesValue.Text = "5";
            // 
            // mogDefaultHistoryValue
            // 
            this.mogDefaultHistoryValue.AutoSize = true;
            this.mogDefaultHistoryValue.Location = new System.Drawing.Point(211, 22);
            this.mogDefaultHistoryValue.Name = "mogDefaultHistoryValue";
            this.mogDefaultHistoryValue.Size = new System.Drawing.Size(25, 13);
            this.mogDefaultHistoryValue.TabIndex = 17;
            this.mogDefaultHistoryValue.Text = "200";
            // 
            // mogNoiseSigmaTxBx
            // 
            this.mogNoiseSigmaTxBx.Location = new System.Drawing.Point(105, 112);
            this.mogNoiseSigmaTxBx.Name = "mogNoiseSigmaTxBx";
            this.mogNoiseSigmaTxBx.Size = new System.Drawing.Size(100, 20);
            this.mogNoiseSigmaTxBx.TabIndex = 16;
            this.mogNoiseSigmaTxBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mogNoiseSigmaTxBx_KeyPress);
            // 
            // mogNoiseSigmaLabel
            // 
            this.mogNoiseSigmaLabel.AutoSize = true;
            this.mogNoiseSigmaLabel.Location = new System.Drawing.Point(3, 115);
            this.mogNoiseSigmaLabel.Name = "mogNoiseSigmaLabel";
            this.mogNoiseSigmaLabel.Size = new System.Drawing.Size(69, 13);
            this.mogNoiseSigmaLabel.TabIndex = 15;
            this.mogNoiseSigmaLabel.Text = "Noise Sigma:";
            // 
            // mogBackgroundRatioTxBx
            // 
            this.mogBackgroundRatioTxBx.Location = new System.Drawing.Point(105, 81);
            this.mogBackgroundRatioTxBx.Name = "mogBackgroundRatioTxBx";
            this.mogBackgroundRatioTxBx.Size = new System.Drawing.Size(100, 20);
            this.mogBackgroundRatioTxBx.TabIndex = 14;
            this.mogBackgroundRatioTxBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mogBackgroundRatioTxBx_KeyPress);
            // 
            // mogBackgroundRatioLabel
            // 
            this.mogBackgroundRatioLabel.AutoSize = true;
            this.mogBackgroundRatioLabel.Location = new System.Drawing.Point(3, 84);
            this.mogBackgroundRatioLabel.Name = "mogBackgroundRatioLabel";
            this.mogBackgroundRatioLabel.Size = new System.Drawing.Size(96, 13);
            this.mogBackgroundRatioLabel.TabIndex = 13;
            this.mogBackgroundRatioLabel.Text = "Background Ratio:";
            // 
            // mogNMixturesTxBx
            // 
            this.mogNMixturesTxBx.Location = new System.Drawing.Point(105, 51);
            this.mogNMixturesTxBx.Name = "mogNMixturesTxBx";
            this.mogNMixturesTxBx.Size = new System.Drawing.Size(100, 20);
            this.mogNMixturesTxBx.TabIndex = 12;
            this.mogNMixturesTxBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mogNMixturesTxBx_KeyPress);
            // 
            // mogNMixturesLabel
            // 
            this.mogNMixturesLabel.AutoSize = true;
            this.mogNMixturesLabel.Location = new System.Drawing.Point(3, 54);
            this.mogNMixturesLabel.Name = "mogNMixturesLabel";
            this.mogNMixturesLabel.Size = new System.Drawing.Size(59, 13);
            this.mogNMixturesLabel.TabIndex = 11;
            this.mogNMixturesLabel.Text = "N mixtures:";
            // 
            // mogHistoryTxBx
            // 
            this.mogHistoryTxBx.Location = new System.Drawing.Point(105, 19);
            this.mogHistoryTxBx.Name = "mogHistoryTxBx";
            this.mogHistoryTxBx.Size = new System.Drawing.Size(100, 20);
            this.mogHistoryTxBx.TabIndex = 10;
            this.mogHistoryTxBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mogHistoryTxBx_KeyPress);
            // 
            // mog2Panel
            // 
            this.mog2Panel.Controls.Add(this.mog2DefaultThresholdValue);
            this.mog2Panel.Controls.Add(this.mog2DefaultHistoryValue);
            this.mog2Panel.Controls.Add(this.mog2DefaultsLabel);
            this.mog2Panel.Controls.Add(this.mog2ShadowDetectionChBx);
            this.mog2Panel.Controls.Add(this.mog2ThresholdTxBx);
            this.mog2Panel.Controls.Add(this.mog2ThresholdLabel);
            this.mog2Panel.Controls.Add(this.mog2HistoryTxBx);
            this.mog2Panel.Controls.Add(this.mog2HisotryLabel);
            this.mog2Panel.Controls.Add(this.MOG2ParamsLabel);
            this.mog2Panel.Location = new System.Drawing.Point(15, 402);
            this.mog2Panel.Name = "mog2Panel";
            this.mog2Panel.Size = new System.Drawing.Size(265, 111);
            this.mog2Panel.TabIndex = 11;
            // 
            // mog2DefaultThresholdValue
            // 
            this.mog2DefaultThresholdValue.AutoSize = true;
            this.mog2DefaultThresholdValue.Location = new System.Drawing.Point(211, 50);
            this.mog2DefaultThresholdValue.Name = "mog2DefaultThresholdValue";
            this.mog2DefaultThresholdValue.Size = new System.Drawing.Size(19, 13);
            this.mog2DefaultThresholdValue.TabIndex = 16;
            this.mog2DefaultThresholdValue.Text = "16";
            // 
            // mog2DefaultHistoryValue
            // 
            this.mog2DefaultHistoryValue.AutoSize = true;
            this.mog2DefaultHistoryValue.Location = new System.Drawing.Point(211, 23);
            this.mog2DefaultHistoryValue.Name = "mog2DefaultHistoryValue";
            this.mog2DefaultHistoryValue.Size = new System.Drawing.Size(25, 13);
            this.mog2DefaultHistoryValue.TabIndex = 15;
            this.mog2DefaultHistoryValue.Text = "500";
            // 
            // mog2DefaultsLabel
            // 
            this.mog2DefaultsLabel.AutoSize = true;
            this.mog2DefaultsLabel.Location = new System.Drawing.Point(211, 0);
            this.mog2DefaultsLabel.Name = "mog2DefaultsLabel";
            this.mog2DefaultsLabel.Size = new System.Drawing.Size(49, 13);
            this.mog2DefaultsLabel.TabIndex = 14;
            this.mog2DefaultsLabel.Text = "Defaults:";
            // 
            // mog2ShadowDetectionChBx
            // 
            this.mog2ShadowDetectionChBx.AutoSize = true;
            this.mog2ShadowDetectionChBx.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mog2ShadowDetectionChBx.Location = new System.Drawing.Point(3, 82);
            this.mog2ShadowDetectionChBx.Name = "mog2ShadowDetectionChBx";
            this.mog2ShadowDetectionChBx.Size = new System.Drawing.Size(112, 17);
            this.mog2ShadowDetectionChBx.TabIndex = 5;
            this.mog2ShadowDetectionChBx.Text = "Shadow detection";
            this.mog2ShadowDetectionChBx.UseVisualStyleBackColor = true;
            // 
            // mog2ThresholdTxBx
            // 
            this.mog2ThresholdTxBx.Location = new System.Drawing.Point(105, 47);
            this.mog2ThresholdTxBx.Name = "mog2ThresholdTxBx";
            this.mog2ThresholdTxBx.Size = new System.Drawing.Size(100, 20);
            this.mog2ThresholdTxBx.TabIndex = 4;
            this.mog2ThresholdTxBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mog2ThresholdTxBx_KeyPress);
            // 
            // mog2ThresholdLabel
            // 
            this.mog2ThresholdLabel.AutoSize = true;
            this.mog2ThresholdLabel.Location = new System.Drawing.Point(3, 50);
            this.mog2ThresholdLabel.Name = "mog2ThresholdLabel";
            this.mog2ThresholdLabel.Size = new System.Drawing.Size(57, 13);
            this.mog2ThresholdLabel.TabIndex = 3;
            this.mog2ThresholdLabel.Text = "Threshold:";
            // 
            // mog2HistoryTxBx
            // 
            this.mog2HistoryTxBx.Location = new System.Drawing.Point(105, 20);
            this.mog2HistoryTxBx.Name = "mog2HistoryTxBx";
            this.mog2HistoryTxBx.Size = new System.Drawing.Size(100, 20);
            this.mog2HistoryTxBx.TabIndex = 2;
            this.mog2HistoryTxBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mog2HistoryTxBx_KeyPress);
            // 
            // mog2HisotryLabel
            // 
            this.mog2HisotryLabel.AutoSize = true;
            this.mog2HisotryLabel.Location = new System.Drawing.Point(3, 23);
            this.mog2HisotryLabel.Name = "mog2HisotryLabel";
            this.mog2HisotryLabel.Size = new System.Drawing.Size(42, 13);
            this.mog2HisotryLabel.TabIndex = 1;
            this.mog2HisotryLabel.Text = "History:";
            // 
            // MOG2ParamsLabel
            // 
            this.MOG2ParamsLabel.AutoSize = true;
            this.MOG2ParamsLabel.Location = new System.Drawing.Point(3, 0);
            this.MOG2ParamsLabel.Name = "MOG2ParamsLabel";
            this.MOG2ParamsLabel.Size = new System.Drawing.Size(96, 13);
            this.MOG2ParamsLabel.TabIndex = 0;
            this.MOG2ParamsLabel.Text = "MOG2 parameters:";
            // 
            // lsbpPanel
            // 
            this.lsbpPanel.Controls.Add(this.lsbpDefaultMinCountValue);
            this.lsbpPanel.Controls.Add(this.lsbpDefaultThresholdValue);
            this.lsbpPanel.Controls.Add(this.lsbpDefaultNRTFFGValue);
            this.lsbpPanel.Controls.Add(this.lsbpDefaultNRTFBGValue);
            this.lsbpPanel.Controls.Add(this.lsbpDefaultRIncDecValue);
            this.lsbpPanel.Controls.Add(this.lsbpDefaultRScaleValue);
            this.lsbpPanel.Controls.Add(this.lsbpDefaultTDecValue);
            this.lsbpPanel.Controls.Add(this.lsbpDefaultTIncValue);
            this.lsbpPanel.Controls.Add(this.lsbpDefaultTUpperValue);
            this.lsbpPanel.Controls.Add(this.lsbpDefaultTLowerValue);
            this.lsbpPanel.Controls.Add(this.lsbpDefaultRadiusValue);
            this.lsbpPanel.Controls.Add(this.lsbpDefaultNSamplesValue);
            this.lsbpPanel.Controls.Add(this.lsbpDefaultsLabel);
            this.lsbpPanel.Controls.Add(this.lsbpMinCountTxBx);
            this.lsbpPanel.Controls.Add(this.lsbpMinCountLabel);
            this.lsbpPanel.Controls.Add(this.lsbpThresholdTxBx);
            this.lsbpPanel.Controls.Add(this.lsbpThresholdLabel);
            this.lsbpPanel.Controls.Add(this.lsbpNoiseRemovalThresholdFacFGTxBx);
            this.lsbpPanel.Controls.Add(this.lsbpNoiseRemovalThresholdFacFGLabel);
            this.lsbpPanel.Controls.Add(this.lsbpNoiseRemovalThresholdFacBGTxBx);
            this.lsbpPanel.Controls.Add(this.lsbpNoiseRemovalThresholdFacBGLabel);
            this.lsbpPanel.Controls.Add(this.lsbpRIncDecTxBx);
            this.lsbpPanel.Controls.Add(this.lsbpRIncDecLabel);
            this.lsbpPanel.Controls.Add(this.lsbpRScaleTxBx);
            this.lsbpPanel.Controls.Add(this.lsbpRScaleLabel);
            this.lsbpPanel.Controls.Add(this.lsbpTDecTxBx);
            this.lsbpPanel.Controls.Add(this.lsbpTDecLabel);
            this.lsbpPanel.Controls.Add(this.lsbpTIncTxBx);
            this.lsbpPanel.Controls.Add(this.lsbpTIncLabel);
            this.lsbpPanel.Controls.Add(this.lsbpTUpperTxBx);
            this.lsbpPanel.Controls.Add(this.lsbpTUpperLabel);
            this.lsbpPanel.Controls.Add(this.lsbpTLowerTxBx);
            this.lsbpPanel.Controls.Add(this.lsbpTLowerLabel);
            this.lsbpPanel.Controls.Add(this.lsbpRadiusTxBx);
            this.lsbpPanel.Controls.Add(this.lsbpRadiusLabel);
            this.lsbpPanel.Controls.Add(this.lsbpNSamplesTxBx);
            this.lsbpPanel.Controls.Add(this.lsbpNSamplesLabel);
            this.lsbpPanel.Controls.Add(this.lsbpCameraMotionCompensationLabel);
            this.lsbpPanel.Controls.Add(this.lsbpCameraMotionCompensationCmBx);
            this.lsbpPanel.Controls.Add(this.LSBPParamsLabel);
            this.lsbpPanel.Location = new System.Drawing.Point(286, 73);
            this.lsbpPanel.Name = "lsbpPanel";
            this.lsbpPanel.Size = new System.Drawing.Size(247, 440);
            this.lsbpPanel.TabIndex = 12;
            // 
            // lsbpDefaultMinCountValue
            // 
            this.lsbpDefaultMinCountValue.AutoSize = true;
            this.lsbpDefaultMinCountValue.Location = new System.Drawing.Point(188, 409);
            this.lsbpDefaultMinCountValue.Name = "lsbpDefaultMinCountValue";
            this.lsbpDefaultMinCountValue.Size = new System.Drawing.Size(13, 13);
            this.lsbpDefaultMinCountValue.TabIndex = 40;
            this.lsbpDefaultMinCountValue.Text = "2";
            // 
            // lsbpDefaultThresholdValue
            // 
            this.lsbpDefaultThresholdValue.AutoSize = true;
            this.lsbpDefaultThresholdValue.Location = new System.Drawing.Point(188, 382);
            this.lsbpDefaultThresholdValue.Name = "lsbpDefaultThresholdValue";
            this.lsbpDefaultThresholdValue.Size = new System.Drawing.Size(13, 13);
            this.lsbpDefaultThresholdValue.TabIndex = 40;
            this.lsbpDefaultThresholdValue.Text = "8";
            // 
            // lsbpDefaultNRTFFGValue
            // 
            this.lsbpDefaultNRTFFGValue.AutoSize = true;
            this.lsbpDefaultNRTFFGValue.Location = new System.Drawing.Point(188, 354);
            this.lsbpDefaultNRTFFGValue.Name = "lsbpDefaultNRTFFGValue";
            this.lsbpDefaultNRTFFGValue.Size = new System.Drawing.Size(40, 13);
            this.lsbpDefaultNRTFFGValue.TabIndex = 47;
            this.lsbpDefaultNRTFFGValue.Text = "0.0008";
            // 
            // lsbpDefaultNRTFBGValue
            // 
            this.lsbpDefaultNRTFBGValue.AutoSize = true;
            this.lsbpDefaultNRTFBGValue.Location = new System.Drawing.Point(188, 307);
            this.lsbpDefaultNRTFBGValue.Name = "lsbpDefaultNRTFBGValue";
            this.lsbpDefaultNRTFBGValue.Size = new System.Drawing.Size(40, 13);
            this.lsbpDefaultNRTFBGValue.TabIndex = 46;
            this.lsbpDefaultNRTFBGValue.Text = "0.0004";
            // 
            // lsbpDefaultRIncDecValue
            // 
            this.lsbpDefaultRIncDecValue.AutoSize = true;
            this.lsbpDefaultRIncDecValue.Location = new System.Drawing.Point(188, 261);
            this.lsbpDefaultRIncDecValue.Name = "lsbpDefaultRIncDecValue";
            this.lsbpDefaultRIncDecValue.Size = new System.Drawing.Size(34, 13);
            this.lsbpDefaultRIncDecValue.TabIndex = 45;
            this.lsbpDefaultRIncDecValue.Text = "0.005";
            // 
            // lsbpDefaultRScaleValue
            // 
            this.lsbpDefaultRScaleValue.AutoSize = true;
            this.lsbpDefaultRScaleValue.Location = new System.Drawing.Point(188, 234);
            this.lsbpDefaultRScaleValue.Name = "lsbpDefaultRScaleValue";
            this.lsbpDefaultRScaleValue.Size = new System.Drawing.Size(19, 13);
            this.lsbpDefaultRScaleValue.TabIndex = 40;
            this.lsbpDefaultRScaleValue.Text = "10";
            // 
            // lsbpDefaultTDecValue
            // 
            this.lsbpDefaultTDecValue.AutoSize = true;
            this.lsbpDefaultTDecValue.Location = new System.Drawing.Point(188, 207);
            this.lsbpDefaultTDecValue.Name = "lsbpDefaultTDecValue";
            this.lsbpDefaultTDecValue.Size = new System.Drawing.Size(28, 13);
            this.lsbpDefaultTDecValue.TabIndex = 44;
            this.lsbpDefaultTDecValue.Text = "0.05";
            // 
            // lsbpDefaultTIncValue
            // 
            this.lsbpDefaultTIncValue.AutoSize = true;
            this.lsbpDefaultTIncValue.Location = new System.Drawing.Point(188, 180);
            this.lsbpDefaultTIncValue.Name = "lsbpDefaultTIncValue";
            this.lsbpDefaultTIncValue.Size = new System.Drawing.Size(13, 13);
            this.lsbpDefaultTIncValue.TabIndex = 43;
            this.lsbpDefaultTIncValue.Text = "1";
            // 
            // lsbpDefaultTUpperValue
            // 
            this.lsbpDefaultTUpperValue.AutoSize = true;
            this.lsbpDefaultTUpperValue.Location = new System.Drawing.Point(188, 153);
            this.lsbpDefaultTUpperValue.Name = "lsbpDefaultTUpperValue";
            this.lsbpDefaultTUpperValue.Size = new System.Drawing.Size(19, 13);
            this.lsbpDefaultTUpperValue.TabIndex = 42;
            this.lsbpDefaultTUpperValue.Text = "32";
            // 
            // lsbpDefaultTLowerValue
            // 
            this.lsbpDefaultTLowerValue.AutoSize = true;
            this.lsbpDefaultTLowerValue.Location = new System.Drawing.Point(188, 126);
            this.lsbpDefaultTLowerValue.Name = "lsbpDefaultTLowerValue";
            this.lsbpDefaultTLowerValue.Size = new System.Drawing.Size(13, 13);
            this.lsbpDefaultTLowerValue.TabIndex = 41;
            this.lsbpDefaultTLowerValue.Text = "2";
            // 
            // lsbpDefaultRadiusValue
            // 
            this.lsbpDefaultRadiusValue.AutoSize = true;
            this.lsbpDefaultRadiusValue.Location = new System.Drawing.Point(188, 100);
            this.lsbpDefaultRadiusValue.Name = "lsbpDefaultRadiusValue";
            this.lsbpDefaultRadiusValue.Size = new System.Drawing.Size(19, 13);
            this.lsbpDefaultRadiusValue.TabIndex = 40;
            this.lsbpDefaultRadiusValue.Text = "16";
            // 
            // lsbpDefaultNSamplesValue
            // 
            this.lsbpDefaultNSamplesValue.AutoSize = true;
            this.lsbpDefaultNSamplesValue.Location = new System.Drawing.Point(188, 72);
            this.lsbpDefaultNSamplesValue.Name = "lsbpDefaultNSamplesValue";
            this.lsbpDefaultNSamplesValue.Size = new System.Drawing.Size(19, 13);
            this.lsbpDefaultNSamplesValue.TabIndex = 39;
            this.lsbpDefaultNSamplesValue.Text = "20";
            // 
            // lsbpDefaultsLabel
            // 
            this.lsbpDefaultsLabel.AutoSize = true;
            this.lsbpDefaultsLabel.Location = new System.Drawing.Point(188, 0);
            this.lsbpDefaultsLabel.Name = "lsbpDefaultsLabel";
            this.lsbpDefaultsLabel.Size = new System.Drawing.Size(49, 13);
            this.lsbpDefaultsLabel.TabIndex = 21;
            this.lsbpDefaultsLabel.Text = "Defaults:";
            // 
            // lsbpMinCountTxBx
            // 
            this.lsbpMinCountTxBx.Location = new System.Drawing.Point(82, 406);
            this.lsbpMinCountTxBx.Name = "lsbpMinCountTxBx";
            this.lsbpMinCountTxBx.Size = new System.Drawing.Size(100, 20);
            this.lsbpMinCountTxBx.TabIndex = 38;
            this.lsbpMinCountTxBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lsbpMinCountTxBx_KeyPress);
            // 
            // lsbpMinCountLabel
            // 
            this.lsbpMinCountLabel.AutoSize = true;
            this.lsbpMinCountLabel.Location = new System.Drawing.Point(3, 409);
            this.lsbpMinCountLabel.Name = "lsbpMinCountLabel";
            this.lsbpMinCountLabel.Size = new System.Drawing.Size(57, 13);
            this.lsbpMinCountLabel.TabIndex = 37;
            this.lsbpMinCountLabel.Text = "Min count:";
            // 
            // lsbpThresholdTxBx
            // 
            this.lsbpThresholdTxBx.Location = new System.Drawing.Point(82, 379);
            this.lsbpThresholdTxBx.Name = "lsbpThresholdTxBx";
            this.lsbpThresholdTxBx.Size = new System.Drawing.Size(100, 20);
            this.lsbpThresholdTxBx.TabIndex = 36;
            this.lsbpThresholdTxBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lsbpThresholdTxBx_KeyPress);
            // 
            // lsbpThresholdLabel
            // 
            this.lsbpThresholdLabel.AutoSize = true;
            this.lsbpThresholdLabel.Location = new System.Drawing.Point(3, 382);
            this.lsbpThresholdLabel.Name = "lsbpThresholdLabel";
            this.lsbpThresholdLabel.Size = new System.Drawing.Size(57, 13);
            this.lsbpThresholdLabel.TabIndex = 35;
            this.lsbpThresholdLabel.Text = "Threshold:";
            // 
            // lsbpNoiseRemovalThresholdFacFGTxBx
            // 
            this.lsbpNoiseRemovalThresholdFacFGTxBx.Location = new System.Drawing.Point(82, 351);
            this.lsbpNoiseRemovalThresholdFacFGTxBx.Name = "lsbpNoiseRemovalThresholdFacFGTxBx";
            this.lsbpNoiseRemovalThresholdFacFGTxBx.Size = new System.Drawing.Size(100, 20);
            this.lsbpNoiseRemovalThresholdFacFGTxBx.TabIndex = 34;
            this.lsbpNoiseRemovalThresholdFacFGTxBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lsbpNoiseRemovalThresholdFacFGTxBx_KeyPress);
            // 
            // lsbpNoiseRemovalThresholdFacFGLabel
            // 
            this.lsbpNoiseRemovalThresholdFacFGLabel.AutoSize = true;
            this.lsbpNoiseRemovalThresholdFacFGLabel.Location = new System.Drawing.Point(3, 335);
            this.lsbpNoiseRemovalThresholdFacFGLabel.Name = "lsbpNoiseRemovalThresholdFacFGLabel";
            this.lsbpNoiseRemovalThresholdFacFGLabel.Size = new System.Drawing.Size(170, 13);
            this.lsbpNoiseRemovalThresholdFacFGLabel.TabIndex = 33;
            this.lsbpNoiseRemovalThresholdFacFGLabel.Text = "Noise Removal Threshold Fac FG:";
            // 
            // lsbpNoiseRemovalThresholdFacBGTxBx
            // 
            this.lsbpNoiseRemovalThresholdFacBGTxBx.Location = new System.Drawing.Point(82, 304);
            this.lsbpNoiseRemovalThresholdFacBGTxBx.Name = "lsbpNoiseRemovalThresholdFacBGTxBx";
            this.lsbpNoiseRemovalThresholdFacBGTxBx.Size = new System.Drawing.Size(100, 20);
            this.lsbpNoiseRemovalThresholdFacBGTxBx.TabIndex = 32;
            this.lsbpNoiseRemovalThresholdFacBGTxBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lsbpNoiseRemovalThresholdFacBGTxBx_KeyPress);
            // 
            // lsbpNoiseRemovalThresholdFacBGLabel
            // 
            this.lsbpNoiseRemovalThresholdFacBGLabel.AutoSize = true;
            this.lsbpNoiseRemovalThresholdFacBGLabel.Location = new System.Drawing.Point(3, 288);
            this.lsbpNoiseRemovalThresholdFacBGLabel.Name = "lsbpNoiseRemovalThresholdFacBGLabel";
            this.lsbpNoiseRemovalThresholdFacBGLabel.Size = new System.Drawing.Size(171, 13);
            this.lsbpNoiseRemovalThresholdFacBGLabel.TabIndex = 31;
            this.lsbpNoiseRemovalThresholdFacBGLabel.Text = "Noise Removal Threshold Fac BG:";
            // 
            // lsbpRIncDecTxBx
            // 
            this.lsbpRIncDecTxBx.Location = new System.Drawing.Point(82, 258);
            this.lsbpRIncDecTxBx.Name = "lsbpRIncDecTxBx";
            this.lsbpRIncDecTxBx.Size = new System.Drawing.Size(100, 20);
            this.lsbpRIncDecTxBx.TabIndex = 30;
            this.lsbpRIncDecTxBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lsbpRIncDecTxBx_KeyPress);
            // 
            // lsbpRIncDecLabel
            // 
            this.lsbpRIncDecLabel.AutoSize = true;
            this.lsbpRIncDecLabel.Location = new System.Drawing.Point(3, 261);
            this.lsbpRIncDecLabel.Name = "lsbpRIncDecLabel";
            this.lsbpRIncDecLabel.Size = new System.Drawing.Size(56, 13);
            this.lsbpRIncDecLabel.TabIndex = 29;
            this.lsbpRIncDecLabel.Text = "R IncDec:";
            // 
            // lsbpRScaleTxBx
            // 
            this.lsbpRScaleTxBx.Location = new System.Drawing.Point(82, 231);
            this.lsbpRScaleTxBx.Name = "lsbpRScaleTxBx";
            this.lsbpRScaleTxBx.Size = new System.Drawing.Size(100, 20);
            this.lsbpRScaleTxBx.TabIndex = 28;
            this.lsbpRScaleTxBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lsbpRScaleTxBx_KeyPress);
            // 
            // lsbpRScaleLabel
            // 
            this.lsbpRScaleLabel.AutoSize = true;
            this.lsbpRScaleLabel.Location = new System.Drawing.Point(3, 234);
            this.lsbpRScaleLabel.Name = "lsbpRScaleLabel";
            this.lsbpRScaleLabel.Size = new System.Drawing.Size(48, 13);
            this.lsbpRScaleLabel.TabIndex = 27;
            this.lsbpRScaleLabel.Text = "R Scale:";
            // 
            // lsbpTDecTxBx
            // 
            this.lsbpTDecTxBx.Location = new System.Drawing.Point(82, 204);
            this.lsbpTDecTxBx.Name = "lsbpTDecTxBx";
            this.lsbpTDecTxBx.Size = new System.Drawing.Size(100, 20);
            this.lsbpTDecTxBx.TabIndex = 26;
            this.lsbpTDecTxBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lsbpTDecTxBx_KeyPress);
            // 
            // lsbpTDecLabel
            // 
            this.lsbpTDecLabel.AutoSize = true;
            this.lsbpTDecLabel.Location = new System.Drawing.Point(3, 207);
            this.lsbpTDecLabel.Name = "lsbpTDecLabel";
            this.lsbpTDecLabel.Size = new System.Drawing.Size(40, 13);
            this.lsbpTDecLabel.TabIndex = 25;
            this.lsbpTDecLabel.Text = "T Dec:";
            // 
            // lsbpTIncTxBx
            // 
            this.lsbpTIncTxBx.Location = new System.Drawing.Point(82, 177);
            this.lsbpTIncTxBx.Name = "lsbpTIncTxBx";
            this.lsbpTIncTxBx.Size = new System.Drawing.Size(100, 20);
            this.lsbpTIncTxBx.TabIndex = 24;
            this.lsbpTIncTxBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lsbpTIncTxBx_KeyPress);
            // 
            // lsbpTIncLabel
            // 
            this.lsbpTIncLabel.AutoSize = true;
            this.lsbpTIncLabel.Location = new System.Drawing.Point(3, 180);
            this.lsbpTIncLabel.Name = "lsbpTIncLabel";
            this.lsbpTIncLabel.Size = new System.Drawing.Size(35, 13);
            this.lsbpTIncLabel.TabIndex = 23;
            this.lsbpTIncLabel.Text = "T Inc:";
            // 
            // lsbpTUpperTxBx
            // 
            this.lsbpTUpperTxBx.Location = new System.Drawing.Point(82, 150);
            this.lsbpTUpperTxBx.Name = "lsbpTUpperTxBx";
            this.lsbpTUpperTxBx.Size = new System.Drawing.Size(100, 20);
            this.lsbpTUpperTxBx.TabIndex = 22;
            this.lsbpTUpperTxBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lsbpTUpperTxBx_KeyPress);
            // 
            // lsbpTUpperLabel
            // 
            this.lsbpTUpperLabel.AutoSize = true;
            this.lsbpTUpperLabel.Location = new System.Drawing.Point(3, 153);
            this.lsbpTUpperLabel.Name = "lsbpTUpperLabel";
            this.lsbpTUpperLabel.Size = new System.Drawing.Size(49, 13);
            this.lsbpTUpperLabel.TabIndex = 21;
            this.lsbpTUpperLabel.Text = "T Upper:";
            // 
            // lsbpTLowerTxBx
            // 
            this.lsbpTLowerTxBx.Location = new System.Drawing.Point(82, 123);
            this.lsbpTLowerTxBx.Name = "lsbpTLowerTxBx";
            this.lsbpTLowerTxBx.Size = new System.Drawing.Size(100, 20);
            this.lsbpTLowerTxBx.TabIndex = 20;
            this.lsbpTLowerTxBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lsbpTLowerTxBx_KeyPress);
            // 
            // lsbpTLowerLabel
            // 
            this.lsbpTLowerLabel.AutoSize = true;
            this.lsbpTLowerLabel.Location = new System.Drawing.Point(3, 126);
            this.lsbpTLowerLabel.Name = "lsbpTLowerLabel";
            this.lsbpTLowerLabel.Size = new System.Drawing.Size(49, 13);
            this.lsbpTLowerLabel.TabIndex = 19;
            this.lsbpTLowerLabel.Text = "T Lower:";
            // 
            // lsbpRadiusTxBx
            // 
            this.lsbpRadiusTxBx.Location = new System.Drawing.Point(82, 96);
            this.lsbpRadiusTxBx.Name = "lsbpRadiusTxBx";
            this.lsbpRadiusTxBx.Size = new System.Drawing.Size(100, 20);
            this.lsbpRadiusTxBx.TabIndex = 18;
            this.lsbpRadiusTxBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lsbpRadiusTxBx_KeyPress);
            // 
            // lsbpRadiusLabel
            // 
            this.lsbpRadiusLabel.AutoSize = true;
            this.lsbpRadiusLabel.Location = new System.Drawing.Point(3, 99);
            this.lsbpRadiusLabel.Name = "lsbpRadiusLabel";
            this.lsbpRadiusLabel.Size = new System.Drawing.Size(73, 13);
            this.lsbpRadiusLabel.TabIndex = 17;
            this.lsbpRadiusLabel.Text = "LSBP Radius:";
            // 
            // lsbpNSamplesTxBx
            // 
            this.lsbpNSamplesTxBx.Location = new System.Drawing.Point(82, 69);
            this.lsbpNSamplesTxBx.Name = "lsbpNSamplesTxBx";
            this.lsbpNSamplesTxBx.Size = new System.Drawing.Size(100, 20);
            this.lsbpNSamplesTxBx.TabIndex = 16;
            this.lsbpNSamplesTxBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lsbpNSamplesTxBx_KeyPress);
            // 
            // lsbpNSamplesLabel
            // 
            this.lsbpNSamplesLabel.AutoSize = true;
            this.lsbpNSamplesLabel.Location = new System.Drawing.Point(3, 72);
            this.lsbpNSamplesLabel.Name = "lsbpNSamplesLabel";
            this.lsbpNSamplesLabel.Size = new System.Drawing.Size(59, 13);
            this.lsbpNSamplesLabel.TabIndex = 15;
            this.lsbpNSamplesLabel.Text = "N samples:";
            // 
            // lsbpCameraMotionCompensationLabel
            // 
            this.lsbpCameraMotionCompensationLabel.AutoSize = true;
            this.lsbpCameraMotionCompensationLabel.Location = new System.Drawing.Point(3, 22);
            this.lsbpCameraMotionCompensationLabel.Name = "lsbpCameraMotionCompensationLabel";
            this.lsbpCameraMotionCompensationLabel.Size = new System.Drawing.Size(151, 13);
            this.lsbpCameraMotionCompensationLabel.TabIndex = 14;
            this.lsbpCameraMotionCompensationLabel.Text = "Camera Motion Compensation:";
            // 
            // lsbpCameraMotionCompensationCmBx
            // 
            this.lsbpCameraMotionCompensationCmBx.DataSource = new Emgu.CV.BgSegm.BackgroundSubtractorLSBP.CameraMotionCompensation[] {
        Emgu.CV.BgSegm.BackgroundSubtractorLSBP.CameraMotionCompensation.None,
        Emgu.CV.BgSegm.BackgroundSubtractorLSBP.CameraMotionCompensation.LK};
            this.lsbpCameraMotionCompensationCmBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lsbpCameraMotionCompensationCmBx.FormattingEnabled = true;
            this.lsbpCameraMotionCompensationCmBx.Location = new System.Drawing.Point(33, 38);
            this.lsbpCameraMotionCompensationCmBx.Name = "lsbpCameraMotionCompensationCmBx";
            this.lsbpCameraMotionCompensationCmBx.Size = new System.Drawing.Size(121, 21);
            this.lsbpCameraMotionCompensationCmBx.TabIndex = 13;
            // 
            // LSBPParamsLabel
            // 
            this.LSBPParamsLabel.AutoSize = true;
            this.LSBPParamsLabel.Location = new System.Drawing.Point(3, 0);
            this.LSBPParamsLabel.Name = "LSBPParamsLabel";
            this.LSBPParamsLabel.Size = new System.Drawing.Size(92, 13);
            this.LSBPParamsLabel.TabIndex = 0;
            this.LSBPParamsLabel.Text = "LSBP parameters:";
            // 
            // knnPanel
            // 
            this.knnPanel.Controls.Add(this.knnDefaultDist2ThresholdValue);
            this.knnPanel.Controls.Add(this.knnDefaultHistoryValue);
            this.knnPanel.Controls.Add(this.knnDefaultsLabel);
            this.knnPanel.Controls.Add(this.knnDetectShadowsChBx);
            this.knnPanel.Controls.Add(this.knnDist2ThresholdTxBx);
            this.knnPanel.Controls.Add(this.knnDist2ThresholdLabel);
            this.knnPanel.Controls.Add(this.knnHistoryTxBx);
            this.knnPanel.Controls.Add(this.knnHistoryLabel);
            this.knnPanel.Controls.Add(this.KNNParamsLabel);
            this.knnPanel.Location = new System.Drawing.Point(539, 73);
            this.knnPanel.Name = "knnPanel";
            this.knnPanel.Size = new System.Drawing.Size(265, 111);
            this.knnPanel.TabIndex = 13;
            // 
            // knnDefaultDist2ThresholdValue
            // 
            this.knnDefaultDist2ThresholdValue.AutoSize = true;
            this.knnDefaultDist2ThresholdValue.Location = new System.Drawing.Point(211, 50);
            this.knnDefaultDist2ThresholdValue.Name = "knnDefaultDist2ThresholdValue";
            this.knnDefaultDist2ThresholdValue.Size = new System.Drawing.Size(25, 13);
            this.knnDefaultDist2ThresholdValue.TabIndex = 16;
            this.knnDefaultDist2ThresholdValue.Text = "100";
            // 
            // knnDefaultHistoryValue
            // 
            this.knnDefaultHistoryValue.AutoSize = true;
            this.knnDefaultHistoryValue.Location = new System.Drawing.Point(211, 23);
            this.knnDefaultHistoryValue.Name = "knnDefaultHistoryValue";
            this.knnDefaultHistoryValue.Size = new System.Drawing.Size(19, 13);
            this.knnDefaultHistoryValue.TabIndex = 15;
            this.knnDefaultHistoryValue.Text = "20";
            // 
            // knnDefaultsLabel
            // 
            this.knnDefaultsLabel.AutoSize = true;
            this.knnDefaultsLabel.Location = new System.Drawing.Point(211, 0);
            this.knnDefaultsLabel.Name = "knnDefaultsLabel";
            this.knnDefaultsLabel.Size = new System.Drawing.Size(49, 13);
            this.knnDefaultsLabel.TabIndex = 14;
            this.knnDefaultsLabel.Text = "Defaults:";
            // 
            // knnDetectShadowsChBx
            // 
            this.knnDetectShadowsChBx.AutoSize = true;
            this.knnDetectShadowsChBx.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.knnDetectShadowsChBx.Location = new System.Drawing.Point(3, 82);
            this.knnDetectShadowsChBx.Name = "knnDetectShadowsChBx";
            this.knnDetectShadowsChBx.Size = new System.Drawing.Size(112, 17);
            this.knnDetectShadowsChBx.TabIndex = 5;
            this.knnDetectShadowsChBx.Text = "Shadow detection";
            this.knnDetectShadowsChBx.UseVisualStyleBackColor = true;
            // 
            // knnDist2ThresholdTxBx
            // 
            this.knnDist2ThresholdTxBx.Location = new System.Drawing.Point(105, 47);
            this.knnDist2ThresholdTxBx.Name = "knnDist2ThresholdTxBx";
            this.knnDist2ThresholdTxBx.Size = new System.Drawing.Size(100, 20);
            this.knnDist2ThresholdTxBx.TabIndex = 4;
            this.knnDist2ThresholdTxBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.knnDist2ThresholdTxBx_KeyPress);
            // 
            // knnDist2ThresholdLabel
            // 
            this.knnDist2ThresholdLabel.AutoSize = true;
            this.knnDist2ThresholdLabel.Location = new System.Drawing.Point(3, 50);
            this.knnDist2ThresholdLabel.Name = "knnDist2ThresholdLabel";
            this.knnDist2ThresholdLabel.Size = new System.Drawing.Size(86, 13);
            this.knnDist2ThresholdLabel.TabIndex = 3;
            this.knnDist2ThresholdLabel.Text = "Dist to threshold:";
            // 
            // knnHistoryTxBx
            // 
            this.knnHistoryTxBx.Location = new System.Drawing.Point(105, 20);
            this.knnHistoryTxBx.Name = "knnHistoryTxBx";
            this.knnHistoryTxBx.Size = new System.Drawing.Size(100, 20);
            this.knnHistoryTxBx.TabIndex = 2;
            this.knnHistoryTxBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.knnHistoryTxBx_KeyPress);
            // 
            // knnHistoryLabel
            // 
            this.knnHistoryLabel.AutoSize = true;
            this.knnHistoryLabel.Location = new System.Drawing.Point(3, 23);
            this.knnHistoryLabel.Name = "knnHistoryLabel";
            this.knnHistoryLabel.Size = new System.Drawing.Size(42, 13);
            this.knnHistoryLabel.TabIndex = 1;
            this.knnHistoryLabel.Text = "History:";
            // 
            // KNNParamsLabel
            // 
            this.KNNParamsLabel.AutoSize = true;
            this.KNNParamsLabel.Location = new System.Drawing.Point(3, 0);
            this.KNNParamsLabel.Name = "KNNParamsLabel";
            this.KNNParamsLabel.Size = new System.Drawing.Size(88, 13);
            this.KNNParamsLabel.TabIndex = 0;
            this.KNNParamsLabel.Text = "KNN parameters:";
            // 
            // gmgPanel
            // 
            this.gmgPanel.Controls.Add(this.gmgDefaultDecisionThresholdValue);
            this.gmgPanel.Controls.Add(this.gmgDefaultInitializationFramesValue);
            this.gmgPanel.Controls.Add(this.gmgDefaultsLabel);
            this.gmgPanel.Controls.Add(this.gmgDecisionThresholdTxBx);
            this.gmgPanel.Controls.Add(this.gmgDecisionThresholdLabel);
            this.gmgPanel.Controls.Add(this.gmgInitializationFramesTxBx);
            this.gmgPanel.Controls.Add(this.gmgInitializationFramesLabel);
            this.gmgPanel.Controls.Add(this.GMGParamsLabel);
            this.gmgPanel.Location = new System.Drawing.Point(539, 190);
            this.gmgPanel.Name = "gmgPanel";
            this.gmgPanel.Size = new System.Drawing.Size(265, 80);
            this.gmgPanel.TabIndex = 14;
            // 
            // gmgDefaultDecisionThresholdValue
            // 
            this.gmgDefaultDecisionThresholdValue.AutoSize = true;
            this.gmgDefaultDecisionThresholdValue.Location = new System.Drawing.Point(211, 50);
            this.gmgDefaultDecisionThresholdValue.Name = "gmgDefaultDecisionThresholdValue";
            this.gmgDefaultDecisionThresholdValue.Size = new System.Drawing.Size(22, 13);
            this.gmgDefaultDecisionThresholdValue.TabIndex = 16;
            this.gmgDefaultDecisionThresholdValue.Text = "0.7";
            // 
            // gmgDefaultInitializationFramesValue
            // 
            this.gmgDefaultInitializationFramesValue.AutoSize = true;
            this.gmgDefaultInitializationFramesValue.Location = new System.Drawing.Point(211, 23);
            this.gmgDefaultInitializationFramesValue.Name = "gmgDefaultInitializationFramesValue";
            this.gmgDefaultInitializationFramesValue.Size = new System.Drawing.Size(13, 13);
            this.gmgDefaultInitializationFramesValue.TabIndex = 15;
            this.gmgDefaultInitializationFramesValue.Text = "5";
            // 
            // gmgDefaultsLabel
            // 
            this.gmgDefaultsLabel.AutoSize = true;
            this.gmgDefaultsLabel.Location = new System.Drawing.Point(211, 0);
            this.gmgDefaultsLabel.Name = "gmgDefaultsLabel";
            this.gmgDefaultsLabel.Size = new System.Drawing.Size(49, 13);
            this.gmgDefaultsLabel.TabIndex = 14;
            this.gmgDefaultsLabel.Text = "Defaults:";
            // 
            // gmgDecisionThresholdTxBx
            // 
            this.gmgDecisionThresholdTxBx.Location = new System.Drawing.Point(105, 47);
            this.gmgDecisionThresholdTxBx.Name = "gmgDecisionThresholdTxBx";
            this.gmgDecisionThresholdTxBx.Size = new System.Drawing.Size(100, 20);
            this.gmgDecisionThresholdTxBx.TabIndex = 4;
            this.gmgDecisionThresholdTxBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gmgDecisionThresholdTxBx_KeyPress);
            // 
            // gmgDecisionThresholdLabel
            // 
            this.gmgDecisionThresholdLabel.AutoSize = true;
            this.gmgDecisionThresholdLabel.Location = new System.Drawing.Point(3, 50);
            this.gmgDecisionThresholdLabel.Name = "gmgDecisionThresholdLabel";
            this.gmgDecisionThresholdLabel.Size = new System.Drawing.Size(97, 13);
            this.gmgDecisionThresholdLabel.TabIndex = 3;
            this.gmgDecisionThresholdLabel.Text = "Decision threshold:";
            // 
            // gmgInitializationFramesTxBx
            // 
            this.gmgInitializationFramesTxBx.Location = new System.Drawing.Point(105, 20);
            this.gmgInitializationFramesTxBx.Name = "gmgInitializationFramesTxBx";
            this.gmgInitializationFramesTxBx.Size = new System.Drawing.Size(100, 20);
            this.gmgInitializationFramesTxBx.TabIndex = 2;
            this.gmgInitializationFramesTxBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gmgInitializationFramesTxBx_KeyPress);
            // 
            // gmgInitializationFramesLabel
            // 
            this.gmgInitializationFramesLabel.AutoSize = true;
            this.gmgInitializationFramesLabel.Location = new System.Drawing.Point(3, 23);
            this.gmgInitializationFramesLabel.Name = "gmgInitializationFramesLabel";
            this.gmgInitializationFramesLabel.Size = new System.Drawing.Size(98, 13);
            this.gmgInitializationFramesLabel.TabIndex = 1;
            this.gmgInitializationFramesLabel.Text = "Initialization frames:";
            // 
            // GMGParamsLabel
            // 
            this.GMGParamsLabel.AutoSize = true;
            this.GMGParamsLabel.Location = new System.Drawing.Point(3, 0);
            this.GMGParamsLabel.Name = "GMGParamsLabel";
            this.GMGParamsLabel.Size = new System.Drawing.Size(90, 13);
            this.GMGParamsLabel.TabIndex = 0;
            this.GMGParamsLabel.Text = "GMG parameters:";
            // 
            // minAreaLabel
            // 
            this.minAreaLabel.AutoSize = true;
            this.minAreaLabel.Location = new System.Drawing.Point(346, 34);
            this.minAreaLabel.Name = "minAreaLabel";
            this.minAreaLabel.Size = new System.Drawing.Size(130, 13);
            this.minAreaLabel.TabIndex = 15;
            this.minAreaLabel.Text = "Min motion area to detect:";
            // 
            // minAreaTxBx
            // 
            this.minAreaTxBx.Location = new System.Drawing.Point(482, 30);
            this.minAreaTxBx.Name = "minAreaTxBx";
            this.minAreaTxBx.Size = new System.Drawing.Size(100, 20);
            this.minAreaTxBx.TabIndex = 16;
            this.minAreaTxBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.minAreaTxBx_KeyPress);
            // 
            // motionsDetectedLabel
            // 
            this.motionsDetectedLabel.AutoSize = true;
            this.motionsDetectedLabel.Location = new System.Drawing.Point(604, 336);
            this.motionsDetectedLabel.Name = "motionsDetectedLabel";
            this.motionsDetectedLabel.Size = new System.Drawing.Size(92, 13);
            this.motionsDetectedLabel.TabIndex = 17;
            this.motionsDetectedLabel.Text = "Motions detected:";
            // 
            // motionsDetectedTxBx
            // 
            this.motionsDetectedTxBx.Location = new System.Drawing.Point(702, 333);
            this.motionsDetectedTxBx.Name = "motionsDetectedTxBx";
            this.motionsDetectedTxBx.ReadOnly = true;
            this.motionsDetectedTxBx.Size = new System.Drawing.Size(100, 20);
            this.motionsDetectedTxBx.TabIndex = 18;
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(699, 498);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 19;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // singleFrameDetectedTxBx
            // 
            this.singleFrameDetectedTxBx.Location = new System.Drawing.Point(702, 377);
            this.singleFrameDetectedTxBx.Name = "singleFrameDetectedTxBx";
            this.singleFrameDetectedTxBx.ReadOnly = true;
            this.singleFrameDetectedTxBx.Size = new System.Drawing.Size(100, 20);
            this.singleFrameDetectedTxBx.TabIndex = 21;
            // 
            // singleFrameDetectedLabel
            // 
            this.singleFrameDetectedLabel.AutoSize = true;
            this.singleFrameDetectedLabel.Location = new System.Drawing.Point(583, 380);
            this.singleFrameDetectedLabel.Name = "singleFrameDetectedLabel";
            this.singleFrameDetectedLabel.Size = new System.Drawing.Size(113, 13);
            this.singleFrameDetectedLabel.TabIndex = 20;
            this.singleFrameDetectedLabel.Text = "Single frame detected:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 533);
            this.Controls.Add(this.singleFrameDetectedTxBx);
            this.Controls.Add(this.singleFrameDetectedLabel);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.motionsDetectedTxBx);
            this.Controls.Add(this.motionsDetectedLabel);
            this.Controls.Add(this.minAreaTxBx);
            this.Controls.Add(this.minAreaLabel);
            this.Controls.Add(this.gmgPanel);
            this.Controls.Add(this.knnPanel);
            this.Controls.Add(this.lsbpPanel);
            this.Controls.Add(this.mog2Panel);
            this.Controls.Add(this.mogPanel);
            this.Controls.Add(this.selectBGSubtractorTypeLabel);
            this.Controls.Add(this.useCameraChBx);
            this.Controls.Add(this.selectSourceLabel);
            this.Controls.Add(this.bgSubtractorTypePanel);
            this.Controls.Add(this.detectMotionButton);
            this.Controls.Add(this.selectVideoTXB);
            this.Controls.Add(this.selectVideoButton);
            this.Name = "Form1";
            this.Text = "MotionDetectionAlgorithmsAnalysis";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.bgSubtractorTypePanel.ResumeLayout(false);
            this.bgSubtractorTypePanel.PerformLayout();
            this.mogPanel.ResumeLayout(false);
            this.mogPanel.PerformLayout();
            this.mog2Panel.ResumeLayout(false);
            this.mog2Panel.PerformLayout();
            this.lsbpPanel.ResumeLayout(false);
            this.lsbpPanel.PerformLayout();
            this.knnPanel.ResumeLayout(false);
            this.knnPanel.PerformLayout();
            this.gmgPanel.ResumeLayout(false);
            this.gmgPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selectVideoButton;
        private System.Windows.Forms.TextBox selectVideoTXB;
        private System.Windows.Forms.Button detectMotionButton;
        private System.Windows.Forms.Label MOGParamsLabel;
        private System.Windows.Forms.Panel bgSubtractorTypePanel;
        private System.Windows.Forms.RadioButton GMG_RB;
        private System.Windows.Forms.RadioButton LSBP_RB;
        private System.Windows.Forms.RadioButton KNN_RB;
        private System.Windows.Forms.RadioButton MOG2_RB;
        private System.Windows.Forms.RadioButton MOG_RB;
        private System.Windows.Forms.Label selectSourceLabel;
        private System.Windows.Forms.CheckBox useCameraChBx;
        private System.Windows.Forms.Label selectBGSubtractorTypeLabel;
        private System.Windows.Forms.Label mogHistoryLabel;
        private System.Windows.Forms.Panel mogPanel;
        private System.Windows.Forms.TextBox mogNoiseSigmaTxBx;
        private System.Windows.Forms.Label mogNoiseSigmaLabel;
        private System.Windows.Forms.TextBox mogBackgroundRatioTxBx;
        private System.Windows.Forms.Label mogBackgroundRatioLabel;
        private System.Windows.Forms.TextBox mogNMixturesTxBx;
        private System.Windows.Forms.Label mogNMixturesLabel;
        private System.Windows.Forms.TextBox mogHistoryTxBx;
        private System.Windows.Forms.Panel mog2Panel;
        private System.Windows.Forms.TextBox mog2ThresholdTxBx;
        private System.Windows.Forms.Label mog2ThresholdLabel;
        private System.Windows.Forms.TextBox mog2HistoryTxBx;
        private System.Windows.Forms.Label mog2HisotryLabel;
        private System.Windows.Forms.Label MOG2ParamsLabel;
        private System.Windows.Forms.CheckBox mog2ShadowDetectionChBx;
        private System.Windows.Forms.Panel lsbpPanel;
        private System.Windows.Forms.Label lsbpCameraMotionCompensationLabel;
        private System.Windows.Forms.ComboBox lsbpCameraMotionCompensationCmBx;
        private System.Windows.Forms.Label LSBPParamsLabel;
        private System.Windows.Forms.Label mogDefaultNoiseSigmaValue;
        private System.Windows.Forms.Label mogDefaultsLabel;
        private System.Windows.Forms.Label mogDefaultBgRatioValue;
        private System.Windows.Forms.Label mogDefaultNMixturesValue;
        private System.Windows.Forms.Label mogDefaultHistoryValue;
        private System.Windows.Forms.Label mog2DefaultThresholdValue;
        private System.Windows.Forms.Label mog2DefaultHistoryValue;
        private System.Windows.Forms.Label mog2DefaultsLabel;
        private System.Windows.Forms.Label lsbpDefaultTIncValue;
        private System.Windows.Forms.Label lsbpDefaultTUpperValue;
        private System.Windows.Forms.Label lsbpDefaultTLowerValue;
        private System.Windows.Forms.Label lsbpDefaultRadiusValue;
        private System.Windows.Forms.Label lsbpDefaultNSamplesValue;
        private System.Windows.Forms.Label lsbpDefaultsLabel;
        private System.Windows.Forms.TextBox lsbpMinCountTxBx;
        private System.Windows.Forms.Label lsbpMinCountLabel;
        private System.Windows.Forms.TextBox lsbpThresholdTxBx;
        private System.Windows.Forms.Label lsbpThresholdLabel;
        private System.Windows.Forms.TextBox lsbpNoiseRemovalThresholdFacFGTxBx;
        private System.Windows.Forms.Label lsbpNoiseRemovalThresholdFacFGLabel;
        private System.Windows.Forms.TextBox lsbpNoiseRemovalThresholdFacBGTxBx;
        private System.Windows.Forms.Label lsbpNoiseRemovalThresholdFacBGLabel;
        private System.Windows.Forms.TextBox lsbpRIncDecTxBx;
        private System.Windows.Forms.Label lsbpRIncDecLabel;
        private System.Windows.Forms.TextBox lsbpRScaleTxBx;
        private System.Windows.Forms.Label lsbpRScaleLabel;
        private System.Windows.Forms.TextBox lsbpTDecTxBx;
        private System.Windows.Forms.Label lsbpTDecLabel;
        private System.Windows.Forms.TextBox lsbpTIncTxBx;
        private System.Windows.Forms.Label lsbpTIncLabel;
        private System.Windows.Forms.TextBox lsbpTUpperTxBx;
        private System.Windows.Forms.Label lsbpTUpperLabel;
        private System.Windows.Forms.TextBox lsbpTLowerTxBx;
        private System.Windows.Forms.Label lsbpTLowerLabel;
        private System.Windows.Forms.TextBox lsbpRadiusTxBx;
        private System.Windows.Forms.Label lsbpRadiusLabel;
        private System.Windows.Forms.TextBox lsbpNSamplesTxBx;
        private System.Windows.Forms.Label lsbpNSamplesLabel;
        private System.Windows.Forms.Label lsbpDefaultMinCountValue;
        private System.Windows.Forms.Label lsbpDefaultThresholdValue;
        private System.Windows.Forms.Label lsbpDefaultNRTFFGValue;
        private System.Windows.Forms.Label lsbpDefaultNRTFBGValue;
        private System.Windows.Forms.Label lsbpDefaultRIncDecValue;
        private System.Windows.Forms.Label lsbpDefaultRScaleValue;
        private System.Windows.Forms.Label lsbpDefaultTDecValue;
        private System.Windows.Forms.Panel knnPanel;
        private System.Windows.Forms.Label knnDefaultDist2ThresholdValue;
        private System.Windows.Forms.Label knnDefaultHistoryValue;
        private System.Windows.Forms.Label knnDefaultsLabel;
        private System.Windows.Forms.CheckBox knnDetectShadowsChBx;
        private System.Windows.Forms.TextBox knnDist2ThresholdTxBx;
        private System.Windows.Forms.Label knnDist2ThresholdLabel;
        private System.Windows.Forms.TextBox knnHistoryTxBx;
        private System.Windows.Forms.Label knnHistoryLabel;
        private System.Windows.Forms.Label KNNParamsLabel;
        private System.Windows.Forms.Panel gmgPanel;
        private System.Windows.Forms.Label gmgDefaultDecisionThresholdValue;
        private System.Windows.Forms.Label gmgDefaultInitializationFramesValue;
        private System.Windows.Forms.Label gmgDefaultsLabel;
        private System.Windows.Forms.TextBox gmgDecisionThresholdTxBx;
        private System.Windows.Forms.Label gmgDecisionThresholdLabel;
        private System.Windows.Forms.TextBox gmgInitializationFramesTxBx;
        private System.Windows.Forms.Label gmgInitializationFramesLabel;
        private System.Windows.Forms.Label GMGParamsLabel;
        private System.Windows.Forms.Label minAreaLabel;
        private System.Windows.Forms.TextBox minAreaTxBx;
        private System.Windows.Forms.Label motionsDetectedLabel;
        private System.Windows.Forms.TextBox motionsDetectedTxBx;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.TextBox singleFrameDetectedTxBx;
        private System.Windows.Forms.Label singleFrameDetectedLabel;
    }
}

