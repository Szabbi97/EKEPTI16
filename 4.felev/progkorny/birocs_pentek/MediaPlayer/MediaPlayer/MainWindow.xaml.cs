using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using Microsoft.Win32;

namespace MediaPlayer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            media.Play();
            btnPlay.IsEnabled = false;
            btnPause.IsEnabled = true;
            btnStop.IsEnabled = true;
        }

        private void btnPause_Click(object sender, RoutedEventArgs e)
        {
            media.Pause();
            btnPlay.IsEnabled = true;
            btnPause.IsEnabled = false;
            btnStop.IsEnabled = true;
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            media.Stop();
            btnPlay.IsEnabled = true;
            btnPause.IsEnabled = true;
            btnStop.IsEnabled = false;
        }

        private void OpenVideo(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.DefaultExt = ".mp4";
            dlg.Filter = "Videos (.mp4)|*.mp4";

            Nullable<bool> result = dlg.ShowDialog();

            if (result == true)
            {
                media.Source = new Uri(dlg.FileName);
                media.Play();
                btnPlay.IsEnabled = false;
                btnPause.IsEnabled = true;
                btnStop.IsEnabled = true;

            }
        }

        private void sldVolume_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            media.Volume = sldVolume.Value;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            btnPlay.IsEnabled = false;
            btnPause.IsEnabled = false;
            btnStop.IsEnabled = false;
            sldVolume.Minimum = 0;
            sldVolume.Maximum = 1;
            media.Volume = sldVolume.Value = 0.5;
        }

        private void CloseApp(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
