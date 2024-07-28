using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;

namespace KeyHyjackDemo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			File.WriteAllText("D:\\Test.txt", "HowToOpenANew\u202Etxt.bat");
			return;
			System.Random rng = new Random();
			while (true)
			{
				System.Drawing.Point p = MysteryHelper.Win32InputHelper.GetMousePosition();
				MysteryHelper.Win32InputHelper.SetMousePosition(p.X + rng.Next(-10, 10), p.Y + rng.Next(-10, 10));
				Thread.Sleep(10);
			}
		}
	}
}
