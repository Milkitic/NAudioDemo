using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;

namespace SimplePlayer
{
    public partial class FormPlayer : Form
    {
        private IWavePlayer _device;
        private AudioFileReader _reader;

        private VolumeSampleProvider _volumeProvider;

        private CancellationTokenSource _cts;

        private bool _sliderLock;

        public FormPlayer()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            PlayAction();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            PauseAction();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            StopAction();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog
            {
                Filter = "支持的文件|*.mp3;*.wav;*.aiff|所有文件|*.*",
                Multiselect = false
            };
            var result = ofd.ShowDialog();
            if (result != DialogResult.OK) return;

            DisposeAll();

            try
            {
                var fileName = ofd.FileName;

                if (!File.Exists(fileName))
                    throw new FileNotFoundException("所选文件不存在");
                _device = new WaveOutEvent();
                _reader = new AudioFileReader(fileName);

                // dsp start
                _volumeProvider = new VolumeSampleProvider(_reader)
                {
                    Volume = sliderVolume.Value / 100f
                };
                // dsp end

                _device.Init(_volumeProvider);

                var duration = _reader.TotalTime;
                sliderProgress.Maximum = (int)duration.TotalMilliseconds;
                lblDuration.Text = duration.ToString(@"mm\:ss");

                _cts = new CancellationTokenSource();
                StartUpdateProgress();

                _device.PlaybackStopped += Device_OnPlaybackStopped;
            }
            catch (Exception ex)
            {
                DisposeAll();
                MessageBox.Show(ex.Message);
            }
        }

        private void sliderProgress_MouseDown(object sender, MouseEventArgs e)
        {
            _sliderLock = true;
        }

        private void sliderProgress_MouseUp(object sender, MouseEventArgs e)
        {
            _reader.CurrentTime = TimeSpan.FromMilliseconds(sliderProgress.Value);
            UpdateProgress();
            _sliderLock = false;
        }

        private void sliderProgress_ValueChanged(object sender, EventArgs e)
        {
            if (_sliderLock)
            {
                lblPosition.Text = TimeSpan.FromMilliseconds(sliderProgress.Value).ToString(@"mm\:ss");
            }
        }

        private void sliderVolume_ValueChanged(object sender, EventArgs e)
        {
            SetVolume();
        }

        private void Form_Load(object sender, EventArgs e)
        {

        }

        private void Form_Closed(object sender, EventArgs e)
        {
            DisposeAll();
        }

        private void Device_OnPlaybackStopped(object obj, StoppedEventArgs arg)
        {
            StopAction();
        }

        private void StartUpdateProgress()
        {
            Task.Run(() =>
            {
                while (!_cts.IsCancellationRequested)
                {
                    if (_device.PlaybackState == PlaybackState.Playing)
                    {
                        BeginInvoke(new Action(UpdateProgress));
                        Thread.Sleep(100);
                    }
                    else
                    {
                        Thread.Sleep(50);
                    }
                }
            });
        }

        private void StopAction()
        {
            _device?.Stop();
            if (_reader != null) _reader.Position = 0;
            UpdateProgress();
        }

        private void PlayAction()
        {
            _device?.Play();
        }

        private void PauseAction()
        {
            _device?.Pause();
        }

        private void UpdateProgress()
        {
            var currentTime = _reader?.CurrentTime ?? TimeSpan.Zero;
            Console.WriteLine(currentTime);

            if (!_sliderLock)
            {
                sliderProgress.Value = (int)currentTime.TotalMilliseconds;
                lblPosition.Text = currentTime.ToString(@"mm\:ss");
            }
        }

        private void SetVolume()
        {
            _volumeProvider.Volume = sliderVolume.Value / 100f;
        }

        private void DisposeDevice()
        {
            if (_device != null)
            {
                _device.PlaybackStopped -= Device_OnPlaybackStopped;
                _device.Dispose();
            }
        }

        private void DisposeAll()
        {
            _cts?.Cancel();
            _cts?.Dispose();
            _reader?.Dispose();
            DisposeDevice();
        }
    }
}
