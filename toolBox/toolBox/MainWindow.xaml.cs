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

namespace toolBox
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            //이름 지정안해도 가져올 수 있다.
            RadioButton radioButton = (RadioButton)sender;
            MessageBox.Show($"{radioButton.IsChecked}");
            //MessageBox.Show("Checked");
        }

        private void RadioButton_Unchecked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Unchecked");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           /* Button button = (Button)sender;
            MessageBox.Show($"{button.Content}");*/

           /* comboBox.Items.Add("Tomato");
            string item_name = comboBox.SelectedItem.ToString();
            comboBox.Items.Remove(comboBox.SelectedItem);*/
            /*
                        MessageBox.Show(item_name + "  removed");*/
            listBox.Items.Add("문");
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Slider slider = (Slider)sender;
            label1.Content = slider.Value;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            webBrowser.CoreWebView2.Navigate("http://www.naver.com");

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            webBrowser.CoreWebView2.Navigate(url.Text);
        }
    }
}
