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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF1
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        bool btn_image = true;
        Uri click1;
        Uri click2;

        public MainWindow()
        {
            InitializeComponent();

            this.click1 = new Uri("pack://application:,,,/스크린샷 2024-07-12 111221.png", UriKind.Absolute);

            this.click2 = new Uri("pack://application:,,,/스크린샷 2024-07-12 111312.png", UriKind.Absolute);

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (helloButton.IsChecked == true)
            {
                MessageBox.Show("Hello.");
            }

            else if (goodByeButton.IsChecked == true)
            {
                MessageBox.Show("Goodbye.");
            }

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (this.btn_image)
            {
                button1.Background = new ImageBrush(new BitmapImage(this.click1));
                imageBox1.Source = new BitmapImage(this.click1);
                this.btn_image = false;
            }
            else
            {
                button1.Background = new ImageBrush(new BitmapImage(this.click2));
                imageBox1.Source = new BitmapImage(this.click2);
                this.btn_image = true;
            }
        }

    }
    
}
