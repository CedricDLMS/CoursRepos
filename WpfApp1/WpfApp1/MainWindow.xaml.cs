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

namespace WpfApp1
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			sliderValue.Content = slider.Value;
		}

		private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
		{
			var yes = "yes";
			faceB.Height = 147*(1+slider.Value);
			sliderValue.Content = (1+slider.Value);
			if(e.OldValue <= e.NewValue)
			{
				faceB.RenderTransform = new TranslateTransform ((faceB.RenderTransformOrigin.X * 2*(1+slider.Value)),0);
			}
			else
			{
				faceB.RenderTransform = new TranslateTransform(5, (2 + e.NewValue));
			}
		}
	}
}