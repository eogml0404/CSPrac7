using ScottPlot;
using ScottPlot.Colormaps;
using ScottPlot.Plottables;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace plot22
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Plot myPlot = WpfPlot1.Plot;

            double[] dataX = { 1, 2, 3, 4, 5 };
            double[] dataY = { 1, 4, 9, 16, 25 };
            var colorPlot = WpfPlot1.Plot.Add.Scatter(dataX, dataY);

            WpfPlot1.Refresh();


            colorPlot.Color = ScottPlot.Colors.Orange.WithOpacity(.2);
            colorPlot.LineWidth = 5;
            colorPlot.MarkerSize = 15;

            myPlot.SavePng("demo.png", 400, 300);
        }
    }
}