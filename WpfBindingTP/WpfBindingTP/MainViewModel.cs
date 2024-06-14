using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using Color = System.Windows.Media.Color;
using ColorConverter = System.Windows.Media.ColorConverter;

namespace WpfBindingTP
{
	public class MainViewModel : INotifyPropertyChanged
	{

		public event PropertyChangedEventHandler PropertyChanged;

		protected void OnPropertyChanged(string name)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}
		private string _test = "Hello";
		public string Test
		{
			get { return _test; }
			set
			{
				_test = value;
				OnPropertyChanged("Test");
			}
		}


		#region ColorSection
		private SolidColorBrush _colorBrush = new SolidColorBrush(Colors.Aqua);
		public SolidColorBrush ColorBrush
		{
			get => _colorBrush;
			set
			{
				_colorBrush = value;
				OnPropertyChanged("ColorBrush");
			}
		}

		public ICommand EditItem
		{
			get
			{
				return new RelayCommand(param =>
				{
					MessageBox.Show("Alerte");
				});
			}
		}

		public ICommand RandomColor
		{
			get
			{
				return new RelayCommand(param =>
				{
					var random = new Random();
					var randomColorS = String.Format("#{0:X6}", random.Next(0x1000000));
					Color randomColor = (Color)ColorConverter.ConvertFromString(randomColorS);
					ColorBrush = new SolidColorBrush(randomColor);
				});
			}
		}
		#endregion ColorSection

		public ObservableCollection<string> ListeTest { get; set; } = new ObservableCollection<string> { "Default" };

		public string _newItem;
		public string NewItem
		{
			get { return _newItem; }
			set
			{
				_newItem = value;
				OnPropertyChanged("NewItem");
			}
		}
		public ICommand addToList
		{
			get
			{
				return new RelayCommand(param =>
				{
					ListeTest.Add(NewItem);
					NewItem = "";
				});
			}
		}


	}
}
