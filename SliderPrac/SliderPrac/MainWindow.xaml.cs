using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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

namespace SliderPrac
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        byte r;
        byte g;
        byte b;
        byte _val = byte.Parse("255");
        int revR;
        int revG;
        int revB;
        int Rval;
        int Gval;
        int Bval;
        
        double rgbAvg;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Rslider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Slider slider = (Slider)sender;
            Rvalue.Content = slider.Value;
            r = byte.Parse(Rvalue.Content.ToString());
            revR = 255 - int.Parse(r.ToString());
            Rval = int.Parse(Rvalue.Content.ToString());
            rgbAvg = ((double)Rval +(double) Gval + (double)Bval)/3;
            if (Ori.IsChecked == true)
            {
                Maingrid.Background = new SolidColorBrush(Color.FromRgb((byte)r, (byte)g, (byte)b));
            }
            else if(Invert.IsChecked == true)
            {
                Maingrid.Background = new SolidColorBrush(Color.FromRgb((byte)revR, (byte)revG, (byte)revB));
            }
            else if (Gray.IsChecked == true)
            {
                Maingrid.Background = new SolidColorBrush(Color.FromRgb((byte)rgbAvg, (byte)rgbAvg, (byte)rgbAvg));
            }
        }

        private void Gslider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Slider slider = (Slider)sender;
            Gvalue.Content = slider.Value;
            g = byte.Parse(Gvalue.Content.ToString());
            revG = 255 - int.Parse(g.ToString());
            Gval = int.Parse(Gvalue.Content.ToString());
            rgbAvg = ((double)Rval + (double)Gval + (double)Bval) / 3;
            if (Ori.IsChecked == true)
            {
                Maingrid.Background = new SolidColorBrush(Color.FromRgb((byte)r, (byte)g, (byte)b));
            }
            else if (Invert.IsChecked == true)
            {
                Maingrid.Background = new SolidColorBrush(Color.FromRgb((byte)revR, (byte)revG, (byte)revB));
            }
            else if(Gray.IsChecked == true)
            {
                Maingrid.Background = new SolidColorBrush(Color.FromRgb((byte)rgbAvg, (byte)rgbAvg, (byte)rgbAvg));
            }
        }

        private void Bsilder_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Slider slider = (Slider)sender;
            Bvalue.Content = slider.Value;
            b = byte.Parse(Bvalue.Content.ToString());
            revB = 255 - int.Parse(b.ToString());
            Bval = int.Parse(Bvalue.Content.ToString());
            rgbAvg = ((double)Rval + (double)Gval + (double)Bval) / 3;
            if (Ori.IsChecked == true)
            {
                Maingrid.Background = new SolidColorBrush(Color.FromRgb((byte)r, (byte)g, (byte)b));
            }
            else if (Invert.IsChecked == true)
            {
                Maingrid.Background = new SolidColorBrush(Color.FromRgb((byte)revR, (byte)revG, (byte)revB));
            }
            else if (Gray.IsChecked == true)
            {
                Maingrid.Background = new SolidColorBrush(Color.FromRgb((byte)rgbAvg, (byte)rgbAvg, (byte)rgbAvg));
            }
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
             Maingrid.Background = new SolidColorBrush(Color.FromRgb((byte)r, (byte)g, (byte)b));
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {

            Maingrid.Background = new SolidColorBrush(Color.FromRgb((byte)revR, (byte)revG, (byte)revB));

        }

        private void Gray_Checked(object sender, RoutedEventArgs e)
        {
           
            Maingrid.Background = new SolidColorBrush(Color.FromRgb((byte)rgbAvg, (byte)rgbAvg, (byte)rgbAvg));
        }
    }
}
