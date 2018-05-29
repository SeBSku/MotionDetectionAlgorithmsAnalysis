namespace MotionDetectionAlgorithmsAnalysis
{
    partial class MeanshiftForm
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
            this.originalVideoFramePlaceholder = new System.Windows.Forms.PictureBox();
            this.startButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.originalVideoFramePlaceholder)).BeginInit();
            this.SuspendLayout();
            // 
            // originalVideoFramePlaceholder
            // 
            this.originalVideoFramePlaceholder.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.originalVideoFramePlaceholder.Location = new System.Drawing.Point(12, 12);
            this.originalVideoFramePlaceholder.Name = "originalVideoFramePlaceholder";
            this.originalVideoFramePlaceholder.Size = new System.Drawing.Size(500, 400);
            this.originalVideoFramePlaceholder.TabIndex = 0;
            this.originalVideoFramePlaceholder.TabStop = false;
            this.originalVideoFramePlaceholder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.originalVideoFramePlaceholder_MouseDown);
            this.originalVideoFramePlaceholder.MouseUp += new System.Windows.Forms.MouseEventHandler(this.originalVideoFramePlaceholder_MouseUp);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(12, 418);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start video";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // MeanshiftForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 561);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.originalVideoFramePlaceholder);
            this.Name = "MeanshiftForm";
            this.Text = "MeanshiftForm";
            ((System.ComponentModel.ISupportInitialize)(this.originalVideoFramePlaceholder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox originalVideoFramePlaceholder;
        private System.Windows.Forms.Button startButton;
    }
}