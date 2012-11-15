using System.Windows;
using System.Windows.Media;

namespace TheGame
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


        private void SliderValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ColoredButton.Background = new SolidColorBrush(Color.FromRgb((byte)RedSlider.Value, (byte)GreedSlider.Value, (byte)BlueSlider.Value));
            ColoredButton.Content = "Red Value = " +   (byte) RedSlider.Value +
                "Green Value = " + (byte) GreedSlider.Value +
                                    "Blue Value = " + (byte)BlueSlider.Value;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
