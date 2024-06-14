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

namespace ExoWPF
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public int HeightS { get; set; } = 400;
		public MainWindow()
		{
			InitializeComponent();
		}

		private void Window_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Key == Key.Up)
			{
				Movement.Up(fusee);
			}
			if (e.Key == Key.Down)
			{
				Movement.Down(fusee);

			}
			if (e.Key == Key.Left)
			{
				Movement.Left(fusee);
			}
			if (e.Key == Key.Right)
			{
				Movement.Right(fusee);
			}
		}
		private void StartGravityTask()
		{
			Task.Run(async () =>
			{
				while (true)
				{
					Movement.Gravity(fusee);
					await Task.Delay(50); // Ajoutez un délai de 50 millisecondes
				}
			});
		}

		private void Window_Activated(object sender, EventArgs e)
		{
			status.Content = "true";
			bool superieur = Canvas.GetBottom(fusee) > 6;
			StartGravityTask();
		}

		private void Window_Deactivated(object sender, EventArgs e)
		{
			status.Content = "false";
		}
	}
}