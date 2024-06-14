using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Threading;

namespace ExoWPF
{
	public static class Movement
	{
		public static void Up(Image image)
		{
			var newPos = Canvas.GetBottom(image) + 5;
			Canvas.SetBottom(image, newPos);
			var endPos = Canvas.GetBottom(image);
		}
		public static void Down(Image image)
		{
			var newPos = Canvas.GetBottom(image) - 5;
			Canvas.SetBottom(image, newPos);
			var endPos = Canvas.GetBottom(image);
		}
		public static void Left(Image image)
		{
			var newPos = Canvas.GetLeft(image) - 5;
			Canvas.SetLeft(image, newPos);
			var endPos = Canvas.GetLeft(image);
		}
		public static void Right(Image image)
		{
			var newPos = Canvas.GetLeft(image) + 5;
			Canvas.SetLeft(image, newPos);
			var endPos = Canvas.GetLeft(image);
		}
		public static void Gravity(Image image)
		{
			var oldPos = Canvas.GetBottom(image);
			if (oldPos > 6)
			{
				var newPos = Canvas.GetBottom(image) - 4;
				Canvas.SetBottom(image, newPos);
			}
		}
		
	}
}
