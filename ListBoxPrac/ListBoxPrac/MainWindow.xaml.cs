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

namespace ListBoxPrac
{
    public class Animals
    {
        public string Name { get; set; }
        public int Percent { get; set; }

 

    }
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            List<Animals> animals = new List<Animals>();
            InitializeComponent();
            animals.Add(new Animals() { Name = "하마", Percent = 10 });
            animals.Add(new Animals() { Name = "타조", Percent = 90 });
            animals.Add(new Animals() { Name = "코끼리", Percent = 50 });
            animals.Add(new Animals() { Name = "목도리도마뱀", Percent = 100 });

            listBox.ItemsSource = animals;
        }
    }
}
