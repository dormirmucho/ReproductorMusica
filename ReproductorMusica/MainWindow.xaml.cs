using Microsoft.Win32;
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
using WMPLib;

namespace ReproductorMusica
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
        private WindowsMediaPlayer wmp = new WindowsMediaPlayer();
        private string ruta;
        private void bSeleccionar_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Archivos MP3 (*.mp3)|*.mp3|Todos los archivos (*.*)|*.*";
            ofd.FilterIndex = 1;

            ofd.FileName = ruta;
            
        }

        private void bPlayPause_Click(object sender, RoutedEventArgs e)
        {
            Boolean esSonando = false;
            if (!esSonando)
            {
                Reproducir();
            }
            else
            {
                wmp.controls.pause();
            }
        }

        private void Reproducir()
        {
            wmp.URL = ruta;
            wmp.controls.play();
        }
    }
}
