using Microsoft.Win32;
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

namespace WpfGridBox
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Data> list = new List<Data>();
        public MainWindow()
        {
            InitializeComponent();

        }

        public class Data
        {
            public string name { get; set; }
            public string age { get; set; }
            public string etc { get; set; }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            //현재 실행프로그램 경로

            int i = 0;
            if (openFileDialog.ShowDialog() == true)
            {
                //스트림리더로로 데이터 불러옴
                StreamReader sr = new StreamReader(openFileDialog.FileName);
                path.Content = openFileDialog.FileName;
               

                    try
                    {
                        while (!sr.EndOfStream)
                        {
                            i++;
                            //csv데이터는 콤마단위로 나뉘어져 있어서, Split을 콤마로 구분
                            string[] readData = sr.ReadLine().Split(',');

                            list.Add(new Data
                            {
                                name = readData[0],
                                age = readData[1],
                                etc = readData[2]
                            });
                            
                            if(i == 1)
                            {
                                list.Clear();
                            }
                        }
                    }
                    catch
                    {
                        MessageBox.Show("csv파일을 선택해주세요");
                    }

            }
            
            studentList.ItemsSource = list; 
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            string names = string.Empty;

            foreach (Data data in studentList.SelectedItems)
            {
                names += data.name + "\r\n";
            }
            MessageBox.Show($"{names} 선택됨");
        }
    }
}
