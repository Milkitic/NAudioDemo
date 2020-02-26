namespace SimplePlayer
{
    partial class FormPlayer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.lblPosition = new System.Windows.Forms.Label();
            this.sliderProgress = new System.Windows.Forms.TrackBar();
            this.lblDuration = new System.Windows.Forms.Label();
            this.sliderVolume = new System.Windows.Forms.TrackBar();

            this.components = new System.ComponentModel.Container();

            ((System.ComponentModel.ISupportInitialize)(this.sliderProgress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(140, 12);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "播放";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(221, 12);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 23);
            this.btnPause.TabIndex = 1;
            this.btnPause.Text = "暂停";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(302, 12);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "停止";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(12, 12);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 3;
            this.btnOpen.Text = "打开";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(13, 46);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(35, 12);
            this.lblPosition.TabIndex = 4;
            this.lblPosition.Text = "00:00";
            // 
            // sliderProgress
            // 
            this.sliderProgress.Location = new System.Drawing.Point(49, 41);
            this.sliderProgress.Minimum = 0;
            this.sliderProgress.Name = "sliderProgress";
            this.sliderProgress.Size = new System.Drawing.Size(334, 45);
            this.sliderProgress.TabIndex = 5;
            this.sliderProgress.TickFrequency = 0;
            this.sliderProgress.TickStyle = System.Windows.Forms.TickStyle.None;
            this.sliderProgress.MouseDown += new System.Windows.Forms.MouseEventHandler(this.sliderProgress_MouseDown);
            this.sliderProgress.MouseUp += new System.Windows.Forms.MouseEventHandler(this.sliderProgress_MouseUp);
            this.sliderProgress.ValueChanged += new System.EventHandler(this.sliderProgress_ValueChanged);
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(385, 46);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(35, 12);
            this.lblDuration.TabIndex = 6;
            this.lblDuration.Text = "00:00";
            // 
            // sliderVolume
            // 
            this.sliderVolume.Location = new System.Drawing.Point(426, 2);
            this.sliderVolume.Maximum = 100;
            this.sliderVolume.Minimum = 0;
            this.sliderVolume.Name = "sliderVolume";
            this.sliderVolume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.sliderVolume.Size = new System.Drawing.Size(45, 70);
            this.sliderVolume.TabIndex = 7;
            this.sliderVolume.TickFrequency = 0;
            this.sliderVolume.TickStyle = System.Windows.Forms.TickStyle.None;
            this.sliderVolume.Value = 80;
            this.sliderVolume.ValueChanged += new System.EventHandler(this.sliderVolume_ValueChanged);
            // 
            // FormPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 79);
            this.Controls.Add(this.sliderVolume);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.sliderProgress);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnPlay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPlayer";
            this.Closed += new System.EventHandler(this.Form_Closed);
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sliderProgress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderVolume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.TrackBar sliderProgress;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.TrackBar sliderVolume;
    }
}

