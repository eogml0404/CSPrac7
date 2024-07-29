using ScottPlot;
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

namespace plotSinCos
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Plot myPlot = WpfPlot1.Plot;

            Plot myPlot2 = WpfPlot2.Plot;

            Plot myPlot3 = WpfPlot3.Plot;
            var sig1 = myPlot.Add.Signal(Generate.Sin(51));
            sig1.LegendText = "Sin";

            var sig2 = myPlot.Add.Signal(Generate.Cos(51));
            sig2.LegendText = "Cos";

            myPlot.ShowLegend();

            //좌우 축
            /*          sig1.Axes.YAxis = myPlot.Axes.Left;
                      sig2.Axes.YAxis = myPlot.Axes.Right;

                      // add additional styling options to each axis
                      myPlot.Axes.Left.Label.Text = "Left Axis";
                      myPlot.Axes.Right.Label.Text = "Right Axis";
                      myPlot.Axes.Left.Label.ForeColor = sig1.Color;
                      myPlot.Axes.Right.Label.ForeColor = sig2.Color;*/
            sig1.Axes.XAxis = myPlot.Axes.Bottom; // standard X axis
            sig1.Axes.YAxis = myPlot.Axes.Left; // standard Y axis
            myPlot.Axes.Left.Label.Text = "Primary Y Axis";

            // create a second axis and add it to the plot
            var yAxis2 = myPlot.Axes.AddLeftAxis();

            // add a new plottable and tell it to use the custom Y axis
       
            sig2.Axes.XAxis = myPlot.Axes.Bottom; // standard X axis
            sig2.Axes.YAxis = yAxis2; // custom Y axis
            yAxis2.LabelText = "Secondary Y Axis";

            myPlot2.Add.Signal(Generate.Sin(51));

            myPlot3.Add.Signal(Generate.Sin(51));

            myPlot.SavePng("demo.png", 400, 300);
        }
    }
}