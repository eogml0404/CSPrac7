using System;
using System.Collections.Generic;
using System.IO;
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

namespace WebPrac
{
    public partial class MainWindow : Window
    {
        string filePath = "fvr.txt";
        List<string> pathes = new List<string>();
        public MainWindow()
        {
            InitializeComponent();

            listBoxPrint();
        }
        private void listSave()
        {
            File.WriteAllLines(filePath, pathes);
        }
        private void listBoxPrint()
        {
            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                pathes.Add(line); // pathes 리스트에 추가
                listBox.Items.Add(line); // ListBox에 추가
            }
            
        }

        //fav 버튼 눌렀을 때
        private void Button1_Click(object sender, RoutedEventArgs e)
        {

            if (addRadio.IsChecked == true) 
            {
                listBox.Items.Add(url.Text); 
                pathes.Add(url.Text);
                listSave(); 
            }
            else if (LoadRadio.IsChecked == true) 
            {
                url.Text = listBox.SelectedItem.ToString();
                webBrowser.CoreWebView2.Navigate(url.Text); 
            }
           
        }

        //Move 눌렀을 때
        private void Button1_Click_1(object sender, RoutedEventArgs e)
        {
            webBrowser.CoreWebView2.Navigate(url.Text);
        }

        // 'Back' 버튼을 눌렀을 때
        private void back_Click(object sender, RoutedEventArgs e)
        {

            webBrowser.CoreWebView2.GoBack();

        }

        // 'Forward' 버튼을 눌렀을 때
        private void forward_Click(object sender, RoutedEventArgs e)
        {
           
            webBrowser.CoreWebView2.GoForward();
          
        }
    }
}
