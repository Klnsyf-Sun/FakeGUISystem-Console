﻿using System.IO;
using System.Collections.Generic;
using System;
using System.Text;
using System.Threading.Tasks;
using SupplementaryClassLibraryForStringManipulation;

namespace VirtualDesktopApps_Console
{
	class Window : IEntity
	{
		public Coordinates Anchor { get; set; } = new Coordinates(2, 2);
		public int Width { get; set; }
		public int Height { get; set; }
		public bool IsSelected { get; set; }
		public bool IsFocused { get; set; }
		public List<Button> InteractiveUnitsCollection { get; set; } = new List<Button>();

		public delegate void GetAppearanceDelegate();
		public GetAppearanceDelegate GetAppearanceHandler;

		public Window(int width, int height)
		{
			Width  = width;
			Height = height;

			InteractiveUnitsCollection.Add(new TitleBar());
		}

		public void GetAppearance()
		{
			GetAppearanceHandler();

			//GetAppearanceHandler = null;	//This subprocess is removed merely for test
		}

		public Button GetSelectedComponent()
		{
			for (int i = 0; i < InteractiveUnitsCollection.Count; i++)
			{
				if (InteractiveUnitsCollection[i].IsSelected)
				{
					return InteractiveUnitsCollection[i];
				}
			}

			return null;
		}
	}
}
