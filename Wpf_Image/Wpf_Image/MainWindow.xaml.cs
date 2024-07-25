using Microsoft.Win32;
using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.IO;

namespace Wpf_Image
{
    public partial class MainWindow : Window
    {
        Uri uri;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnOpenFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;"; 
            if (openFileDialog.ShowDialog() == true)
            {
                string filePath = openFileDialog.FileName;

                textEditor.Text = filePath; 
                // 파일 경로를 사용하여 BitmapImage 생성
                this.uri = new Uri(filePath, UriKind.Absolute);
                BitmapImage bitmap = new BitmapImage(this.uri);

                // 버튼의 배경을 이미지로 설정
                button1.Background = new ImageBrush(bitmap);

                int imageWidth = bitmap.PixelWidth / 6;
                int imageHeight = bitmap.PixelHeight / 6;
                button1.Width = imageWidth;
                button1.Height = imageHeight;
            }
        }
    }
}