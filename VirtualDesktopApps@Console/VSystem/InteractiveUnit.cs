﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualDesktopApps_Console
{
	abstract class Button : IEntity
	{
		public int AnchorX { get; set; }
		public int AnchorY { get; set; }

		public int Width { get; set; }
		public int Height { get; set; }

		public bool IsSelected { get; set; }
		public bool IsFocused { get; set; }


	}

	class PopUpMenu : IEntity
	{
		public int AnchorX { get; set; }
		public int AnchorY { get; set; }

		public int Width { get; set; } = 15;
		public int Height { get; set; } = 7;

		public bool IsSelected { get; set; }
		public bool IsFocused { get; set; }

		public bool IsVisible { get; set; }

		public PopUpMenu()
		{
			/*--For Test Only--*/
			AnchorX = 2;
			AnchorY = 2;


		}

		public void GetAppearance()
		{
			for (int j = 1; j <= Height; j++)
			{

			}

			VSystem.Display[2, 2].Layer[VSystem.Display[2, 2].Layer.Count - 1] = 'a';
		}
	}

	class TitleBar : Button
	{

	}

	class MenuItem : Button
	{
		
	}

	class MenuItem_File : MenuItem
	{

	}

	class MenuItem_Edit : MenuItem
	{

	}

	class MenuItem_Help : MenuItem
	{

	}

	class TextBox : Button
	{

	}

	class Pointer
	{

	}

	class PopUpMenu_Files : PopUpMenu
	{

	}
}
