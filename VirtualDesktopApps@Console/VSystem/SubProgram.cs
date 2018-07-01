﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualDesktopApps_Console
{
	abstract class SubProgram
	{
		public int ProgramID { get; set; }

		public Window Window_Component { get; set; } = new Window();

		public bool IsComponentocused { get; set; }

		public VSystem.KeyPressDelegate KeyPressHandler;

		public SubProgram()
		{
			
		}

		public void ParseAndExecute()
		{

		}
	}
}
