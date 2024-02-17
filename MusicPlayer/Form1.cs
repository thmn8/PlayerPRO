using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MusicPlayer
{
    public partial class Form1 : Form
    {
        public static string SelectedFolderPath;
        private WaveOutEvent waveOutEvent;
        private AudioFileReader audioFileReader;
        private bool isPlaying = false;
        private NotifyIcon TrayIcon;
        private List<string> playlist = new List<string>();

        public Form1()
        {
            InitializeComponent();

            statusLabel.Text = "Задание остановлено";
            stopButton.Enabled = false;

            TrayIcon = new NotifyIcon();
            TrayIcon.Icon = Icon; // установите путь к иконке
            TrayIcon.Text = "ПлеерPRO";
            TrayIcon.Click += new EventHandler(TrayIcon_Click);

            waveOutEvent = new WaveOutEvent();
        }

        private void MinimizeToTray()
        {
            TrayIcon.Visible = true;
            Hide();
        }

        private void TrayIcon_Click(object sender, EventArgs e)
        {
            Show();
            TrayIcon.Visible = false;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SelectedFolderPath))
            {
                MessageBox.Show("Выберите папку с музыкой.");
                return;
            }

            if (timer.Enabled == false)
            {
                timer.Enabled = true;
                statusLabel.Text = "Задание запущено";
                stopButton.Enabled = true;
                startButton.Enabled = false;

                MondayCheckBox.Enabled = false;
                TuesdayCheckBox.Enabled = false;
                WednesdayCheckBox.Enabled = false;
                ThursdayCheckBox.Enabled = false;
                FridayCheckBox.Enabled = false;
                SaturdayCheckBox.Enabled = false;
                SundayCheckBox.Enabled = false;
                txtStart.Enabled = false;
                txtEnd.Enabled = false;
                MusicFolderTextBox.Enabled = false;
                openButton.Enabled = false;
            }
        }

        private bool IsTimeInRange(DateTime currentTime)
        {
            // получаем начальное и конечное время из TextBox
            string startTime = txtStart.Text;
            string endTime = txtEnd.Text;

            // создаем объекты DateTime для начального и конечного времени и сохраняем результаты
            DateTime startDateTime = DateTime.ParseExact(startTime, "HH:mm", null);
            DateTime endDateTime = DateTime.ParseExact(endTime, "HH:mm", null);

            // проверяем, соответствует ли текущее время временному интервалу
            TimeSpan currentTimeSpan = currentTime.TimeOfDay;

            if (currentTimeSpan < startDateTime.TimeOfDay || currentTimeSpan > endDateTime.TimeOfDay)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            StopMusic();
        }


        private void PlayMusic()
        {
            if (!isPlaying)
            {
                string[] musicFiles = Directory.GetFiles(SelectedFolderPath, "*.mp3");

                if (musicFiles.Length > 0)
                {
                    Random random = new Random();
                    int randomIndex = random.Next(0, musicFiles.Length);
                    string randomMusicFile = musicFiles[randomIndex];

                    if (waveOutEvent != null)
                    {
                        waveOutEvent.Stop();
                        waveOutEvent.Dispose();
                        waveOutEvent = null;
                    }

                    if (audioFileReader != null)
                    {
                        audioFileReader.Dispose();
                        audioFileReader = null;
                    }
                    
                    audioFileReader = new AudioFileReader(randomMusicFile);
                    waveOutEvent = new WaveOutEvent();
                    waveOutEvent.Init(audioFileReader);
                    waveOutEvent.Play();

                    // Устанавливаем флаг воспроизведения
                    isPlaying = true;
                    statusLabel.Text = "Задание запущено";
                }
            }
        }

        private void StopMusic()
        {
            statusLabel.Text = "Задание остановлено";
            stopButton.Enabled = false;
            startButton.Enabled = true;

            timer.Enabled = false;
            isPlaying = false;

            MondayCheckBox.Enabled = true;
            TuesdayCheckBox.Enabled = true;
            WednesdayCheckBox.Enabled = true;
            ThursdayCheckBox.Enabled = true;
            FridayCheckBox.Enabled = true;
            SaturdayCheckBox.Enabled = true;
            SundayCheckBox.Enabled = true;
            txtStart.Enabled = true;
            txtEnd.Enabled = true;
            MusicFolderTextBox.Enabled = true;
            openButton.Enabled = true;

            if (waveOutEvent != null)
            {
                waveOutEvent.Stop();
                waveOutEvent.Dispose();
                waveOutEvent = null;
            }

            if (audioFileReader != null)
            {
                audioFileReader.Dispose();
                audioFileReader = null;
            }
        }

        private void PauseMusic()
        {
            //срабатывает если не совпадают условия по дате и времени
            statusLabel.Text = "Задание в ожидании";

            if (isPlaying && waveOutEvent != null)
            {
                waveOutEvent.Pause();
                isPlaying = false;
            }
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                SelectedFolderPath = folderBrowserDialog.SelectedPath;
                MusicFolderTextBox.Text = SelectedFolderPath;

                // Сохраняем выбранную папку в настройки
                PlayerPRO.Properties.Settings.Default.SelectedFolderPath = SelectedFolderPath;
                PlayerPRO.Properties.Settings.Default.Save();
            }
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;

            switch (currentTime.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    if (MondayCheckBox.Checked && IsTimeInRange(currentTime))
                    {
                        PlayMusic();
                    }
                    else
                    {
                        PauseMusic();
                    }
                    break;
                case DayOfWeek.Tuesday:
                    if (TuesdayCheckBox.Checked && IsTimeInRange(currentTime))
                    {
                        PlayMusic();
                    }
                    else
                    {
                        PauseMusic();
                    }
                    break;
                case DayOfWeek.Wednesday:
                    if (WednesdayCheckBox.Checked && IsTimeInRange(currentTime))
                    {
                        PlayMusic();
                    }
                    else
                    {
                        PauseMusic();
                    }
                    break;
                case DayOfWeek.Thursday:
                    if (ThursdayCheckBox.Checked && IsTimeInRange(currentTime))
                    {
                        PlayMusic();
                    }
                    else
                    {
                        PauseMusic();
                    }
                    break;
                case DayOfWeek.Friday:
                    if (FridayCheckBox.Checked && IsTimeInRange(currentTime))
                    {
                        PlayMusic();
                    }
                    else
                    {
                        PauseMusic();
                    }
                    break;
                case DayOfWeek.Saturday:
                    if (SaturdayCheckBox.Checked && IsTimeInRange(currentTime))
                    {
                        PlayMusic();
                    }
                    else
                    {
                        PauseMusic();
                    }
                    break;
                case DayOfWeek.Sunday:
                    if (SundayCheckBox.Checked && IsTimeInRange(currentTime))
                    {
                        PlayMusic();
                    }
                    else
                    {
                        PauseMusic();
                    }
                    break;
            }
        }

        private void HomeWebMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://tehadm.ru/threads/pleerpro.1454/");
        }

        private void AboutMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();
            about.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Хотите выйти из приложения, свернуть его в трей или остаться в приложении?", "Закрытие приложения", MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.Yes)
            {
                // Закрытие приложения
                return;
            }
            else if (result == DialogResult.No)
            {
                // Сворачивание приложения в трей
                MinimizeToTray();
                e.Cancel = true;
                return;
            }
            else
            {
                // Отмена закрытия приложения
                e.Cancel = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Загружаем путь к папке, сохраненный в настройках
            if (!string.IsNullOrEmpty(PlayerPRO.Properties.Settings.Default.SelectedFolderPath))
            {
                SelectedFolderPath = PlayerPRO.Properties.Settings.Default.SelectedFolderPath;
                MusicFolderTextBox.Text = SelectedFolderPath;
            }
        }
    }
}